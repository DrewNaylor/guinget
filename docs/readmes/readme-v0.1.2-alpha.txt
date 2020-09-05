If you are reading this in Notepad or another text editor, it displays best in Word Wrap view. Click on Format>Word Wrap on the top bar. Notepad++ users will find it under View>Word wrap.


guinget -- Version 0.1.2 Alpha -- 8/3/2020 (MM/DD/YYYY).

If you have any trouble, you might be able to find an answer in the documentation. It's linked at the end of this readme file. If not, you can submit a bug report at the "Report a problem" link at the end of this readme file. Your report will be labeled by the developers accordingly in a reasonable amount of time.


MD5 checksums are not used for guinget as they are weaker than SHA-256. More details, though they're not as relevant to guinget:
https://github.com/DrewNaylor/UXL-Launcher/issues/124

You can use Windows PowerShell to confirm the hash of the main guinget EXE file by running
Get-FileHash .\guinget.exe -Algorithm SHA256 in the folder you extracted the archive to and comparing the output to my sum listed below. HowToGeek has a nice article on this:
https://www.howtogeek.com/67241/htg-explains-what-are-md5-sha-1-hashes-and-how-do-i-check-them/ , but the Windows section is a bit further down on the page.

The PowerShell method can be used for all files listed below, though you'll have to switch out the filenames.

SHA-256 sum for "guinget.exe" in the archive:
77BE11957E22E4A3341F0D671E510981E7E7D45794FA89B861133EA71241A170

SHA-256 sum for "lib\libguinget.dll" in the archive:
BE071A6B17AE209E0242777A7385250BD549E697B69F5B73425FDF597C6D971D

SHA-256 sum for "update-manifests.bat" in the archive:
AFA421669D4856FB9136656B97CD2098478B1FE67AD5CB2326DA5A8BDA4BD36A

SHA-256 sum for "lib\YamlDotNet.dll" in the archive:
632E1C37E67E5BE46766FFC9ED7790C22D1FE75A5B83AAB9EC4C0678414E5B82

The rest of the libraries in the "lib" folder are from Microsoft.Data.Sqlite and I don't want to list them all:
https://www.nuget.org/packages/Microsoft.Data.Sqlite/


----------------
GENERAL NOTES
~~~~~~~~~~~~~~~~

--> Some packages like CrystalDiskMark and LibreOffice may require administrative permissions to install, so you'll have to run guinget as an administrator.

--> Before running guinget, please extract the entire archive to an easy-to-access location. It won't work correctly if it's temporarily extracted without its config file ("guinget.exe.config") and helper libraries (everything in the "lib" folder). You don't have to do this if you used the installer.

--> Some documentation is available in the "/docs" folder included in this archive, while all of it is available online as linked below. Please be aware that it's not comprehensive by any means.

--> There are brief instructions on how to use guinget available in the "HOW TO USE" section below.

--> Make sure to read the changelog included in this archive. There may be some documentation in this file that's not actually in the /docs (and online) documentation since I have a hard time making good documentation unless I know exactly what to talk about. The changelog does have markdown so that it looks nice on GitHub, but it shouldn't be too intrusive.

--> Version 0.1.2 and newer uses .NET Framework 4.8, so you'll have to install that as described in the System Requirements section if it's not already installed on your system. Windows 10 versions 1903 and newer already have this version of the .NET Framework installed, so you don't need to do anything in that case.

--> guinget uses YamlDotNet to read package manifests, and its license is available in "LICENSE-YamlDotNet.txt"

--> Reading SQLite databases (if turned on) is done using Microsot.Data.Sqlite, which falls under the Apache License 2.0.

--> The source code should be included in this archive in a Zip file called "source-code.zip". Visual Studio 2019 is required to open this project as it uses NuGet packages, and there were changes in the past where older Visual Studio versions can't use newer NuGet packages or something.

--> If you find any bugs, please report them at the GitHub Issues page linked at the end of this document.

--> I am not responsible for any damage using my app may cause.

----------------
KNOWN ISSUES
~~~~~~~~~~~~~~~~

- Selecting all packages with Ctrl+A while searching will select every package, even the ones that aren't visible. (issue #13 https://github.com/DrewNaylor/guinget/issues/13 )

See all known issues: https://github.com/DrewNaylor/guinget/labels/known%20issue

--------------------
SYSTEM REQUIREMENTS
~~~~~~~~~~~~~~~~~~~~

To run guinget, your computer requires the following:

- Microsoft .NET Framework 4.8 https://dotnet.microsoft.com/download/dotnet-framework/net48
  - Click "Download .NET Framework 4.8 Runtime" under the "Runtime" header on the right near the top. Note that this is the web installer and it'll download its components after it's opened. May take a while to download.
  - This is only required for Windows versions older than Windows 10 1903, except for Windows 8.0 as it doesn't support that version.
  
- winget https://github.com/microsoft/winget-cli/releases/latest
  - I personally installed from there, but there are other methods you could use instead: https://github.com/microsoft/winget-cli#installing-the-client
  
- Windows versions: Windows 10 version 1903 or higher recommended.
  - guinget has only been tested on Windows 10 versions 1803, 1903, 1909, and 2004. Windows 7 SP1, 8.1, and all other versions of Windows 10 are untested although they might work for everything that's not directly reliant on winget, such as installing packages.
  - As .NET Framework 4.8 doesn't appear to be compatible with Windows 8.0, guinget version 0.1.2 or newer may not work on that version of Windows.
  - winget requires Windows 10 version 1709 or greater.
  
