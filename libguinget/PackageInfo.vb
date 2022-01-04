' libguinget - Package and package list tools for guinget
'              and other programs that want to use them.
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




Public Class PackageInfo

    ' This class contains info on the packages.
    Public Property Action As String
    Public Property Status As String
    Public Property PackageId As String
    Public Property PackageName As String
    Public Property InstalledVersion As String
    Public Property AvailableVersion As String
    Public Property Description As String
    Public Property ManifestPath As String
End Class