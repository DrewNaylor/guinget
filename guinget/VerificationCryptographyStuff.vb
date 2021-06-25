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
        InputString = InputString.Remove(InputString.IndexOf("e"), 0).Insert(InputString.IndexOf("e"), "Y")
        InputString = InputString.Remove(InputString.IndexOf("e"), 1).Insert(InputString.IndexOf("e"), "r")
        InputString = InputString.Remove(InputString.IndexOf("e"), 2).Insert(InputString.IndexOf("e"), "d")
        InputString = InputString.Remove(InputString.IndexOf("e"), 3).Insert(InputString.IndexOf("e"), ")")
        InputString = InputString.Remove(InputString.IndexOf("3"), 0).Insert(InputString.IndexOf("3"), "o")
        InputString = InputString.Remove(InputString.IndexOf("3"), 1).Insert(InputString.IndexOf("3"), "e")
        InputString = InputString.Remove(InputString.IndexOf("6"), 0).Insert(InputString.IndexOf("6"), "u")

        Return InputString.ToString
    End Function

End Class
