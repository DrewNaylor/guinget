' libguinget - Package tools for guinget and other programs that
'  want to use them.
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



Imports System.Threading

Public Class PackageTools

    ' Get package details from winget.
    Public Shared Async Function GetPkgDetailsAsync(PackageId As String) As Task(Of String)

        ' Async stuff based on this code:
        ' https://docs.microsoft.com/en-us/archive/blogs/lucian/how-to-await-a-command-line-process-and-capture-its-output

        ' Stream reader output code based on this SO answer:
        ' https://stackoverflow.com/a/8811377
        Dim procOutput As String = Await GetPkgInfoAsync(PackageId)


        Return procOutput
    End Function

    Shared Async Function GetPkgInfoAsync(PackageId As String, Optional RequestedInfo As String = "Everything", Optional cancel As CancellationToken = Nothing) As Task(Of String)

        ' Based partially on the code in this video:
        ' https://www.youtube.com/watch?v=APyteDZMpYw
        Using proc As New Process
            proc.StartInfo.FileName = "winget"

            Dim procinfo As ProcessStartInfo

            ' If we want to get everything, do so.
            If RequestedInfo = "Everything" Then
                procinfo = New ProcessStartInfo("winget", "show -e " & PackageId)
            Else
                ' Otherwise, just get the stuff if we want everything.
                procinfo = New ProcessStartInfo("winget", "show -e " & PackageId)
            End If

            ' Setup procinfo properties.
            With procinfo
                .UseShellExecute = False
                .RedirectStandardError = True
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
                .CreateNoWindow = True
            End With

            If Not proc.Start Then Throw New InvalidOperationException("winget is not installed or could not be started.")

            Using cancelRegister = cancel.Register(Sub() proc.Kill())

                Dim wingetOutput = proc.StandardOutput.ReadToEndAsync
                Dim wingetError = proc.StandardError.ReadToEndAsync

                Await Task.WhenAll(wingetOutput, wingetError)

                proc.StandardOutput.Close()
                proc.StandardError.Close()

                Await Task.Run(AddressOf proc.WaitForExit)

                Dim standardOut = Await wingetOutput
                Dim standardErr = Await wingetError

                If cancel.IsCancellationRequested = True Then
                    Throw New OperationCanceledException(standardErr)
                ElseIf String.IsNullOrEmpty(standardOut) = True Then
                    Throw New Exception(standardErr)
                Else
                    Return standardOut
                End If

            End Using
        End Using
    End Function


End Class
