Public Class aaformMainWindow
    Private Sub ExamplePackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamplePackageToolStripMenuItem.Click
        ' Original code for info as well as the PackageInfo class was from this StackOverflow answer:
        ' https://stackoverflow.com/a/36801744

        ' Add test packages to the list.
        ' These will eventually be replaced with a package list
        ' retrieved from winget.
        Dim p = New PackageInfo With {.Status = "NotInstalled", .PkgName = "VLC", .Description = "A versitile media player."}
        AddPackageEntryToList(p.Status, p.PkgName, p.Description)
        Dim p2 = New PackageInfo With {.Status = "Installed", .PkgName = "Notepad++", .Description = "Light-weight but feature-rich text editor."}
        AddPackageEntryToList(p2.Status, p2.PkgName, p2.Description)
        Dim p3 = New PackageInfo With {.Status = "Installed", .PkgName = "z", .Description = "z test"}
        AddPackageEntryToList(p3.Status, p3.PkgName, p3.Description)
    End Sub

    Private Sub AddPackageEntryToList(Status As String, PkgName As String, Description As String)

        ' Adds a package to the package list based on what's passed to it.
        ' TODO: "Do nothing" should be changed to match the package's
        ' current status. Maybe this could be something stored in another hidden
        ' list for selections that can be shown in a different window or something.
        datagridviewPackageList.Rows.Add("Do nothing", Status, PkgName, Description)
    End Sub

    Private Sub datagridviewPackageList_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewPackageList.CellMouseDown
        ' Code based on this SO answer:
        ' https://stackoverflow.com/a/939275
        ' Also borrows from this answer:
        ' https://stackoverflow.com/a/173315

        If e.Button = MouseButtons.Right AndAlso e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Check if Control is being held down.
            If ModifierKeys = Nothing Then
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



    ' This YouTube video should help out with displaying CMD
    ' output in the app's window:
    ' https://www.youtube.com/watch?v=APyteDZMpYw

End Class


Public Class PackageInfo
    Public Property Status As String
    Public Property PkgName As String
    Public Property InstalledVersion As String
    Public Property AvailableVersion As String
    Public Property Description As String
End Class