# guinget
Unofficial GUI for Microsoft's Windows Package Manager (winget). Kinda like Synaptic, but for Windows.

Not associated with Microsoft, and Microsoft does not endorse guinget.
Not associated with the Synaptic project, either.

Visual Studio 2019 Community is being used for this project.

Early screenshot:
![](/docs/images/screenshot.png?raw=true)

Even though it looks like the UI is complete, it's really not, and the package list is just a hard-coded example list (filled by clicking `File>Example package`) that's being used for testing until it's possible to load the real package list files used by winget. Additionally, the `Status` column cells just have arbitrary data for now; guinget doesn't check to see if an app is installed or not yet. The only thing that's being loaded from winget for now is the text in the package details textbox at the bottom.

Just a few hours after this screenshot was taken, guinget gained the ability to load package names from a manually-downloaded copy of the sources package. To use it, for now you'll have to manually download and extract the [source MSIX package from Microsoft](https://winget.azureedge.net/cache/source.msix) and change the file path in the code, then re-compile. The database is stored in `Public\index.db` in this MSIX package.

Turns out that the YAML manifests are stored on the same server as `source.msix`. In the case of VLC, that's in `https://winget.azureedge.net/cache/manifests/VideoLAN/VLC/369c-3.0.10.yaml`. This probably varies between versions, but at least the location is known. I found this out by reading one of winget's log files.

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
