' libguinget - Package and package list tools for guinget
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



Imports System.Windows.Forms
Imports System.IO.Compression
Imports Microsoft.Data.Sqlite
Imports System.IO

Public Class PackageListTools

    ' Define an http client we'll use.
    Shared ReadOnly PkgClient As Net.Http.HttpClient = New Net.Http.HttpClient()

    ' Define a flag we'll use to see if updating should be canceled.
    ' Updating can't be stopped once the package list is extracted.
    ' As of right now, the current task has to complete before it
    ' updating is stopped.
    Public Shared CancelUpdateFlag As Boolean = False

    ' Add a variable to store the root form so the progress dialog
    ' doesn't stay on top of everything.
    ' If the form isn't specified, it'll just fall back to being
    ' on top of everything.
    Public Shared RootForm As Form = Nothing

    ' Specify whether temp files should be deleted after an update.
    Public Shared DeleteTempDirsAfterCacheUpdate As Boolean = True

#Region "Delete cache in Roaming"
    Public Shared Sub DeleteCacheFilesInRoaming(CallingForm As Form, CacheRootDir As String, TitleText As String)
        ' Ask the user if they're sure they want to delete the folder.
        Dim path As String = CacheRootDir & "\winget-frontends\"
        Dim response As DialogResult = MessageBox.Show(CallingForm, "Are you sure you want to delete the files and folders located in " &
                                                  """" & path & """? This cannot be undone.",
                                                  TitleText, MessageBoxButtons.YesNo)
        ' If the user clicks Yes, delete the folder then let them know if it was successful.
        ' Make sure it's not in use at the moment.
        If response = DialogResult.Yes AndAlso IO.Directory.Exists(path) Then
            Try
                System.IO.Directory.Delete(path, True)
            Catch ex As System.IO.IOException
                MessageBox.Show(CallingForm, "A file in the requested directory """ & path & """ is in use by another process. Please close it and try again. It may also be possible that the directory " &
                                "was deleted between when its existence was checked and when we tried to delete it.", TitleText)
                ' Don't keep going as there's an issue.
                Exit Sub
            End Try

            ' Check if the folder exists now for a feedback message.
            If Not IO.Directory.Exists(path) Then
                ' Let the user know it was deleted.
                MessageBox.Show(CallingForm, "Cache files deleted successfully.", TitleText)
            Else
                ' Tell the user it seems to exist, but might have been deleted.
                MessageBox.Show(CallingForm, "It seems like the folder still exists, but the cache files should be deleted." &
                                " This can happen if the folder is open in a program like Explorer.", TitleText)

            End If

        ElseIf response = DialogResult.Yes AndAlso Not IO.Directory.Exists(path) Then
            ' Let the user know if the folder doesn't exist.
            MessageBox.Show(CallingForm, "The requested directory """ & path & """ does not exist; there's nothing to delete.", TitleText)
        End If
    End Sub

    Public Shared Function DoesPathExist(CacheRootDir As String) As Boolean
        ' We can use this to determine if the cache paths exist
        ' so the Options window buttons can be blocked.
        If Not IO.Directory.Exists(CacheRootDir & "\winget-frontends\") Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region

#Region "Download package list with progress async"
    Private Shared Async Function DownloadPkgListWithProgressAsync(ByVal SourceUrl As String, ByVal SourceName As String) As Task

        ' Download a file with HttpClient:
        ' https://stackoverflow.com/a/54475013

        ' Show a progress form that says what's being done.
        Using progressform As New DownloadProgressForm
            ' Set progress form properties.
            progressform.PackageListUrl = SourceUrl
            progressform.PackageListSourceName = SourceName

            ' Specify whether or not the form should stay on top
            ' of everything.
            RootFormTools.ProgressFormShow(RootForm, progressform)

            ' Define uri with source url.
            Dim PkgUri As Uri = New Uri(SourceUrl)

            ' Have progress bar be an indeterminate one for now.
            ' If the server sends a content length header, we
            ' can change the max to that instead.
            ' Not really sure how to get the length before we
            ' get a client response, so I might not do this for
            ' now.
            ' Code that might work in the future:
            ' https://stackoverflow.com/a/24350338
            progressform.progressbarDownloadProgress.Style = ProgressBarStyle.Marquee
            progressform.Update()

            ' Define HTTP response message.
            Try
                Dim ClientResponse = Await PkgClient.GetAsync(PkgUri)

                ' Set up the filestream we'll write to.
                ' We need to check if the path ends with .zip or .msix.
                If SourceUrl.EndsWith(".zip") Then
                    Using OutputStream As IO.FileStream = New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) &
                                           "\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master.zip", IO.FileMode.CreateNew)
                        'MessageBox.Show(OutputStream.ToString)

                        ' Copy out the stream.
                        Await ClientResponse.Content.CopyToAsync(OutputStream)
                    End Using

                ElseIf SourceUrl.EndsWith(".msix") Then
                    ' If the source url ends with .msix, then it's
                    ' probably the database.
                    Using OutputStream As IO.FileStream = New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) &
                                           "\winget-frontends\source\winget-db\temp\source.msix", IO.FileMode.CreateNew)
                        'MessageBox.Show(OutputStream.ToString)

                        ' Copy out the stream.
                        Await ClientResponse.Content.CopyToAsync(OutputStream)
                    End Using
                End If

            Catch ex As System.Net.Http.HttpRequestException
                ' Temporary, basic error handler in case we can't find
                ' the source's URL. This may happen if there's
                ' no Internet connection.
                MessageBox.Show("Couldn't find " & SourceUrl & ". Please check your connection and try again. If you're online, the source may be unavailable.",
                                "Downloading manifests")
                Exit Function

            Catch ex As IO.DirectoryNotFoundException
                ' Catch directory not found exceptions if the user cancels the update early
                ' after deleting the package list zip file downloaded during the previous update.
                MessageBox.Show(ex.Message & vbCrLf &
                                vbCrLf &
                                "This may be caused by having the directory above open in another program like Explorer. Please try again.",
                                "Downloading manifests")
                Exit Function
            End Try

        End Using

        Return
    End Function
#End Region

#Region "Update manifests async"
    Public Shared Async Function UpdateManifestsAsync(Optional Use7zip As Boolean = False,
                                                      Optional PathTo7zip As String = "C:\Program Files\7-Zip\7z.exe",
                                                      Optional UseRobocopy As Boolean = False) As Task
        ' Start downloading the package list from
        ' https://github.com/Microsoft/winget-pkgs/archive/master.zip

        ' The manifest's location needs to be based on the source's name,
        ' but for now it's hardcoded until source configuration is supported.
        ' This will probably use a YAML file to store source names, locations, and types.

        ' Reset the cancel update flag.
        CancelUpdateFlag = False

        ' Re-create the temp folder.
        Dim tempDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) &
                                   "\winget-frontends\source\winget-pkgs\temp"

        ' Specify the database folder.
        Dim DatabaseTempDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) &
                                           "\winget-frontends\source\winget-db\temp"

#Region "Update manifests."
        If Not System.IO.Directory.Exists(tempDir) Then
            ' If it doesn't exist, create it.
            Await Task.Run(Sub()
                               System.IO.Directory.CreateDirectory(tempDir)
                           End Sub)
            ' Now we can download the package.
            ' This is copied here so it doesn't crash
            ' when it can't find the temp folder.
            Await DownloadPkgListWithProgressAsync("https://github.com/Microsoft/winget-pkgs/archive/master.zip",
                                             "Microsoft/winget-pkgs")
        Else
            ' Otherwise, re-create it.
            If Await DeleteTempDirAsync("winget-pkgs", True) = False Then
                ' Make sure it was successful before moving on.
                Exit Function
            End If

            ' Now we can download the package.
            ' This is copied here so it doesn't crash
            ' when it can't find the temp folder.
            Await DownloadPkgListWithProgressAsync("https://github.com/Microsoft/winget-pkgs/archive/master.zip",
                                             "Microsoft/winget-pkgs")
        End If
#End Region

#Region "Update database."
        ' Update the database.
        ' Check if the directory exists for the database as well,
        ' if necessary.
        ' Cancel out if the CancelUpdatesFlag is set.
        If CancelUpdateFlag = True Then
            Exit Function
        End If
        ' Now download the database.
        If IO.Directory.Exists(DatabaseTempDir) Then
            ' Exists; re-create it.
            If Await DeleteTempDirAsync("winget-db", True) = False Then
                ' If there's an issue and a file is open, stop updating.
                Exit Function
            End If
        ElseIf Not IO.Directory.Exists(DatabaseTempDir) Then
            ' Doesn't exist; create it.
            Await Task.Run(Sub()
                               System.IO.Directory.CreateDirectory(DatabaseTempDir)
                           End Sub)
        End If
        ' Now download.
        Await DownloadPkgListWithProgressAsync("https://cdn.winget.microsoft.com/cache/source.msix",
                                             "winget-db")
#End Region

        ' Trying to use this code to display progress as
        ' we update:
        ' https://stackoverflow.com/a/19459595

        'MessageBox.Show("Done downloading.")

        ' Check if the user clicked Cancel or not in the download part first.
        If CancelUpdateFlag = False Then

            ' Now we extract that file, but first we need to delete old manifests.
            ' We'll wait to delete the old ones until the copying phase.
            Dim ManifestDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) &
                                       "\winget-frontends\source\winget-pkgs\pkglist\manifests"

            Dim DatabaseDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) &
                                       "\winget-frontends\source\winget-db\source\Public"

            ' We can now extract the manifests.

            ' Display a window to show progress.
            Using progressform As New DownloadProgressForm
                progressform.labelSourceLocation.Hide()
                progressform.labelSourceName.Hide()
                progressform.CurrentAction = "Extracting manifests"

                ' Specify whether or not the form should stay on top
                ' of everything.
                RootFormTools.ProgressFormShow(RootForm, progressform)

                ' Start the progress bar.
                progressform.progressbarDownloadProgress.Style = ProgressBarStyle.Marquee
                progressform.Update()

                ' Extract manifests.
                ' To monitor progress, maybe something like the following
                ' StackOverflow answer would work:
                ' https://stackoverflow.com/a/39668142

                If Use7zip = False Then
                    ' If the calling app doesn't want to use 7zip, use the built-in .Net extraction.
                    ' During testing on my laptop, using 7zip and robocopy reduced the cache updating time from
                    ' 1 minute 40 seconds to about 1 minute 4 seconds.
                    ' New testing as of 5/28/2021 shows that the improved zip file extraction code
                    ' now takes about 1 minute 36 seconds and the 7-zip and RoboCopy combination
                    ' takes about 1 minute 11 seconds. This is also with the debugger attached and
                    ' Firefox open with a bunch of tabs.
                    ' Without the debugger attached, I got about 1 minute 25 seconds. Robocopy + 7-Zip
                    ' still get about 1 minute 4 seconds.
                    ' Testing with v0.2.0.2 gets about 1 minute 45 seconds, so this is an improvement
                    ' of roughly 20 seconds.
                    ' Showing the filename as we extract it makes it take about 1 minute 45 seconds
                    ' with the debugger attached, or about 1 minute 35 seconds when detached.
                    ' That's still a 10-second improvement even when showing what file is being
                    ' extracted.
                    ' Another test with the laptop unplugged showed it takes about 2 minutes 12 seconds detached from
                    ' the debugger, then one a few minutes later took about 2 minutes 8 seconds.
                    ' Another test with the current extraction and copy code took about 3 minutes 2 seconds,
                    ' so it's still faster.
                    ' It appears that using "Better performance" makes the extraction go faster,
                    ' which is to be expected.

                    ' Check if the zip file exists before extracting it.

                    ' This ZipArchiveEntry thing is based on MSDN code for extraction from here:
                    ' https://docs.microsoft.com/en-us/dotnet/api/system.io.compression.ziparchiveentry?view=netframework-4.8

                    ' Temporary, basic error handler in case we can't find
                    ' the zip file we want to extract.
                    Try
                        If System.IO.File.Exists(tempDir & "\winget-pkgs-master.zip") Then

                            ' Show the progress label for the filename.
                            progressform.labelSourceName.Visible = True
                            ' Placeholder text.
                            progressform.labelSourceName.Text = "File: "
                            ' Change the progress bar to be the regular kind.
                            progressform.progressbarDownloadProgress.Style = ProgressBarStyle.Continuous

                            ' Now extract.
                            Using ManifestsZipFile As ZipArchive = ZipFile.OpenRead(tempDir & "\winget-pkgs-master.zip")

                                ' Set progress bar maximum.
                                progressform.progressbarDownloadProgress.Maximum = ManifestsZipFile.Entries.Count

                                For Each ZipArchiveEntry In ManifestsZipFile.Entries

                                    ' Stop extracting if the user clicks Cancel.
                                    If CancelUpdateFlag = True Then
                                        ManifestsZipFile.Dispose()
                                        Exit Function
                                    End If

                                    ' Make sure we're only looking at the yaml files.
                                    ' Should make it faster.
                                    If ZipArchiveEntry.FullName.EndsWith(".yaml", StringComparison.OrdinalIgnoreCase) Then

                                        ' The final place where extracted files will be.
                                        Dim DestinationPath As String = Path.GetFullPath(Path.Combine(tempDir & "\winget-pkgs-master", ZipArchiveEntry.FullName))

                                        ' Not sure why we're checking if the destination path
                                        ' starts with the extraction directory, but the
                                        ' example had it so we're doing it here.
                                        If DestinationPath.StartsWith(tempDir & "\winget-pkgs-master", StringComparison.OrdinalIgnoreCase) Then
                                            ' Debugging to see where it gets stuck.
                                            'Debug.WriteLine(DestinationPath)

                                            ' Update the current filename.
                                            ' Even with showing the current filename, it's
                                            ' still faster than the old way of extracting
                                            ' every file.
                                            progressform.labelSourceName.Text = "File: " & ZipArchiveEntry.Name.ToString


                                            ' Make sure there's a "\" at the end of the path to prevent path traversal.
                                            If Not DestinationPath.Replace(ZipArchiveEntry.Name, String.Empty).EndsWith("\") Then
                                                DestinationPath = DestinationPath.Replace(ZipArchiveEntry.Name, String.Empty) & "\"
                                            Else
                                                ' Destination path has a "\", so just replace the filename.
                                                DestinationPath = DestinationPath.Replace(ZipArchiveEntry.Name, String.Empty)
                                            End If

                                            Await Task.Run(Sub()
                                                               ' Create the directory for the manifest if it doesn't exist.
                                                               IO.Directory.CreateDirectory(DestinationPath)

                                                               ' Now extract.
                                                               ' Catch System.IO.DirectoryNotFoundException exceptions to tell the user they may
                                                               ' need to go to the Options window to turn LongFilePath support on in the Windows Registry.
                                                               ' Also state that a process will help it to be done automatically.
                                                               ' TODO/NOTE: The feature in the Options window will be available in a future version.
                                                               ' Default max was taken from here:
                                                               ' https://docs.microsoft.com/en-us/windows/win32/fileio/maximum-file-path-limitation

                                                               Try
                                                                   ' TODO: Make sure the file doesn't exist yet, which can happen if the main window
                                                                   ' is closed during extraction and we're not deleting the temp directory yet.
                                                                   If Not System.IO.File.Exists(DestinationPath & ZipArchiveEntry.Name) Then
                                                                       ZipArchiveEntry.ExtractToFile(DestinationPath & ZipArchiveEntry.Name)
                                                                   Else
                                                                       Exit Sub
                                                                   End If

                                                               Catch ex As System.IO.DirectoryNotFoundException
                                                                   ' The messagebox was moved to its own sub so that the boolean
                                                                   ' would be updated properly.
                                                                   ManifestPathTooLongMessage(ZipArchiveEntry.Name)
                                                               End Try
                                                           End Sub)
                                        End If
                                    End If
                                    ' Update progress bar.
                                    progressform.progressbarDownloadProgress.Value = progressform.progressbarDownloadProgress.Value + 1
                                Next

                                ' Set the progress bar back to the way it was.
                                progressform.progressbarDownloadProgress.Style = ProgressBarStyle.Marquee

                            End Using
                            ' Old extraction code.
                            'ZipFile.ExtractToDirectory(tempDir & "\winget-pkgs-master.zip", tempDir & "\winget-pkgs-master\")
                        End If
                    Catch ex As System.IO.FileNotFoundException
                        MessageBox.Show("Couldn't find " & tempDir & "\winget-pkgs-master.zip",
                                           "Extracting manifests")
                    Catch ex As System.IO.DirectoryNotFoundException
                        MessageBox.Show(ex.Message,
                                           "Extracting manifests")
                    Catch ex As System.IO.InvalidDataException
                        MessageBox.Show("We couldn't extract the manifest package. Please verify that the source URL is correct, and try again." & vbCrLf &
                                           vbCrLf & "Details:" & vbCrLf &
                                           ex.GetType.ToString & ": " & ex.Message,
                                           "Extracting manifests")
                    End Try

                    ' Now extract the database.
                    Try
                        If System.IO.File.Exists(DatabaseTempDir & "\source.msix") Then
                            ' Now extract.

                            Await Task.Run(Sub()
                                               ' TODO: Ensure files that already exist are skipped if we're debugging
                                               ' extracting without updating the cache from the server.
                                               ZipFile.ExtractToDirectory(DatabaseTempDir & "\source.msix", DatabaseTempDir & "\source\")
                                           End Sub)

                        End If
                    Catch ex As System.IO.FileNotFoundException
                        MessageBox.Show("Couldn't find " & DatabaseTempDir & "\source.msix",
                                           "Extracting manifests")
                    Catch ex As System.IO.DirectoryNotFoundException
                        MessageBox.Show("Couldn't find " & DatabaseTempDir & "\source",
                                           "Extracting manifests")
                    Catch ex As System.IO.InvalidDataException
                        MessageBox.Show("We couldn't extract the database package. Please verify that the source URL is correct, and try again." & vbCrLf &
                                           vbCrLf & "Details:" & vbCrLf &
                                           ex.GetType.ToString & ": " & ex.Message,
                                           "Extracting manifests")
                    End Try
                Else
                    ' The calling app wants to use 7zip, so use it.
                    ' Make sure it doesn't have "://" in the path.
                    If PathTo7zip.Contains("://") Then
                        PathTo7zip = "C:\Program Files\7-Zip\7z.exe"
                    End If

                    Using extraction7z As New Process
                        Await Task.Run(Sub()
                                           extraction7z.StartInfo.FileName = PathTo7zip
                                           extraction7z.StartInfo.Arguments = "x -bd " & tempDir & "\winget-pkgs-master.zip -o" & tempDir & "\winget-pkgs-master\"
                                           extraction7z.Start()
                                           ' Wait for 7zip to exit, otherwise it'll move on too soon.
                                           extraction7z.WaitForExit()
                                       End Sub)
                    End Using

                    ' The calling app wants to use 7zip, so use it.
                    ' This is for the database.
                    Using extraction7zDatabase As New Process
                        Await Task.Run(Sub()
                                           extraction7zDatabase.StartInfo.FileName = PathTo7zip
                                           extraction7zDatabase.StartInfo.Arguments = "x -bd " & DatabaseTempDir & "\source.msix -o" & DatabaseTempDir & "\source\"
                                           extraction7zDatabase.Start()
                                           ' Wait for 7zip to exit, otherwise it'll move on too soon.
                                           extraction7zDatabase.WaitForExit()
                                       End Sub)
                    End Using
                End If

                'MessageBox.Show("7zip finished")



            End Using

            'MessageBox.Show("Done extracting.")

            ' Check if the user wants to cancel before the copying phase.
            If CancelUpdateFlag = False Then

                ' Now we just need to move the right files over.
                ' Probably should add a dialog to not make it
                ' look like nothing is happening.
                Using progressform As New DownloadProgressForm
                    progressform.labelSourceLocation.Hide()
                    progressform.labelSourceName.Hide()
                    progressform.CurrentAction = "Moving manifests"

                    ' Specify whether or not the form should stay on top
                    ' of everything.
                    RootFormTools.ProgressFormShow(RootForm, progressform)

                    ' Start the progress bar.
                    progressform.progressbarDownloadProgress.Style = ProgressBarStyle.Marquee

                    ' At this point, the user can't cancel the update.
                    progressform.buttonCancel.Enabled = False

                    ' Update the progress form.
                    progressform.Update()

                    ' Move manifests.


                    If UseRobocopy = False Then

                        ' The calling app doesn't want to use Robocopy.

                        ' Temporary, basic error handler in case
                        ' we can't find the manifests folder.
                        Try

                            ' Make sure the manifest temp folder exists before deleting
                            ' the manifest dir.
                            ' It might not exist if the user is running guinget offline,
                            ' in which case the package list cache will just be loaded from
                            ' disk and won't be updated.
                            Await Task.Run(Sub()
                                               If System.IO.Directory.Exists(ManifestDir) AndAlso IO.Directory.Exists(tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests") Then
                                                   System.IO.Directory.Delete(ManifestDir, True)
                                               End If
                                           End Sub)

                            ' Move the manifests to their proper
                            ' folder rather than copy so it's
                            ' faster.
                            Await Task.Run(Sub()
                                               ' We need to make sure it exists first, though.
                                               If Directory.Exists(tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests") Then
                                                   My.Computer.FileSystem.MoveDirectory(tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests", ManifestDir)
                                               End If
                                           End Sub)

                        Catch ex As System.IO.DirectoryNotFoundException
                            MessageBox.Show("Couldn't find " & tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests" & vbCrLf &
                                            "Please close any Explorer windows that may be open in this directory, and try again.",
                                            "Moving manifests")
                        Catch ex As System.IO.IOException
                            MessageBox.Show("Please close any Explorer windows that may be open in this directory, and try again." & vbCrLf &
                                                               vbCrLf &
                                                               "Details:" & vbCrLf &
                                                               ex.Message, "Moving manifests")
                        End Try

                        Try
                            ' Make sure the database temp folder exists before deleting
                            ' the database dir.
                            ' It might not exist if the user is running guinget offline,
                            ' in which case the database cache will just be loaded from
                            ' disk and won't be updated.
                            Await Task.Run(Sub()
                                               If System.IO.Directory.Exists(DatabaseDir) AndAlso IO.Directory.Exists(DatabaseTempDir & "\source\Public") Then
                                                   System.IO.Directory.Delete(DatabaseDir, True)
                                               End If
                                           End Sub)

                            ' Move the database to its proper
                            ' folder rather than copy so it's
                            ' faster.
                            Await Task.Run(Sub()
                                               ' We need to make sure it exists first, though.
                                               If Directory.Exists(DatabaseTempDir & "\source\Public") Then
                                                   My.Computer.FileSystem.MoveDirectory(DatabaseTempDir & "\source\Public", DatabaseDir)
                                               End If
                                           End Sub)

                        Catch ex As System.IO.DirectoryNotFoundException
                            MessageBox.Show("Couldn't find " & DatabaseTempDir & "\source\Public" & vbCrLf &
                                                       "Please close any Explorer windows that may be open in this directory, and try again.",
                                       "Moving manifests")
                        Catch ex As System.IO.IOException
                            MessageBox.Show("Please close any Explorer windows that may be open in this directory, and try again." & vbCrLf &
                                                       vbCrLf &
                                                       "Details:" & vbCrLf &
                                                       ex.Message, "Moving manifests")
                        End Try

                    Else

                        ' The calling app wants to use Robocopy.
                        ' Partially copying code from update-manifests.bat.
                        Using RobocopyFileCopying As New Process
                            Await Task.Run(Sub()
                                               RobocopyFileCopying.StartInfo.FileName = "robocopy"
                                               RobocopyFileCopying.StartInfo.Arguments = "/NFL /NDL /S " & tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests " & ManifestDir
                                               RobocopyFileCopying.Start()
                                               ' Wait for robocopy to exit, or else it'll move on too soon.
                                               RobocopyFileCopying.WaitForExit()
                                           End Sub)
                        End Using

                        ' The calling app wants to use Robocopy.
                        ' Partially copying code from update-manifests.bat.
                        ' Update the database.
                        Using RobocopyFileCopyingDatabaseUpdate As New Process
                            Await Task.Run(Sub()
                                               RobocopyFileCopyingDatabaseUpdate.StartInfo.FileName = "robocopy"
                                               RobocopyFileCopyingDatabaseUpdate.StartInfo.Arguments = "/NFL /NDL /S " & DatabaseTempDir & "\source\Public " & DatabaseDir
                                               RobocopyFileCopyingDatabaseUpdate.Start()
                                               ' Wait for robocopy to exit, or else it'll move on too soon.
                                               RobocopyFileCopyingDatabaseUpdate.WaitForExit()
                                           End Sub)
                        End Using
                    End If

                End Using

                ' Delete temp files if the user wants to do so once updating is complete.
                ' Make sure the cancel update flag is off before doing this, as
                ' there may be a reason why people want to keep the temp files
                ' around at the last minute.
                If DeleteTempDirsAfterCacheUpdate = True AndAlso CancelUpdateFlag = False Then
                    ' winget-pkgs
                    If Await DeleteTempDirAsync("winget-pkgs") = False Then
                        ' If there's an issue deleting it here, exit the function.
                        Exit Function
                    End If
                    ' winget-db
                    If Await DeleteTempDirAsync("winget-db") = False Then
                        ' If there's an issue deleting it here, exit the function.
                        Exit Function
                    End If
                End If

                ' End checking if user clicked Cancel in the extracting phase.
            End If

            ' End checking if user clicked Cancel in the downloading phase.
        End If

    End Function

#Region "Stop extracting manifests with paths that are too long message."

    ' Boolean to store if the long file path message has been shown yet.
    ' This and the sub with the message box below has been moved from the
    ' extraction code as it wasn't properly updating the boolean
    ' due to happening in an async block.
    Private Shared LongFilePathMessageShown As Boolean = False

    Private Shared Sub ManifestPathTooLongMessage(ZipArchiveEntryName As String)
        If LongFilePathMessageShown = False Then
            MessageBox.Show("The file path for this manifest is too long." & vbCrLf & vbCrLf &
                            "You'll need to turn LongPathsEnabled on in the Windows Registry manually for now, or use the EnableLongPathsEnabled.reg file that shipped with guinget. You can turn it back off with DisableLongPathsEnabled.reg." & vbCrLf & vbCrLf &
                            "Be sure to read these files in Notepad first to ensure they don't do anything dangerous (just in case they get modified by a third-party in an unofficial guinget package), or so that you can just copy everything manually if you know what you're doing. These files must be opened from an elevated (Administrator) process, such as Command Prompt or PowerShell. After doing either, you may need to restart your computer to ensure the changes take effect. We won't tell you again during this extraction for any more files we run into that are too long." & vbCrLf & vbCrLf &
                            "A future version will make this easier." & vbCrLf &
                            vbCrLf &
                            "Current manifest we're trying to extract: " & ZipArchiveEntryName, "Manifest File Path Too Long")
            'MessageBox.Show("The file path for this manifest is probably too long. You'll need to go to the Options window to turn LongPathsEnabled on in the Windows Registry. You'll be guided through the task automatically.")
            ' Update variable to say if we've shown this message or not yet.
            LongFilePathMessageShown = True
        End If
    End Sub
#End Region
#End Region

#Region "Deleting temp directories."
    Public Shared Async Function DeleteTempDirAsync(SourceRootDir As String, Optional RecreateTempDir As Boolean = False) As Task(Of Boolean)
        ' Delete the temp dir of the source specified in SourceRootDir.
        ' Define a variable to store the path.
        Dim tempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) &
                                   "\winget-frontends\source\" & SourceRootDir & "\temp"
        ' Now begin deletion process.
        ' Make sure it's not in use at the moment.
        Try
            ' Using Await so it's properly async.
            Await Task.Run(Sub()
                               ' Make sure the path exists first.
                               If System.IO.Directory.Exists(tempPath) Then
                                   Try
                                       System.IO.Directory.Delete(tempPath, True)
                                   Catch ex As System.IO.IOException
                                       ' We need to tell another sub to load the last session's package list
                                       ' because something in the path is in use and we'll do it
                                       ' by updating a boolean outside the Await because I don't
                                       ' know how to do this properly.
                                       ' TODO: Figure it out to do it properly.
                                       UpdateBooleanToUsePreviousSessionPackageList(True)
                                   End Try
                               End If
                           End Sub)
            ' Re-create the dir if necessary.
            If RecreateTempDir = True Then
                System.IO.Directory.CreateDirectory(tempPath)
            End If
        Catch ex As System.IO.IOException
            MessageBox.Show("A file in " & tempPath & " is in use by another process. Please close it and try again. Loading last session's package list.", "Deleting temp dir")
            ' Task unsuccessful.
            Return False
        End Try
        ' Task successful.
        Return True
    End Function
#End Region

#Region "Get manifest paths list"
    Public Shared Async Function GetManifestsAsync() As Task(Of List(Of String))
        ' Get and return each manifest in the manifests folder.
        ' This should only be used after ensuring that there's
        ' stuff in this folder, or it'll crash.
        Dim ManifestAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

        ' Define a variable so we can store the manifest paths.
        Dim ManifestPath As List(Of String) = New List(Of String)

        ' Take the Id string for each package file and append it to the
        ' package list array variable.
        For Each PackageManifest As String In My.Computer.FileSystem.GetFiles(ManifestAppDataFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.yaml")
            ' Append the current package manifest's path to the ManifestPath string.
            Await Task.Run(Sub()
                               ManifestPath.Add(PackageManifest)
                           End Sub)
        Next

        Return ManifestPath
    End Function
#End Region

#Region "Find manifest by version and ID"
    ' This is used as a fallback if we can't figure out where the manifest is by
    ' just using the package id and version.
    ' If the folder used here doesn't exist, applications using this
    ' library will crash, so it has to be set by the calling application before
    ' being used.
    Public Shared FallbackPathList As List(Of String)

    Public Shared Async Function FindManifestByVersionAndId(ManifestId As String, ManifestVersion As String) As Task(Of String)
        ' We'll look through the manifests in the cache, and if there's a version number match,
        ' we'll open it and check the ID. If it's a match, we'll return the path.
        ' This path will eventually be used in the manifest path column in the main window,
        ' but for now we just need a messagebox to display it.
        Dim ManifestAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

        ' If we can't do a simple replacement on each "." in the ID,
        ' we'll have to fall back to the slower method.
        Dim QuickPathReplaceReplaceAllPeriods As String = ManifestAppDataFolder & "\" & ManifestId.Substring(0, 1).ToLowerInvariant & "\" & ManifestId.Replace(".", "\") & "\" & ManifestVersion & "\" & ManifestId & ".yaml"
        ' Replacing only the first period uses code based on this:
        ' https://stackoverflow.com/a/5015804
        Dim QuickPathReplaceReplaceOnlyFirstPeriod As String = ManifestAppDataFolder & "\" & ManifestId.Substring(0, 1).ToLowerInvariant & "\" & ManifestId.Remove(ManifestId.IndexOf("."), 1).Insert(ManifestId.IndexOf("."), "\") & "\" & ManifestVersion & "\" & ManifestId & ".yaml"

        ' Show the new path.
        'If ManifestId.ToLowerInvariant.Contains("gitter") Then
        '    MessageBox.Show(QuickPathReplaceReplaceOnlyFirstPeriod)
        'End If

        If IO.File.Exists(QuickPathReplaceReplaceAllPeriods) Then
            Return QuickPathReplaceReplaceAllPeriods

        ElseIf Not IO.File.Exists(QuickPathReplaceReplaceAllPeriods) AndAlso IO.File.Exists(QuickPathReplaceReplaceOnlyFirstPeriod) Then
            ' If we can't do the fastest one, try only replacing the first period.
            Return QuickPathReplaceReplaceOnlyFirstPeriod

        Else
            ' We can't use either of these two methods, so use the fallback one.

            ' Take the Id string for each package file and append it to the
            ' package list array variable.
            For Each PackageManifest As String In FallbackPathList
                'Debug.WriteLine("ManifestAppDataFolder: " & ManifestAppDataFolder & vbCrLf &
                '"PackageManifest: " & PackageManifest & vbCrLf &
                '"ManifestVersion: " & ManifestVersion & vbCrLf &
                '"ManifestId: " & ManifestId)

                ' Check if the manifest has the ID we're looking for.
                If PackageManifest.ToLowerInvariant.EndsWith(ManifestId.ToLowerInvariant & ".yaml") Then
                    'Debug.WriteLine("Hit")
                    ' Open and read the manifest version.
                    Dim LocalVersion As String = Await PackageTools.GetPackageInfoFromYamlAsync(PackageManifest, "PackageVersion")
                    'MessageBox.Show(LocalId)
                    If LocalVersion = ManifestVersion Then
                        Return PackageManifest
                    End If
                End If
            Next
        End If
    End Function
#End Region

#Region "Get package details table from SQLite database"
    Public Shared Async Function GetPackageDetailsTableFromSqliteDBAsync() As Task(Of DataTable)
        ' Trying to load the package list as shown in this SO
        ' question that has the solution with it:
        ' https://stackoverflow.com/q/19553165

        'Value to search as SQL Query - return first match
        Dim SqlQuery As String = "select distinct ids.id, manifest.id, versions.version," &
            " manifest.version, names.name, manifest.name from ids, manifest, versions," &
            " names where manifest.id = ids._rowid_ and manifest.version = versions._rowid_ " &
            " and manifest.name = names._rowid_ order by ids.id;"

        ' SQL query for latest package version.
        ' This puts what it thinks is the latest version
        ' in a column just for it for later comparison,
        ' but not all packages have the latest version
        ' specified properly. Not sure how winget does
        ' it, but it would be better to do it that way.
        ' Based on the code at the bottom of this page:
        ' https://www.sqlitetutorial.net/sqlite-window-functions/sqlite-last_value/#:~:text=The%20LAST_VALUE%20%28%29%20is%20a%20window%20function%20that,LAST_VALUE%20%28expression%29%20OVER%20%28%20PARTITION%20BY%20expression1%2C%20expression2%2C
        Dim SqlQueryWithLatestVersion As String = "SELECT DISTINCT
    ids.id, manifest.id, versions.version, manifest.version, names.name, manifest.name,
    LAST_VALUE ( versions.version ) OVER (
		PARTITION by ids.id
        ORDER BY ids.id 
        RANGE BETWEEN UNBOUNDED PRECEDING AND 
        UNBOUNDED FOLLOWING
    ) AS NewestVersion 
FROM
    ids, manifest, versions, names 
WHERE
    manifest.id = ids._rowid_ and manifest.version = versions._rowid_ and manifest.name = names._rowid_;"

        ' Specify winget package list database file we want
        ' to read from.
        Dim PackageListPath As String = "Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) &
                                       "\winget-frontends\source\winget-db\source\Public\index.db"
        Dim SqlConnection As New SqliteConnection(PackageListPath)
        Dim SqlCommand As New SqliteCommand(SqlConnection.ToString)
        Dim SqlDataReader As SqliteDataReader
        ' Open connection to the database file.
        SqlConnection.Open()

        SqlCommand.Connection = SqlConnection
        SqlCommand.CommandText = SqlQueryWithLatestVersion
        SqlDataReader = SqlCommand.ExecuteReader()


        ' Store the package name list in an array.
        Dim packageArray As New DataTable

        ' Create columns for storing data.
        ' Based on this answer here:
        ' https://stackoverflow.com/a/2350647
        packageArray.Columns.Add("PackageId", GetType(String))
        packageArray.Columns.Add("PackageName", GetType(String))
        packageArray.Columns.Add("PackageVersion", GetType(String))
        packageArray.Columns.Add("PackageLatestVersion", GetType(String))

        ' Get data from the name column based on this MSDN page:
        ' https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader
        If SqlDataReader.HasRows Then
            ' If the SQL data reader has rows, then read it.
            Do While SqlDataReader.Read
                ' While reading the SQL db file, append the package name we're
                ' looking at with the current package and add a comma
                ' for separation.

                ' Column 0 is ID, 4 is Name, 2 is Version, and 6 is latest version.
                ' Running this as async.
                Await Task.Run(Sub()
                                   packageArray.Rows.Add(SqlDataReader.GetValue(0), SqlDataReader.GetValue(4), SqlDataReader.GetValue(2), SqlDataReader.GetValue(6))
                               End Sub)
            Loop
        End If


        ' End the connection
        ' Trying to make sure the database is disconnected.
        SqlDataReader.Dispose()
        SqlConnection.Dispose()
        SqlCommand.Dispose()
        SqlDataReader.Close()
        SqlConnection.Close()

        ' Also have it clear all pools, as it'll otherwise keep the file
        ' in memory in case you want to use it later. We don't need that,
        ' because the data is copied into memory.
        ' Learned about this from various answers to this SO post:
        ' https://stackoverflow.com/questions/8511901/system-data-sqlite-close-not-releasing-database-file
        SqliteConnection.ClearAllPools()

        ' Return the list of packages.
        Return packageArray
    End Function
#End Region

    Public Shared Sub ImportPackages(FileName As String)
        ' Pass the filename to winget.
        CommandTools.ImportExport("Import", FileName)
    End Sub

    Public Shared Sub ExportPackages(FileName As String)
        ' Pass the filename to winget.
        CommandTools.ImportExport("Export", FileName)
    End Sub

End Class
