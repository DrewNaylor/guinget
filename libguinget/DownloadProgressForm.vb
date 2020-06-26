﻿Public Class DownloadProgressForm

    ' Some of this code may help to figure out how to download stuff async
    ' and display progress:
    ' https://stackoverflow.com/a/19459595

    Private Sub DownloadProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set label text.
        labelSourceName.Text = labelSourceName.Text & PackageListSourceName
        labelSourceLocation.Text = labelSourceLocation.Text & PackageListUrl

    End Sub

#Region "Package list properties"
    ' Package list URL.
    Public Property PackageListUrl As String = String.Empty

    ' Package list source name.
    Public Property PackageListSourceName As String = String.Empty
#End Region

End Class