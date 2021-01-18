' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows. Not associated with either
'           Microsoft or the Synaptic project. 
' Copyright (C) 2020 Drew Naylor
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

#Region "Add package entry to list."
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

        '' Turn off autosize to make it go way faster.Might not help
        '' performance, so it's commented out for now.
        '' Credits to this SO answer:
        '' https://stackoverflow.com/a/19518340
        'For Each column As DataGridViewColumn In aaformMainWindow.datagridviewPackageList.Columns
        '    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        'Next

        ' Hide the datagridview while we're updating to make
        ' this slightly faster.
        aaformMainWindow.datagridviewPackageList.Visible = False



        ' Clear the rows.
        aaformMainWindow.datagridviewPackageList.Rows.Clear()

        ' Reset progress bar to 0.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0

        ' Display loading progress bar and stuff.
        ProgressInfoVisibility()

        ' Update main window so the "loading package list, please wait..." label
        ' looks ok when the package list is hidden, along with anything else
        ' that needs to be refreshed, like the details textbox.
        aaformMainWindow.Update()

        ' Now we populate the Manifest column with each manifest.
        Dim ManifestPaths As List(Of String) = PackageListTools.GetManifests

        ' Set progress bar maximum and step count.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum = ManifestPaths.Count - 1
        aaformMainWindow.toolstripprogressbarLoadingPackages.Step = 1

        ' Update loading statusbar label.
        ' We're not showing the current index anymore since that takes too long.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading package list..."

        'MessageBox.Show(ManifestPaths.Count.ToString)
        'MessageBox.Show(ManifestPaths(0))

        ' Check to make sure there are manifests.
        If ManifestPaths(0) = String.Empty Then
            ' Reset main window stuff to default.
            PackageListPostUpdate()
            Exit Function
        End If

        ' Go through everything in the manifest paths array until it's out if
        ' we don't want to load from a database.
        If My.Settings.LoadFromSqliteDb = False Then
            For i As Integer = 0 To ManifestPaths.Count - 1

                ' Read the file into the manifest column and make a new row with it.
                aaformMainWindow.datagridviewPackageList.Rows.Add("Do nothing", "Unknown", "Loading...", "Loading...", "Loading...", "Unknown", "Loading...", ManifestPaths(i))

                ' Make the progress bar progress.
                aaformMainWindow.toolstripprogressbarLoadingPackages.Value = i
                ' Update the statusbar to show the current info.
                aaformMainWindow.statusbarMainWindow.Update()
            Next
        Else
            ' We do want to load from the database, so do it.
            Dim SqliteList As DataTable = PackageListTools.GetPackageDetailsTableFromSqliteDB()
            'MessageBox.Show(SqliteList.Rows.Item(0).ToString)
            'aaformMainWindow.datagridviewPackageList.DataSource = SqliteList
            For Each PackageRow As DataRow In SqliteList.Rows
                If My.Settings.OnlyDisplayLatestPackageVersion = True Then
                    ' If the user wants to only display the latest package version,
                    ' we'll have to compare it.
                    If PackageRow.Item(2).ToString = PackageRow.Item(3).ToString Then
                        ' Only add the package to the list if the package row we're looking
                        ' at is the latest version of the package.
                        aaformMainWindow.datagridviewPackageList.Rows.Add("Do nothing", "Unknown", PackageRow.Item(0), PackageRow.Item(1), PackageRow.Item(2), PackageRow.Item(3), "Loading...", "Loading...")
                    End If
                Else
                    ' Just add all the package versions.
                    aaformMainWindow.datagridviewPackageList.Rows.Add("Do nothing", "Unknown", PackageRow.Item(0), PackageRow.Item(1), PackageRow.Item(2), PackageRow.Item(3), "Loading...", "Loading...")
                End If
                ' Make the progress bar progress.
                aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
                ' Update the statusbar to show the current info.
                aaformMainWindow.statusbarMainWindow.Update()
            Next
        End If

        ' Update the main window now that the list is loaded.
        aaformMainWindow.Update()

        ' Set the progressbar to the maximum to make it look finished.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum

        ' Update loading label.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading package details..."

        ' Update the main window again after making the list visible and changing the loading label.
        aaformMainWindow.Update()

        ' Now we load the details for each row.
        If My.Settings.LoadFromSqliteDb = False Then
            For Each Row As DataGridViewRow In aaformMainWindow.datagridviewPackageList.Rows
                ' Load package ID column.
                Row.Cells.Item(2).Value = Await PackageTools.GetPackageInfoFromYamlAsync(Row.Cells.Item(7).Value.ToString, "Id")
                ' Load package name column.
                Row.Cells.Item(3).Value = Await PackageTools.GetPackageInfoFromYamlAsync(Row.Cells.Item(7).Value.ToString, "Name")
                ' Load package version column.
                Row.Cells.Item(4).Value = Await PackageTools.GetPackageInfoFromYamlAsync(Row.Cells.Item(7).Value.ToString, "Version")
                ' Load package description column.
                Row.Cells.Item(6).Value = Await PackageTools.GetPackageInfoFromYamlAsync(Row.Cells.Item(7).Value.ToString, "Description")
                ' Update the progressbar so it doesn't look frozen.
                aaformMainWindow.toolstripprogressbarLoadingPackages.Value = Row.Index
                aaformMainWindow.statusbarMainWindow.Update()
            Next

            ' In case there are manifests we can't find easily,
            ' we need to get them now.
            ' These have to be grabbed now or else updating the manifests
            ' will crash when the path doesn't exist.
        ElseIf My.Settings.LoadFromSqliteDb = True Then
            PackageListTools.FallbackPathList = PackageListTools.GetManifests

            ' Now we need to load the manifests and the descriptions.
            For Each PackageRow As DataGridViewRow In aaformMainWindow.datagridviewPackageList.Rows
                ' Find the manifest and get its description.
                PackageRow.Cells.Item(7).Value = Await PackageListTools.FindManifestByVersionAndId(PackageRow.Cells.Item(2).Value.ToString, PackageRow.Cells.Item(4).Value.ToString)

                ' Ensure the manifest path cell isn't nothing.
                ' The database was broken just after 1 AM EDT
                ' on October 8, 2020, so this is to prevent
                ' future crashes, even if the database is broken
                ' again.
                If PackageRow.Cells.Item(7).Value IsNot Nothing Then
                    PackageRow.Cells.Item(6).Value = Await PackageTools.GetPackageInfoFromYamlAsync(PackageRow.Cells.Item(7).Value.ToString, "Description")
                Else
                    ' If the value in the manifest path cell is nothing, change the description.
                    PackageRow.Cells.Item(6).Value = "(Couldn't find manifest)"
                End If
                ' Make the progress bar progress.
                aaformMainWindow.toolstripprogressbarLoadingPackages.Value = PackageRow.Index
                ' Update the statusbar to show the current info.
                aaformMainWindow.statusbarMainWindow.Update()
            Next
        End If

        ' We're done updating the package list, so call the post-update sub.
        PackageListPostUpdate()

    End Function

    Friend Shared Async Sub PackageListPostUpdate()

        ' Show the package list again.

        '' Turn autosize back on for certain columns. Might not help
        '' performance, so it's commented out for now.
        'aaformMainWindow.PkgAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'aaformMainWindow.PkgStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        ' Reset progress bar to 0.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0

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

        ' Display number of packages loaded. This really should be
        ' changed to calculate the number of currently-visible rows
        ' in case the user is filtering the list,
        ' but this is better than nothing for now.
        ' This SO answer might help:
        ' https://stackoverflow.com/a/44661255
        aaformMainWindow.toolstripstatuslabelPackageCount.Text = (aaformMainWindow.datagridviewPackageList.RowCount).ToString &
            " packages loaded."

        ' Focus the package list.
        aaformMainWindow.datagridviewPackageList.Focus()
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


    Private Sub SelectedPackagesActionDoNothingMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedPackagesActionDoNothingMenuItem.Click
        ' Mark packages from the menubar.
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

    Private Sub SelectedPackagesActionInstallMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedPackagesActionInstallMenuItem.Click
        ' Mark packages from the menubar.
        MarkPackages("Install")
    End Sub
