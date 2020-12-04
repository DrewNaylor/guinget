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

    Public Shared Sub ListInstalled()
        ' Lists installed packages if the feature is available.
        WingetStarter("list")
    End Sub

    Private Shared Sub WingetStarter(Command As String, Optional RunAsAdmin As Boolean = False, Optional ShowWindow As Boolean = True)
        ' To reduce code duplication, simple winget commands
        ' are passed into here.
        Using proc As New Process

            proc.StartInfo.FileName = "cmd"
            ' Determine if CMD should stay open.
            Dim Args As String = String.Empty
            If ShowWindow = True Then
                Args = "winget "
            Else
                Args = "winget "
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
                Dim OutputWindow As New LotsOfCommandOutputForm
                ' Update winget in the console then switch the tab when
                ' ready to display the list.
                OutputWindow.TabControl1.SelectTab(1)
                OutputWindow.Show()
                Dim ConEmuStarter As New ConEmu.WinForms.ConEmuStartInfo
                ConEmuStarter.ConEmuExecutablePath = "C:\Users\Drew\Documents\0GitHub\guinget\packages\ConEmu.Core.20.11.24\Tools\ConEmu\ConEmu.exe"
                ConEmuStarter.ConsoleProcessCommandLine = "{cmd} " & proc.StartInfo.Arguments
                ConEmuStarter.WhenConsoleProcessExits = ConEmu.WinForms.WhenConsoleProcessExits.KeepConsoleEmulator
                OutputWindow.ConEmuControl1.Start(ConEmuStarter)
            Catch ex As System.ComponentModel.Win32Exception
            End Try
        End Using

    End Sub

End Class
