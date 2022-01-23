' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows. Not associated with either
'           Microsoft or the Synaptic project. 
' Copyright (C) 2020-2022 Drew Naylor
' (Note that the copyright years include the years left out by the hyphen.)
' winget, Windows, and all related words are copyright and trademark Microsoft Corporation.
'
' This file is a part of the guinget project.
' Neither guinget nor Drew Naylor are associated with Microsoft
' and Microsoft does not endorse guinget.
'
'
'   Licensed under the Apache License, Version 2.0 (the "License");
'   you may not use this file except in compliance with the License.
'   You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
'   Unless required by applicable law or agreed to in writing, software
'   distributed under the License is distributed on an "AS IS" BASIS,
'   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'   See the License for the specific language governing permissions and
'   limitations under the License.


Imports libguinget

Public Class aaformMainWindow

#Region "Clicking links in the package details textbox."
    Private Sub textboxPackageDetails_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles textboxPackageDetails.LinkClicked
        ' When the user clicks a link in the package details RichTextBox, go to that
        ' page in the default browser if the user chooses to visit the
        ' page in the messagebox.
        ' Code mainly copied from UXL Launcher since it's a known way to do it.
        Dim msgResult As Integer = MessageBox.Show("Are you sure you want open this link?" & vbCrLf &
                "" & vbCrLf &
                e.LinkText, "guinget",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' If the user chooses to open the link, navigate the default browser there.
        If msgResult = DialogResult.Yes Then
            Process.Start(e.LinkText)
        End If
    End Sub
#End Region

#Region "Add package entry to list."
    ' Flag to see whether it's currently updating or not.
    Friend Shared IsPackageListTaskRunning As Boolean = False

    Friend Shared Async Function AddPackageEntryToListAsync() As Task

        ' Adds a package to the package list based on what's in the manifests folder.
        ' TODO: Make sure the package's status is properly set. For now, it'll
        ' probably be "Not installed" unless tracking installed packages is added
        ' as a feature.

        ' TODO: If I can figure out a way to make this async, I will,
        ' but for now non-async is better than nothing.
        ' Update 5/27/2020: This sub is now async for getting
        ' package details, but not async for getting the package
        ' list yet.

        ' Change mouse cursor to the "working" one.
        ' For some reason this doesn't work if the mouse is outside
        ' the window when starting to load the list.
        ' Instead it'll just keep the default cursor.
        aaformMainWindow.Cursor = Cursors.WaitCursor

        ' Set update running flag.
        IsPackageListTaskRunning = True

        ' Turn off autosize to make it go way faster.
        ' Credits to this SO answer:
        ' https://stackoverflow.com/a/19518340
        For Each column As DataGridViewColumn In aaformMainWindow.datagridviewPackageList.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        Next

        ' Hide the datagridview while we're updating to make
        ' this slightly faster.
        aaformMainWindow.datagridviewPackageList.Visible = False

        ' Don't auto-create columns.
        'aaformMainWindow.datagridviewPackageList.AutoGenerateColumns = False

        ' Set the datasource to Nothing so it's empty.
        aaformMainWindow.datagridviewPackageList.DataSource = Nothing
        aaformMainWindow.datagridviewPackageList.Columns.Clear()

        ' Clear the package list datatable.
        PackageListTable.Clear()
        PackageListTable.AcceptChanges()

        ' Reset progress bar to 0.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0

        ' Display loading progress bar and stuff.
        ProgressInfoVisibility()

        ' Update main window so the "loading package list, please wait..." label
        ' looks ok when the package list is hidden, along with anything else
        ' that needs to be refreshed, like the details textbox.
        aaformMainWindow.Update()

        ' Now we populate the Manifest column with each manifest.
        Dim ManifestPaths As List(Of String) = Await PackageListTools.GetManifestsAsync

        ' Set progress bar step count.
        ' Make sure the number of packages is high enough, or lower accordingly.
        If ManifestPaths.Count >= 100 Then
            aaformMainWindow.toolstripprogressbarLoadingPackages.Step = 100
        ElseIf ManifestPaths.Count >= 10 AndAlso ManifestPaths.Count < 100 Then
            aaformMainWindow.toolstripprogressbarLoadingPackages.Step = 10
        Else
            aaformMainWindow.toolstripprogressbarLoadingPackages.Step = 1
        End If

        ' Update loading statusbar label.
        ' We're not showing the current index anymore since that takes too long.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading package list..."

        'MessageBox.Show(ManifestPaths.Count.ToString)
        'MessageBox.Show(ManifestPaths(0))

        ' Check to make sure there are manifests.
        If ManifestPaths.Count = 0 Then
            ' Reset main window stuff to default.
            PackageListPostUpdate()
            Exit Function
        End If

        ' Get a datatable ready.
        ' Not sure how much this helps to be async, but I hope it does help at least some.
        Dim SqliteList As DataTable = Await PackageListTools.GetPackageDetailsTableFromSqliteDB()

        ' Set progress bar maximum value.
        ' This has to be done here or there will be a crash
        ' if we can't find all the manifests.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum = SqliteList.Rows.Count - 1

        ' Update the statusbar before doing the progressbar.
        aaformMainWindow.statusbarMainWindow.Update()

        ' In case there are manifests we can't find easily,
        ' we need to get them now.
        ' These have to be grabbed now or else updating the manifests
        ' will crash when the path doesn't exist.
        PackageListTools.FallbackPathList = Await PackageListTools.GetManifestsAsync

        ' Set properties for each column.
        For Each LocalColumn As DataColumn In PackageListTable.Columns
            If Not LocalColumn.ColumnName = "Action" Then
                LocalColumn.ReadOnly = True
            Else
                LocalColumn.ReadOnly = False
            End If
        Next

        'MessageBox.Show(SqliteList.Rows.Item(0).ToString)
        'aaformMainWindow.datagridviewPackageList.DataSource = SqliteList
        For Each PackageRow As DataRow In SqliteList.Rows
            ' Get the manifest path and description for the current row.
            Dim manifestPath As String = Await PackageListTools.FindManifestByVersionAndId(PackageRow.Item(0).ToString, PackageRow.Item(2).ToString)
            ' Get description from manifest.
            ' Ensure the manifest path cell isn't nothing.
            ' The database was broken just after 1 AM EDT
            ' on October 8, 2020, so this is to prevent
            ' future crashes, even if the database is broken
            ' again.
            ' Defaulting this to "(Couldn't find manifest)" so that it's simpler
            ' and uses fewer lines.
            ' TODO: Move this to a separate function so it doesn't have to get called as often,
            ' as a lot of packages won't need to call it if only the latest version is supposed to be shown.
            Dim packageDescription As String = "(Couldn't find manifest)"
            If manifestPath IsNot Nothing Then
                ' Make sure the short description doesn't match the package ID, and use the
                ' long description if it does.
                ' Store the short description in a string so we don't have to read
                ' the manifest multiple times just for the description comparison.
                ' First check if it's a single-file manifest or not.
                Dim FileWithDescription As String = manifestPath
                If Await PackageTools.GetPackageInfoFromYamlAsync(manifestPath, "ManifestType") = "version" Then
                    ' Get the default locale path.
                    FileWithDescription = Await PackageTools.GetMultiFileManifestPieceFilePath(FileWithDescription, "defaultLocale")
                End If
                ' Check if the file path isn't Nothing.
                If FileWithDescription IsNot Nothing Then
                    ' Now do the description stuff.
                    Dim ShortDescription As String = Await PackageTools.GetPackageInfoFromYamlAsync(FileWithDescription, "ShortDescription")
                    If ShortDescription = PackageRow.Item(0).ToString Then
                        ' Use the full description if the short description
                        ' is just the package ID.
                        packageDescription = Await PackageTools.GetPackageInfoFromYamlAsync(FileWithDescription, "Description")
                    Else
                        ' Package ID and short description aren't the same
                        ' thing, so use the short description.
                        packageDescription = ShortDescription
                    End If
                Else
                    ' If the file path is Nothing, meaning the file
                    ' doesn't exist or we couldn't find it, just say that
                    ' we couldn't find the manifest.
                    packageDescription = "(Couldn't find manifest)"
                End If

            Else
                ' If the value in the manifest path cell is nothing, change the description.
                packageDescription = "(Couldn't find manifest)"
            End If

            ' ManifestType for debugging. This'll be commented out until it's needed.
            ' It'll also have to be changed to support the new DataTable, and I'm just putting this here
            ' in case it ends up being necessary for someone.
            'PackageRow.Cells.Item(8).Value = Await PackageTools.GetPackageInfoFromYamlAsync(PackageRow.Cells.Item(7).Value.ToString, "ManifestType")

            If My.Settings.OnlyDisplayLatestPackageVersion = True Then
                ' If the user wants to only display the latest package version,
                ' we'll have to compare it.
                If PackageRow.Item(2).ToString = PackageRow.Item(3).ToString Then
                    ' Only add the package to the list if the package row we're looking
                    ' at is the latest version of the package.
                    ' Not all packages display the "latest version"
                    ' correctly, so this isn't on by default.
                    ' One example is Adopt OpenJDK which displays
                    ' version 8.x last I checked when it should
                    ' display 15.x or something.
                    Await Task.Run(Sub()
                                       PackageListTable.Rows.Add("Do nothing", "Unknown", PackageRow.Item(0), PackageRow.Item(1), PackageRow.Item(2), PackageRow.Item(3), packageDescription, manifestPath)
                                   End Sub)
                End If
            Else
                ' Just add all the package versions.
                Await Task.Run(Sub()
                                   PackageListTable.Rows.Add("Do nothing", "Unknown", PackageRow.Item(0), PackageRow.Item(1), PackageRow.Item(2), PackageRow.Item(3), packageDescription, manifestPath)
                               End Sub)
            End If
            ' Make the progress bar progress if this row number is divisible by 100 and there are
            ' 100 or more packages.
            If ManifestPaths.Count >= 100 AndAlso PackageListTable.Rows.Count Mod 100 = 0 Then
                'Debug.WriteLine(">= 100, dividing by 100: " & PackageListTable.Rows.Count)
                aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
            ElseIf ManifestPaths.Count >= 10 AndAlso ManifestPaths.Count < 100 AndAlso PackageListTable.Rows.Count Mod 10 = 0 Then
                ' If there are 10 or more but fewer than 100 packages, perform a step when the
                ' number of rows in the package list table is divisible by 10.
                'Debug.WriteLine(">= 10, < 100, dividing by 10: " & PackageListTable.Rows.Count)
                aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
            ElseIf ManifestPaths.Count < 10 Then
                ' If there are fewer than 10 packages, go one at a time.
                'Debug.WriteLine("< 10: " & PackageListTable.Rows.Count)
                aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
            End If
            ' Update the statusbar to show the current info.
            ' Currently commented out because it's faster to not
            ' update the statusbar every time, but to instead
            ' rely on it just updating automatically.
            'aaformMainWindow.statusbarMainWindow.Update()
        Next

        ' Accept the changes to the datatable.
        PackageListTable.AcceptChanges()

        ' Close the database.
        SqliteList.Dispose()

        ' Create a dataview so that it can be sorted automatically.
        ' https://docs.microsoft.com/en-us/dotnet/api/system.data.dataview.sort?redirectedfrom=MSDN&view=netframework-4.8#System_Data_DataView_Sort

        ' Set the datasource for the datagridview to the public package list table.
        aaformMainWindow.datagridviewPackageList.DataSource = PackageListDataView

        ' Set the progressbar to the maximum to make it look finished.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum

        ' Update the main window again after making the list visible and changing the loading label.
        aaformMainWindow.Update()

        ' We're done updating the package list, so call the post-update sub.
        PackageListPostUpdate()

    End Function

    ' PackageListTable is the DataTable that we'll use to assign things to.
    Friend Shared PackageListTable As New DataTable
    ' PackageListDataView is the DataView that we'll sort and filter with.
    Friend Shared PackageListDataView As New DataView(PackageListTable)

    Friend Shared Sub UpdatePackageListCount()
        ' Updates the number of packages as shown in the statusbar.
        ' Since the DataView rowfilter makes the datagridview think
        ' rows are getting removed even though the rows are still there,
        ' we can take advantage of this and change the number to how
        ' many packages are currently listed, like what Synaptic does.
        ' TODO: Display the number of packages that are installed,
        ' the number to install or upgrade, and the number to uninstall.
        ' Pretty sure there won't have to be one for broken packages,
        ' as winget doesn't have that at the moment, though I'll add that
        ' if it gets that feature.
        If aaformMainWindow.datagridviewPackageList.RowCount = 1 Then
            ' Make sure it doesn't display "packages" when there's only one.
            aaformMainWindow.toolstripstatuslabelPackageCount.Text = (aaformMainWindow.datagridviewPackageList.RowCount).ToString &
                        " package listed, " & PackageListTable.Rows.Count.ToString & " loaded."
        Else
            aaformMainWindow.toolstripstatuslabelPackageCount.Text = (aaformMainWindow.datagridviewPackageList.RowCount).ToString &
                        " packages listed, " & PackageListTable.Rows.Count.ToString & " loaded."
        End If
    End Sub

    Friend Shared Async Sub PackageListPostUpdate()

        ' Sort the package list if it's not already sorted.
        PackageListDataView.Sort = "Id ASC"

        '' Turn autosize back on for certain columns. Might not help
        '' performance, so it's commented out for now.
        aaformMainWindow.datagridviewPackageList.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        aaformMainWindow.datagridviewPackageList.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        ' Reset progress bar to 0.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0

        ' Reset progress bar step count to 1.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Step = 1

        ' Update the main window again.
        aaformMainWindow.Update()

        ' We're waiting until the loading is done so it finishes faster.
        aaformMainWindow.datagridviewPackageList.Visible = True

        ' Hide the loading label and progress bar as well as the
        ' fake splitter label.
        ProgressInfoVisibility(False)

        ' Reset progress bar to 0.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0

        ' Reset loading label to default.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."

        ' Change mouse cursor to the default one.
        aaformMainWindow.Cursor = Cursors.Default

        ' Display number of packages loaded and currently listed.
        ' Moved to its own sub, so see that for more details.
        ' This SO answer might help:
        ' https://stackoverflow.com/a/44661255
        UpdatePackageListCount()

        ' Focus the package list.
        aaformMainWindow.datagridviewPackageList.Focus()

        ' Show the package details for the first-selected manifest.
        ShowSelectedPackageDetails()

        ' Reset the datagridview's layout.
        ' This makes sure that the packages at the bottom
        ' of the list will show up without needing to
        ' move stuff around or click on a package.
        aaformMainWindow.datagridviewPackageList.PerformLayout()

        ' Reset update task flag.
        IsPackageListTaskRunning = False
    End Sub
