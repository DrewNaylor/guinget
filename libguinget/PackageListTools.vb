' libguinget - Package and package list tools for guinget
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



Imports System.Windows.Forms
Imports System.IO.Compression
Imports Microsoft.Data.Sqlite

Public Class PackageListTools

    ' Define an http client we'll use.
    Shared ReadOnly PkgClient As Net.Http.HttpClient = New Net.Http.HttpClient()

    ' Define a flag we'll use to see if updating should be canceled.
    ' Updating can't be stopped once the package list is extracted.
    ' As of right now, the current task has to complete before it
    ' updating is stopped.
    Public Shared CancelUpdateFlag As Boolean = False

    Private Shared Async Function DownloadPkgListWithProgressAsync(ByVal SourceUrl As String, ByVal SourceName As String) As Task

        ' Download a file with HttpClient:
        ' https://stackoverflow.com/a/54475013

        ' Show a progress form that says what's being done.
        Using progressform As New libguinget.DownloadProgressForm
            ' Set progress form properties.
            progressform.PackageListUrl = SourceUrl
            progressform.PackageListSourceName = SourceName

            ' Show progress form.
            progressform.Show()

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
                Using OutputStream As IO.FileStream = New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                                           "\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master.zip", IO.FileMode.CreateNew)
                    'MessageBox.Show(OutputStream.ToString)

                    ' Copy out the stream.
                    Await ClientResponse.Content.CopyToAsync(OutputStream)
                End Using

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
        Dim tempDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                                   "\winget-frontends\source\winget-pkgs\temp"

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
            Await Task.Run(Sub()
                               System.IO.Directory.Delete(tempDir, True)
                               System.IO.Directory.CreateDirectory(tempDir)
                           End Sub)

            ' Now we can download the package.
            ' This is copied here so it doesn't crash
            ' when it can't find the temp folder.
            Await DownloadPkgListWithProgressAsync("https://github.com/Microsoft/winget-pkgs/archive/master.zip",
                                             "Microsoft/winget-pkgs")
        End If

        ' Trying to use this code to display progress as
        ' we update:
        ' https://stackoverflow.com/a/19459595

        'MessageBox.Show("Done downloading.")

        ' Check if the user clicked Cancel or not in the download part first.
        If CancelUpdateFlag = False Then

            ' Now we extract that file, but first we need to delete old manifests.
            ' We'll wait to delete the old ones until the copying phase.
            Dim ManifestDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                                       "\winget-frontends\source\winget-pkgs\pkglist\manifests"

            ' We can now extract the manifests.

            ' Display a window to show progress.
            Using progressform As New DownloadProgressForm
                progressform.labelSourceLocation.Hide()
                progressform.labelSourceName.Hide()
                progressform.CurrentAction = "Extracting manifests"

                ' Show progress form.
                progressform.Show()

                ' Start the progress bar.
                progressform.progressbarDownloadProgress.Style = ProgressBarStyle.Marquee
                progressform.Update()

                ' Extract manifests.
                ' To monitor progress, maybe something like the following
                ' StackOverflow answer would work:
                ' https://stackoverflow.com/a/39668142

                ' Temporary, basic error handler in case we can't find
                ' the zip file we want to extract.
                Await Task.Run(Sub()
                                   If Use7zip = False Then
                                       ' If the calling app doesn't want to use 7zip, use the built-in .Net extraction.
                                       ' During testing on my laptop, using 7zip and robocopy reduced the cache updating time from
                                       ' 1 minute 40 seconds to about 1 minute 4 seconds.

                                       ' Check if the zip file exists before extracting it.

                                       Try
                                           If System.IO.File.Exists(tempDir & "\winget-pkgs-master.zip") Then
                                               ZipFile.ExtractToDirectory(tempDir & "\winget-pkgs-master.zip", tempDir & "\winget-pkgs-master")
                                           End If
                                       Catch ex As System.IO.FileNotFoundException
                                           MessageBox.Show("Couldn't find " & tempDir & "\winget-pkgs-master.zip",
                                           "Extracting manifests")
                                       Catch ex As System.IO.DirectoryNotFoundException
                                           MessageBox.Show("Couldn't find " & tempDir & "\winget-pkgs-master",
                                           "Extracting manifests")
                                       Catch ex As System.IO.InvalidDataException
                                           MessageBox.Show("We couldn't extract the manifest package. Please verify that the source URL is correct, and try again." & vbCrLf &
                                           vbCrLf & "Details:" & vbCrLf &
                                           ex.GetType.ToString & ": " & ex.Message,
                                           "Extracting manifests")
                                       End Try

                                   Else
                                       ' The calling app wants to use 7zip, so use it.
                                       Dim extraction7z As New Process
                                       extraction7z.StartInfo.FileName = PathTo7zip
                                       extraction7z.StartInfo.Arguments = "x -bd " & tempDir & "\winget-pkgs-master.zip -o" & tempDir & "\winget-pkgs-master"
                                       extraction7z.Start()
                                       ' Wait for 7zip to exit, otherwise it'll move on too soon.
                                       extraction7z.WaitForExit()
                                   End If
                               End Sub)

                'MessageBox.Show("7zip finished")



            End Using

            'MessageBox.Show("Done extracting.")

            ' Check if the user wants to cancel before the copying phase.
            If CancelUpdateFlag = False Then

                ' Now we just need to copy the right files over.
                ' Probably should add a dialog to not make it
                ' look like nothing is happening.
                Using progressform As New DownloadProgressForm
                    progressform.labelSourceLocation.Hide()
                    progressform.labelSourceName.Hide()
                    progressform.CurrentAction = "Copying manifests"

                    ' Show progress form.
                    progressform.Show()

                    ' Start the progress bar.
                    progressform.progressbarDownloadProgress.Style = ProgressBarStyle.Marquee

                    ' At this point, the user can't cancel the update.
                    progressform.buttonCancel.Enabled = False

                    ' Update the progress form.
                    progressform.Update()

                    ' Copy manifests.
                    Await Task.Run(Sub()

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
                                               If System.IO.Directory.Exists(ManifestDir) AndAlso IO.Directory.Exists(tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests") Then
                                                   System.IO.Directory.Delete(ManifestDir, True)
                                               End If

                                               My.Computer.FileSystem.CopyDirectory(tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests", ManifestDir)
                                           Catch ex As System.IO.DirectoryNotFoundException
                                               MessageBox.Show("Couldn't find " & tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests",
                                               "Copying manifests")
                                           End Try

                                       Else

                                           ' The calling app wants to use Robocopy.
                                           ' Partially copying code from update-manifests.bat.
                                           Dim RobocopyFileCopying As New Process
                                           RobocopyFileCopying.StartInfo.FileName = "robocopy"
                                           RobocopyFileCopying.StartInfo.Arguments = "/NFL /NDL /S " & tempDir & "\winget-pkgs-master\winget-pkgs-master\manifests " & ManifestDir
                                           RobocopyFileCopying.Start()
                                           ' Wait for robocopy to exit, or else it'll move on too soon.
                                           RobocopyFileCopying.WaitForExit()
                                       End If
                                   End Sub)

                End Using

                ' End checking if user clicked Cancel in the extracting phase.
            End If

            ' End checking if user clicked Cancel in the downloading phase.
        End If

    End Function

    Public Shared Function GetManifests() As String
        ' Get and return each manifest in the manifests folder.
        Dim ManifestAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

        ' Define a variable so we can store the manifest paths.
        Dim ManifestPath As String = String.Empty

        ' Take the Id string for each package file and append it to the
        ' package list array variable.
        For Each PackageManifest As String In My.Computer.FileSystem.GetFiles(ManifestAppDataFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.yaml")

            ' Append the current package manifest's path to the ManifestPath string.
            ' Using a question mark since it's not allowed in path names.
            ManifestPath = ManifestPath & PackageManifest & "?"
        Next

        Return ManifestPath
    End Function

    Public Shared Async Function FindManifestByVersionAndId(ManifestId As String, ManifestVersion As String) As Task(Of String)
        ' We'll look through the manifests in the cache, and if there's a version number match,
        ' we'll open it and check the ID. If it's a match, we'll return the path.
        ' This path will eventually be used in the manifest path column in the main window,
        ' but for now we just need a messagebox to display it.
        Dim ManifestAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\winget-frontends\source\winget-pkgs\pkglist\manifests"

        ' Take the Id string for each package file and append it to the
        ' package list array variable.
        For Each PackageManifest As String In My.Computer.FileSystem.GetFiles(ManifestAppDataFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.yaml")
            'MessageBox.Show("ManifestAppDataFolder: " & ManifestAppDataFolder & vbCrLf &
            '"PackageManifest: " & PackageManifest & vbCrLf &
            '"ManifestVersion: " & ManifestVersion & vbCrLf &
            '"ManifestId: " & ManifestId)
            ' Check if the manifest has the version number we're looking for.
            If PackageManifest.EndsWith(ManifestVersion & ".yaml") Then
                ' Open and read the manifest ID.
                Dim LocalId As String = Await PackageTools.GetPackageInfoFromYamlAsync(PackageManifest, "Id")
                'MessageBox.Show(LocalId)
                If LocalId = ManifestId Then
                    Return PackageManifest
                End If
            End If
        Next
    End Function

    Public Shared Function GetPackageDetailsTableFromSqliteDB() As DataTable
        ' Trying to load the package list as shown in this SO
        ' question that has the solution with it:
        ' https://stackoverflow.com/q/19553165

        'Value to search as SQL Query - return first match
        Dim SqlQuery As String = "select distinct ids.id, manifest.id, versions.version," &
            " manifest.version, names.name, manifest.name from ids, manifest, versions," &
            " names where manifest.id = ids._rowid_ and manifest.version = versions._rowid_ " &
            " and manifest.name = names._rowid_ order by ids.id;"

        ' Specify winget package list database file we want
        ' to read from.
        Dim PackageListPath As String = "Data Source=""C:\Users\drewn\Desktop\source_8-13-2020\Public\index.db"""
        Dim SqlConnection As New SqliteConnection(PackageListPath)
        Dim SqlCommand As New SqliteCommand(SqlConnection.ToString)
        Dim SqlDataReader As SqliteDataReader
        ' Open connection to the database file.
        SqlConnection.Open()

        SqlCommand.Connection = SqlConnection
        SqlCommand.CommandText = SqlQuery
        SqlDataReader = SqlCommand.ExecuteReader()


        ' Store the package name list in an array.
        Dim packageArray As String = String.Empty

        ' Get data from the name column based on this MSDN page:
        ' https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader
        If SqlDataReader.HasRows Then
            ' If the SQL data reader has rows, then read it.
            Do While SqlDataReader.Read
                ' While reading the SQL db file, append the package name we're
                ' looking at with the current package and add a comma
                ' for separation.
                packageArray = packageArray & SqlDataReader.GetString(0) & ","
            Loop
        End If


        'End the connection
        SqlDataReader.Close()
        SqlConnection.Close()

        ' Return the list of packages.
        Return packageArray
    End Function

    Public Shared Function GetPackageListFromSqliteDB() As String
        ' Trying to load the package list as shown in this SO
        ' question that has the solution with it:
        ' https://stackoverflow.com/q/19553165

        'Value to search as SQL Query - return first match
        Dim SqlQuery As String = "Select id FROM ids;"

        ' Specify winget package list database file we want
        ' to read from.
        Dim PackageListPath As String = "Data Source=""C:\Users\drewn\Desktop\source_8-13-2020\Public\index.db"""
        Dim SqlConnection As New SqliteConnection(PackageListPath)
        Dim SqlCommand As New SqliteCommand(SqlConnection.ToString)
        Dim SqlDataReader As SqliteDataReader
        ' Open connection to the database file.
        SqlConnection.Open()

        SqlCommand.Connection = SqlConnection
        SqlCommand.CommandText = SqlQuery
        SqlDataReader = SqlCommand.ExecuteReader()


        ' Store the package name list in an array.
        Dim packageArray As String = String.Empty

        ' Get data from the name column based on this MSDN page:
        ' https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader
        If SqlDataReader.HasRows Then
            ' If the SQL data reader has rows, then read it.
            Do While SqlDataReader.Read
                ' While reading the SQL db file, append the package name we're
                ' looking at with the current package and add a comma
                ' for separation.
                packageArray = packageArray & SqlDataReader.GetString(0) & ","
            Loop
        End If


        'End the connection
        SqlDataReader.Close()
        SqlConnection.Close()

        ' Return the list of packages.
        Return packageArray
    End Function

End Class
