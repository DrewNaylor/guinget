@echo off
cls

REM This script automatically downloads and extracts the latest version of Microsoft/winget-pkgs from the master branch. Script based on UXL Autobuild Script:
Rem https://gist.github.com/DrewNaylor/22e3f1cded702fff494a46dabe643fde


REM Current script version:
set VERSIONNUMBER=2020.05-1

REM Create variable for the titlebar text when not doing anything:
set REGULAR_TITLE_BAR=update-manifests Version %VERSIONNUMBER%

REM Create variable for the titlebar text when downloading the package:
set DOWNLOADING_TITLE_BAR=update-manifests Version %VERSIONNUMBER%: Downloading package from GitHub...

REM Create variable for the titlebar text when extracting the package:
set EXTRACTING_TITLE_BAR=update-manifests Version %VERSIONNUMBER%: Extracting package previously downloaded from GitHub...

REM Create variable for the titlebar text when deleting the old manifests:
set DELETING_OLD_MANIFESTS_TITLE_BAR=update-manifests Version %VERSIONNUMBER%: Deleting old manifests...

REM Create variable for the titlebar text when deleting the old manifests:
set COPYING_TITLE_BAR=update-manifests Version %VERSIONNUMBER%: Copying manifests folder from package...

REM Create variable for the titlebar text when deleting the temp files:
set DELETING_TEMP_FILES_TITLE_BAR=update-manifests Version %VERSIONNUMBER%: Deleting temp files...

REM Set the titlebar text to the regular text:
title %REGULAR_TITLE_BAR%






:beginning-of-script
echo update-manifests is provided to others free of charge and without warranty by Drew Naylor.
echo Based on UXL Autobuild Script version 2018.01-1:
echo https://gist.github.com/DrewNaylor/22e3f1cded702fff494a46dabe643fde
echo update-manifests Version %VERSIONNUMBER% Copyright 2020 Drew Naylor.
echo Drew Naylor has no relation to Microsoft or GitHub.
echo update-manifests is related to neither Microsoft nor winget, and Microsoft does not endorse this software.
echo If anything happens to your computer, Drew Naylor is not responsible. Use at your own risk.
echo Please visit https://github.com/DrewNaylor/guinget/ for more information on this script's parent project, guinget, which is open source.
echo(

echo The purpose of update-manifests is to expediate the downloading and extracting of winget sources from Microsoft's Community Package Repository. For now, this is the only source supported, but the goal is to support more sources in the future, along with winget gaining that feature whenever it does. Eventually guinget will get its own manifest updater, so this script is just a temporary solution. update-manifests will use PowerShell to download a Zip file from github.com and extract it into "%AppData%\winget-frontends\source\winget-pkgs\pkglist\manifests" using PowerShell and robocopy. Manifests in this folder can be used by other winget frontends in addition to guinget, if they want to. Additionally, manifests from other sources will be extracted to their own "source\" folder. After copying the manifests, you'll be asked if you want to delete the temp files.

echo(
echo Windows PowerShell is required to run this script. Links are available in the System Requirements in the UXL Launcher README file here:  https://github.com/DrewNaylor/UXL-Launcher/blob/master/README.md#system-requirements
echo(

echo --------------------------------------
echo(

REM Start asking the user if they want to continue.
echo Would you like to continue running this script? Type "Yes" to continue, "no" to abort, or "README" to see the links for required software mentioned above. Currently update-manifests only supports the Master branch of Microsoft\winget-pkgs on GitHub.
set /p BUILDQUESTION=
If %BUILDQUESTION%==no exit cmd
If %BUILDQUESTION%==Yes goto start-building
If %BUILDQUESTION%==README start "" https://github.com/DrewNaylor/UXL-Launcher/blob/master/README.md#system-requirements

REM If the user types either README or something else that doesn't have a goto or exit command in the "If" line, clear
REM the screen and go back to the beginning of the script.
cls
goto beginning-of-script






:start-building
REM The code below here will be where the build starts.

REM Check if the temp folder exists.
IF NOT EXIST "%AppData%\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master" (
REM If it doesn't exist, create it.
mkdir "%AppData%\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master" )

cls
REM Set titlebar text to the downloading text:
title %DOWNLOADING_TITLE_BAR%
echo Downloading package from GitHub...
echo If you want to cancel, please use Ctrl+C.
REM powershell Invoke-WebRequest "https://github.com/Microsoft/winget-pkgs/archive/master.zip" -OutFile "$env:AppData\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master.zip" -UseBasicParsing

REM Check if the manifests folder exists.
IF EXIST "%AppData%\winget-frontends\source\winget-pkgs\pkglist\manifests" (
REM If it does exist, ask to delete.
cls
REM Set titlebar text to the deleting text:
title %DELETING_OLD_MANIFESTS_TITLE_BAR%
echo Deleting old manifests...
echo If you want to cancel, please use Ctrl+C.
echo This will remove the following folder and all subfolders:
rmdir /s "%AppData%\winget-frontends\source\winget-pkgs\pkglist\manifests"
)

echo(
cls
REM Set titlebar text to the extracting text:
title %EXTRACTING_TITLE_BAR%
echo Extracting package previously downloaded from GitHub...
echo If you want to cancel, please use Ctrl+C.
powershell Expand-Archive -Path "$env:AppData\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master.zip" -DestinationPath " '%AppData%\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master' " -Force
pause

echo(
cls
REM Set titlebar text to the copying text:
title %COPYING_TITLE_BAR%
echo Copying manifests folder from package...
echo If you want to cancel, please use Ctrl+C.
pause
robocopy /NFL /NDL /S "%AppData%\winget-frontends\source\winget-pkgs\temp\winget-pkgs-master\winget-pkgs-master\manifests" "%AppData%\winget-frontends\source\winget-pkgs\pkglist\manifests"
pause

REM Ask the user if they'd like to delete the items in the temp folder.
REM Check if the manifests folder exists.
IF EXIST "%AppData%\winget-frontends\source\winget-pkgs\temp" (
REM If it does exist, ask to delete.
cls
REM Set titlebar text to the deleting text:
title %DELETING_TEMP_FILES_TITLE_BAR%
echo Deleting temp files...
echo If you want to cancel, please use Ctrl+C.
echo Would you like to delete the temp files left from updating the manifests?
echo This will remove the following folder and all subfolders:
rmdir /s "%AppData%\winget-frontends\source\winget-pkgs\temp"
)

echo(

REM Set titlebar text back to the regular text:
title %REGULAR_TITLE_BAR%
echo Manifest update complete. Please refresh the package list in guinget to see the updated list.

pause

REM Set titlebar back to default.
title Command Prompt