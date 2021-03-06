﻿' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows. Not associated with either
'           Microsoft or the Synaptic project. 
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




Public Class AboutWindow

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Put text in the About textbox.
        textboxAbout.Text = "guinget" & vbCrLf &
                        "Version " & My.Application.Info.Version.ToString & " Beta" & vbCrLf &
                        My.Application.Info.Copyright & vbCrLf &
                        vbCrLf &
                        "Unofficial GUI for Microsoft's Windows Package Manager (winget)." & vbCrLf &
                        "Kinda like Synaptic, but for Windows. Not associated with either" & vbCrLf &
                        "Microsoft or the Synaptic project. Microsoft does not endorse guinget." & vbCrLf &
                        "winget is Copyright (c) Microsoft Corporation. All rights reserved." & vbCrLf &
                        vbCrLf &
                        "You can get the source code for guinget from" & vbCrLf &
                        "https://github.com/DrewNaylor/guinget" & vbCrLf &
                        vbCrLf &
                        "libguinget is used for things like loading the package list and uses the Apache License 2.0." & vbCrLf &
                        "libguinget Copyright (C) 2020-2021 Drew Naylor." & vbCrLf &
                        vbCrLf &
                        "libscrollswitchtabs is part of the drews-libs project and is used for switching tab control tabs using the mouse scroll wheel, just like in many Linux applications." & vbCrLf &
                        "libscrollswitchtabs uses the Apace License 2.0 and you can get its source code here:" & vbCrLf &
                        "https://github.com/DrewNaylor/drews-libs" & vbCrLf &
                        "libscrollswitchtabs Copyright (C) 2020 Drew Naylor." & vbCrLf &
                        vbCrLf &
                        "Microsoft.Data.Sqlite is used for loading the package list from an SQLite database and uses the Apache License 2.0. " &
                        "NuGet page for Microsoft.Data.Sqlite:" & vbCrLf &
                        "https://www.nuget.org/packages/Microsoft.Data.Sqlite/" & vbCrLf &
                        "Microsoft.Data.Sqlite Copyright (C) Microsoft Corporation. All rights reserved." & vbCrLf &
                        vbCrLf &
                        "YamlDotNet is used to read manifests, which you can get the source code for here:" & vbCrLf &
                        "https://github.com/aaubry/YamlDotNet" & vbCrLf &
                        "YamlDotNet falls under the MIT license, which you can read a copy of below the Apache License summary." & vbCrLf &
                        "YamlDotNet Copyright (c) 2008, 2009, 2010, 2011, 2012, 2013, 2014 Antoine Aubry and contributors" & vbCrLf &
                        vbCrLf &
                        My.Resources.AboutSeparator & vbCrLf &
                        vbCrLf &
                        "Apache License 2.0 summary as it applies to guinget, libguinget, libscrollswitchtabs, and Microsoft.Data.Sqlite:" & vbCrLf &
                        "Licensed under the Apache License, Version 2.0 (the ""License"");" & vbCrLf &
"you may not use this file except in compliance with the License." & vbCrLf &
"You may obtain a copy of the License at" & vbCrLf &
vbCrLf &
"   http://www.apache.org/licenses/LICENSE-2.0" & vbCrLf &
vbCrLf &
"Unless required by applicable law or agreed to in writing, software" & vbCrLf &
"distributed under the License is distributed on an ""AS IS"" BASIS," & vbCrLf &
"WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied." & vbCrLf &
"See the License for the specific language governing permissions and" & vbCrLf &
"limitations under the License." & vbCrLf &
vbCrLf &
My.Resources.AboutSeparator & vbCrLf &
vbCrLf &
"MIT license as it applies to YamlDotNet:" & vbCrLf &
"Copyright (c) 2008, 2009, 2010, 2011, 2012, 2013, 2014 Antoine Aubry and contributors" & vbCrLf &
vbCrLf &
"Permission is hereby granted, free of charge, to any person obtaining a copy of" & vbCrLf &
"this software and associated documentation files (the ""Software""), to deal in" & vbCrLf &
"the Software without restriction, including without limitation the rights to" & vbCrLf &
"use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies" & vbCrLf &
"of the Software, and to permit persons to whom the Software is furnished to do" & vbCrLf &
"so, subject to the following conditions:" & vbCrLf &
vbCrLf &
"The above copyright notice and this permission notice shall be included in all" & vbCrLf &
"copies or substantial portions of the Software." & vbCrLf &
vbCrLf &
"THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR" & vbCrLf &
"IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY," & vbCrLf &
"FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE" & vbCrLf &
"AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER" & vbCrLf &
"LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM," & vbCrLf &
"OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE" & vbCrLf &
"SOFTWARE."
    End Sub

    Private Sub labelShowHiddenControls_Click(sender As Object, e As EventArgs) Handles labelShowHiddenControls.Click
        ' Show unfinished controls.
        aaformMainWindow.UnfinishedControlsVisible(True)
    End Sub
End Class
