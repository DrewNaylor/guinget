﻿Public Class aaformMainWindow
    Private Sub ExamplePackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamplePackageToolStripMenuItem.Click
        ' Original code for info as well as the PackageInfo class was from this StackOverflow answer:
        ' https://stackoverflow.com/a/36801744
        Dim p = New PackageInfo With {.Status = "NotInstalled", .PkgName = "VLC", .Description = "A versitile media player."}
        datagridPackageList.Rows.Add(New String() {"Do nothing", p.Status, p.PkgName, p.Description})
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