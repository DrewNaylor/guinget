' libguinget - Package and package list tools for guinget
'              and other programs that want to use them.
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



Imports System.Windows.Forms
Imports System.IO.Compression

Public Class PackageListTools

    ' Define an http client we'll use.
    Shared ReadOnly PkgClient As Net.Http.HttpClient = New Net.Http.HttpClient()

    Private Shared Async Function DownloadPkgListWithProgressAsync(ByVal SourceUrl As String, ByVal SourceName As String) As Task

        ' Download a file with HttpClient:
        ' https://stackoverflow.com/a/54475013

        ' Show a progress form that says what's being done.
        Using progressform As New libguinget.DownloadProgressForm
            ' Set progress form properties.
            progressform.PackageListUrl = "https://github.com/Microsoft/winget-pkgs/archive/master.zip"
            progressform.PackageListSourceName = "Microsoft/winget-pkgs"

            ' Show progress form.
            progressform.ShowDialog()

            ' Define uri with source url.
            Dim PkgUri As Uri = New Uri(SourceUrl)

            ' Define HTTP response message.
            Dim ClientResponse = Await PkgClient.GetAsync(PkgUri)

            ' Set up the filestream we'll write to.
            Using OutputStream As IO.FileStream = New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                                       "\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master.zip", IO.FileMode.CreateNew)
                MessageBox.Show(OutputStream.ToString)
                ' Copy out the stream.
                Await ClientResponse.Content.CopyToAsync(OutputStream)
            End Using

        End Using

        Return
    End Function

    Public Shared Async Function UpdateManifests() As Task
        ' Start downloading the package list from
        ' https://github.com/Microsoft/winget-pkgs/archive/master.zip

        ' Re-create the temp folder.
        Dim tempDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                                   "\winget-frontends\source\winget-pkgs\temp"

        If Not System.IO.Directory.Exists(tempDir) Then
            ' If it doesn't exist, create it.
            System.IO.Directory.CreateDirectory(tempDir)
            ' Now we can download the package.
            ' This is copied here so it doesn't crash
            ' when it can't find the temp folder.
            Await DownloadPkgListWithProgressAsync("https://github.com/Microsoft/winget-pkgs/archive/master.zip",
                                         "Microsoft/winget-pkgs")
        Else
            ' Otherwise, re-create it.
            System.IO.Directory.Delete(tempDir, True)
            System.IO.Directory.CreateDirectory(tempDir)
            ' Now we can download the package.
            ' This is copied here so it doesn't crash
            ' when it can't find the temp folder.
            Await DownloadPkgListWithProgressAsync("https://github.com/Microsoft/winget-pkgs/archive/master.zip",
                                         "Microsoft/winget-pkgs")
        End If

        ' Trying to use this code to display progress as
        ' we update:
        ' https://stackoverflow.com/a/19459595

        'Using ArchiveDownloader As New Net.WebClient
        '    ' Download the package list using the ArchiveDownloader.
        '    ' Probably should make this async so that things don't lock up.
        '    ' If the temp folder doesn't exist, create it.
        '    If Not System.IO.Directory.Exists(tempDir) Then
        '        System.IO.Directory.CreateDirectory(tempDir)
        '    End If


        '    ArchiveDownloader.DownloadFile("https://github.com/Microsoft/winget-pkgs/archive/master.zip",
        '                                  tempDir & "\winget-pkgs-master.zip")
        'End Using

        MessageBox.Show("Done downloading.")

        ' Now we extract that file, but first we need to delete old manifests.
        Dim ManifestDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                                   "\winget-frontends\source\winget-pkgs\pkglist\manifests"
        If System.IO.Directory.Exists(ManifestDir) Then
            System.IO.Directory.Delete(ManifestDir, True)
        End If

        ' We can now extract the manifests.
        ZipFile.ExtractToDirectory(tempDir & "\winget-pkgs-master.zip", tempDir & "\winget-pkgs-master")

        MessageBox.Show("Done extracting.")

        ' Now we just need to copy the right files over.
        My.Computer.FileSystem.CopyDirectory(tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests", ManifestDir)

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
