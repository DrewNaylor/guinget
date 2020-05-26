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
Imports YamlDotNet.RepresentationModel

Public Class PackageListTools

    Public Shared Function GetPackageInfoFromYaml(ManifestPath As String, RequestedKey As String) As String

    End Function

    Public Shared Function GetPackageListFromYaml(RequestedKey As String) As String

        ' Look in the manifests folder and get the IDs from
        ' each .yml file in every subdirectory.

        ' Create a variable to hold the package list.
        Dim PackageListArray As String = String.Empty

        ' Create a variable to hold the folder we'll be looking in.
        Dim ManifestAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\pkglist\manifests"

        ' Take the Id string for each package file and append it to the
        ' package list array variable.
        For Each PackageManifest As String In My.Computer.FileSystem.GetFiles(ManifestAppDataFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.yaml")

            ' If the calling code just wants the manifest location, return it.
            If RequestedKey = "ManifestLocation" Then
                PackageListArray = PackageListArray & PackageManifest & ","
                'MessageBox.Show(PackageListArray)

            Else


                ' Set up the document input.
                ' We had to use a StreamReader instead of a StringReader
                ' that the LoadingAYamlStream sample used since we want
                ' to read a file, not a filename.
                ' If we used a StringReader, we'd end up with an Invalid
                ' Cast Exception with the following details:
                '    Unhandled Exception: System.InvalidCastException: Unable
                '    to cast object of type 'YamlDotNet.RepresentationModel.YamlScalarNode'
                '    to type 'YamlDotNet.RepresentationModel.YamlMappingNode'.`
                ' This working example is described in the following
                ' StackOverflow answer:
                ' https://stackoverflow.com/a/46897520
                Dim Input As StreamReader = New StreamReader(PackageManifest)

                ' Load the stream in.
                Dim YamlStream As New YamlStream
                YamlStream.Load(Input)

                ' Create variable for root node.
                Dim YamlRoot = CType(YamlStream.Documents(0).RootNode, YamlMappingNode)

                For Each Entry In YamlRoot.Children

                    Dim tempAppInfo As String

                    ' If the requested key exists, then use it.
                    ' This check doesn't work; maybe something
                    ' like an ordered list would be better:
                    ' https://stackoverflow.com/a/30097560
                    ' Check each entry in the YAML root node.
                    If CType(Entry.Key, YamlScalarNode).Value = RequestedKey Then
                        ' If we're looking at an ID, add it to the package list array.

                        tempAppInfo = tempAppInfo & Entry.Value.ToString & ","
                        'MessageBox.Show(Entry.Value.ToString)

                    End If


                    PackageListArray = tempAppInfo
                    'MessageBox.Show(CType(Entry.Key, YamlScalarNode).Value)
                Next

            End If

            'MessageBox.Show(PackageManifest)
        Next

        Return PackageListArray

    End Function

    Public Shared Function GetManifests() As String
        ' Get and return each manifest in the manifests folder.
        Dim ManifestAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\pkglist\manifests"

        ' Define a variable so we can store the manifest paths.
        Dim ManifestPath As String = String.Empty

        ' Take the Id string for each package file and append it to the
        ' package list array variable.
        For Each PackageManifest As String In My.Computer.FileSystem.GetFiles(ManifestAppDataFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.yaml")

            ' Append the current package manifest's path to the ManifestPath string.
            ' Using a question mark since it's not allowed in path names.
            ManifestPath = ManifestPath & PackageManifest & "?"
        Next

        Return ManifestPath
    End Function

    Public Shared Function GetPackageDir(PackageID As String) As String

        ' Return folder but with the dot replaced with a backslash.
        Dim NewPackageDir As String = PackageID
        ' Make sure we only do this twice.
        ' Using Regex as per this answer if it's easy:
        ' https://stackoverflow.com/a/146747
        Dim regex As System.Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("\.")

        NewPackageDir = regex.Replace(NewPackageDir, "/", 1)

        Return NewPackageDir

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
