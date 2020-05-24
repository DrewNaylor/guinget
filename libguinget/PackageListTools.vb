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

        'For Each query returned

        '' Data table based on this SO answer:
        '' https://stackoverflow.com/a/14629894
        'Dim dtable As DataTable = New DataTable
        'dtable.Load(SQLdr)


        '' Have a number to store how many packages there are.
        'Dim packageIndex As Integer = 0
        Dim packageArray As String = String.Empty
        '' Add package to package string array.
        'For i As Integer = 0 To dtable.Rows.Count - 1
        '    packageArray(i) = dtable.GetString(SQLdr.GetOrdinal("name"))
        '    ' Update the package count.
        '    MessageBox.Show(i.ToString)


        'Next

        ' Get data from the name column based on this MSDN page:
        ' https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader
        If SQLdr.HasRows Then
            Do While SQLdr.Read
                ' While reading the SQL db file, append the package name we're
                ' looking at with the current package and add a comma
                ' for separation.
                Debug.WriteLine(SQLdr.GetInt32(0) _
                  & vbTab & SQLdr.GetString(0))
                packageArray = SQLdr.GetString(0) & ","
                MessageBox.Show(packageArray)
            Loop
        End If


        ' Return package array.
        'Return SQLdr.GetString(SQLdr.GetOrdinal("name"))
        'aaformMainWindow.textboxPackageDetails.AppendText(SQLdr.GetString(SQLdr.GetOrdinal("name")))





        'End the connection
        SQLdr.Close()
        SQLConn.Close()

        Return packageArray
    End Function

End Class
