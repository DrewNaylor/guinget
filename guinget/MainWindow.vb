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

    Private Shared Async Function AddPackageEntryToListAsync() As Task

        ' Adds a package to the package list based on what's in the manifests folder.
        ' TODO: Make sure the package's status is properly set. For now, it'll
        ' probably be "Not installed" unless tracking installed packages is added
        ' as a feature.

        ' TODO: If I can figure out a way to make this async, I will,
        ' but for now non-async is better than nothing.
        ' Update 5/27/2020: This sub is now async for getting
        ' package details, but not async for getting the package
        ' list yet.
        ' One issue with this code is that if the manifests can't be found,
        ' it'll just hang here.

        ' Change mouse cursor to the "working" one.
        ' For some reason this doesn't work if the mouse is outside
        ' the window when starting to load the list.
        ' Instead it'll just keep the default cursor.
        aaformMainWindow.Cursor = Cursors.WaitCursor

        ' Hide the datagridview while we're updating to make
        ' this slightly faster.
        aaformMainWindow.datagridviewPackageList.Visible = False

        ' Clear the rows.
        aaformMainWindow.datagridviewPackageList.Rows.Clear()

        ' Display loading progress bar and stuff.
        ProgressInfoVisibility()

        ' Update main window so the "loading package list, please wait..." label
        ' looks ok when the package list is hidden, along with anything else
        ' that needs to be refreshed, like the details textbox.
        aaformMainWindow.Update()

        ' Now we populate the Manifest column with each manifest.
        Dim ManifestPaths() As String = PackageListTools.GetManifests.TrimEnd.Split(CType("?", Char()))

        ' Set progress bar maximum and step count.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum = ManifestPaths.Count - 1
        aaformMainWindow.toolstripprogressbarLoadingPackages.Step = 1

        ' Update loading statusbar label.
        ' We're not showing the current index anymore since that takes too long.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading package list" & "..."

        'MessageBox.Show(ManifestPaths.Count.ToString)
        'MessageBox.Show(ManifestPaths(0))

        ' Check to make sure there are manifests.
        If ManifestPaths(0) = String.Empty Then
            ' Reset main window stuff to default.
            PackageListPostUpdate()
            Exit Function
        End If

        ' Go through everything in the manifest paths array until it's out.
        For i As Integer = 0 To ManifestPaths.Count - 2

            ' Read the file into the manifest column and make a new row with it.
            aaformMainWindow.datagridviewPackageList.Rows.Add("Do nothing", "Unknown", "Loading...", "Loading...", "Loading...", "Loading...", ManifestPaths(i))

            ' Make the progress bar progress.
            aaformMainWindow.toolstripprogressbarLoadingPackages.Value = i
            ' Update the statusbar to show the current info.
            aaformMainWindow.statusbarMainWindow.Update()
        Next

        ' Update the main window now that the list is loaded.
        aaformMainWindow.Update()

        ' Set the progressbar to the maximum to make it look finished.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum

        ' Update loading label.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading package details..."

        ' Update the main window again after making the list visible and changing the loading label.
        aaformMainWindow.Update()

        ' Now we load the details for each row.
        For Each Row As DataGridViewRow In aaformMainWindow.datagridviewPackageList.Rows
            ' Load package ID column.
            Row.Cells.Item(2).Value = Await PackageTools.GetPackageInfoFromYamlAsync(Row.Cells.Item(6).Value.ToString, "Id")
            ' Load package name column.
            Row.Cells.Item(3).Value = Await PackageTools.GetPackageInfoFromYamlAsync(Row.Cells.Item(6).Value.ToString, "Name")
            ' Load package version column.
            Row.Cells.Item(4).Value = Await PackageTools.GetPackageInfoFromYamlAsync(Row.Cells.Item(6).Value.ToString, "Version")
            ' Load package description column.
            Row.Cells.Item(5).Value = Await PackageTools.GetPackageInfoFromYamlAsync(Row.Cells.Item(6).Value.ToString, "Description")
            ' Update the progressbar so it doesn't look frozen.
            aaformMainWindow.toolstripprogressbarLoadingPackages.Value = Row.Index
            aaformMainWindow.statusbarMainWindow.Update()
        Next

        ' We're done updating the package list, so call the post-update sub.
        PackageListPostUpdate()

    End Function

    Private Shared Sub PackageListPostUpdate()

        ' Show the package list again.
        ' We're waiting until the loading is done so it finishes faster.
        aaformMainWindow.datagridviewPackageList.Visible = True

        ' Update the main window again.
        aaformMainWindow.Update()

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
            " packages listed."

        ' Focus the package list.
        aaformMainWindow.datagridviewPackageList.Focus()
    End Sub

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
        MarkPackages(sender.ToString)
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
        MarkPackages(sender.ToString)
    End Sub

    Friend Shared Sub MarkPackages(Action As String)

        ' Mark each package with an action based on what
        ' the user wants.

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
            Package.Cells.Item(0).Value = Action
            ' Move the progress bar.
            aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
            ' Update the status bar to show the current progress.
            aaformMainWindow.statusbarMainWindow.Update()
        Next

        ' Hide progress bar and info label.
        ProgressInfoVisibility(False)

        ' Reset loading label to default.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."

        ' Change mouse cursor to the default one.
        aaformMainWindow.Cursor = Cursors.Default
    End Sub

    Friend Shared Sub ProgressInfoVisibility(Optional Visible As Boolean = True)

        ' Make the progress bar and progress label shown or hidden
        ' based on the Visible arg.
        aaformMainWindow.toolstripstatusSplitter.Visible = Visible
        aaformMainWindow.toolstripprogressbarLoadingPackages.Visible = Visible
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Visible = Visible
    End Sub

    Private Sub datagridviewPackageList_SelectionChanged(sender As Object, e As EventArgs) Handles datagridviewPackageList.SelectionChanged
        ' Get package details if only one package is selected.
        If datagridviewPackageList.SelectedRows.Count = 1 Then
            ' If only one is selected, get its details into the details textbox.
            ' Set the textbox to say "Loading..." so it doesn't look like it's hanging.
            textboxPackageDetails.Text = "Loading, please wait..."
            ' Take text from the Manifest cell and use that
            ' file path to display text in the details textbox.
            Dim ManifestPath As String = datagridviewPackageList.Item(6, datagridviewPackageList.SelectedRows.Item(0).Index).Value.ToString
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
            textboxPackageDetails.Text = "No package is selected or the package list hasn't been loaded yet." &
                " You can load the package list using the Refresh cache button."
        End If
    End Sub

    Private Sub toolstripbuttonApplyChanges_Click(sender As Object, e As EventArgs) Handles toolstripbuttonApplyChanges.Click

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

    Private Sub toolstripbuttonRefreshCache_Click(sender As Object, e As EventArgs) Handles toolstripbuttonRefreshCache.Click
        ' Display temporary message saying that we'll use update-manifests.bat, then to click Ok when ready.
        MessageBox.Show("For now, we'll update the manifests with update-manifests.bat, but this'll eventually be replaced with something better." &
                        " Please click OK when ready and follow the prompts in update-manifests.bat.", "Refresh cache")
        Using updatemanifestsscript As New Process
            ' Run update-manifests.bat.
            updatemanifestsscript.StartInfo.FileName = Application.StartupPath & "\update-manifests.bat"
            ' Need to make sure the update script is in the folder.
            Try
                updatemanifestsscript.Start()
            Catch ex As ComponentModel.Win32Exception
                MessageBox.Show("We couldn't find update-manifests.bat in the same folder as guinget.exe. " &
                                "Please download a new copy of guinget from https://github.com/DrewNaylor/guinget/releases")
            End Try
        End Using
        ' Show messagebox that says to click OK when finished with update-manifests.bat.
        MessageBox.Show("When finished with update-manifests.bat, please click OK.", "Refresh cache")
        ' Reload the package list with the new manifests.
        ' Trying to do this without blocking with this example:
        ' https://www.codeproject.com/Tips/729674/Simple-Net-progress-bar-using-async-await
        ' We need to make sure the manifests are installed, otherwise this will look like it hangs.
        Dim ManifestDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

        If My.Computer.FileSystem.DirectoryExists(ManifestDir) Then
            AddPackageEntryToListAsync()
        End If
    End Sub

    Private Sub datagridviewPackageList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewPackageList.CellDoubleClick
        ' Show package context menu on cell double-click, like Synaptic.
        contextmenustripPackageMenu.Show(MousePosition)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        '  Exit the application.
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Show About window.
        AboutWindow.ShowDialog(Me)
    End Sub

    Friend Shared Sub UnfinishedControlsVisible(Visible As Boolean)

        ' Hide controls that don't work yet.
        ' Fiters pane.
        ' Saying "Not" here makes it the inverse of Visible.
        aaformMainWindow.splitcontainerSidebarAndPkgList.Panel1Collapsed = Not Visible
        ' Tools menu.
        aaformMainWindow.ToolsToolStripMenuItem.Visible = Visible
        ' Properties button.
        aaformMainWindow.toolstripbuttonProperties.Visible = Visible
        ' Search box.
        aaformMainWindow.toolstriptextboxSearch.Visible = Visible
        ' Search button.
        aaformMainWindow.toolstripsplitbuttonSearch.Visible = Visible
        ' Toolstrip separators.
        aaformMainWindow.ToolStripSeparator1.Visible = Visible
        aaformMainWindow.ToolStripSeparator2.Visible = Visible

    End Sub

    Private Sub aaformMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide unfinished controls on startup if My.Settings.HideUnfinishedControls = True.
        If My.Settings.HideUnfinishedControls = True Then
            UnfinishedControlsVisible(False)
        End If
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