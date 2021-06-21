If you are reading this in Notepad or another text editor, it displays best in Word Wrap view. Click on Format>Word Wrap on the top bar. Notepad++ users will find it under View>Word wrap.


guinget -- Version 0.2.0.2 Alpha -- 4/06/2021 (MM/DD/YYYY).

If you have any trouble, you might be able to find an answer in the documentation. It's linked at the end of this readme file. If not, you can submit a bug report at the "Report a problem" link at the end of this readme file. Your report will be labeled by the developers accordingly in a reasonable amount of time.


MD5 checksums are not used for guinget as they are weaker than SHA-256. More details, though they're not as relevant to guinget:
https://github.com/DrewNaylor/UXL-Launcher/issues/124

You can use Windows PowerShell to confirm the hash of the main guinget EXE file by running
Get-FileHash .\guinget.exe -Algorithm SHA256 in the folder you extracted the archive to and comparing the output to my sum listed below. HowToGeek has a nice article on this:
https://www.howtogeek.com/67241/htg-explains-what-are-md5-sha-1-hashes-and-how-do-i-check-them/ , but the Windows section is a bit further down on the page.

The PowerShell method can be used for all files listed below, though you'll have to switch out the filenames.

SHA-256 sum for "guinget.exe" in the archive:
8740D634FE31B026F592D4AFE8170A48BFF87F30D5AE9DFDCC312606EACE078F

SHA-256 sum for "lib\libguinget.dll" in the archive:
EBD9CFC10B81185E47100FD53BCE9724C08543E038BDDB8B936E871A84ED99B4

SHA-256 sum for "lib\libscrollswitchtabs.dll" in the archive:
3F2741B885A3BDD03422E0346542BF4D13384A5287FD3BAF94D05C964ABECB92

SHA-256 sum for "update-manifests.bat" in the archive:
522392D92BC5E6AEE85DADCBB2D4A3F6A84BD3163A42DC72B7ABDCC7CA37CDE6

SHA-256 sum for "lib\YamlDotNet.dll" in the archive:
8AC0C1165E3857DD2685A2A1146F24597218AE2DF90BA5F15EA3BA76D0605A4B

The rest of the libraries in the "lib" folder are from Microsoft.Data.Sqlite and I don't want to list them all:
https://www.nuget.org/packages/Microsoft.Data.Sqlite/


----------------
GENERAL NOTES
~~~~~~~~~~~~~~~~

--> Some packages like CrystalDiskMark and LibreOffice may require administrative permissions to install, so you'll have to check the "Elevate winget with UAC" checkbox in the "Apply changes" window's mini-form version of Options accessible from the "Options..." linklabel before confirming changes. Please don't run guinget itself as an administrator for versions 0.1.3 and above.

Sometimes you'll have to update winget's sources as well since winget doesn't like updating its sources while elevated from a non-administrator account, so you can use "Package list>Update winget sources", or run "winget source update".

Some installations of Windows 10 might have issues with elevating winget, so in that case you'll have to hope it automatically elevates package installers, but I've had a problem with that in the past, and I'm not entirely sure how to fix it without just making yourself an Administrator.

--> Before running guinget, please extract the entire archive to an easy-to-access location. It won't work correctly if it's temporarily extracted without its config file ("guinget.exe.config") and helper libraries (everything in the "lib" folder). You don't have to do this if you used the installer.

--> Some documentation is available in the "/docs" folder included in this archive, while all of it is available online as linked below. Please be aware that it might not be comprehensive.

