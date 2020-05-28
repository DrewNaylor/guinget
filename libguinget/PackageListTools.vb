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
Imports YamlDotNet.RepresentationModel

Public Class PackageListTools

    Public Shared Async Function GetPackageInfoFromYaml(ManifestPath As String, RequestedKey As String) As Task(Of String)

        ' Load in the file and get whatever was requested of it.


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

        Dim PackageInfo As String = String.Empty
        Using Input As StreamReader = File.OpenText(ManifestPath)

            PackageInfo = Await GetManifestInfoAsync(Input, RequestedKey)
        End Using

        Return PackageInfo

        ' Load the stream in.
        'Dim YamlStream As New YamlStream
        'YamlStream.Load(Input)

        '' Create variable for root node.
        'Dim YamlRoot = CType(YamlStream.Documents(0).RootNode, YamlMappingNode)

        'For Each Entry In YamlRoot.Children

        '    ' If the requested key exists, then use it.
        '    ' This check doesn't work; maybe something
        '    ' like an ordered list would be better:
        '    ' https://stackoverflow.com/a/30097560
        '    ' Check each entry in the YAML root node.
        '    If CType(Entry.Key, YamlScalarNode).Value = RequestedKey Then
        '        ' If we're looking at an ID, add it to the package list array.

        '        Return Entry.Value.ToString
        '        'MessageBox.Show(Entry.Value.ToString)

        '    End If

        'Next

    End Function

    Friend Shared Async Function GetManifestInfoAsync(YamlInput As StreamReader, RequestedKey As String) As Task(Of String)
        ' Load the stream in.
        Dim YamlStream As New YamlStream
        YamlStream.Load(YamlInput)

        ' Create variable for root node.
        Dim YamlRoot = CType(YamlStream.Documents(0).RootNode, YamlMappingNode)

        Dim FinalList As String = String.Empty

        For Each Entry In YamlRoot.Children

            ' If the requested key exists, then use it.
            ' This check doesn't work; maybe something
            ' like an ordered list would be better:
            ' https://stackoverflow.com/a/30097560
            ' Check each entry in the YAML root node.
            If CType(Entry.Key, YamlScalarNode).Value = RequestedKey Then
                ' If we're looking at an ID, add it to the package list array.

                Return Entry.Value.ToString
                'MessageBox.Show(Entry.Value.ToString)

            End If

        Next
    End Function

    Public Shared Function GetManifests() As String
        ' Get and return each manifest in the manifests folder.
        Dim ManifestAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

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

End Class
