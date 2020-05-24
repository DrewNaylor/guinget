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

        ' Have a number to store how many packages there are.
        Dim packageCount As Integer = 0
        Dim packageArray(packageCount) As String
        While SQLdr.Read()
            ' Add package to package string array.
            For i As Integer = 0 To SQLdr.GetString(SQLdr.GetOrdinal("name")).Count
                packageArray(i) = SQLdr.GetString(SQLdr.GetOrdinal("name"))
                ' Update the package count.
                MessageBox.Show(i.ToString)

            Next
            ' Return package array.
            'Return SQLdr.GetString(SQLdr.GetOrdinal("name"))
            'aaformMainWindow.textboxPackageDetails.AppendText(SQLdr.GetString(SQLdr.GetOrdinal("name")))
        End While



        Return packageArray(packageCount)

        'End the connection
        SQLdr.Close()
        SQLConn.Close()
    End Function

End Class
