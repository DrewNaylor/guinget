Public Class DownloadProgressForm

    ' Some of this code may help to figure out how to download stuff async
    ' and display progress:
    ' https://stackoverflow.com/a/19459595

#Region "Package list properties"
    ' Package list URL.
    Friend Shared Property PackageListUrl As String = String.Empty

    ' Package list source name.
    Friend Shared Property PackageListSourceName As String = String.Empty
#End Region

End Class