' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows. Not associated with either
'           Microsoft or the Synaptic project. 
' Copyright (C) 2020-2022 Drew Naylor
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




Public Class AboutWindow

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Put text in the About textbox.
        textboxAbout.Text = "guinget" & vbCrLf &
                        "Version " & My.Application.Info.Version.ToString & " Beta" & vbCrLf &
                        My.Application.Info.Copyright & vbCrLf &
                        vbCrLf &
                        My.Resources.AboutWindowCopyrightsAndStuff.Replace(vbLf, vbCrLf)
    End Sub

    Private Sub labelShowHiddenControls_Click(sender As Object, e As EventArgs) Handles labelShowHiddenControls.Click
        ' Show unfinished controls.
        aaformMainWindow.UnfinishedControlsVisible(True)
    End Sub
End Class
