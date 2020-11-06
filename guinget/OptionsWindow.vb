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



Public Class OptionsWindow
    Private Sub OptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update controls with their current value from My.Settings.
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        ' Re-run search.
        checkboxRerunSearch.Checked = My.Settings.RerunSearchAfterCacheUpdate
        ' Show sidebar.
        checkboxShowSidebar.Checked = My.Settings.ShowSidebar
        ' Exact match for last-selected package ID.
        checkboxUseExactMatchForLastSelectedPackageIDSearch.Checked = My.Settings.ExactMatchForLastSelectedIDSearch

        ' Install interactively.
        checkboxInstallInteractively.Checked = My.Settings.InstallInteractively
        ' Elevate winget.
        checkboxElevateWinget.Checked = My.Settings.ElevateWinget

        ' Show last-selected package details.
        checkboxLastSelectedPackageDetails.Checked = My.Settings.ShowLastSelectedPackageDetails

        ' Load from database.
        checkboxLoadFromDatabase.Checked = My.Settings.LoadFromSqliteDb
        ' Load only latest versions.
        checkboxShowOnlyLatestVersions.Checked = My.Settings.OnlyDisplayLatestPackageVersion
        ' Use 7-Zip.
        checkboxUse7zip.Checked = My.Settings.Use7zipForExtraction
        ' Use Robocopy.
        checkboxUseRobocopy.Checked = My.Settings.UseRobocopyForCopying
        ' 7z.exe path.
        textbox7zExePath.Text = My.Settings.PathTo7zip
        ' Hide unfinished controls.
        checkboxHideUnfinishedControls.Checked = My.Settings.HideUnfinishedControls
    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        ' Reload the current settings.
        My.Settings.Reload()

        ' Close the window.
        Me.Close()
    End Sub

    Private Sub buttonOk_Click(sender As Object, e As EventArgs) Handles buttonOk.Click
        ' Save settings.
        SaveSettings()

        ' Close the window.
        Me.Close()
    End Sub

    Private Sub SaveSettings()
        ' Re-run search checkbox.
        My.Settings.RerunSearchAfterCacheUpdate = checkboxRerunSearch.Checked
        ' Show sidebar checkbox.
        My.Settings.ShowSidebar = checkboxShowSidebar.Checked
        ' Exact match for last-selected package ID checkbox.
        My.Settings.ExactMatchForLastSelectedIDSearch = checkboxUseExactMatchForLastSelectedPackageIDSearch.Checked

        ' Interactive installation.
        My.Settings.InstallInteractively = checkboxInstallInteractively.Checked
        ' Elevate winget.
        My.Settings.ElevateWinget = checkboxElevateWinget.Checked

        ' Show last-selected package details.
        My.Settings.ShowLastSelectedPackageDetails = checkboxLastSelectedPackageDetails.Checked

        ' Load from database.
        My.Settings.LoadFromSqliteDb = checkboxLoadFromDatabase.Checked
        ' Load only latest versions.
        My.Settings.OnlyDisplayLatestPackageVersion = checkboxShowOnlyLatestVersions.Checked
        ' Use 7-Zip.
        My.Settings.Use7zipForExtraction = checkboxUse7zip.Checked
        ' Use Robocopy.
        My.Settings.UseRobocopyForCopying = checkboxUseRobocopy.Checked
        ' 7z.exe path.
        My.Settings.PathTo7zip = textbox7zExePath.Text
        ' Hide unfinished controls.
        My.Settings.HideUnfinishedControls = checkboxHideUnfinishedControls.Checked

        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub buttonDefaults_Click(sender As Object, e As EventArgs) Handles buttonDefaults.Click
        ' Reload defaults.
        ReloadDefaults()

        ' Show a message saying it's been reset.
        MessageBox.Show("Values reset to default. Please note that this won't apply until you click OK.", "Defaults")
    End Sub

    Private Sub ReloadDefaults()
        ' Re-run search checkbox.
        checkboxRerunSearch.Checked = True
        ' Show sidebar checkbox.
        checkboxShowSidebar.Checked = True
        ' Exact match for last-selected package ID checkbox.
        checkboxUseExactMatchForLastSelectedPackageIDSearch.Checked = True

        ' Install interactively.
        checkboxInstallInteractively.Checked = False
        ' Elevate winget.
        checkboxElevateWinget.Checked = False

        ' Show last-selected package details.
        checkboxLastSelectedPackageDetails.Checked = True

        ' Load from database.
        checkboxLoadFromDatabase.Checked = False
        ' Load only latest versions.
        checkboxShowOnlyLatestVersions.Checked = False
        ' Use 7-Zip.
        checkboxUse7zip.Checked = False
        ' Use Robocopy.
        checkboxUseRobocopy.Checked = False
        ' 7z.exe path.
        textbox7zExePath.Text = "C:\Program Files\7-Zip\7z.exe"
        ' Hide unfinished controls.
        checkboxHideUnfinishedControls.Checked = True
    End Sub

    Private Sub tabcontrolOptions_MouseWheel(sender As Object, e As MouseEventArgs) Handles tabcontrolOptions.MouseWheel
        ' Switch tabs on scroll.
        libscrollswitchtabs.ScrollSwitchTabs.switch(tabcontrolOptions, e)
    End Sub

    Private Sub buttonBrowse7zExePath_Click(sender As Object, e As EventArgs) Handles buttonBrowse7zExePath.Click
        ' Show a Browse window so people can choose the 7z.exe path.
        If SevenZExeOpenFileDialog.ShowDialog = DialogResult.OK Then
            ' Make sure it's 7z.exe.
            If SevenZExeOpenFileDialog.SafeFileName.ToLowerInvariant = "7z.exe" Then
                textbox7zExePath.Text = SevenZExeOpenFileDialog.FileName
            Else
                ' If it's not 7z.exe, let the user know and allow them to use it anyway if they want.
                Dim msgResult As Integer = MessageBox.Show("The selected file is not 7z.exe. This may cause problems. Use this file?", "Browse for 7z.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If msgResult = DialogResult.Yes Then
                    textbox7zExePath.Text = SevenZExeOpenFileDialog.FileName
                End If
            End If
        End If
    End Sub
End Class