#End Region

#Region "Right-click to select cells in the package list."
    Private Sub datagridviewPackageList_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewPackageList.CellMouseDown
        ' Code based on this SO answer:
        ' https://stackoverflow.com/a/939275
        ' Also borrows from this answer:
        ' https://stackoverflow.com/a/173315

        If e.Button = MouseButtons.Right AndAlso e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Make sure no modifier keys like Control are held down.
            ' Also make sure what we're right-clicking isn't in the selected
            ' items collection of the datagridview.
            If ModifierKeys = Nothing AndAlso Not datagridviewPackageList.Item(e.ColumnIndex, e.RowIndex).Selected Then
                ' If it's not one of the selected items, select only whatever was right-clicked.
                datagridviewPackageList.CurrentCell = datagridviewPackageList(e.ColumnIndex, e.RowIndex)
            End If
        End If
    End Sub
#End Region

#Region "Marking packages."
#Region "Menu items for do nothing, install, etc."
#Region "Package context menu"
    Private Sub DoNothingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoNothingToolStripMenuItem.Click
        ' Set all selected packages to "do nothing", or whatever the text in the
        ' context menu item that was clicked is. This could allow for
        ' translation and adding additional actions.

        ' This takes a while if there are a lot of packages selected,
        ' so we'll have to use the progress bar and stuff so it doesn't
        ' look like the app is frozen. Preferably we'd also use an async
        ' operation to select everything while disabling certain controls
        ' like the Refresh cache button and the Apply changes button.

        ' Maybe add a messagebox that asks if the user is sure they want to
        ' mark more than 40 packages for installation/do nothing at once
        ' as that may take a long time to complete, with an option to not ask again.
        MarkPackages("Do nothing")
    End Sub

    Private Sub InstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallToolStripMenuItem.Click
        ' Set all selected packages to "do nothing", or whatever the text in the
        ' context menu item that was clicked is. This could allow for
        ' translation and adding additional actions.

        ' This takes a while if there are a lot of packages selected,
        ' so we'll have to use the progress bar and stuff so it doesn't
        ' look like the app is frozen. Preferably we'd also use an async
        ' operation to select everything while disabling certain controls
        ' like the Refresh cache button and the Apply changes button.

        ' Maybe add a messagebox that asks if the user is sure they want to
        ' mark more than 40 packages for installation/do nothing at once
        ' as that may take a long time to complete, with an option to not ask again.
        MarkPackages("Install")
    End Sub

    Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UninstallToolStripMenuItem.Click
        ' Mark packages for uninstallation from the package context menu.
        MarkPackages("Uninstall")
    End Sub

    Private Sub UpgradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpgradeToolStripMenuItem.Click
        ' Mark packages for upgrade from the package context menu.
        MarkPackages("Upgrade")
    End Sub
