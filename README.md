# guinget
Unofficial GUI for Microsoft's Windows Package Manager (winget). Kinda like Synaptic, but for Windows.

Not associated with Microsoft, and Microsoft does not endorse guinget.
Not associated with the Synaptic project, either.

Master branch build status:<br>
[![Master branch build status](https://ci.appveyor.com/api/projects/status/ec0r3vwr0wmvtc23/branch/master?svg=true)](https://ci.appveyor.com/project/DrewNaylor/guinget/branch/master)

Visual Studio 2019 Community is being used for this project's development, and .Net Framework 4.6.1 or greater is required to run it. YAML files are being read with [YamlDotNet](https://github.com/aaubry/YamlDotNet), which uses the MIT license.

There's a [project roadmap](./docs/Project-roadmap.md) available, if you want to read it.

Screenshot as of the middle of the night on May 26/27th, 2020, featuring a mostly-complete package list from the YAML files:
![](/docs/images/screenshot-mostly-complete-packagelist.png?raw=true)

Packages displayed here are loaded from a package list cache stored in `%AppData%\winget-frontends\source\winget-pkgs\pkglist\manifests`, which is downloaded from `Microsoft\winget-pkgs` on GitHub. The `update-manifests.bat` script can be used to automate the downloading and updating of these manifests.

Loading these YAML files takes a bit at the moment, as it's not async. I'd like to make it async, but for now this is good enough. Besides, there's a progress bar and progress label at the bottom and a label that says "please wait", so it's not like the window shows nothing while it loads. One issue is the window can't be moved around while it loads, which is something async loading would fix. Something that's ended up making it faster is just loading details directly from the YAML files, bypassing `winget show -e` entirely.

Here's what it looks like when loading the package list:
![](/docs/images/screenshot-loading-progress.png?raw=true)

The data grid view that's used for the package list is hidden while loading so that things go faster. If the data grid view were still visible, it would show all the rows as they're added and slow things down until rows that aren't on screen are being added, at which point it would speed up a lot.

Currently, the `Status` column cells just have arbitrary data for now; guinget doesn't check to see if an app is installed or not yet. Package details in the textbox at the bottom are loaded directly from the YAML files.

More screenshots available in the [devlog](./docs/devlog.md). This document has a few things similar to the readme, but organized more by date and what I tried to do/did do around each time.

TODO:
- Create graphical sources manager app, one that's kinda like Mintsources. May need a drop-down to select the primary source, since winget only uses one right now, but a list of sources would be a good idea to have at the same time.
- Create library that can be used by guinget (as well as other winget front-ends that want to use it) that makes it easier to get package info from winget.
- Everything that would make guinget a functional front-end.
- May need to fill in a bit for where winget lacks, such as the repo cache. As far as I know, it doesn't have a repo cache, so I'll have to do that manually (for stuff like package searching and listing available packages) and it can be something that other front-ends share, too. Would be a good idea to do what apt does with a lock file, though.
- Unless winget has this already, downloading a package installer without installing it would be a good addition. Maybe it could install to a configurable location or the user's Downloads folder, depending on what they want. Checking the SHA256 sum in guinget would be important for this feature.
- Package search should be done by filtering the datagridview control's entries. This would have an option to filter when typing or only on Enter/on clicking Search. Entry filtering can also allow for showing just apps to be installed, to be removed, of specific categories (whenever that's officially supported by winget), etc.
- Might be possible to directly read from the same database file as winget reads from; that is, https://winget.azureedge.net/cache/source.msix. This would require using SQLite to read the database inside "Public\index.db" in the MSIX package, but it should be possible I hope. Had some issues so far with EntityFramework not wanting to install when installing System.Data.Sqlite from Nuget. May require increasing .Net version.
- Although it's probably unsupported by winget, maybe an alternate-functionality mode could directly use YAML files in the official repo to reduce how much would need to be downloaded. This could probably be a "Virtual Source", as it's not a database file and is only being used by guinget for search and listing. Unless this is supported by Microsoft in winget, it may not necessarily match what winget displays.
- To make it easier for other frontends to use and update the package list, maybe have it be saved to a folder like "winget-frontends-pkglist", and in that folder there will be folders with the name of each configured source, containing the package list files in there.
- Ensuring this folder doesn't get messed up by a frontend while another one is running, have a file named "frontend.lock" in the root of "winget-frontends-pkglist" that both prevents other frontends from running when that file exists as well as storing the frontend's name for easy identification in other frontends that are being prevented from running, if they want to display the name of the app that's preventing them from running.
- "winget-frontends-pkglist" could be stored in the user's AppData folder. Having the location be configurable to be on a USB drive instead for example may make things confusing and result in frontends becoming incompatible or having the incorrect information if they choose to use a different location.
- Remember that winget allows installing from a manifest passed to it. This may be useful to allow for the user to select a manifest to install from the File menu, for example. Might also be possible to use this feature to have winget use the YAML manifests downloaded from Microsoft's `winget-pkgs` repo instead of the default one in winget, as well.
