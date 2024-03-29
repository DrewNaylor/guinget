﻿' libguinget - Package and package list tools for guinget
'              and other programs that want to use them.
' Copyright (C) 2020-2023 Drew Naylor
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



Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports YamlDotNet.RepresentationModel

Public Class PackageTools

#Region "Variables that act as settings."
    ' Specifying version numbers.
    Public Shared SpecifyVersionOnInstall As Boolean = True
    Public Shared SpecifyVersionOnUpgrade As Boolean = False
    Public Shared SpecifyVersionOnUninstall As Boolean = False
#End Region

#Region "Process package with winget."
    Public Shared Sub SinglePackageProcessor(Action As String, PackageId As String, PackageVersion As String, Optional Interactive As Boolean = False,
                                 Optional ElevateWinget As Boolean = False, Optional DefaultSourceName As String = "winget")

        ' Define variables for storing the winget process. We'll run CMD
        ' so that we can keep it open with /k.

        ' This sub used to be the single-package installation sub, but
        ' it's been changed to allow uninstallation with a different
        ' value for "Action".
        ' Combining these two will make things like always installing
        ' or uninstalling the latest version easier.
        ' Uninstalling may in fact default to uninstalling the latest version.

        Using proc As New Process

            proc.StartInfo.FileName = "cmd"

            ' Define interactive flag.
            Dim InteractiveFlag As String = String.Empty
            If Interactive = True Then
                InteractiveFlag = " -i"
            End If

            ' Determine whether winget should be elevated.
            If ElevateWinget = True Then
                proc.StartInfo.Verb = "runas"
            End If

            ' See if the versions should be used.
            ' Store the current version as a variable that can be updated.
            Dim Version As String = String.Empty
            If Action = "install" AndAlso SpecifyVersionOnInstall = True Then
                Version = " -v " & PackageVersion
            ElseIf Action = "upgrade" AndAlso SpecifyVersionOnUpgrade = True Then
                Version = " -v " & PackageVersion
            ElseIf Action = "uninstall" AndAlso SpecifyVersionOnUninstall = True Then
                Version = " -v " & PackageVersion
            End If

            ' Define CMD args.
            proc.StartInfo.Arguments = "/k winget " & Action & " --id " & PackageId & Version & InteractiveFlag & " -e -s " & DefaultSourceName

            ' Start installing. Catch the exception in case the user cancels the UAC dialog.
            Try
                proc.Start()
            Catch ex As System.ComponentModel.Win32Exception
            End Try

        End Using

    End Sub

    Public Shared Sub BulkPackageProcessor(Actions As List(Of String), PackageIDs As List(Of String), PackageVersions As List(Of String), Optional Interactive As Boolean = False,
                                     Optional ElevateWinget As Boolean = False, Optional DefaultSourceName As String = "winget")
        ' Define process variables to store winget's stuff.
        ' CMD will be kept open with /k.

        Using proc As New Process

            proc.StartInfo.FileName = "cmd"

            ' Define interactive flag.
            Dim InteractiveFlag As String = String.Empty
            If Interactive = True Then
                InteractiveFlag = " -i"
            End If

            ' Determine whether winget should be elevated.
            If ElevateWinget = True Then
                proc.StartInfo.Verb = "runas"
            End If

            ' Define CMD args by going through the list of packages.
            ' Be sure to only add && if there are packages left to add.
            Dim BulkInstallCommandList As String = String.Empty
            For i As Integer = 0 To PackageIDs.Count - 1

                ' See if the versions should be used.
                ' Store the current version as a variable that can be updated.
                Dim Version As String = String.Empty
                If Actions(i) = "install" AndAlso SpecifyVersionOnInstall = True Then
                    Version = " -v " & PackageVersions(i)
                ElseIf Actions(i) = "upgrade" AndAlso SpecifyVersionOnUpgrade = True Then
                    Version = " -v " & PackageVersions(i)
                ElseIf Actions(i) = "uninstall" AndAlso SpecifyVersionOnUninstall = True Then
                    Version = " -v " & PackageVersions(i)
                End If

                ' Begin adding packages to the list.
                BulkInstallCommandList = BulkInstallCommandList & "winget " & Actions(i) & " --id " & PackageIDs(i) & Version & InteractiveFlag & " -e -s " & DefaultSourceName
                ' Now see if we should add " && ".
                If i < PackageIDs.Count - 1 Then
                    BulkInstallCommandList = BulkInstallCommandList & " && "
                End If
            Next

            ' Define args for running winget and CMD.
            proc.StartInfo.Arguments = "/k " & BulkInstallCommandList

            ' Start processing. Catch the exception in case the user cancels the UAC dialog.
            Try
                proc.Start()
            Catch ex As System.ComponentModel.Win32Exception
            End Try
        End Using
    End Sub