#End Region

#Region "Selected packages menu"
    Private Sub SelectedPackagesActionDoNothingMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedPackagesActionDoNothingMenuItem.Click
        ' Mark packages from the menubar.
        MarkPackages("Do nothing")
    End Sub

    Private Sub SelectedPackagesActionInstallMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedPackagesActionInstallMenuItem.Click
        ' Mark packages from the menubar.
        MarkPackages("Install")
    End Sub

    Private Sub SelectedPackagesActionUninstallMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedPackagesActionUninstallMenuItem.Click
        ' Mark packages for uninstallation from the menubar.
        MarkPackages("Uninstall")
    End Sub

    Private Sub SelectedPackagesActionUpgradeMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedPackagesActionUpgradeMenuItem.Click
        ' Mark packages for upgrade from the menubar.
        MarkPackages("Upgrade")
    End Sub
#End Region
#End Region

#Region "Where the package-marking takes place."
    Friend Shared Sub MarkPackages(Action As String)

        ' Mark each package with an action based on what
        ' the user wants.

        ' Set package list task flag.
        IsPackageListTaskRunning = True

        ' Turn off autosize to make it go way faster.
        ' Credits to this SO answer:
        ' https://stackoverflow.com/a/19518340
        If aaformMainWindow.datagridviewPackageList.SelectedRows.Count >= 1 Then
            For Each column As DataGridViewColumn In aaformMainWindow.datagridviewPackageList.Columns
                ' Store the column width for later so only the first time
                ' marking multiple packages in a session looks funny.
                ' This also allows the benefits of un-setting autosizing
                ' to be available all the time.
                Dim tempColWidth As Integer = column.Width
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                column.Width = tempColWidth
            Next
        End If

        ' We need to use the progress bar so it doesn't look like the UI is frozen.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0
        ' Show progress bar and info label.
        ProgressInfoVisibility()

        ' Change the mouse cursor to the waiting one.
        Cursor.Current = Cursors.WaitCursor

        ' Change progress text.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Marking selected packages, please wait..."

        ' Update the main window.
        aaformMainWindow.Update()

        ' Now we actually mark the packages with what the user chose.
        For Each Package As DataGridViewRow In aaformMainWindow.datagridviewPackageList.SelectedRows
            ' Make sure the packages are visible first.
            ' If we don't do this, we'll accidentally mark
            ' packages that aren't being shown, such as if
            ' we're doing a search.
            If Package.Visible = True AndAlso Not Package.Cells.Item(0).Value.ToString = Action Then
                ' Mark the package.
                Package.Cells.Item(0).Value = Action
            End If
            ' Move the progress bar.
            aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
        Next

        ' Turn autosize back on for certain columns.
        aaformMainWindow.datagridviewPackageList.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        aaformMainWindow.datagridviewPackageList.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        ' Hide progress bar and info label.
        ProgressInfoVisibility(False)

        ' Reset loading label to default.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."

        ' Change mouse cursor to the default one.
        aaformMainWindow.Cursor = Cursors.Default

        ' Update the number of listed packages, because marking them causes them to be
        ' removed from view if you're not in the "All" view filter.
        UpdatePackageListCount()

        ' Accept the changes to the datatable.
        PackageListTable.AcceptChanges()

        ' Reset package list flag.
        IsPackageListTaskRunning = False
    End Sub
