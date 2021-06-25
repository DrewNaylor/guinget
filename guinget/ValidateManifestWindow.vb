' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows. Not associated with either
'           Microsoft or the Synaptic project. 
' Copyright (C) 2020-2021 Drew Naylor
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




Public Class ValidateManifestWindow
    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        ' Close the window.
        Me.Close()
    End Sub

    Private Sub buttonBrowseForManifest_Click(sender As Object, e As EventArgs) Handles buttonBrowseForManifest.Click
        ' Get manifest path from browse dialog.
        ' Some code copied from UXL Launcher.
        If openfiledialogBrowseForManifest.ShowDialog = DialogResult.OK Then
            ' If the user clicks the "OK" button, put the path
            ' in the textbox.
            textboxManifestPath.Text = openfiledialogBrowseForManifest.FileName
        End If
    End Sub

    Private Sub buttonValidateManifest_Click(sender As Object, e As EventArgs) Handles buttonValidateManifest.Click
        ' Send manifest over to winget for validation.
        ' First make sure there's text in the textbox.
        If textboxManifestPath.Text.Length > 0 Then
            If Not textboxManifestPath.Text.StartsWith("""") AndAlso Not textboxManifestPath.Text.EndsWith("""") Then
                ' Wrap the path in quotes if necessary.
                textboxManifestPath.Text = """" & textboxManifestPath.Text & """"
            End If
        End If
    End Sub

    Private Sub textboxManifestPath_TextChanged(sender As Object, e As EventArgs) Handles textboxManifestPath.TextChanged
        ' Allow or block the "Validate manifest" button if
        ' there's text in the textbox.
        If textboxManifestPath.Text.Length > 0 Then
            buttonValidateManifest.Enabled = True
        Else
            buttonValidateManifest.Enabled = False
        End If
    End Sub
End Class