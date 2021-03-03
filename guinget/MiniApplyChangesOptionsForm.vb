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




Public Class MiniApplyChangesOptionsForm

    Private Sub MiniApplyChangesOptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load settings.
        checkboxElevateWinget.Checked = My.Settings.ElevateWinget
        checkboxInstallInteractively.Checked = My.Settings.InstallInteractively
        checkboxOpenAutomatically.Checked = My.Settings.ReopenMiniOptionsWindowOnOpeningApplyChangesWindow
    End Sub

    Private Sub checkboxElevateWinget_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxElevateWinget.CheckedChanged
        ' Save the new setting for checking or unchecking the box.
        My.Settings.ElevateWinget = checkboxElevateWinget.Checked
        SaveReloadSettings()
    End Sub

    Private Sub checkboxInstallInteractively_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxInstallInteractively.CheckedChanged
        ' Save the new setting.
        My.Settings.InstallInteractively = checkboxInstallInteractively.Checked
        SaveReloadSettings()
    End Sub

    Private Sub checkboxOpenAutomatically_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxOpenAutomatically.CheckedChanged
        ' Save this setting.
        My.Settings.ReopenMiniOptionsWindowOnOpeningApplyChangesWindow = checkboxOpenAutomatically.Checked
        SaveReloadSettings()
    End Sub

    Private Sub SaveReloadSettings()
        ' Save and reload settings.
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        ' Close the mini-form.
        Me.Close()
    End Sub
End Class