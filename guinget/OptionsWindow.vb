﻿' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
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
        checkboxRerunSearch.Checked = My.Settings.RerunSearchAfterCacheUpdate
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
        My.Settings.RerunSearchAfterCacheUpdate = checkboxRerunSearch.Checked

        My.Settings.Save()
        My.Settings.Reload()
    End Sub
End Class