#End Region
#End Region

    Friend Shared Sub ProgressInfoVisibility(Optional Visible As Boolean = True)

        ' Make the progress bar and progress label shown or hidden
        ' based on the Visible arg.
        aaformMainWindow.toolstripstatusSplitter.Visible = Visible
        aaformMainWindow.toolstripprogressbarLoadingPackages.Visible = Visible
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Visible = Visible
    End Sub

    Private Sub datagridviewPackageList_SelectionChanged(sender As Object, e As EventArgs) Handles datagridviewPackageList.SelectionChanged
        ' Get package details if the manifest cell isn't Nothing and the manifest exists.
        ' This prevents crashes in case the database is broken.

        If My.Settings.ShowLastSelectedPackageDetails = False Then
            ' Make sure we only show package details for the first-selected package.
            If datagridviewPackageList.SelectedRows.Count = 1 Then
                ShowSelectedPackageDetails()
            End If
        Else
            ' If we want to show the last-selected package, then we can just do that.
            ' Make sure it's greater than 0, or else it'll crash when turning the
            ' database mode on and off then refreshing the cache during the same session.
            If datagridviewPackageList.SelectedRows.Count > 0 Then
                ShowSelectedPackageDetails()
            End If
        End If

        ' Determine if menuitems should be allowed.
        If datagridviewPackageList.SelectedRows.Count = 1 Then
            AllowUsingStuffThatOnlyDoesThingsWhenOnePackageIsSelected(True)
        Else
            AllowUsingStuffThatOnlyDoesThingsWhenOnePackageIsSelected(False)
        End If


    End Sub

    Private Sub AllowUsingStuffThatOnlyDoesThingsWhenOnePackageIsSelected(Optional AllowFunctions As Boolean = True)
        ' Blocks or unblocks the menuitems for things like show in winget.
        ShowInWingetToolStripMenuItem.Enabled = AllowFunctions
        ShowInwingetToolStripMenuItem1.Enabled = AllowFunctions
        SearchForPackageIDFromContextMenu.Enabled = AllowFunctions
        SelectedPackagesSearchForLastSelectedID.Enabled = AllowFunctions
    End Sub

    Private Shared Async Sub ShowSelectedPackageDetails()

        ' We can now display the package details while making sure the manifest isn't
        ' nothing.
        If PackageListTable.Rows.Count > 0 AndAlso aaformMainWindow.datagridviewPackageList.SelectedRows.Item(0).Cells(7).Value IsNot Nothing AndAlso
                    IO.File.Exists(aaformMainWindow.datagridviewPackageList.SelectedRows.Item(0).Cells(7).Value.ToString) Then
            ' If only one is selected, get its details into the details textbox.
            ' Set the textbox to say "Loading..." so it doesn't look like it's hanging.
            aaformMainWindow.textboxPackageDetails.Text = "Loading, please wait..."
            ' Take text from the Manifest cell and use that
            ' file path to display text in the details textbox.
            Dim ManifestPath As String = aaformMainWindow.datagridviewPackageList.Item(7, aaformMainWindow.datagridviewPackageList.SelectedRows.Item(0).Index).Value.ToString
            ' See if it's a multi-file manifest. If it is, we'll have to do some stuff.
            If Await PackageTools.GetPackageInfoFromYamlAsync(ManifestPath, "ManifestType") = "version" Then
                ' Clear textbox.
                aaformMainWindow.textboxPackageDetails.Clear()

                ' Add header for the default locale manifest.
                aaformMainWindow.textboxPackageDetails.Text = "Default locale manifest" & vbCrLf &
                                             "==========================" & vbCrLf
                ' Find the default locale manifest.
                Dim DefaultLocaleManifestPath As String = Await PackageTools.GetMultiFileManifestPieceFilePath(ManifestPath, "defaultLocale")
                ' Put the default locale manifest into the details textbox.
                ' Make sure the file exists.
                If DefaultLocaleManifestPath IsNot Nothing Then
                    aaformMainWindow.textboxPackageDetails.Text = aaformMainWindow.textboxPackageDetails.Text &
                                             My.Computer.FileSystem.ReadAllText(DefaultLocaleManifestPath) &
                                             vbCrLf
                Else
                    aaformMainWindow.textboxPackageDetails.Text = aaformMainWindow.textboxPackageDetails.Text &
                                                 "(Couldn't find manifest)" &
                                                 vbCrLf & vbCrLf
                End If

                ' Add header for the installer manifest.
                aaformMainWindow.textboxPackageDetails.Text = aaformMainWindow.textboxPackageDetails.Text &
                                             "Installer manifest" & vbCrLf &
                                             "==========================" & vbCrLf
                ' Find the installers manifest.
                Dim InstallersManifestPath As String = Await PackageTools.GetMultiFileManifestPieceFilePath(ManifestPath, "installer")
                ' Put the installers manifest into the details textbox.
                ' Make sure the file exists.
                If InstallersManifestPath IsNot Nothing Then
                    aaformMainWindow.textboxPackageDetails.Text = aaformMainWindow.textboxPackageDetails.Text &
                                             My.Computer.FileSystem.ReadAllText(InstallersManifestPath) &
                                             vbCrLf
                Else
                    aaformMainWindow.textboxPackageDetails.Text = aaformMainWindow.textboxPackageDetails.Text &
                                                 "(Couldn't find manifest)" &
                                                 vbCrLf & vbCrLf
                End If

                ' Add header text for the version file section.
                aaformMainWindow.textboxPackageDetails.Text = aaformMainWindow.textboxPackageDetails.Text &
                                             "Version manifest" & vbCrLf &
                                             "==========================" & vbCrLf
                ' Put the version manifest in there.
                ' Make sure the file exists. I'm using the IO.File.Exists
                ' thing since ManifestPath doesn't use the code that
                ' looks for the other files for the multi-file manifest
                ' and as such can't be checked to see if it's Nothing
                ' like those can.
                ' I'm still checking to make sure it's not Nothing
                ' just to be safe.
                If ManifestPath IsNot Nothing AndAlso IO.File.Exists(ManifestPath) Then
                    aaformMainWindow.textboxPackageDetails.Text = aaformMainWindow.textboxPackageDetails.Text &
                                             My.Computer.FileSystem.ReadAllText(ManifestPath)
                Else
                    aaformMainWindow.textboxPackageDetails.Text = aaformMainWindow.textboxPackageDetails.Text &
                                             "(Couldn't find manifest)"
                End If

            Else
                ' It appears to be a single-file one.
                ' Display full manifest in details textbox.
                aaformMainWindow.textboxPackageDetails.Text = "Manifest" & vbCrLf &
                                             "==========================" & vbCrLf &
                                             My.Computer.FileSystem.ReadAllText(ManifestPath)
            End If

        ElseIf aaformMainWindow.datagridviewPackageList.SelectedRows.Count = 0 Then
            ' If no rows are selected, say so in the same way Synaptic does,
            ' because it says it in a way that's simple and nice.
            ' This might not show up since rows are automatically selected when
            ' they're loaded.

            ' TODO: Allow the user to choose whether to update the cache before
            ' loading the package list, or just load the package list. This
            ' should be a setting to allow for people to choose whether it
            ' always updates the cache automatically, or have it ask to update every time.
            ' This should be based on a time thing, so only update after 5 minutes for example.
            aaformMainWindow.textboxPackageDetails.Text = "No package is selected or the package list hasn't been loaded yet. " &
                "You can load the package list by using the Refresh cache toolbar button, by going to Package list" &
                ">Refresh cache, or by pressing Ctrl+R."

        ElseIf aaformMainWindow.datagridviewPackageList.SelectedRows.Count > 0 AndAlso
        aaformMainWindow.datagridviewPackageList.SelectedRows.Item(0).Cells(7).Value Is Nothing Then

            ' If there are more than 0 rows selected and the manifest path
            ' is Nothing, say that we couldn't find the manifest.
            ' Previously it would just display the previously-selected manifest.
            aaformMainWindow.textboxPackageDetails.Text = "(Couldn't find manifest)"
        End If
    End Sub

    Private Sub toolstripbuttonApplyChanges_Click(sender As Object, e As EventArgs) Handles toolstripbuttonApplyChanges.Click
        ' Open the apply changes dialog.
        ApplyChanges()
    End Sub

    Private Sub ApplyChangesMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyChangesMenuItem.Click
        ' Open the apply changes dialog.
        ApplyChanges()
    End Sub

    Private Sub ApplyChanges()
        ' Open the Apply changes window and put the user's selections into it.
        Dim LocalApplyChangesWindow As New ApplyChangesWindow

        ' Commit the action selections so that selecting a different
        ' row after using the combobox for action selection
        ' isn't required to get what's marked for installation or whatever.
        datagridviewPackageList.EndEdit()

        ' Set HiDPI settings for that datagridview, if desired.
        If My.Settings.HiDPIMode = True Then
            LocalApplyChangesWindow.datagridviewAppsBeingInstalled.RowTemplate.Height = 48
        Else
            ' HiDPI mode is off, so use the default height.
            LocalApplyChangesWindow.datagridviewAppsBeingInstalled.RowTemplate.Height = 24
        End If

        ' Put the user's selections into this window.
        For Each Row As DataGridViewRow In datagridviewPackageList.Rows
            ' Check if the package is meant to be installed.
            If Not Row.Cells(0).Value.ToString = "Do nothing" Then
                ' If this package says something other than do nothing,
                ' add it to the list.
                LocalApplyChangesWindow.datagridviewAppsBeingInstalled.Rows.Add(Row.Cells(2).Value.ToString,
                  Row.Cells(4).Value.ToString, Row.Cells(0).Value.ToString, "Ready")

            End If
        Next

        ' Open apply changes window.
        LocalApplyChangesWindow.ShowDialog(Me)
    End Sub

    Friend Shared Async Function UpdatePackageListBuiltinAsync() As Task

        ' First, we need to download and update the manifests if the
        ' debugging setting to bypass updating is turned off.
        If My.Settings.DebuggingBypassCacheUpdate = False Then
            ' Set the updater progress window's root form
            ' to the main window.
            PackageListTools.RootForm = aaformMainWindow
            ' Set the setting for cleaning up temp files
            ' after updating is complete.
            PackageListTools.DeleteTempDirsAfterCacheUpdate = My.Settings.DeleteTempFilesAfterRefresh
            ' Now run the update.
            Await PackageListTools.UpdateManifestsAsync(My.Settings.Use7zipForExtraction, My.Settings.PathTo7zip, My.Settings.UseRobocopyForCopying)
        End If

        ' We need to make sure the manifests are installed, otherwise this will look like it hangs.
        Dim ManifestDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

        ' If the manifest directory exists, we can add the
        ' packages to the list.
        If My.Computer.FileSystem.DirectoryExists(ManifestDir) Then
            Await AddPackageEntryToListAsync()
        End If

        Return
    End Function

