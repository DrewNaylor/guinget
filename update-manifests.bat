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

REM Set the titlebar text to the regular text:
title %REGULAR_TITLE_BAR%






:beginning-of-script
echo UXL Autobuild Script (or UAS) is provided to others free of charge and without warranty by Drew Naylor.
echo UAS Version %VERSIONNUMBER% Copyright 2016-2018 Drew Naylor.
echo Drew Naylor has no relation to Microsoft or GitHub.
echo UAS is not to be confused with other projects and software with a similar name.
echo If anything happens to your computer, Drew Naylor is not responsible. Use at your own risk.
echo Please visit https://github.com/DrewNaylor/UXL-Launcher/ for more information on UXL Launcher which is open source.
echo(

echo The purpose of UAS is to expediate the downloading, extracting, and building of UXL Launcher for developers or those who want to test the latest changes as soon as possible. Not recommended for end users who want stable software. UAS will use PowerShell to download a Zip file from github.com, extract it into a temp file in your user profile folder with PowerShell, and build the Visual Basic project file with MSBuild. 

echo(
echo Windows PowerShell, Microsoft Build Tools 2015 and Microsoft .Net Framework 4.6.1 are required to build and run this application. Links are available in the System Requirements in the README file here:  https://github.com/DrewNaylor/UXL-Launcher/blob/master/README.md#system-requirements
echo(

echo --------------------------------------
echo(

REM Start asking the user if they want to continue.
echo Would you like to continue running this script? Type "Yes" to continue, "no" to abort, or "README" to see the links for required software mentioned above. Currently UAS only supports the Master branch of UXL Launcher.
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

cls
REM Set titlebar text to the downloading text:
title %DOWNLOADING_TITLE_BAR%
echo Downloading package from GitHub...
powershell Invoke-WebRequest "https://github.com/DrewNaylor/UXL-Launcher/archive/master.zip" -OutFile "$env:TEMP\uxl-launcher-master.zip" -UseBasicParsing

echo(
REM Set titlebar text to the extracting text:
title %EXTRACTING_TITLE_BAR%
echo Extracting package previously downloaded from GitHub...
powershell Expand-Archive -Path "$env:TEMP\uxl-launcher-master.zip" -DestinationPath " 'C:\Users\%USERNAME%\0AppLauncherBuilds\uxl-master' " -Force


REM Decide which Program Files folder to run msbuild from based on which folders exist. Courtesy this 
REM Stack Overflow answer: <http://superuser.com/a/142416>

if defined ProgramFiles(x86) (
	REM If the PC has Program Files (x86), run msbuild from this folder.
   echo(
   REM Set titlebar text to the building text:
	title %BUILDING_TITLE_BAR%
	echo Building the VBProj file...
	echo(
	"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" "C:\Users\%USERNAME%\0AppLauncherBuilds\uxl-master\UXL-Launcher-master\UXL-Launcher\UXL-Launcher.vbproj"
	echo(

) else (
   REM If the PC only has Program Files, run msbuild from another folder.
   echo(
   REM Set titlebar text to the building text:
	title %BUILDING_TITLE_BAR%
	echo Building the VBProj file...
	echo(
	"C:\Program Files\MSBuild\14.0\Bin\MSBuild.exe" "C:\Users\%USERNAME%\0AppLauncherBuilds\uxl-master\UXL-Launcher-master\UXL-Launcher\UXL-Launcher.vbproj"
)


echo(

REM Set titlebar text to the running text:
title %RUNNING_TITLE_BAR%
echo Running the EXE file...
"C:\Users\%USERNAME%\0AppLauncherBuilds\uxl-master\UXL-Launcher-master\UXL-Launcher\bin\Debug\UXL-Launcher.exe"

REM Set titlebar back to default.
title Command Prompt