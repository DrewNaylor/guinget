' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows. Not associated with either
'           Microsoft or the Synaptic project. 
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



Public Class ChoosePkglistUpdater

    Private Sub buttonUpdateWithUpdateManifests_Click(sender As Object, e As EventArgs) Handles buttonUpdateWithUpdateManifests.Click
        Me.Hide()
        aaformMainWindow.RefreshCache()
    End Sub

    Private Sub buttonUpdateWithBuiltin_Click(sender As Object, e As EventArgs) Handles buttonUpdateWithBuiltin.Click
        'Me.Hide()

        Using progressform As New libguinget.DownloadProgressForm
            progressform.PackageListUrl = "https://github.com/Microsoft/winget-pkgs/archive/master.zip"
            progressform.PackageListSourceName = "Microsoft/winget-pkgs"
            progressform.ShowDialog()
        End Using

        'libguinget.PackageListTools.UpdateManifests()

        ' We need to make sure the manifests are installed, otherwise this will look like it hangs.
        'Dim ManifestDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"



        'If My.Computer.FileSystem.DirectoryExists(ManifestDir) Then
        '    aaformMainWindow.AddPackageEntryToListAsync()
        'End If

        Me.Close()
    End Sub
End Class