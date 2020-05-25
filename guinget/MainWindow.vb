' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows.
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




Public Class aaformMainWindow
    Private Sub ExamplePackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamplePackageToolStripMenuItem.Click
        ' Original code for info as well as the PackageInfo class was from this StackOverflow answer:
        ' https://stackoverflow.com/a/36801744

        ' Add test packages to the list.
        ' These will eventually be replaced with a package list
        ' retrieved from winget.
        'Dim p = New PackageInfo With {.Status = "NotInstalled", .Package = "VLC", .AvailableVersion = "3.0.10", .Description = "A versitile media player."}
        'AddPackageEntryToList(p.Status, p.Package, p.AvailableVersion, p.Description)
        'Dim p2 = New PackageInfo With {.Status = "Installed", .Package = "Notepad++", .AvailableVersion = "v7.8.5", .Description = "Light-weight but feature-rich text editor."}
        'AddPackageEntryToList(p2.Status, p2.Package, p2.AvailableVersion, p2.Description)
        'Dim p3 = New PackageInfo With {.Status = "Installed", .Package = "z", .AvailableVersion = "1.0", .Description = "z test"}
        'AddPackageEntryToList(p3.Status, p3.Package, p3.AvailableVersion, p3.Description)
        AddPackageEntryToList()
    End Sub

    Private Shared Sub AddPackageEntryToList()
        ' Temporary copy of this sub's args:
        ' Status As String, Package As String, AvailableVersion As String, Description As String

        ' Adds a package to the package list based on what's passed to it.
        ' TODO: "Do nothing" should be changed to match the package's
        ' current status. Maybe this could be something stored in another hidden
        ' list for selections that can be shown in a different window or something.
        'aaformMainWindow.datagridviewPackageList.Rows.Add("Do nothing", Status, libguinget.PackageListTools.GetPackageList, AvailableVersion, Description)

        ' Assign a variable to store the package list array.
        Dim separatedPackageArray() As String = libguinget.PackageListTools.GetPackageList.Split(CType(",", Char()))

        ' Go through all the items in the array until we run out.
        For i As Integer = 0 To separatedPackageArray.Count - 1
            ' Add a row with each item in the array.
            aaformMainWindow.datagridviewPackageList.Rows.Add("Do nothing", "", separatedPackageArray(i), "", "")
        Next
        'LoadPackageList()
    End Sub

    Private Sub datagridviewPackageList_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewPackageList.CellMouseDown
        ' Code based on this SO answer:
        ' https://stackoverflow.com/a/939275
        ' Also borrows from this answer:
        ' https://stackoverflow.com/a/173315

        If e.Button = MouseButtons.Right AndAlso e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Make sure no modifier keys like Control are held down.
            Dim currentRow As Integer = e.RowIndex
            If ModifierKeys = Nothing AndAlso Not datagridviewPackageList.SelectedRows.Contains(currentRow) Then
                ' TODO: Make sure that if the cell under the mouse is selected,
                ' then DON'T deselect the already-selected cells.
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

    Private Async Sub datagridviewPackageList_SelectionChanged(sender As Object, e As EventArgs) Handles datagridviewPackageList.SelectionChanged
        ' Get package details if only one package is selected.
        If datagridviewPackageList.SelectedRows.Count = 1 Then
            ' If only one is selected, get its details into the details textbox.
            ' Set the textbox to say "Loading..." so it doesn't look like it's hanging.
            textboxPackageDetails.Text = "Loading, please wait..."
            textboxPackageDetails.Text = Await libguinget.PackageTools.GetPkgDetailsAsync(datagridviewPackageList.Item(2, datagridviewPackageList.SelectedRows.Item(0).Index).Value.ToString)
        End If
    End Sub





    ' This YouTube video should help out with displaying CMD
    ' output in the app's window:
    ' https://www.youtube.com/watch?v=APyteDZMpYw

End Class


Public Class PackageInfo

    ' This class contains info on the packages.
    Public Property Status As String
    Public Property Package As String
    Public Property InstalledVersion As String
    Public Property AvailableVersion As String
    Public Property Description As String
End Class