#End Region

#Region "Where the package-marking takes place."
    Friend Shared Sub MarkPackages(Action As String)

        ' Mark each package with an action based on what
        ' the user wants.

        ' Turn off autosize to make it go way faster.
        ' We're only doing this if the number of selected
        ' rows is excessive.
        ' Credits to this SO answer:
        ' https://stackoverflow.com/a/19518340
        If aaformMainWindow.datagridviewPackageList.SelectedRows.Count >= 25 Then
            For Each column As DataGridViewColumn In aaformMainWindow.datagridviewPackageList.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
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
            If Package.Visible = True Then
                ' Mark the package.
                Package.Cells.Item(0).Value = Action
            End If
            ' Move the progress bar.
            aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
            ' Update the status bar to show the current progress.
            aaformMainWindow.statusbarMainWindow.Update()
        Next

        ' Turn autosize back on for certain columns.
        aaformMainWindow.PkgAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        aaformMainWindow.PkgStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        ' Hide progress bar and info label.
        ProgressInfoVisibility(False)

        ' Reset loading label to default.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."

        ' Change mouse cursor to the default one.
        aaformMainWindow.Cursor = Cursors.Default
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

    Private Sub ShowSelectedPackageDetails()

        ' We can now display the package details while making sure the manifest isn't
        ' nothing.
        If datagridviewPackageList.SelectedRows.Item(0).Cells(7).Value IsNot Nothing AndAlso
                    IO.File.Exists(datagridviewPackageList.SelectedRows.Item(0).Cells(7).Value.ToString) Then
            ' If only one is selected, get its details into the details textbox.
            ' Set the textbox to say "Loading..." so it doesn't look like it's hanging.
            textboxPackageDetails.Text = "Loading, please wait..."
            ' Take text from the Manifest cell and use that
            ' file path to display text in the details textbox.
            Dim ManifestPath As String = datagridviewPackageList.Item(7, datagridviewPackageList.SelectedRows.Item(0).Index).Value.ToString
            ' Display full manifest in details textbox.
            textboxPackageDetails.Text = My.Computer.FileSystem.ReadAllText(ManifestPath).Replace(vbLf, vbCrLf)
        ElseIf datagridviewPackageList.SelectedRows.Count = 0 Then
            ' If no rows are selected, say so in the same way Synaptic does,
            ' because it says it in a way that's simple and nice.
            ' This might not show up since rows are automatically selected when
            ' they're loaded.

            ' TODO: Allow the user to choose whether to update the cache before
            ' loading the package list, or just load the package list. This
            ' should be a setting to allow for people to choose whether it
            ' always updates the cache automatically, or have it ask to update every time.
            ' This should be based on a time thing, so only update after 5 minutes for example.
            textboxPackageDetails.Text = "No package is selected or the package list hasn't been loaded yet. " &
                "You can load the package list by using the Refresh cache toolbar button, by going to Package list" &
                ">Refresh cache, or by pressing Ctrl+R."
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
            PackageListTools.RootForm = aaformMainWindow
            Await PackageListTools.UpdateManifestsAsync(My.Settings.Use7zipForExtraction, My.Settings.PathTo7zip, My.Settings.UseRobocopyForCopying, My.Settings.LoadFromSqliteDb)
        End If

        ' We need to make sure the manifests are installed, otherwise this will look like it hangs.
        Dim ManifestDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

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

        If My.Settings.UseBuiltinCacheUpdater = False Then
            ' If the user doesn't want to use the new updater,
            ' then use update-manifests.bat.
            ' Be sure to tell the user it's deprecated.
            RefreshCache()
        Else
            ' Otherwise, we default to using the new, built-in updater
            ' provided by libguinget.
            Await aaformMainWindow.UpdatePackageListBuiltinAsync
        End If

        ' Re-enable those controls now that we're done updating.
        ControlStateDuringCacheUpdate(True)

        ' Re-run search if the user wants to.
        If My.Settings.RerunSearchAfterCacheUpdate = True AndAlso toolstriptextboxSearch.Text IsNot String.Empty Then
            BeginPackageIdSearch()
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

