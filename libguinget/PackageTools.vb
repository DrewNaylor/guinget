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



Public Class PackageTools

    ' Get package details from winget.
    Public Shared Function GetPkgDetails(PackageId As String)

        ' Based on the code in this video:
        ' https://www.youtube.com/watch?v=APyteDZMpYw
        Dim proc As Process
        Dim procinfo As ProcessStartInfo

        procinfo = New ProcessStartInfo("winget", "show -e " & PackageId)

        With procinfo
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .CreateNoWindow = True
        End With

        proc = New Process With {.StartInfo = procinfo, .EnableRaisingEvents = True}
        'AddHandler proc.ErrorDataReceived, AddressOf Async_Data_Received
        'AddHandler proc.OutputDataReceived, AddressOf Async_Data_Received

        proc.Start()
        'proc.BeginOutputReadLine()
        'proc.BeginErrorReadLine()

        ' Stream reader output code based on this SO answer:
        ' https://stackoverflow.com/a/8811377
        Dim procOutput As String
        Using outputStreamReader As IO.StreamReader = proc.StandardOutput
            procOutput = outputStreamReader.ReadToEnd
        End Using

        Return procOutput
    End Function


End Class
