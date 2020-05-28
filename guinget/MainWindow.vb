﻿' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
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

        ' Change mouse cursor to the "working" one.
        aaformMainWindow.Cursor = Cursors.WaitCursor

        ' Hide the datagridview while we're updating to make
        ' this slightly faster.
        aaformMainWindow.datagridviewPackageList.Visible = False

        ' Clear the rows.
        aaformMainWindow.datagridviewPackageList.Rows.Clear()

        ' Display loading progress bar and stuff.
        aaformMainWindow.toolstripstatusSplitter.Visible = True
        aaformMainWindow.toolstripprogressbarLoadingPackages.Visible = True
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Visible = True

        ' Update main window so the "loading package list, please wait..." label
        ' looks ok when the package list is hidden, along with anything else
        ' that needs to be refreshed, like the details textbox.
        aaformMainWindow.Update()

        ' Now we populate the Manifest column with each manifest.
        Dim ManifestPaths() As String = PackageListTools.GetManifests.TrimEnd.Split(CType("?", Char()))

        ' Set progress bar maximum and step count.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum = ManifestPaths.Count - 1
        aaformMainWindow.toolstripprogressbarLoadingPackages.Step = 1

        Dim starttime As DateTime = DateTime.Now

        ' Update loading statusbar label.
        ' We're not showing the current index anymore since that takes too long.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading package list" & "..."

        ' Go through everything in the manifest paths array until it's out.
        For i As Integer = 0 To ManifestPaths.Count - 2

            ' Read the file into the manifest column and make a new row with it.
            aaformMainWindow.datagridviewPackageList.Rows.Add("Do nothing", "Unknown", "Loading...", "Loading...", "Loading...", "Loading...", ManifestPaths(i))

            ' Make the progress bar progress.
            aaformMainWindow.toolstripprogressbarLoadingPackages.PerformStep()
            ' Update the statusbar to show the current info.
            aaformMainWindow.statusbarMainWindow.Update()
        Next

        Debug.WriteLine((DateTime.Now - starttime).TotalSeconds)

        ' Update the main window now that the list is loaded.
        aaformMainWindow.Update()

        ' Set the progressbar to the maximum to make it look finished.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Maximum = 100
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 100

        ' Update loading label.
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Text = "Loading package details..."

        ' Show datagridview again.
        aaformMainWindow.datagridviewPackageList.Visible = True

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
            ' Update the package list so it doesn't show loading for everything until it's done.
            aaformMainWindow.datagridviewPackageList.Update()
        Next

        ' Update the main window again.
        aaformMainWindow.Update()

        ' Hide the loading label and progress bar as well as the
        ' fake splitter label.
        aaformMainWindow.toolstripstatusSplitter.Visible = False
        aaformMainWindow.toolstripprogressbarLoadingPackages.Visible = False
        aaformMainWindow.toolstripstatuslabelLoadingPackageCount.Visible = False

        ' Reset progress bar to 0.
        aaformMainWindow.toolstripprogressbarLoadingPackages.Value = 0

        ' Change mouse cursor to the default one.
        aaformMainWindow.Cursor = Cursors.Default

        ' Display number of packages loaded. This really should be
        ' changed to calculate the number of currently-visible rows
        ' in case the user is filtering the list,
        ' but this is better than nothing for now.
        ' This SO answer might help:
        ' https://stackoverflow.com/a/44661255
        aaformMainWindow.toolstripstatuslabelPackageCount.Text = (aaformMainWindow.datagridviewPackageList.RowCount - 1).ToString &
            " packages listed."
    End Function

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
        For Each Package As DataGridViewRow In datagridviewPackageList.SelectedRows
            Package.Cells.Item(0).Value = sender.ToString
        Next
    End Sub

    Private Sub InstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallToolStripMenuItem.Click
        ' Set all selected packages to "do nothing", or whatever the text in the
        ' context menu item that was clicked is. This could allow for
        ' translation and adding additional actions.
        For Each Package As DataGridViewRow In datagridviewPackageList.SelectedRows
            Package.Cells.Item(0).Value = sender.ToString
        Next
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
            textboxPackageDetails.Text = "No package is selected."
        End If
    End Sub

    Private Sub toolstripbuttonApplyChanges_Click(sender As Object, e As EventArgs) Handles toolstripbuttonApplyChanges.Click
        Using proc As New Process
            proc.StartInfo.FileName = "winget"

            ' If we want to get everything, do so.
            If datagridviewPackageList.Rows(3).Cells(0).Value.ToString = "Install" Then
                proc.StartInfo.Arguments = "show -e " & """" & datagridviewPackageList.Rows(3).Cells(2).Value.ToString & """"
                proc.Start()
            End If
            '' Setup procinfo properties.
            'proc.StartInfo.UseShellExecute = False
            'proc.StartInfo.RedirectStandardError = True
            'proc.StartInfo.RedirectStandardInput = True
            'proc.StartInfo.RedirectStandardOutput = True
            'proc.StartInfo.CreateNoWindow = True

            ''If Not proc.Start Then Throw New InvalidOperationException("winget is not installed or could not be started.")

            'Using cancelRegister = cancel.Register(Sub() proc.Kill())

            '    ' Start winget so we can get output from it.
            '    proc.Start()

            '    ' Assign and create variables to store its output.
            '    Dim wingetOutput = proc.StandardOutput.ReadToEndAsync
            '    Dim wingetError = proc.StandardError.ReadToEndAsync

            '    ' Wait for the output and error tasks to complete.
            '    Await Task.WhenAll(wingetOutput, wingetError)

            '    ' Close winget's standard output and standard error.
            '    proc.StandardOutput.Close()
            '    proc.StandardError.Close()

            '    ' Run the process and wait for exit (why didn't this work before? I have no idea.)
            '    Await Task.Run(AddressOf proc.WaitForExit)

            '    ' Assign variables for standard output and error to winget's output stuff.
            '    Dim standardOut = Await wingetOutput
            '    Dim standardErr = Await wingetError

            '    ' If canceling is requested, then throw an operation canceled exception.
            '    If cancel.IsCancellationRequested = True Then
            '        Throw New OperationCanceledException(standardErr)
            '    ElseIf String.IsNullOrEmpty(standardOut) = True Then
            '        ' If the output is null or empty, throw an exception.
            '        Throw New Exception(standardErr)
            '    Else
            '        ' Otherwise, if it's all good, return the output.
            '        Return standardOut
            '    End If

        End Using
    End Sub

    Private Sub toolstripbuttonRefreshCache_Click(sender As Object, e As EventArgs) Handles toolstripbuttonRefreshCache.Click
        ' Display temporary message saying to use update-manifests.bat, then click Ok.
        MessageBox.Show("Please run update-manifests.bat located in guinget's EXE directory (may also be in the" &
                        " repository's root folder), then click OK when it's finished.", "Refresh cache")
        ' Reload the package list with the new manifests.
        AddPackageEntryToListAsync()
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