#Region "update-manifests.bat cache updater."
    Friend Shared Sub RefreshCache()
        ' Display temporary message saying that we'll use update-manifests.bat, then to click Ok when ready.
        MessageBox.Show(aaformMainWindow, "We'll update the manifests with update-manifests.bat instead of the much faster built-in updater." &
                        " Please be aware that update-manifests.bat was deprecated in guinget version 0.1 alpha and may be removed in a future version without prior notice." & vbCrLf &
                        vbCrLf & "When ready, please click OK and follow the prompts in update-manifests.bat.", "Refresh cache")
        Using updatemanifestsscript As New Process
            ' Run update-manifests.bat.
            updatemanifestsscript.StartInfo.FileName = Application.StartupPath & "\update-manifests.bat"
            ' Need to make sure the update script is in the folder.
            Try
                updatemanifestsscript.Start()
            Catch ex As ComponentModel.Win32Exception
                MessageBox.Show(aaformMainWindow, "We couldn't find update-manifests.bat in the same folder as guinget.exe. " &
                                "Please download a new copy of guinget from https://github.com/DrewNaylor/guinget/releases")
            End Try
        End Using
        ' Show messagebox that says to click OK when finished with update-manifests.bat.
        MessageBox.Show(aaformMainWindow, "When finished with update-manifests.bat, please click OK.", "Refresh cache")
        ' Reload the package list with the new manifests.
        ' Trying to do this without blocking with this example:
        ' https://www.codeproject.com/Tips/729674/Simple-Net-progress-bar-using-async-await
        ' We need to make sure the manifests are installed, otherwise this will look like it hangs.
        Dim ManifestDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

        If My.Computer.FileSystem.DirectoryExists(ManifestDir) Then
            AddPackageEntryToListAsync()
        End If
    End Sub