- Architectures: x86 (32-bit) and x64 (64-bit). May also work on Windows 10 on ARM as a 32-bit application, though that's untested.

- Hardware requirements: 
  - Minimum: At least a 1.2 GHz CPU; 1 GB of RAM or more.
  - Recommended: At least a 2.5 GHz dual-core CPU; 2 GB of RAM or more.
  - The recommended may not be enough in some cases to prevent lockups when loading the package list and details, but it should be ok.
  
- Disk space:
  - 32-bit: 5 GB space free
  - 64-bit: 5 GB space free
  
- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in guinget due to Visual Studio building problems, but VS2019 doesn't seem to have the setting that tends to cause issues anyway. There may also be a warning message on first start about Windows Defender SmartScreen saying it "prevented an unrecognized app from starting. Running this app might put your PC at risk." You can click the "More info" link, then the "Run anyway" button if you want to use it, though this may not be allowed on corporate networks.

- Disk space, RAM, and CPU frequency minimum requirements are based on the .NET Framework 4.8 requirements. guinget itself is quite small, although some packages may take up more space.

------------
HOW TO USE
~~~~~~~~~~~~

A more-detailed usage guide is available in "docs/How to use guinget.html".

1. Extract this archive to a folder. There's an installer available if you want to use one, though it may be easier to run "winget install guinget", with the caveat that the version in winget may be outdated: https://github.com/DrewNaylor/guinget/releases/latest

2. Open the file titled "guinget.exe". I recommend making a shortcut to the app on your desktop or taskbar for easy access.

3. Refresh the package cache using the "Refresh cache" button on the toolbar, choosing "Refresh cache" from the "Package list" menu, or by pressing "Ctrl+R".

4. Wait until the package list cache has been updated and the package details have been loaded. This may take a bit.

5. Mark the packages as you wish by right-clicking or double-clicking on them and selecting what you want them to be marked as from the "Action" submenu (either install or "do nothing"/ignore for now).

You can also mark packages from the "Selected packages>Action" menu, or by opening the package's combobox/dropdown in the "Action" column (may require a few clicks). This combobox/dropdown can also be activated by moving over to it with the arrow keys and pressing "space", though sometimes I have a bit of issue with this.

Each version of a package is listed as a separate package for now. I want to have it be like Synaptic where you open a different window to choose a different version of a package.

Search:
Searching is available, so you can use the search box to make finding packages faster. At the moment, you'll have to manually clear the search box (either with `Backspace` or `Escape`) and search again to get back to the non-filtered package list. If you're showing the sidebar, you can double-click or press `Enter` on the `All` item at the top of the search terms list.

You can also search for all packages containing a specific package's ID using `Search for last-selected ID`, either from the package context menu, or from the `Selected packages` menu.

After searching, you can use the `Tab` key to focus the package list again, although this may take several `Tab`s if the sidebar is shown.

By default, searches are re-done after updating the package list, although you can turn this off from the `Options` window under `Package list>Search options...`; uncheck `Re-run search after cache update` and click `OK`.

6. Once you've marked your packages, you can apply them by opening the "Apply changes" dialog, either from the toolbar or from the "Package list" menu.

7. guinget doesn't support batch installs (or uninstalls, but uninstalls aren't supported by winget yet, either) yet, so you'll have to either press "Enter" or double-click on each package entry in the list when you want to start installing it.

----------------------------------
CONTACT AND COPYRIGHT/LICENSING
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Drew's Main Website:      		https://drew-naylor.com/
Drew's GitHub profile:     		https://github.com/DrewNaylor
guinget GitHub repository:		https://github.com/DrewNaylor/guinget
Report a problem:	  			https://github.com/DrewNaylor/guinget/issues/new
Check for updates:				https://github.com/DrewNaylor/guinget/releases/latest
guinget documentation:			https://github.com/DrewNaylor/guinget/docs
guinget website:				https://drew-naylor.com/guinget/
The website has most of the important documentation presented in a cleaner way than just a list of files, but it's not finished yet.

Email:                    		drewnaylor_apps -AT- outlook.com




guinget
Version 0.1.2.0 Alpha
Copyright (C) 2020 Drew Naylor. Licensed under Apache License 2.0.

Unofficial GUI for Microsoft's Windows Package Manager (winget).
Kinda like Synaptic, but for Windows. Not associated with either
Microsoft or the Synaptic project. Microsoft does not endorse guinget.

You can get the source code for guinget from
https://github.com/DrewNaylor/guinget

libguinget is used for things like loading the package list and uses the Apache License 2.0.

Microsoft.Data.Sqlite is used for loading the package list from an SQLite database and uses the Apache License 2.0. NuGet page for Microsoft.Data.Sqlite:
https://www.nuget.org/packages/Microsoft.Data.Sqlite/

YamlDotNet is used to read manifests, which you can get the source code for here:
https://github.com/aaubry/YamlDotNet
YamlDotNet falls under the MIT license, which you can read a copy of below the Apache License summary.

---------------------------------------------------------------

Apache License 2.0 summary as it applies to guinget, libguinget, and Microsoft.Data.Sqlite:
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

---------------------------------------------------------------

MIT license as it applies to YamlDotNet:
Copyright (c) 2008, 2009, 2010, 2011, 2012, 2013, 2014 Antoine Aubry and contributors

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.