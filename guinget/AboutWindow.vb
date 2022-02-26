' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
'           Kinda like Synaptic, but for Windows. Not associated with either
'           Microsoft or the Synaptic project. 
' Copyright (C) 2020-2022 Drew Naylor
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
                        "libguinget Copyright (C) 2020-2022 Drew Naylor." & vbCrLf &
                        vbCrLf &
                        "libscrollswitchtabs is part of the drews-libs project and is used for switching tab control tabs using the mouse scroll wheel, just like in many Linux applications." & vbCrLf &
                        "libscrollswitchtabs uses the Apace License 2.0 and you can get its source code here:" & vbCrLf &
                        "https://github.com/DrewNaylor/drews-libs" & vbCrLf &
                        "libscrollswitchtabs Copyright (C) 2020 Drew Naylor." & vbCrLf &
                        vbCrLf &
                        "Microsoft.Data.Sqlite is used for loading the package list from an SQLite database and uses the MIT License. " & vbCrLf &
                        "NuGet page for Microsoft.Data.Sqlite:" & vbCrLf &
                        "https://www.nuget.org/packages/Microsoft.Data.Sqlite/" & vbCrLf &
                        "Microsoft.Data.Sqlite Copyright (c) .NET Foundation and Contributors. All rights reserved." & vbCrLf &
                        vbCrLf &
                        "System.Numerics.Vectors, System.Buffers, and System.Memory are all under the MIT License." & vbCrLf &
                        "NuGet for Buffers: https://www.nuget.org/packages/System.Buffers/" & vbCrLf &
                        "NuGet for Numerics.Vectors: https://www.nuget.org/packages/System.Numerics.Vectors/" & vbCrLf &
                        "NuGet for Memory: https://www.nuget.org/packages/System.Memory" & vbCrLf &
                        "These are Copyright (c) .NET Foundation and Contributors. All rights reserved." & vbCrLf &
                        "See the license below." & vbCrLf &
                        vbCrLf &
                        "System.Runtime.CompilerServices.Unsafe is a dependency of Microsoft.Data.Sqlite and is under the MIT License." & vbCrLf &
                        "NuGet page for System.Runtime.CompilerServices.Unsafe:" & vbCrLf &
                        "https://www.nuget.org/packages/System.Runtime.CompilerServices.Unsafe" & vbCrLf &
                        vbCrLf &
                        My.Resources.MicrosoftDataSqliteDependencies.Replace(vbLf, vbCrLf) & vbCrLf & vbCrLf &
                        "YamlDotNet is used to read manifests, which you can get the source code for here:" & vbCrLf &
                        "https://github.com/aaubry/YamlDotNet" & vbCrLf &
                        "YamlDotNet falls under the MIT license, which you can read a copy of below the Apache License summary." & vbCrLf &
                        "YamlDotNet Copyright (c) 2008, 2009, 2010, 2011, 2012, 2013, 2014 Antoine Aubry and contributors" & vbCrLf &
                        vbCrLf &
                        My.Resources.AboutSeparator & vbCrLf &
                        vbCrLf &
                        "Apache License 2.0 summary as it applies to guinget, libguinget, libscrollswitchtabs, and SQLitePCLRaw (though more detail for the last one is in its own section):" & vbCrLf &
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
"MIT License as it applies to YamlDotNet:" & vbCrLf &
My.Resources.LicenseForYamlDotNet.Replace(vbLf, vbCrLf) & vbCrLf &
vbCrLf &
My.Resources.AboutSeparator & vbCrLf &
vbCrLf &
"MIT License as it applies to Microsoft.Data.Sqlite and System.Runtime.CompilerServices.Unsafe:" & vbCrLf &
My.Resources.LicenseForMicrosoftDataSqlite.Replace(vbLf, vbCrLf) & vbCrLf &
vbCrLf &
My.Resources.AboutSeparator & vbCrLf &
vbCrLf &
"MIT License as it applies to System.Numerics.Vectors, System.Buffers, and System.Memory:" & vbCrLf &
My.Resources.LicenseForNumericsBuffersAndMemory.Replace(vbLf, vbCrLf) & vbCrLf &
vbCrLf &
My.Resources.AboutSeparator & vbCrLf &
vbCrLf &
"Licenses and copyright notices for SQLitePCLRaw:" & vbCrLf &
My.Resources.SQLitePCLRawLicenses.Replace(vbLf, vbCrLf)
    End Sub

    Private Sub labelShowHiddenControls_Click(sender As Object, e As EventArgs) Handles labelShowHiddenControls.Click
        ' Show unfinished controls.
        aaformMainWindow.UnfinishedControlsVisible(True)
    End Sub
End Class