--> There are brief instructions on how to use guinget available in the "HOW TO USE" section below, with more detailed ones available in the usage guide (https://drew-naylor.com/guinget/How-to-use), in "How to use guinget.html" located in the "/docs" folder, or linked from "Help>How to use guinget".

--> Make sure to read the changelog included in this archive. There may be some documentation in this file that's not actually in the /docs (and online) documentation since I have a hard time making good documentation unless I know exactly what to talk about. The changelog does have markdown so that it looks nice on GitHub, but it shouldn't be too intrusive.

--> Version 0.1.2 and newer uses .NET Framework 4.8, so you'll have to install that as described in the System Requirements section if it's not already installed on your system. Windows 10 versions 1903 and newer already have this version of the .NET Framework installed, so you don't need to do anything in that case.

--> guinget uses YamlDotNet to read package manifests, and its license is available in "LICENSE-YamlDotNet.txt"

--> Reading SQLite databases is done using Microsoft.Data.Sqlite, which falls under the Apache License 2.0.

--> Switching tab control tabs with the mouse scroll wheel is provided by libscrollswitchtabs.

--> The source code should be included in this archive in a Zip file called "source-code.zip". Visual Studio 2019 is required to open this project as it uses NuGet packages, and there were changes in the past where older Visual Studio versions can't use newer NuGet packages or something.

--> If you find any bugs, please report them at the GitHub Issues page linked at the end of this document.

--> I am not responsible for any damage using my app may cause.

----------------
KNOWN ISSUES
~~~~~~~~~~~~~~~~

- Selecting all packages with Ctrl+A while searching will select every package, even the ones that aren't visible. (issue #13 https://github.com/DrewNaylor/guinget/issues/13)
- Applying changes with too many packages at once makes guinget lock up. (issue #57 https://github.com/DrewNaylor/guinget/issues/57)
- When displaying only the latest version of a package, some of them aren't really the latest version as shown in winget. (issue #63 https://github.com/DrewNaylor/guinget/issues/63)
- The "Action" column shrinks for a second the first time you mark a package in a session. (issue #94 https://github.com/DrewNaylor/guinget/issues/94)
- Running CMD from guinget on 64-bit Windows causes filesystem redirection to occur, resulting in anything that has to be launched from the "real" System32 not working correctly. (issue #98 https://github.com/DrewNaylor/guinget/issues/98)
- Shift+clicking makes it show the first-clicked item if the selection goes above the first-selected item. (issue #99 https://github.com/DrewNaylor/guinget/issues/99)
- If the Apply changes window is too low when you open the mini-form, the mini-form will be offscreen. (issue #101 https://github.com/DrewNaylor/guinget/issues/101)
- Installing just for your account works, but the uninstaller (using Inno Setup) doesn't seem to properly remove it for some versions of Windows 10. (issue #102 https://github.com/DrewNaylor/guinget/issues/102)

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

- Disk space, RAM, and CPU frequency minimum requirements are based on the .NET Framework 4.8 requirements. guinget itself is quite small, although some packages and the cache may take up more space.

------------
HOW TO USE
~~~~~~~~~~~~

A more-detailed usage guide is available in "docs/How to use guinget.html".

1. Extract this archive to a folder. There's an installer available if you want to use one, though it may be easier to run "winget install guinget", with the caveat that the version in winget may be outdated: https://github.com/DrewNaylor/guinget/releases/latest

2. Open the file titled "guinget.exe". I recommend making a shortcut to the app on your desktop or taskbar for easy access.

3. Refresh the package list cache using the "Refresh cache" button on the toolbar, choosing "Refresh cache" from the "Package list" menu, or by pressing "Ctrl+R".

4. Wait until the package list cache has been updated and the package details have been loaded. This may take a bit.

5. Mark the packages as you wish by right-clicking or double-clicking on them and selecting what you want them to be marked as using the "Action: (action)" items ("do nothing"/ignore, install, uninstall, or upgrade). For example, to mark a package to install, double-click on it and select "Action: Install".

You can also mark packages from the "Selected packages" menu, or by opening the package's combobox/dropdown in the "Action" column (may require a few clicks). This combobox/dropdown can also be activated by moving over to it with the arrow keys and pressing "space", though sometimes I have a bit of issue with this.

Each version of a package is listed as a separate package for now. I want to have it be like Synaptic where you open a different window to choose a different version of a package.

Search:
Searching is available, so you can use the search box to make finding packages faster. If you're showing the sidebar, you can double-click or press `Enter` on the `All` item at the top of the search terms list.

You can also search for all packages containing a specific package's ID using `Search for package ID`, either from the package context menu, or from the `Selected packages` menu.

After searching, you can press `Ctrl+F` a second time to focus the package list again.

By default, searches are re-done after updating the package list, although you can turn this off from the `Options` window under `Package list>Search options...`; uncheck `Re-run search after cache update` and click `OK`.

6. Once you've marked your packages, you can apply them by opening the "Apply changes" dialog, either from the toolbar or from the "Package list" menu.

7. guinget supports batch processing, so you can just click the "Confirm changes" button when ready. If you want to process packages one at a time, either press "Enter" or double-click on each package entry in the list when you want to start processing it.

If a package didn't (for example) install the first time, you can reset its status by right-clicking on it, clicking `Reset status for selected package`, change the `Apply changes` options via the linklabel in the bottom-left corner that says, `Options...`, and check the `Elevate winget with UAC` checkbox, then try again.

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
Version 0.2.0.2 Alpha
Copyright (C) 2020-2021 Drew Naylor. Licensed under Apache License 2.0.

Unofficial GUI for Microsoft's Windows Package Manager (winget).
Kinda like Synaptic, but for Windows. Not associated with either
Microsoft or the Synaptic project. Microsoft does not endorse guinget.
winget is Copyright (c) Microsoft Corporation. All rights reserved.

You can get the source code for guinget from
https://github.com/DrewNaylor/guinget

libguinget is used for things like loading the package list and uses the Apache License 2.0.
libguinget Copyright (C) 2020-2021 Drew Naylor.

libscrollswitchtabs is part of the drews-libs project and is used for switching tab control tabs using the mouse scroll wheel, just like in many Linux applications.
libscrollswitchtabs uses the Apace License 2.0 and you can get its source code here:
https://github.com/DrewNaylor/drews-libs
libscrollswitchtabs Copyright (C) 2020 Drew Naylor.

Microsoft.Data.Sqlite is used for loading the package list from an SQLite database and uses the Apache License 2.0. NuGet page for Microsoft.Data.Sqlite:
https://www.nuget.org/packages/Microsoft.Data.Sqlite/
Microsoft.Data.Sqlite Copyright (C) Microsoft Corporation. All rights reserved.

YamlDotNet is used to read manifests, which you can get the source code for here:
https://github.com/aaubry/YamlDotNet
YamlDotNet falls under the MIT license, which you can read a copy of below the Apache License summary.
YamlDotNet Copyright (c) 2008, 2009, 2010, 2011, 2012, 2013, 2014 Antoine Aubry and contributors

---------------------------------------------------------------

Apache License 2.0 summary as it applies to guinget, libguinget, libscrollswitchtabs, and Microsoft.Data.Sqlite:
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