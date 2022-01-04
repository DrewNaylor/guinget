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




Public Class PackageObject

    ' This class contains info on the packages.
    Public Property PackageId As String
    Public Property PackageName As String
    Public Property PackageDescription As String
    Public Property PackageStatus As String

    Public Property PackageInstalledVersion As String
    Public Property PackageAvailableVersion As String

    Public Property PackageManifestPath As String
    Public Property PackageAction As String

    ' Required due to "Your custom class must be public and support a default (parameterless) public constructor."
    ' https://docs.microsoft.com/en-us/dotnet/desktop/wpf/advanced/xaml-and-custom-classes-for-wpf?view=netframeworkdesktop-4.8
    Public Sub New()

    End Sub

    Public Sub New(packageId As String,
                   packageName As String,
                   packageDescription As String,
                   packageStatus As String,
                   packageInstalledVersion As String,
                   packageAvailableVersion As String,
                   packageManifestPath As String)

        ' Set the properties to be the parameters.
        Me.PackageId = packageId
        Me.PackageName = packageName
        Me.PackageDescription = packageDescription
        Me.PackageStatus = packageStatus
        Me.PackageInstalledVersion = packageInstalledVersion
        Me.PackageAvailableVersion = packageAvailableVersion
        Me.PackageManifestPath = packageManifestPath
        ' Set the PackageAction property to the default of "Do nothing".
        Me.PackageAction = "Do nothing"

    End Sub
End Class