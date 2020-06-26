Public Class DownloadProgressForm

    ' Some of this code may help to figure out how to download stuff async
    ' and display progress:
    ' https://stackoverflow.com/a/19459595

    Friend Shared Property PackageListUrl As String

    ' Package list URL for the property.
    Private Shared _PackageListUrl As String = String.Empty

End Class