#End Region
#End Region

    Private Sub datagridviewPackageList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewPackageList.CellDoubleClick
        ' Show package context menu on cell double-click, like Synaptic.

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Make sure we're not double-clicking on the column headers
            ' before showing the context menu. This allows quick column
            ' auto-sizing based on cell contents when double-clicking
            ' the header separators.
            ' Related issue:
            ' https://github.com/DrewNaylor/guinget/issues/16
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
    Friend Shared Sub UnfinishedControlsVisible(Visible As Boolean)

        ' Hide controls that don't work yet.

        ' Sidebar tab control.
        ' We need to use properties based on this answer:
        ' https://stackoverflow.com/a/30231315
        ' Properties set in the designer.
        ' Switch the dropdown list that's displayed.
        If Visible = True Then
            ' Clear the items from the dropdown.
            aaformMainWindow.comboboxSidebarTabSelector.Items.Clear()
            ' Take the list of pages that are currently hidden and split them.
            Dim HiddenList As String() = My.Resources.HiddenSidebarList.Split(CChar(","))
            ' Go through the list and add them to the dropdown.
            For Each HiddenPage As String In HiddenList
                aaformMainWindow.comboboxSidebarTabSelector.Items.Add(HiddenPage)
            Next
            ' Set the selected index for the dropdown back to 0.
            aaformMainWindow.comboboxSidebarTabSelector.SelectedIndex = 0
        End If

        ' Tools menu items.
        aaformMainWindow.FindManifestToolStripMenuItem.Visible = Visible
        aaformMainWindow.VerifyManifestToolStripMenuItem.Visible = Visible
        If Visible = False Then
            ' Empty menu items so they don't make the Options menu item
            ' too long.
            aaformMainWindow.FindManifestToolStripMenuItem.Text = String.Empty
            aaformMainWindow.VerifyManifestToolStripMenuItem.Text = String.Empty
        Else
            aaformMainWindow.FindManifestToolStripMenuItem.Text = "Find manifest using version and ID..."
            aaformMainWindow.VerifyManifestToolStripMenuItem.Text = "&Validate manifest"
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
        ' Tools menu.
        aaformMainWindow.zSeparatorAboveEditWingetSettings.Visible = Visible

        ' Experimental settings panel in Options window.
        OptionsWindow.panelExperimentalSettings.Visible = Visible

    End Sub
#End Region

    Private Sub aaformMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Upgrade settings if necessary.
        If My.Settings.UpgradeSettingsFromPreviousVersion = True Then
            My.Settings.Upgrade()
            My.Settings.UpgradeSettingsFromPreviousVersion = False
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

    End Sub

#Region "HiDPI-related stuff."
    Private Sub HiDPIModeToggle(UseHiDPIMode As Boolean)
        ' Turn on or off HiDPI mode as needed.
        If UseHiDPIMode = True Then
            ' Make the package list double height.
            datagridviewPackageList.RowTemplate.Height = 48
            ' Change the height of all the packages in there.
            PkgAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            PkgStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            For Each PackageRow As DataGridViewRow In datagridviewPackageList.Rows
                PackageRow.Height = 48
            Next
            PkgAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            PkgStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Else
            ' Turn off HiDPI mode.
            datagridviewPackageList.RowTemplate.Height = 24
            PkgAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            PkgStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            For Each PackageRow As DataGridViewRow In datagridviewPackageList.Rows
                PackageRow.Height = 24
            Next
            PkgAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            PkgStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End If
    End Sub
#End Region

