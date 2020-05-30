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



Imports libguinget

Public Class ApplyChangesWindow
    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click

    End Sub

    Private Sub datagridviewAppsBeingInstalled_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewAppsBeingInstalled.CellDoubleClick
        ' When double-clicking a cell, we'll call winget and start
        ' installing or uninstalling the package.
        ' Necessary for now as we don't support batch installs yet.

        ' Now we install the selected package.
        InstallSinglePackage()

    End Sub

    Private Sub buttonConfirmChanges_Click(sender As Object, e As EventArgs) Handles buttonConfirmChanges.Click
        ' Show a messagebox that says we don't support batch installs yet, and
        ' ask the user to double-click or press Enter on each of the packages
        ' when they're ready to start installing them.
    End Sub

    Private Sub InstallSinglePackage()
        ' First make sure that we're not already installing the package.
        If Not datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(3).Value.ToString = datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(2).Value.ToString & "ing..." Then

            ' If we're not installing, change the current status cell value to "Installing..." and
            ' show a messagebox for testing.

            datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(3).Value = datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(2).Value.ToString & "ing..."

            ' Show messagebox with current status.
            'MessageBox.Show(datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(3).Value.ToString)

            ' Now call winget and install the package. Be sure to keep the window open
            ' for now until configuration is possible and until we display winget output
            ' in a textbox below the datagridview.
            PackageTools.InstallPkg(datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(0).Value.ToString,
                                               datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(1).Value.ToString)

        End If
    End Sub

    Private Sub datagridviewAppsBeingInstalled_KeyDown(sender As Object, e As KeyEventArgs) Handles datagridviewAppsBeingInstalled.KeyDown
        ' Make sure the user pressed Enter.
        If e.KeyCode = Keys.Enter Then

            ' Now we install whatever package the user has selected.
            InstallSinglePackage()

        End If
    End Sub
End Class