#End Region

#Region "Show package in winget"
    Public Shared Sub ShowPkgInWinget(PackageID As String, PackageVersion As String, Optional DefaultSourceName As String = "winget")
        ' This'll open a CMD window and display the package info in winget.
        Using proc As New Process
            proc.StartInfo.FileName = "cmd"
            proc.StartInfo.Arguments = "/k winget show --id " & PackageID & " -v " & PackageVersion & " -e -s " & DefaultSourceName
            proc.Start()
        End Using
    End Sub
#End Region

#Region "Get default locale file for multi-file manifest."
    Public Shared Async Function GetMultiFileManifestPieceFilePath(ManifestPath As String, ManifestType As String) As Task(Of String)
        ' Define piece file path string and remove
        ' file extension from the original path.
        Dim PieceFilePath = ManifestPath.Remove(ManifestPath.Length - 5)

        ' Check if we want the installer or default locale file.
        If ManifestType = "defaultLocale" Then

            ' Add default locale stuff and re-add file extension.
            PieceFilePath = PieceFilePath & ".locale." &
            Await GetPackageInfoFromYamlAsync(ManifestPath, "DefaultLocale") &
            ".yaml"

        ElseIf ManifestType = "installer" Then

            ' Add "installer" to the file path and re-add file extension.
            PieceFilePath = PieceFilePath & ".installer.yaml"

        End If

        ' Check to make sure the manifest file path we created exists.
        If IO.File.Exists(PieceFilePath) Then
            ' Now we're done and can return the path.
            Return PieceFilePath
        Else
            ' Otherwise, if it doesn't exist, return Nothing.
            Return Nothing
        End If


    End Function
#End Region

#Region "Get package details from YAML"
    Public Shared Async Function GetPackageInfoFromYamlAsync(ManifestPath As String, RequestedKey As String) As Task(Of String)

        ' Load in the file and get whatever was requested of it.

        ' Set up the document input.
        ' We had to use a StreamReader instead of a StringReader
        ' that the LoadingAYamlStream sample used since we want
        ' to read a file, not a filename.
        ' If we used a StringReader, we'd end up with an Invalid
        ' Cast Exception with the following details:
        '    Unhandled Exception: System.InvalidCastException: Unable
        '    to cast object of type 'YamlDotNet.RepresentationModel.YamlScalarNode'
        '    to type 'YamlDotNet.RepresentationModel.YamlMappingNode'.`
        ' This working example is described in the following
        ' StackOverflow answer:
        ' https://stackoverflow.com/a/46897520

        Dim PackageInfo As String = String.Empty
        Using Input As StreamReader = File.OpenText(ManifestPath)

            ' Getting package info using async.
            PackageInfo = Await GetYamlKeyValueAsync(Input, RequestedKey)
        End Using

        Return PackageInfo

    End Function

    Friend Shared Async Function GetYamlKeyValueAsync(YamlInput As StreamReader, RequestedKey As String) As Task(Of String)

        ' Load the stream in.
        Dim YamlStream As New YamlStream
        YamlStream.Load(YamlInput)

        ' Create variable for root node.
        Dim YamlRoot = CType(YamlStream.Documents(0).RootNode, YamlMappingNode)

        Dim EntryValue As String = String.Empty

        For Each Entry In YamlRoot.Children

            ' If the requested key exists, then return it.
            ' This check doesn't work; maybe something
            ' like an ordered list would be better:
            ' https://stackoverflow.com/a/30097560
            ' Check each entry in the YAML root node

            ' Using Await Task.Run(Sub() here allows the main window
            ' to be moved around while the package list is being
            ' updated with details, but it's really slow.
            ' There needs to be a way to move the window around
            ' and have the updating be fast.
            'Await Task.Run(Sub()
            If CType(Entry.Key, YamlScalarNode).Value = RequestedKey Then
                ' If we're looking at what's requested, return it.
                EntryValue = Entry.Value.ToString
            End If
            'End Sub)
        Next

        Return EntryValue
    End Function