#Region "Refresh cache."
    Private Async Function BeginRefreshCacheAsync() As Task

        ' Disable some controls so nothing bad happens
        ' by accident while we're updating.
        ControlStateDuringCacheUpdate(False)

        ' Use the built-in updater provided by libguinget.
        Await aaformMainWindow.UpdatePackageListBuiltinAsync

        ' Re-enable those controls now that we're done updating.
        ControlStateDuringCacheUpdate(True)

        ' Re-run search if the user wants to.
        If My.Settings.RerunSearchAfterCacheUpdate = True AndAlso toolstriptextboxSearch.Text IsNot String.Empty Then
            BeginPackageIdSearch(toolstriptextboxSearch.Text, False, "Id")
        End If

        Return
    End Function

    Private Async Sub toolstripbuttonRefreshCache_Click(sender As Object, e As EventArgs) Handles toolstripbuttonRefreshCache.Click
        ' Refresh package list and package cache.

        ' Moved to its own function so it's easier to update.
        Await BeginRefreshCacheAsync()
    End Sub

    Private Async Sub RefreshCacheMenuButton_Click(sender As Object, e As EventArgs) Handles RefreshCacheMenuButton.Click
        ' Refresh package list and package cache.

        ' Moved to its own function so it's easier to update.
        Await BeginRefreshCacheAsync()
    End Sub

    Private Sub ControlStateDuringCacheUpdate(ControlsEnabled As Boolean)

        ' Don't let the user click things like Refresh cache if we're updating.
        ' We need ControlsEnabled to see if they should be enabled or not.

        ' Refresh buttons.
        toolstripbuttonRefreshCache.Enabled = ControlsEnabled
        RefreshCacheMenuButton.Enabled = ControlsEnabled

        ' Installed packages and available updates.
        ListInstalledPackagesToolStripMenuItem.Enabled = ControlsEnabled
        ShowUpgradesToolStripMenuItem.Enabled = ControlsEnabled

        ' Package list.
        datagridviewPackageList.Enabled = ControlsEnabled

        ' Was going to disable the package details textbox while
        ' updating, but some people might get bored while it
        ' updates and they might want to read something.

        ' Package context menu.
        ' Only affects the entry point in the Package list
        ' menu under the Selected package submenu since the
        ' package list is disabled.
        contextmenustripPackageMenu.Enabled = ControlsEnabled

        ' Apply changes buttons.
        ApplyChangesMenuItem.Enabled = ControlsEnabled
        toolstripbuttonApplyChanges.Enabled = ControlsEnabled

        ' Search-related controls.
        SearchMenuItem.Enabled = ControlsEnabled
        AdvancedSearchMenuItem.Enabled = ControlsEnabled
        toolstripsplitbuttonSearch.Enabled = ControlsEnabled
        toolstriptextboxSearch.Enabled = ControlsEnabled

        ' Properties buttons.
        zCantFindThisPackagePropertiesMenuItem.Enabled = ControlsEnabled
        toolstripbuttonProperties.Enabled = ControlsEnabled

        ' Package list menu.
        ' Why not just disable the entire menu while updating.
        PackageToolStripMenuItem.Enabled = ControlsEnabled

        ' Selected packages menu.
        SelectedPackagesToolStripMenuItem.Enabled = ControlsEnabled

        ' Tools menu.
        ToolsToolStripMenuItem.Enabled = ControlsEnabled

        ' File menu.
        ToolStripMenuItemImportPackages.Enabled = ControlsEnabled
        ToolStripMenuItemExportPackages.Enabled = ControlsEnabled


        ' Sidebar.
        ' Might change it to a dropdown that switches tabs to what's
        ' in the dropdown so it's easier to see what tabs are available,
        ' but this is all that's necessary for now.
        ' If that dropdown idea is implemented, then the tabs need to be
        ' hidden.
        tabcontrolSidebar.Enabled = ControlsEnabled
        comboboxSidebarTabSelector.Enabled = ControlsEnabled

        Me.Update()

    End Sub
#End Region

    Private Sub datagridviewPackageList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewPackageList.CellDoubleClick
        ' Show package context menu on cell double-click, like Synaptic.

        If e.ColumnIndex >= 1 AndAlso e.RowIndex >= 0 Then
            ' Make sure we're not double-clicking on the column header sizing area
            ' before showing the context menu. This allows quick column
            ' auto-sizing based on cell contents when double-clicking
            ' the header separators.
            ' Related issue:
            ' https://github.com/DrewNaylor/guinget/issues/16
            contextmenustripPackageMenu.Show(MousePosition)
        End If
    End Sub

    Private Sub datagridviewPackageList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewPackageList.CellClick
        ' Show the context menu if we're clicking in the Action column.
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            ' Show the context menu at the mouse position.
            contextmenustripPackageMenu.Show(MousePosition)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        '  Exit the application.
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Show About window.
        AboutWindow.ShowDialog(Me)
    End Sub

#Region "Unfinished controls visibility"

    Friend Shared Sub SidebarTabSelectionListItems(VisibleTabsList As String())
        ' Clear the items from the dropdown.
        aaformMainWindow.comboboxSidebarTabSelector.Items.Clear()
        ' Go through the list and add them to the dropdown.
        For Each VisibleTab As String In VisibleTabsList
            aaformMainWindow.comboboxSidebarTabSelector.Items.Add(VisibleTab)
        Next
        ' Set the selected index for the dropdown back to 0.
        aaformMainWindow.comboboxSidebarTabSelector.SelectedIndex = 0
    End Sub

    Friend Shared Sub UnfinishedControlsVisible(Visible As Boolean)

        ' Hide controls that don't work yet.

        ' Sidebar tab control.
        ' We need to use properties based on this answer:
        ' https://stackoverflow.com/a/30231315
        ' Properties set in the designer.
        ' Switch the dropdown list that's displayed.
        If Visible = True Then
            SidebarTabSelectionListItems(My.Resources.HiddenSidebarList.Split(CChar(",")))
        Else
            ' Show only the ones that are expected.
            SidebarTabSelectionListItems(My.Resources.DefaultSidebarList.Split(CChar(",")))
        End If

        ' Tools menu items.
        aaformMainWindow.FindManifestToolStripMenuItem.Visible = Visible
        If Visible = False Then
            ' Empty menu items so they don't make the Options menu item
            ' too long.
            aaformMainWindow.FindManifestToolStripMenuItem.Text = String.Empty
        Else
            aaformMainWindow.FindManifestToolStripMenuItem.Text = "Find manifest using version and ID..."
        End If

        ' Properties button on toolbar.
        aaformMainWindow.toolstripbuttonProperties.Visible = Visible
        ' Properties button in Selected packages menu.
        aaformMainWindow.SelectedPackagesProperties.Visible = Visible
        ' Properties button in package context menu.
        aaformMainWindow.PropertiesPackageContextMenuToolStripMenuItem.Visible = Visible

        ' Toolstrip separators.
        ' Main toolbar.
        aaformMainWindow.zSeparatorPropertiesAndSearchBox.Visible = Visible

        ' Experimental settings panel in Options window.
        OptionsWindow.panelExperimentalSettings.Visible = Visible

    End Sub
#End Region

    Private Sub aaformMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Upgrade settings if necessary.
        If My.Settings.UpgradeSettingsFromPreviousVersion = True Then
            My.Settings.Upgrade()
            My.Settings.UpgradeSettingsFromPreviousVersion = False

            ' Save new settings.
            My.Settings.Save()
            My.Settings.Reload()
        End If

        ' Change timer interval if it's not the default.
        ' Make sure it's not 0, but if it is, set it to 1.
        If My.Settings.SearchWhenTypingTimerInterval < 1 Then
            TypeTimer.Interval = 1
        ElseIf My.Settings.SearchWhenTypingTimerInterval > 9999 Then
            ' If it's above 9999, set it to 9999.
            TypeTimer.Interval = 9999
        Else
            ' It's fine, so just use the thing in here.
            TypeTimer.Interval = My.Settings.SearchWhenTypingTimerInterval
        End If

        ' Configure HiDPI-related stuff.
        HiDPIModeToggle(My.Settings.HiDPIMode)

        ' Set text for sidebar dropdown.
        comboboxSidebarTabSelector.SelectedIndex = 0

        ' Show or hide the sidebar.
        SidebarVisibility(My.Settings.ShowSidebar)

        ' Hide unfinished controls on startup if My.Settings.HideUnfinishedControls = True.
        If My.Settings.HideUnfinishedControls = True Then
            UnfinishedControlsVisible(False)
        Else
            UnfinishedControlsVisible(True)
        End If

        ' Remove rounded edge from toolbar.
        ' This code was found on StackOverflow
        ' in C# here: https://stackoverflow.com/questions/13418721/toolstrip-rounded-corners/48564597#48564597
        CType(toolstripMainWindow.Renderer, ToolStripProfessionalRenderer).RoundedEdges = False

        ' Add table columns.
        ' We're doing this on startup so we don't have to figure out
        ' how to clear them when refreshing the cache.
        PackageListTable.Columns.Add("Action", GetType(String))
        PackageListTable.Columns.Add("Status", GetType(String))
        PackageListTable.Columns.Add("Id", GetType(String))
        PackageListTable.Columns.Add("Name", GetType(String))
        PackageListTable.Columns.Add("Version", GetType(String))
        PackageListTable.Columns.Add("LatestVersion", GetType(String))
        PackageListTable.Columns.Add("Description", GetType(String))
        PackageListTable.Columns.Add("ManifestPath", GetType(String))


    End Sub

