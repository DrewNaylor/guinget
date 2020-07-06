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



Public Class DownloadProgressForm

    ' Some of this code may help to figure out how to download stuff async
    ' and display progress:
    ' https://stackoverflow.com/a/19459595

    Private Sub DownloadProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set label text.
        labelSourceName.Text = labelSourceName.Text & PackageListSourceName
        labelSourceLocation.Text = labelSourceLocation.Text & PackageListUrl
        labelDownloadingPackageList.Text = CurrentAction & ", please wait..."

        ' Update titlebar.
        Me.Text = CurrentAction

    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        ' Set the cancel flag if the user clicks Cancel.
        ' This can't be done if we're copying the package list files.
        PackageListTools.CancelUpdateFlag = True
    End Sub

#Region "Package list properties"
    ' Package list URL.
    Public Property PackageListUrl As String = String.Empty

    ' Package list source name.
    Public Property PackageListSourceName As String = String.Empty

    ' What action is currently being taken.
    ' This can be downloading or extracting.
    Public Property CurrentAction As String = "Downloading manifests"
#End Region

End Class