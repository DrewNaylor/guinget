Imports System.Windows.Forms
Imports Microsoft.Data.Sqlite

Public Class PackageListTools

    Public Shared Function GetPackageList() As String
        ' Trying to load the package list as shown in this SO
        ' question that has the solution with it:
        ' https://stackoverflow.com/q/19553165

        'Value to search as SQL Query - return first match
        Dim SQLstr As String = "Select name FROM names;"

        'Define file to open - .path passed from parent form
        Dim connection As String = "Data Source=C:\Users\drewn\Desktop\index.db"
        Dim SQLConn As New SqliteConnection(connection)
        Dim SQLcmd As New SqliteCommand(SQLConn.ToString)
        Dim SQLdr As SqliteDataReader
        SQLConn.Open()

        SQLcmd.Connection = SQLConn
        SQLcmd.CommandText = SQLstr
        SQLdr = SQLcmd.ExecuteReader()


        ' Store the package name list in an array.
        Dim packageArray As String = String.Empty

        ' Get data from the name column based on this MSDN page:
        ' https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader
        If SQLdr.HasRows Then
            ' If the SQL data reader has rows, then read it.
            Do While SQLdr.Read
                ' While reading the SQL db file, append the package name we're
                ' looking at with the current package and add a comma
                ' for separation.
                packageArray = packageArray & SQLdr.GetString(0) & ","
            Loop
        End If


        'End the connection
        SQLdr.Close()
        SQLConn.Close()

        ' Return the list of packages.
        Return packageArray
    End Function

End Class