#Region "HiDPI-related stuff."
    Private Sub HiDPIModeToggle(UseHiDPIMode As Boolean)
        ' Turn on or off HiDPI mode as needed.
        ' Hide the datagridview to speed things up.
        datagridviewPackageList.Visible = False
        If UseHiDPIMode = True Then
            ' Make the package list double height.
            datagridviewPackageList.RowTemplate.Height = 48
            ' Change the height of all the packages in there.
            datagridviewPackageList.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            datagridviewPackageList.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            For Each PackageRow As DataGridViewRow In datagridviewPackageList.Rows
                PackageRow.Height = 48
            Next
            datagridviewPackageList.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            datagridviewPackageList.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Else
            ' Turn off HiDPI mode.
            datagridviewPackageList.RowTemplate.Height = 24
            datagridviewPackageList.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            datagridviewPackageList.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            For Each PackageRow As DataGridViewRow In datagridviewPackageList.Rows
                PackageRow.Height = 24
            Next
            datagridviewPackageList.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            datagridviewPackageList.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End If
        ' Show the datagridview again.
        datagridviewPackageList.Visible = True
    End Sub
#End Region

#Region "Package ID search."
    Private Sub toolstripsplitbuttonSearch_ButtonClick(sender As Object, e As EventArgs) Handles toolstripsplitbuttonSearch.ButtonClick
        ' Start searching.
        BeginPackageIdSearch(toolstriptextboxSearch.Text, False, "Id")
    End Sub

    Friend Shared Sub BeginPackageIdSearch(SearchTerm As String, Optional SearchStartedFromSidebar As Boolean = False, Optional ColumnToSearch As String = "Id")

        ' Make sure there are packages to begin with.
        ' We have to look at the package list table's row count rather than
        ' the datagridview, as the packages aren't being stored in the datagridview anymore.
        If PackageListTable.Rows.Count >= 1 Then

            ' Set package list task flag.
            IsPackageListTaskRunning = True

            ' Place search term into the sidebar if it wasn't started from the sidebar.
            If SearchStartedFromSidebar = False Then
                ' Make sure it's not already in the sidebar.
                If Not aaformMainWindow.listboxSearchTerms.Items.Contains(SearchTerm) Then
                    aaformMainWindow.listboxSearchTerms.Items.Add(SearchTerm)
                End If
            End If

            ' Change progress label text.
            If Not SearchTerm = String.Empty Then
                ' If there's something in the search box, include it in the status bar text.
                aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Searching for " & SearchTerm & "..."
            Else
                ' Otherwise, if it's empty, just say "searching".
                aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Searching..."
            End If

            ' Show progress bar; this'll take a while.
            ProgressInfoVisibility(True)

            ' Hide the package list.
            aaformMainWindow.datagridviewPackageList.Visible = False

            ' Turn off autosize to make it go way faster.
            ' Credits to this SO answer:
            ' https://stackoverflow.com/a/19518340
            For Each column As DataGridViewColumn In aaformMainWindow.datagridviewPackageList.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            Next

            ' Set progress bar maximum to number of rows.
            aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum = PackageListTable.Rows.Count - 1
            ' Set progress bar value to 0.
            aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0
            ' Update main window.
            aaformMainWindow.Update()

            ' Create a variable to store the search method.
            Dim SearchMethod As String = "LIKE '%" & SearchTerm & "%'"

            ' Check to see if we should do an exact match.
            If SearchTerm.StartsWith("""") AndAlso SearchTerm.EndsWith("""") Then
                SearchMethod = "= '" & SearchTerm.Trim(CChar("""")) & "'"
            End If

            ' Set DataView filter based on this SO example:
            ' https://stackoverflow.com/a/10009794
            ' A bunch of expression examples from here:
            ' https://docs.microsoft.com/en-us/dotnet/api/system.data.datacolumn.expression?view=netframework-4.8
            ' Turns out the rowstatefilter makes this break, so we can't use it.
            ' Got the idea to just not use the rowstatefilter from this SO answer:
            ' https://stackoverflow.com/a/52055612
            If SearchTerm.Length > 0 Then
                PackageListDataView.RowFilter = "[" & ColumnToSearch & "]" & SearchMethod
            Else
                PackageListDataView.RowFilter = String.Empty
            End If

            ' Hide the progress bar.
            ProgressInfoVisibility(False)

            ' Reset progress label text.
            aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."

            ' Show the current number of packages in the filter.
            UpdatePackageListCount()

            ' Turn autosize back on for certain columns.
            ' This is for the Action and Status columns.
            aaformMainWindow.datagridviewPackageList.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            aaformMainWindow.datagridviewPackageList.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            ' Show the package list again.
            aaformMainWindow.datagridviewPackageList.Visible = True

            ' Update the main window.
            aaformMainWindow.Update()

            IsPackageListTaskRunning = False

        End If
    End Sub

    Private Sub toolstriptextboxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles toolstriptextboxSearch.KeyDown
        ' Start searching on pressing Enter.

        If e.KeyCode = Keys.Enter Then
            BeginPackageIdSearch(toolstriptextboxSearch.Text, False, "Id")
            ' Stop search when typing timer.
            StopStartTypeTimer(False)

        ElseIf e.KeyCode = Keys.Escape Then
            ' Otherwise if it's Escape, clear the search box.
            toolstriptextboxSearch.Clear()
            ' Restart search when typing timer.
            StopStartTypeTimer(True)

        ElseIf e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            ' If the backspace or delete keys are pressed, restart search timer.
            StopStartTypeTimer(True)
        End If

    End Sub

    Private Sub StopStartTypeTimer(Restart As Boolean)
        ' Stop timer, if necessary.
        If My.Settings.SearchWhenTyping = True Then
            TypeTimer.Stop()
            ' Run search again if requested.
            If Restart = True Then
                TypeTimer.Start()
            End If
        End If
    End Sub

    Private Sub SearchMenuItem_Click(sender As Object, e As EventArgs) Handles SearchMenuItem.Click
        ' Focus search textbox and select its text
        ' to make it easier to type something else.
        If Not toolstriptextboxSearch.Focused = True Then
            ' First check if it's not focused.
            ' If it isn't, focus and select all the text in it.
            toolstriptextboxSearch.Focus()
            toolstriptextboxSearch.SelectAll()
        Else
            ' Focus the package list if the search box is focused
            ' right now.
            datagridviewPackageList.Focus()
        End If
    End Sub
#End Region

#Region "Sidebar search."
    Private Sub listboxSearchTerms_DoubleClick(sender As Object, e As EventArgs) Handles listboxSearchTerms.DoubleClick
        ' Start searching if something is selected.
        If listboxSearchTerms.SelectedItems.Count = 1 Then
            BeginSearchFromSidebar()
        End If
    End Sub

    Private Shared Sub BeginSearchFromSidebar()
        ' Send current index to the search bar and begin searching.
        ' First check if index 0 is selected.
        ' Index 0 is "All", and this allows an easier way to show everything.
        If aaformMainWindow.listboxSearchTerms.SelectedIndex = 0 Then
            aaformMainWindow.toolstriptextboxSearch.Text = String.Empty
        Else
            aaformMainWindow.toolstriptextboxSearch.Text = aaformMainWindow.listboxSearchTerms.SelectedItem.ToString
        End If

        ' Stop timer, if necessary.
        If My.Settings.SearchWhenTyping = True Then
            aaformMainWindow.TypeTimer.Stop()
        End If

        ' Begin search.
        BeginPackageIdSearch(aaformMainWindow.toolstriptextboxSearch.Text, True, "Id")
    End Sub

    Private Sub listboxSearchTerms_KeyDown(sender As Object, e As KeyEventArgs) Handles listboxSearchTerms.KeyDown
        ' Start searching if the "Enter" key is pressed and something is selected.
        If e.KeyCode = Keys.Enter AndAlso listboxSearchTerms.SelectedItems.Count = 1 Then
            ' Stop timer, if necessary.
            If My.Settings.SearchWhenTyping = True Then
                TypeTimer.Stop()
            End If
            ' Start searching.
            BeginSearchFromSidebar()
        ElseIf e.KeyCode = Keys.Delete AndAlso listboxSearchTerms.SelectedItems.Count = 1 AndAlso listboxSearchTerms.SelectedIndex > 0 Then
            ' Delete the selected search term as long as it's not the first item.
            listboxSearchTerms.Items.Remove(listboxSearchTerms.SelectedItem)
        End If
    End Sub
#End Region

    Private Sub ClearSelectedSearchTermToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSelectedSearchTermToolStripMenuItem.Click
        ' Clear selected search term as long as it's not the first item.
        ' We also need to make sure something is selected.
        If listboxSearchTerms.SelectedIndex > 0 Then
            listboxSearchTerms.Items.RemoveAt(listboxSearchTerms.SelectedIndex)
        End If
    End Sub

    Private Sub ClearAllSearchTermsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllSearchTermsToolStripMenuItem.Click
        ' Clear all search terms, and put "All" back in there.
        listboxSearchTerms.Items.Clear()
        listboxSearchTerms.Items.Add("All")
    End Sub

    Private Sub buttonCloseSidebar_Click(sender As Object, e As EventArgs) Handles buttonCloseSidebar.Click
        ' Hide sidebar and turn off showing the sidebar.
        SidebarVisibility(False)
        My.Settings.ShowSidebar = False
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Async Sub FindManifestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindManifestToolStripMenuItem.Click
        ' Send the currently-selected ID and version to the manifest finder.
        Dim ManifestPath As String = Await PackageListTools.FindManifestByVersionAndId(datagridviewPackageList.SelectedRows(0).Cells(2).Value.ToString,
                              datagridviewPackageList.SelectedRows(0).Cells(4).Value.ToString)
        MessageBox.Show(ManifestPath)
        ' Now we can copy the description into the details box, since we have the path.
        ' This is just an example of what can be done here, so we'll comment it out for now.
        'Dim Description As String = Await PackageTools.GetPackageInfoFromYamlAsync(ManifestPath, "Description")
        'textboxPackageDetails.Text = Description
    End Sub

    Private Sub SidebarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SidebarToolStripMenuItem.Click
        ' Show or hide the sidebar.
        If My.Settings.ShowSidebar = False Then
            SidebarVisibility(True)
            My.Settings.ShowSidebar = True
        Else
            SidebarVisibility(False)
            My.Settings.ShowSidebar = False
        End If

        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Friend Shared Sub SidebarVisibility(IsVisible As Boolean)

        ' Show or hide the sidebar based on what's passed to this.
        If IsVisible = True Then
            aaformMainWindow.SidebarToolStripMenuItem.Checked = True
            aaformMainWindow.splitcontainerSidebarAndPkgList.Panel1Collapsed = False
        Else
            aaformMainWindow.SidebarToolStripMenuItem.Checked = False
            aaformMainWindow.splitcontainerSidebarAndPkgList.Panel1Collapsed = True
        End If
    End Sub

    Private Sub toolstripmenuitemAdvancedSearch_Click(sender As Object, e As EventArgs) Handles toolstripmenuitemAdvancedSearch.Click
        ' Run the sub to show the Options window, Search tab.
        ShowOptions(1)
    End Sub

    Private Sub AdvancedSearchMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedSearchMenuItem.Click
        ' Run the sub to show the Options window, Search tab.
        ShowOptions(1)
    End Sub

    Private Sub ShowOptions(Optional SelectedTab As Integer = 0)
        ' Show search options.
        ' Change it to the proper tab first.
        OptionsWindow.tabcontrolOptions.SelectTab(SelectedTab)
        OptionsWindow.ShowDialog(Me)

        ' Show or hide unfinished controls.
        UnfinishedControlsVisible(Not My.Settings.HideUnfinishedControls)

        ' Update search when typing timer if necessary.
        TypeTimer.Interval = My.Settings.SearchWhenTypingTimerInterval

        ' Update HiDPI Mode status.
        HiDPIModeToggle(My.Settings.HiDPIMode)

        ' Change sidebar visibility if necessary.
        SidebarVisibility(My.Settings.ShowSidebar)
    End Sub

    Private Sub SearchForPackageIDFromContextMenu_Click(sender As Object, e As EventArgs) Handles SearchForPackageIDFromContextMenu.Click
        ' The last-selected package will have its ID searched for.
        SearchForLastSelectedPackageID()
    End Sub

    Private Sub SelectedPackagesSearchForLastSelectedID_Click(sender As Object, e As EventArgs) Handles SelectedPackagesSearchForLastSelectedID.Click
        ' The last-selected package will have its ID searched for.
        SearchForLastSelectedPackageID()
    End Sub

    Private Sub SearchForLastSelectedPackageID()

        ' Search for the ID of the most-recently selected package.
        ' Make sure there are packages in the list.
        If datagridviewPackageList.Rows.Count > 0 Then
            ' We have to wrap it with quotes to get an exact match, since
            ' that's probably what the user wants.
            If My.Settings.ExactMatchForLastSelectedIDSearch = True Then
                ' Only run an exact match for the package ID if the user wants it.
                toolstriptextboxSearch.Text = """" & datagridviewPackageList.SelectedRows.Item(0).Cells.Item(2).Value.ToString & """"
            Else
                toolstriptextboxSearch.Text = datagridviewPackageList.SelectedRows.Item(0).Cells.Item(2).Value.ToString
            End If

            ' Stop timer, if necessary.
            If My.Settings.SearchWhenTyping = True Then
                TypeTimer.Stop()
            End If

            BeginPackageIdSearch(toolstriptextboxSearch.Text, False, "Id")
        End If
    End Sub

    Private Sub comboboxSidebarTabSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxSidebarTabSelector.SelectedIndexChanged
        ' Change the tab page when the dropdown selection changes.
        tabcontrolSidebar.SelectedIndex = comboboxSidebarTabSelector.SelectedIndex
    End Sub

    Private Sub UpdateWingetSourcesMenuButton_Click(sender As Object, e As EventArgs) Handles UpdateWingetSourcesMenuButton.Click
        ' Tell library to update winget sources.
        CommandTools.UpdateWingetSources()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        ' Open Options window.
        ShowOptions(0)
    End Sub

    Private Sub ShowInWingetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowInWingetToolStripMenuItem.Click
        ShowInWinget()
    End Sub

    Private Sub ShowInwingetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowInwingetToolStripMenuItem1.Click
        ShowInWinget()
    End Sub

    Private Sub ShowInWinget()
        ' Shows the currently-selected package details in winget.
        If datagridviewPackageList.SelectedRows.Count = 1 Then
            PackageTools.ShowPkgInWinget(datagridviewPackageList.SelectedRows(0).Cells(2).Value.ToString,
                                         datagridviewPackageList.SelectedRows(0).Cells(4).Value.ToString,
                                         My.Settings.DefaultSourceName)
        End If
    End Sub

    Private Sub EditWingetSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditWingetSettingsToolStripMenuItem.Click
        ' Run the stuff in the helper library to edit winget settings.
        CommandTools.RunWingetSettings(False)
    End Sub

    Private Sub EditWingetSettingsAsAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditWingetSettingsAsAdminToolStripMenuItem.Click
        ' Run the helper library's code for editing winget settings but have it be as admin.
        CommandTools.RunWingetSettings(True)
    End Sub

    Private Sub toolstriptextboxSearch_TextChanged(sender As Object, e As EventArgs) Handles toolstriptextboxSearch.TextChanged
        ' Restart the textbox typing timer for search when typing if it's on.
        ' Got the idea for this particular code from this post:
        ' https://stackoverflow.com/a/671735
        StopStartTypeTimer(True)
    End Sub

    Private Sub TypeTimer_Tick(sender As Object, e As EventArgs) Handles TypeTimer.Tick
        ' Once the search when typing timer reaches its interval,
        ' stop the timer and start the search.
        ' Got the idea for this particular code from this post:
        ' https://stackoverflow.com/a/671735
        If My.Settings.SearchWhenTyping = True Then
            TypeTimer.Stop()
            BeginPackageIdSearch(toolstriptextboxSearch.Text, False, "Id")
        End If
    End Sub

    Private Sub HowToUseGuingetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseGuingetToolStripMenuItem.Click
        ' Go to the usage guide.
        Process.Start("https://drew-naylor.com/guinget/How-to-use")
    End Sub

    Private Sub RunCMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunCMDToolStripMenuItem.Click
        ' Run CMD.
        RunCMD(False)
    End Sub

    Private Sub RunCMDElevatedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunCMDElevatedToolStripMenuItem.Click
        ' Run CMD elevated.
        RunCMD(True)
    End Sub

    Private Shared Sub RunCMD(Elevated As Boolean)
        ' Run CMD and elevate it if necessary.
        Using CMD As New Process
            CMD.StartInfo.FileName = "cmd"
            If Elevated = True Then
                CMD.StartInfo.Verb = "runas"
            End If
            ' Make sure if the user cancels that it
            ' doesn't crash.
            Try
                CMD.Start()
            Catch ex As System.ComponentModel.Win32Exception
            End Try
        End Using
    End Sub

    Private Sub ShowUpgradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowUpgradesToolStripMenuItem.Click
        ' Show available upgrades in winget.
        CommandTools.ListUpgrades()
    End Sub

    Private Sub ListInstalledPackagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListInstalledPackagesToolStripMenuItem.Click
        ' List installed apps in winget.
        CommandTools.ListInstalled(My.Settings.AppsListUI)
    End Sub

    Private Sub listboxActions_DoubleClick(sender As Object, e As EventArgs) Handles listboxActions.DoubleClick
        ' Filter in the Actions listbox.
        FilterFromActionsListbox()
    End Sub

    Private Sub listboxActions_KeyDown(sender As Object, e As KeyEventArgs) Handles listboxActions.KeyDown
        ' Start searching if the "Enter" key is pressed and something is selected.
        If e.KeyCode = Keys.Enter Then
            ' Start searching.
            FilterFromActionsListbox()
        End If
    End Sub

    Private Shared Sub FilterFromActionsListbox()
        ' IMPORTANT: This doesn't filter after a cache update even if
        ' "Search after cache update" is on. It's possible to add this
        ' functionality, but for now, a regular package ID search is
        ' performed if there's something in the search box when a
        ' cache update is run.
        ' This regular search overrides other filters such as
        ' the "Action" column filter.

        ' Start searching if something is selected.
        If aaformMainWindow.listboxActions.SelectedItems.Count = 1 Then
            If aaformMainWindow.listboxActions.SelectedIndex = 0 Then
                ' Search for everything if "All" is double-clicked.
                BeginPackageIdSearch(String.Empty, True, "Action")
            Else
                ' Search for the selected Action. This is between double-quotes
                ' to ensure that something like "Uninstall" showing up when searching
                ' for "Install" doesn't happen, for example.
                BeginPackageIdSearch("""" & aaformMainWindow.listboxActions.SelectedItem.ToString & """", True, "Action")
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItemImportPackages_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemImportPackages.Click
        ' Check if the user clicked OK in the file open dialog.
        If OpenFileDialogImportPackages.ShowDialog = DialogResult.OK Then
            ' The user clicked OK, so pass the file to winget.
            PackageListTools.ImportPackages(OpenFileDialogImportPackages.FileName)
        End If
    End Sub

    Private Sub ToolStripMenuItemExportPackages_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemExportPackages.Click
        ' Check if the user clicked OK in the file save dialog.
        If SaveFileDialogExportPackages.ShowDialog = DialogResult.OK Then
            ' The user clicked OK, so pass the file to winget.
            PackageListTools.ExportPackages(SaveFileDialogExportPackages.FileName)
        End If
    End Sub

#Region "Package details textbox context menu."
    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        ' Focus the textbox.
        textboxPackageDetails.Focus()
        ' Select all the text.
        textboxPackageDetails.SelectAll()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Copy text if some is selected.
        If textboxPackageDetails.SelectedText.Length > 0 Then
            textboxPackageDetails.Copy()
        End If
    End Sub

    Private Sub RightToLeftMenuItem_Click(sender As Object, e As EventArgs) Handles RightToLeftMenuItem.Click
        ' Toggle the right to left reading order.
        If textboxPackageDetails.RightToLeft = RightToLeft.No Then
            textboxPackageDetails.RightToLeft = RightToLeft.Yes
            ' Change the toggle's checkbox.
            RightToLeftMenuItem.Checked = True
        Else
            ' It's on, so turn it back off.
            textboxPackageDetails.RightToLeft = RightToLeft.No
            ' Change the toggle's checkbox.
            RightToLeftMenuItem.Checked = False
        End If
    End Sub
#End Region

#Region "KDE-style fast resize."
    Private Sub aaformMainWindow_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        ' The window started to resize, so we need to
        ' take a screenshot of the package list
        ' and show it so resizing is fast.
        ' Only do this if UseKDEStyleFastResize is on.
        ' We also have to make sure the update task isn't
        ' currently running.
        If My.Settings.UseKDEStyleFastResize = True AndAlso IsPackageListTaskRunning = False Then
            ' Create an image that we'll copy into.
            ' Code based on these SO answers:
            ' https://stackoverflow.com/a/33454625
            ' https://stackoverflow.com/a/23805004
            ' At first the code was mainly from the
            ' second one, but it ended up mainly being
            ' from the second one mostly I think.
            Dim packagelistScreenshot As New Bitmap(datagridviewPackageList.Width, datagridviewPackageList.Height)

            ' This thing copies the screenshot of the package list
            ' into the screenshot we'll show later.
            Using graphicsCopier As Graphics = Graphics.FromImage(packagelistScreenshot)
                graphicsCopier.CopyFromScreen(datagridviewPackageList.PointToScreen(New Point(0, 0)), New Point(0, 0), New Drawing.Size(datagridviewPackageList.Width, datagridviewPackageList.Height))
            End Using

            ' Assign the screenshot to the imagebox.
            pictureboxFastResizePackageList.Image = packagelistScreenshot

            ' Change visibility for the package list and
            ' the screenshot picturebox.
            pictureboxFastResizePackageList.Visible = True
            datagridviewPackageList.Visible = False

            ' Bring the picturebox to the front.
            pictureboxFastResizePackageList.BringToFront()
        End If
    End Sub

    Private Sub aaformMainWindow_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        ' We're done resizing, so set things back to
        ' how they should be.
        ' Only do this if UseKDEStyleFastResize is on.
        ' We also have to make sure the update task isn't
        ' currently running.
        If My.Settings.UseKDEStyleFastResize = True AndAlso IsPackageListTaskRunning = False Then
            ' Change visibility so the package list is
            ' again visible and the picturebox isn't.
            pictureboxFastResizePackageList.Visible = False
            datagridviewPackageList.Visible = True

            ' Bring the package list to the front.
            datagridviewPackageList.BringToFront()
        End If
    End Sub
#End Region

    Private Sub VerifyManifestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerifyManifestToolStripMenuItem.Click
        ' Show Validate Manifest window.
        ValidateManifestWindow.ShowDialog(Me)
    End Sub

    Private Sub textboxPackageDetails_SelectionChanged(sender As Object, e As EventArgs) Handles textboxPackageDetails.SelectionChanged
        ' Allow or block the "Copy" button based on
        ' whether something is selected or not.
        If textboxPackageDetails.SelectedText.Length > 0 Then
            CopyToolStripMenuItem.Enabled = True
        Else
            CopyToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub datagridviewPackageList_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles datagridviewPackageList.DataBindingComplete
        ' Hide certain columns once databinding is complete.
        ' Based on this SO post, solution 2:
        ' https://stackoverflow.com/a/16744811
        With datagridviewPackageList
            ' Hide the LatestVersion column if My.Settings.HideUnfinishedControls is True,
            ' and show it if it's False.
            .Columns("LatestVersion").Visible = Not My.Settings.HideUnfinishedControls
            ' Setting the AutoSizeMode for Action and Status.
            ' Not sure if this needs to be turned off to improve performance, but
            ' it seems really fast anyway.
            .Columns("Action").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Status").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("ManifestPath").Visible = My.Settings.DebuggingShowManifestPathColumn
            .Columns("Id").HeaderText = "Package"
        End With
    End Sub

    Private Sub ShowContextMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowContextMenuToolStripMenuItem.Click
        ' Shows the context menu for selected cells.
        ' I'd prefer the context menu to show up underneath the last-selected one, but having it be PointToScreen gets it close enough,
        ' in this case to the top-right corner. This isn't that good because it can cover up part of the screen, but
        ' at least it's functional for showing the context menu for keyboard users.
        contextmenustripPackageMenu.Show(datagridviewPackageList.PointToScreen(datagridviewPackageList.Location))
    End Sub


    ' If we wanted to, we could allow the package list to be loaded on application
    ' startup, but since loading the files list isn't async yet, it takes a bit
    ' longer than not loading the files list on startup and requiring a click
    ' on the "Refresh cache" button.
    ' Not sure if this is faster or slower with Await.
    'Private Async Sub aaformMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Await AddPackageEntryToListAsync()
    'End Sub





    ' This YouTube video should help out with displaying CMD
    ' output in the app's window:
    ' https://www.youtube.com/watch?v=APyteDZMpYw
    ' The above video doesn't seem to work if
    ' the code you're calling is in another class without
    ' Me.Invoke. libguinget.PackageTools.GetPkgInfoAsync
    ' works a lot better for this task as example code.

End Class