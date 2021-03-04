' libguinget - Package and package list tools for guinget
'              and other programs that want to use them.
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



Public Class CommandTools
    ' Stuff that doesn't fit into package/package list stuff or sources-related stuff,
    ' but does fit into command-related stuff.
    ' Probably should move the winget source update thing to a source-related class.

    Public Shared Sub RunWingetSettings(Optional RunAsAdmin As Boolean = False)
        ' Run winget settings.
        WingetStarter("settings", RunAsAdmin, False)
    End Sub

    Public Shared Sub UpdateWingetSources()
        ' Update winget sources. This helps in case the user wants to run winget
        ' elevated but winget doesn't update properly when it's elevated.
        ' In that situation, it's expected to run guinget non-elevated,
        ' then run winget elevated in the Apply Changes window.
        WingetStarter("source update")
    End Sub

    Public Shared Sub ListUpgrades()
        ' Lists available upgrades if the feature is available.
        WingetStarter("upgrade")
    End Sub

    Public Shared Sub ListInstalled(AppsListUI As String)
        ' Lists installed packages if the feature is available.
        If AppsListUI = "appsfeatures" Then
            ' If the calling app wants to open apps and features, do so.
            Try
                Process.Start("ms-settings:appsfeatures")
            Catch ex As System.ComponentModel.Win32Exception
                ' Make sure it doesn't crash on a version of Windows that's not Windows 10.
                RunControlPanelAppsFeatures()
            End Try
        ElseIf AppsListUI = "wingetlist" Then
            ' If the calling app is requesting "winget list" use that.
            WingetStarter("list")
        ElseIf AppsListUI = "appwizdotcpl" Then
            ' If the calling app wants the Control Panel Add and Remove Programs, use that instead.
            RunControlPanelAppsFeatures()
        End If
    End Sub

    Private Shared Sub RunControlPanelAppsFeatures()
        ' Run the control panel's apps and features thing.
        Using proc As New Process
            proc.StartInfo.FileName = "control"
            proc.StartInfo.Arguments = "appwiz.cpl"
            ' Make sure it's successful, in case we can't find the control panel anymore.
            Try
                proc.Start()
            Catch ex As Exception
                Windows.Forms.MessageBox.Show("Unfortunately, it appears that the Control Panel is unavailable. " &
                                                     "Please use one of the other choices for ""Installed packages"" " &
                                                     "in the Options window under ""Tools>Options...>Apps and UIs""." & vbCrLf &
                                                     vbCrLf &
                                                     "Exception message: " & ex.Message & vbCrLf &
                                                     "Full exception: " & ex.ToString, "Installed Packages", Windows.Forms.MessageBoxButtons.OK,
                                                                                       Windows.Forms.MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Shared Sub WingetStarter(Command As String, Optional RunAsAdmin As Boolean = False, Optional ShowWindow As Boolean = True)
        ' To reduce code duplication, simple winget commands
        ' are passed into here.
        Using proc As New Process

            proc.StartInfo.FileName = "cmd"
            ' Determine if CMD should stay open.
            Dim Args As String = String.Empty
            If ShowWindow = True Then
                Args = "/k winget "
            Else
                Args = "/c winget "
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            End If
            ' Now pass the args into the startinfo.
            proc.StartInfo.Arguments = Args & Command
            ' Specify whether this should be run as admin or not.
            If RunAsAdmin = True Then
                proc.StartInfo.Verb = "runas"
            End If
            ' Make sure if the user cancels that it
            ' doesn't crash.
            Try
                proc.Start()
            Catch ex As System.ComponentModel.Win32Exception
            End Try

            'proc.WaitForExit()

            'If proc.ExitCode.ToString = "-2147012889" Then
            '    Windows.Forms.MessageBox.Show("We couldn't connect to the sources to check for updates. Please try again.")
            'End If

        End Using
    End Sub

    Friend Shared Sub ImportExport(Task As String, FileName As String)
        ' Run winget and import or export the packages.
        WingetStarter(Task.ToLowerInvariant & " " & FileName)
    End Sub
End Class
