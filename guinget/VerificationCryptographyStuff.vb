' guinget - Unofficial GUI for Microsoft's Windows Package Manager (winget)
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



Imports System.Text

Public Class VerificationCryptographyStuff

    ' Using a simple MD5 hash for verifying that stuff is working.
    ' We don't need anything too complicated as it's a basic string
    ' that's not related to security.
    ' Based on this code:
    ' https://stackoverflow.com/a/40865372

    Friend Shared Function GetMd5(InputString As String) As String
        ' Define things.
        Dim md5ObjectProvider As New Security.Cryptography.MD5CryptoServiceProvider
        Dim BytesWeWantToHash() As Byte = Encoding.UTF8.GetBytes(InputString)

        ' Do the hashing.
        BytesWeWantToHash = md5ObjectProvider.ComputeHash(BytesWeWantToHash)

        ' Set up a stringbuilder.
        Dim ResultString As New StringBuilder

        ' Put bytes in the stringbuilder.
        For Each HashedByte As Byte In BytesWeWantToHash
            ' Append bytes.
            ' Not sure what the "x2" thing is.
            ResultString.Append(HashedByte.ToString("x2"))
        Next

        ' Return the new hash.
        Return ResultString.ToString
    End Function

    Friend Shared Function GetUnciphered(InputString As String) As String
        ' Simple function to manually un-cipher a string.
        ' Using a stringbuilder with code loosely based on
        ' this SO answer: https://stackoverflow.com/a/39289878
        Dim ReplacerStringBuilder As New Text.StringBuilder(InputString)

        ReplacerStringBuilder.Replace("e", "Y", 0, 1)

        ReplacerStringBuilder.Replace("e", "r", 5, 1)

        ReplacerStringBuilder.Replace("e", "d", 12, 1)

        ReplacerStringBuilder.Replace("e", ")", 15, 1)

        ReplacerStringBuilder.Replace("3", "o", 1, 1)

        ReplacerStringBuilder.Replace("3", "e", 6, 1)

        ReplacerStringBuilder.Replace("6", "u", 2, 1)

        ReplacerStringBuilder.Replace("b", ":", 14, 1)

        ReplacerStringBuilder.Replace("b", " ", 3, 1)

        ReplacerStringBuilder.Replace("8", "a", 4, 1)

        ReplacerStringBuilder.Replace("8", " ", 13, 1)

        ReplacerStringBuilder.Replace("f", " ", 7, 1)

        ReplacerStringBuilder.Replace("f", "i", 11, 1)


        Return ReplacerStringBuilder.ToString
    End Function

End Class
