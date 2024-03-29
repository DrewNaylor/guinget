﻿' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows. Not associated with either
'           Microsoft or the Synaptic project. 
' Copyright (C) 2020-2023 Drew Naylor
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

        ' Now we install the selected package after making sure we didn't
        ' double-click on the header.
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ProcessSinglePackage()
        End If

    End Sub

    Private Sub buttonConfirmChanges_Click(sender As Object, e As EventArgs) Handles buttonConfirmChanges.Click
        ' Begin bulk-install process.
        ' Needs to be updated to check for packages the user wants to
        ' have uninstalled in the future when that's supported.
        BulkProcessPackages()
    End Sub

    Private Sub BulkProcessPackages()
        ' First make sure there are packages in the list.
        If datagridviewAppsBeingInstalled.Rows.Count > 0 Then
            ' Make sure we're not already installing by blocking out the "Confirm changes" button.
            buttonConfirmChanges.Enabled = False

            ' Start the install process.
            Dim PackageIDs As New List(Of String)
            Dim PackageVersions As New List(Of String)
            ' The "Tasks" list is used to store things for bulk uninstall,
            ' upgrade, and install.
            Dim Actions As New List(Of String)

            ' Go through the datagridview and add the packages to the list.
            For Each Package As DataGridViewRow In datagridviewAppsBeingInstalled.Rows
                If Package.Cells.Item(3).Value.ToString = "Ready" Then
                    PackageIDs.Add(Package.Cells(0).Value.ToString)
                    PackageVersions.Add(Package.Cells(1).Value.ToString)
                    Actions.Add(Package.Cells(2).Value.ToString.ToLowerInvariant)
                    Package.Cells.Item(3).Value = Package.Cells.Item(2).Value.ToString.TrimEnd(CChar("e")) & "ing..."
                End If
            Next

            ' Set the variables for whether the versions are used or not.
            PackageTools.SpecifyVersionOnInstall = My.Settings.SpecifyVersionOnInstall
            PackageTools.SpecifyVersionOnUpgrade = My.Settings.SpecifyVersionOnUpgrade
            PackageTools.SpecifyVersionOnUninstall = My.Settings.SpecifyVersionOnUninstall


            ' Send the lists over to the bulk install code.
            PackageTools.BulkPackageProcessor(Actions, PackageIDs, PackageVersions, My.Settings.InstallInteractively, My.Settings.ElevateWinget,
                                        My.Settings.DefaultSourceName)
        End If
    End Sub

    Private Sub ProcessSinglePackage()
        ' Before doing anything, make sure there are packages in the list.
        If datagridviewAppsBeingInstalled.CurrentRow IsNot Nothing Then
            ' First make sure that we're not already installing the package.
            If Not datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(3).Value.ToString = datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(2).Value.ToString.TrimEnd(CChar("e")) & "ing..." Then

                ' Call winget and process the package. Be sure to keep the window open
                ' for now until configuration is possible and until we display winget output
                ' in a textbox below the datagridview.

                ' Set the variables for whether the versions are used or not.
                PackageTools.SpecifyVersionOnInstall = My.Settings.SpecifyVersionOnInstall
                PackageTools.SpecifyVersionOnUpgrade = My.Settings.SpecifyVersionOnUpgrade
                PackageTools.SpecifyVersionOnUninstall = My.Settings.SpecifyVersionOnUninstall

                If datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(3).Value.ToString = "Ready" Then
                    ' Pass the package on to the single-package processor.
                    PackageTools.SinglePackageProcessor(datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(2).Value.ToString.ToLowerInvariant,
                                                        datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(0).Value.ToString,
                                                        datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(1).Value.ToString,
                                                        My.Settings.InstallInteractively, My.Settings.ElevateWinget,
                                                        My.Settings.DefaultSourceName)

                    ' Change the Current status column and make sure it's grammatically correct.
                    ' Doing this here since it's kinda weird for it to change from "Skip" to "Installing...".
                    datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(3).Value =
                        datagridviewAppsBeingInstalled.CurrentRow.Cells.Item(2).Value.ToString.TrimEnd(CChar("e")) & "ing..."
                End If
            End If
        End If
    End Sub

    Private Sub datagridviewAppsBeingInstalled_KeyDown(sender As Object, e As KeyEventArgs) Handles datagridviewAppsBeingInstalled.KeyDown
        ' Make sure the user pressed Enter.
        If e.KeyCode = Keys.Enter Then

            ' Now we install whatever package the user has selected.
            ProcessSinglePackage()

        End If
    End Sub

    Private Sub ApplyChangesWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Open the mini-form if the user wants to.
        If My.Settings.ReopenMiniOptionsWindowOnOpeningApplyChangesWindow = True Then
            OpenMiniApplyChangesOptionsForm()
        End If

        ' Unselect the package list.
        datagridviewAppsBeingInstalled.ClearSelection()

        ' Focus the "Confirm changes" button.
        buttonConfirmChanges.Select()
    End Sub

    Private Sub LinkLabelMiniOptionsForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelMiniOptionsForm.LinkClicked
        ' Open the mini-form.
        OpenMiniApplyChangesOptionsForm()
    End Sub

    ' Define a mini Options form used in the "glue" part.
    Dim MiniOptionsForm As Form

    Private Sub OpenMiniApplyChangesOptionsForm()
        ' Open the mini-form and set its location.
        ' Code based on this StackOverflow answer:
        ' https://stackoverflow.com/a/21790460
        If MiniOptionsForm Is Nothing Then
            MiniOptionsForm = New MiniApplyChangesOptionsForm
            AddHandler MiniOptionsForm.Load, AddressOf MoveMiniForm
            AddHandler Me.LocationChanged, AddressOf MoveMiniForm
            AddHandler MiniOptionsForm.FormClosed, Sub() MiniOptionsForm = Nothing
            MiniOptionsForm.Visible = False
            MiniOptionsForm.Show(Me)
        Else
            ' Focus the form.
            MiniOptionsForm.Focus()
        End If
    End Sub

    Private Sub MoveMiniForm(sender As Object, e As EventArgs)
        ' This keeps the mini-form "glued" below the main window.
        If MiniOptionsForm IsNot Nothing Then
            ' Make sure the form exists before trying to move it around.
            If Me.WindowState = FormWindowState.Normal Then
                MiniOptionsForm.Bounds = New Rectangle(Me.Left, Me.Bottom, MiniOptionsForm.Width, MiniOptionsForm.Height)
            ElseIf Me.WindowState = FormWindowState.Maximized Then
                ' We need to make sure the form stays on the screen.
                ' Subtracting the height of the linklabel from both the bottom of the window
                ' and the mini-form ensures that the linklabel should still be visible even when maximized.
                MiniOptionsForm.Bounds = New Rectangle(Me.Left, Me.Bottom - MiniOptionsForm.Height - LinkLabelMiniOptionsForm.Height, MiniOptionsForm.Width, MiniOptionsForm.Height)
            End If
        End If
    End Sub

    Private Sub ApplyChangesWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the mini-form.
        MiniApplyChangesOptionsForm.Close()
    End Sub

    Private Sub ResetStatusForSelectedPackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetStatusForSelectedPackageToolStripMenuItem.Click
        ' Reset status for the currently-selected package.
        If datagridviewAppsBeingInstalled.SelectedRows.Count = 1 Then
            datagridviewAppsBeingInstalled.SelectedRows.Item(0).Cells.Item(3).Value = "Ready"
            ' Reset the "Confirm changes" button.
            buttonConfirmChanges.Enabled = True
        End If
    End Sub

    Private Sub ResetStatusForAllPackagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetStatusForAllPackagesToolStripMenuItem.Click
        ' Reset status for all packages.
        If datagridviewAppsBeingInstalled.Rows.Count >= 1 Then
            ' Unset autosize.
            PackageAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            PackageCurrentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            ' Change the values in the Action column.
            For Each Row As DataGridViewRow In datagridviewAppsBeingInstalled.Rows
                ' See what the cell's contents is.
                If Not Row.Cells.Item(3).Value.ToString = "Ready" Then
                    Row.Cells.Item(3).Value = "Ready"
                End If
            Next
            ' Reset the column autosize.
            PackageAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            PackageCurrentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            ' Reset the "Confirm changes" button.
            buttonConfirmChanges.Enabled = True
        End If
    End Sub

    Private Sub SkipSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SkipSelectedToolStripMenuItem.Click
        ' Mark the currently-selected package to be skipped.
        If datagridviewAppsBeingInstalled.SelectedRows.Count = 1 Then
            datagridviewAppsBeingInstalled.SelectedRows.Item(0).Cells.Item(3).Value = "Skip"
        End If
    End Sub

    Private Sub datagridviewAppsBeingInstalled_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewAppsBeingInstalled.CellMouseDown
        ' Code based on this SO answer:
        ' https://stackoverflow.com/a/939275
        ' Also borrows from this answer:
        ' https://stackoverflow.com/a/173315
        ' Copied from the main window's code.

        If e.Button = MouseButtons.Right AndAlso e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Make sure no modifier keys like Control are held down.
            ' Also make sure what we're right-clicking isn't in the selected
            ' items collection of the datagridview.
            If ModifierKeys = Nothing AndAlso Not datagridviewAppsBeingInstalled.Item(e.ColumnIndex, e.RowIndex).Selected Then
                ' If it's not one of the selected items, select only whatever was right-clicked.
                datagridviewAppsBeingInstalled.CurrentCell = datagridviewAppsBeingInstalled(e.ColumnIndex, e.RowIndex)
            End If
        End If
    End Sub
End Class