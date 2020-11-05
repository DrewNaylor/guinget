﻿' libguinget - Package and package list tools for guinget
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



Public Class ConfigTools
    ' Stuff that doesn't fit into package/package list stuff or sources-related stuff,
    ' but does fit into config-related stuff.
    ' Probably should move the winget source update thing to a source-related class.

    Public Shared Sub RunWingetSettings()
        ' Run winget settings.
        Using proc As New Process

            proc.StartInfo.FileName = "cmd"
            ' Probably don't need to keep CMD open for this.
            proc.StartInfo.Arguments = "/c winget settings"
            proc.Start()
        End Using
    End Sub

End Class