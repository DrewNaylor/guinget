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




Public Class MiniApplyChangesOptionsForm

    Private Sub MiniApplyChangesOptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load settings.
        checkboxElevateWinget.Checked = My.Settings.ElevateWinget
        checkboxInstallInteractively.Checked = My.Settings.InstallInteractively
        checkboxOpenAutomatically.Checked = My.Settings.ReopenMiniOptionsWindowOnOpeningApplyChangesWindow

        ' Version-specifying settings.
        checkboxWhenInstalling.Checked = My.Settings.SpecifyVersionOnInstall
        checkboxWhenUpgrading.Checked = My.Settings.SpecifyVersionOnUpgrade
        checkboxWhenUninstalling.Checked = My.Settings.SpecifyVersionOnUninstall
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

    Private Sub checkboxWhenInstalling_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxWhenInstalling.CheckedChanged
        ' Saving this other setting.
        My.Settings.SpecifyVersionOnInstall = checkboxWhenInstalling.Checked
        SaveReloadSettings()
    End Sub

    Private Sub checkboxWhenUpgrading_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxWhenUpgrading.CheckedChanged
        ' Saving this other setting.
        My.Settings.SpecifyVersionOnUpgrade = checkboxWhenUpgrading.Checked
        SaveReloadSettings()
    End Sub

    Private Sub checkboxWhenUninstalling_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxWhenUninstalling.CheckedChanged
        ' Saving this other setting.
        My.Settings.SpecifyVersionOnUninstall = checkboxWhenUninstalling.Checked
        SaveReloadSettings()
    End Sub

    Private Sub buttonRestoreDefaults_Click(sender As Object, e As EventArgs) Handles buttonRestoreDefaults.Click
        ' Restore defaults.
        checkboxElevateWinget.Checked = False
        checkboxInstallInteractively.Checked = False
        checkboxOpenAutomatically.Checked = False

        ' Version-specifying settings.
        checkboxWhenInstalling.Checked = True
        checkboxWhenUpgrading.Checked = False
        checkboxWhenUninstalling.Checked = False
    End Sub
End Class