#Region "Package ID search."
    Private Sub toolstripsplitbuttonSearch_ButtonClick(sender As Object, e As EventArgs) Handles toolstripsplitbuttonSearch.ButtonClick
        ' Start searching.
        BeginPackageIdSearch()
    End Sub

    Friend Shared Sub BeginPackageIdSearch(Optional SearchStartedFromSidebar As Boolean = False)

        ' Make sure there are packages to begin with.
        If aaformMainWindow.datagridviewPackageList.Rows.Count >= 1 Then

            ' Place search term into the sidebar if it wasn't started from the sidebar.
            If SearchStartedFromSidebar = False Then
                ' Make sure it's not already in the sidebar.
                If Not aaformMainWindow.listboxSearchTerms.Items.Contains(aaformMainWindow.toolstriptextboxSearch.Text) Then
                    aaformMainWindow.listboxSearchTerms.Items.Add(aaformMainWindow.toolstriptextboxSearch.Text)
                End If
            End If

            ' Change progress label text.
            If Not aaformMainWindow.toolstriptextboxSearch.Text = String.Empty Then
                ' If there's something in the search box, include it in the status bar text.
                aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Searching for " & aaformMainWindow.toolstriptextboxSearch.Text & "..."
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
            aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum = aaformMainWindow.datagridviewPackageList.Rows.Count - 1
            ' Set progress bar value to 0.
            aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0
            ' Update main window.
            aaformMainWindow.Update()

            Dim SearchTerm As String = aaformMainWindow.toolstriptextboxSearch.Text

            For Each searchRow As DataGridViewRow In aaformMainWindow.datagridviewPackageList.Rows
                ' Look in each row in the datagridview, and see what text it has.
                ' If it starts and ends with double-quotes, remove them and do an exact match.
                If SearchTerm.ToLowerInvariant.StartsWith("""") AndAlso SearchTerm.ToLowerInvariant.EndsWith("""") Then
                    ' Set all rows visible to what's in the search box without the start and end.
                    If searchRow.Cells.Item(2).Value.ToString.ToLowerInvariant = SearchTerm.ToLowerInvariant.Trim(CChar("""")) Then
                        ' Set only exactly-matching rows to show.
                        searchRow.Visible = True
                    Else
                        ' Otherwise, hide it.
                        searchRow.Visible = False
                    End If
                ElseIf searchRow.Cells.Item(2).Value.ToString.ToLowerInvariant.Contains(SearchTerm.ToLowerInvariant) Then
                    ' If the Package ID cell contains what's in the search box, show it.
                    searchRow.Visible = True
                Else
                    ' Otherwise, hide it.
                    searchRow.Visible = False
                End If
                ' Make the progress bar progress.
                aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
                ' Update the status bar.
                aaformMainWindow.statusbarMainWindow.Update()
            Next
            ' Hide the progress bar.
            ProgressInfoVisibility(False)

            ' Reset progress label text.
            aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."

            ' Turn autosize back on for certain columns.
            aaformMainWindow.PkgAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            aaformMainWindow.PkgStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            ' Show the package list again.
            aaformMainWindow.datagridviewPackageList.Visible = True

            ' Update the main window.
            aaformMainWindow.Update()

        End If
    End Sub

    Private Sub toolstriptextboxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles toolstriptextboxSearch.KeyDown
        ' Start searching on pressing Enter.
        If e.KeyCode = Keys.Enter Then
            BeginPackageIdSearch()
        ElseIf e.KeyCode = Keys.Escape Then
            ' Otherwise if it's Escape, clear the search box.
            toolstriptextboxSearch.Clear()
        End If

        ' Stop timer, if necessary.
        If My.Settings.SearchWhenTyping = True Then
            TypeTimer.Stop()
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
        BeginPackageIdSearch(True)
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

        ' Change sidebar visibility if necessary.
        SidebarVisibility(My.Settings.ShowSidebar)

        ' Show or hide unfinished controls.
        UnfinishedControlsVisible(Not My.Settings.HideUnfinishedControls)

        ' Update search when typing timer if necessary.
        TypeTimer.Interval = My.Settings.SearchWhenTypingTimerInterval

        ' Update HiDPI Mode status.
        HiDPIModeToggle(My.Settings.HiDPIMode)
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

            BeginPackageIdSearch()
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
        If My.Settings.SearchWhenTyping = True Then
            TypeTimer.Stop()
            TypeTimer.Start()
        End If
    End Sub

    Private Sub TypeTimer_Tick(sender As Object, e As EventArgs) Handles TypeTimer.Tick
        ' Once the search when typing timer reaches its interval,
        ' stop the timer and start the search.
        ' Got the idea for this particular code from this post:
        ' https://stackoverflow.com/a/671735
        If My.Settings.SearchWhenTyping = True Then
            TypeTimer.Stop()
            BeginPackageIdSearch()
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
        CommandTools.ListInstalled()
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


Public Class PackageInfo

    ' This class contains info on the packages.
    Public Property Status As String
    Public Property Package As String
    Public Property InstalledVersion As String
    Public Property AvailableVersion As String
    Public Property Description As String
End Class