#End Region

#Region "Get package details from winget."
    '' Get package details from winget.
    '' These functions are deprecated and are mainly
    '' meant to be examples for a way to get info from
    '' winget.
    'Public Shared Async Function GetPkgDetailsFromWingetAsync(PackageId As String) As Task(Of String)

    '    ' Async stuff based on this code:
    '    ' https://docs.microsoft.com/en-us/archive/blogs/lucian/how-to-await-a-command-line-process-and-capture-its-output

    '    ' Stream reader output code based on this SO answer:
    '    ' https://stackoverflow.com/a/8811377
    '    Dim procOutput As String = Await GetPkgInfoFromWingetAsync(PackageId)


    '    Return procOutput
    'End Function

    'Shared Async Function GetPkgInfoFromWingetAsync(PackageId As String, Optional RequestedInfo As String = "Everything", Optional cancel As CancellationToken = Nothing) As Task(Of String)

    '    ' Based partially on the code in this video:
    '    ' https://www.youtube.com/watch?v=APyteDZMpYw
    '    Using proc As New Process
    '        proc.StartInfo.FileName = "winget"

    '        ' If we want to get everything, do so.
    '        If RequestedInfo = "Everything" Then
    '            proc.StartInfo.Arguments = "show -e " & """" & PackageId & """"
    '        Else
    '            ' Otherwise, just get the stuff if we want everything.
    '            proc.StartInfo.Arguments = "show -e " & """" & PackageId & """"
    '        End If

    '        ' Setup procinfo properties.
    '        proc.StartInfo.UseShellExecute = False
    '        proc.StartInfo.RedirectStandardError = True
    '        proc.StartInfo.RedirectStandardInput = True
    '        proc.StartInfo.RedirectStandardOutput = True
    '        proc.StartInfo.CreateNoWindow = True

    '        'If Not proc.Start Then Throw New InvalidOperationException("winget is not installed or could not be started.")

    '        Using cancelRegister = cancel.Register(Sub() proc.Kill())

    '            ' Start winget so we can get output from it.
    '            proc.Start()

    '            ' Assign and create variables to store its output.
    '            Dim wingetOutput = proc.StandardOutput.ReadToEndAsync
    '            Dim wingetError = proc.StandardError.ReadToEndAsync

    '            ' Wait for the output and error tasks to complete.
    '            Await Task.WhenAll(wingetOutput, wingetError)

    '            ' Close winget's standard output and standard error.
    '            proc.StandardOutput.Close()
    '            proc.StandardError.Close()

    '            ' Run the process and wait for exit (why didn't this work before? I have no idea.)
    '            Await Task.Run(AddressOf proc.WaitForExit)

    '            ' Assign variables for standard output and error to winget's output stuff.
    '            Dim standardOut = Await wingetOutput
    '            Dim standardErr = Await wingetError

    '            ' If canceling is requested, then throw an operation canceled exception.
    '            If cancel.IsCancellationRequested = True Then
    '                Throw New OperationCanceledException(standardErr)
    '            ElseIf String.IsNullOrEmpty(standardOut) = True Then
    '                ' If the output is null or empty, throw an exception.
    '                Throw New Exception(standardErr)
    '            Else
    '                ' Otherwise, if it's all good, return the output.
    '                Return standardOut
    '            End If

    '        End Using
    '    End Using
    'End Function
#End Region

End Class
