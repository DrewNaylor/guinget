Public Class aaformMainWindow
    Private Sub ExamplePackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamplePackageToolStripMenuItem.Click
        ' Original code for info as well as the PackageInfo class was from this StackOverflow answer:
        ' https://stackoverflow.com/a/36801744
        Dim p = New PackageInfo With {.Status = "NotInstalled", .PkgName = "VLC", .Description = "A versitile media player."}
        AddPackageEntryToList(p.Status, p.PkgName, p.Description)
        Dim p2 = New PackageInfo With {.Status = "Installed", .PkgName = "Notepad++", .Description = "Light-weight but feature-rich text editor."}
        AddPackageEntryToList(p2.Status, p2.PkgName, p2.Description)
        Dim p3 = New PackageInfo With {.Status = "Installed", .PkgName = "z", .Description = "z test"}
        AddPackageEntryToList(p3.Status, p3.PkgName, p3.Description)
    End Sub

    Private Sub AddPackageEntryToList(Status As String, PkgName As String, Description As String)

        datagridviewPackageList.Rows.Add("Do nothing", Status, PkgName, Description)
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