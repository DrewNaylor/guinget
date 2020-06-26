Public Class DownloadProgressForm

    ' Some of this code may help to figure out how to download stuff async
    ' and display progress:
    ' https://stackoverflow.com/a/19459595


    ' Get and return property for the package list URL.
    Friend Shared Property PackageListUrl As String
        Get
            Return _PackageListUrl
        End Get
        Set(value As String)
            _PackageListUrl = value
        End Set
    End Property

    ' Package list URL for the property.
    Private Shared _PackageListUrl As String = String.Empty

End Class