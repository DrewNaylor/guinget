' libguinget - Package tools for guinget and other programs that
'              want to use them.
' Copyright (C) 2020 Drew Naylor
' (Note that the copyright years include the years left out by the hyphen.)
' winget, Windows, and all related words are copyright and trademark Microsoft Corporation.
'
' This file is a part of the guinget project.
' Neither guinget nor Drew Naylor are associated with Microsoft
' and Microsoft does not endorse guinget.
'
'
'   Licensed under the Apache License, Version 2.0 (the "License");
'   you may not use this file except in compliance with the License.
'   You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
'   Unless required by applicable law or agreed to in writing, software
'   distributed under the License is distributed on an "AS IS" BASIS,
'   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'   See the License for the specific language governing permissions and
'   limitations under the License.



Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.Data.Sqlite
Imports YamlDotNet

Public Class PackageListTools

    Public Shared Function GetPackageListFromYaml() As String

        ' Look in the manifests folder and get the IDs from
        ' each .yml file in every subdirectory.

        ' Create a variable to hold the package list.
        Dim PackageListArray As String = String.Empty

        ' Create a variable to hold the folder we'll be looking in.
        Dim ManifestAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\pkglist\manifests"

        ' Take the Id string for each package file and append it to the
        ' package list array variable.
        For Each PackageManifest As String In My.Computer.FileSystem.GetFiles(ManifestAppDataFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.yaml")

            ' Set up the document input.
            Dim Input As StringReader = New StringReader(PackageManifest)

            MessageBox.Show(PackageManifest)
        Next

        Return PackageListArray

    End Function

    Public Shared Function GetPackageListFromSqliteDB() As String
        ' Trying to load the package list as shown in this SO
        ' question that has the solution with it:
        ' https://stackoverflow.com/q/19553165

        'Value to search as SQL Query - return first match
        Dim SqlQuery As String = "Select id FROM ids;"

        ' Specify winget package list database file we want
        ' to read from.
        Dim PackageListPath As String = "Data Source=C:\Users\drewn\Desktop\index.db"
        Dim SqlConnection As New SqliteConnection(PackageListPath)
        Dim SqlCommand As New SqliteCommand(SqlConnection.ToString)
        Dim SqlDataReader As SqliteDataReader
        ' Open connection to the database file.
        SqlConnection.Open()

        SqlCommand.Connection = SqlConnection
        SqlCommand.CommandText = SqlQuery
        SqlDataReader = SqlCommand.ExecuteReader()


        ' Store the package name list in an array.
        Dim packageArray As String = String.Empty

        ' Get data from the name column based on this MSDN page:
        ' https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader
        If SqlDataReader.HasRows Then
            ' If the SQL data reader has rows, then read it.
            Do While SqlDataReader.Read
                ' While reading the SQL db file, append the package name we're
                ' looking at with the current package and add a comma
                ' for separation.
                packageArray = packageArray & SqlDataReader.GetString(0) & ","
            Loop
        End If


        'End the connection
        SqlDataReader.Close()
        SqlConnection.Close()

        ' Return the list of packages.
        Return packageArray
    End Function

End Class
