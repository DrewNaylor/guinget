# guinget
Unofficial GUI for Microsoft's Windows Package Manager (winget). Kinda like Synaptic, but for Windows.

TODO:
- Create graphical sources manager app, one that's kinda like Mintsources. May need a drop-down to select the primary source, since winget only uses one right now, but a list of sources would be a good idea to have at the same time.
- Create library that can be used by guinget (as well as other winget front-ends that want to use it) that makes it easier to get package info from winget.
- Everything that would make guinget a functional front-end.
- May need to fill in a bit for where winget lacks, such as the repo cache. As far as I know, it doesn't have a repo cache, so I'll have to do that manually (for stuff like package searching and listing available packages) and it can be something that other front-ends share, too. Would be a good idea to do what apt does with a lock file, though.
- Unless winget has this already, downloading a package installer without installing it would be a good addition. Maybe it could install to a configurable location or the user's Downloads folder, depending on what they want. Checking the SHA256 sum in guinget would be important for this feature.
- Package search should be done by filtering the datagridview control's entries. This would have an option to filter when typing or only on Enter/on clicking Search. Entry filtering can also allow for showing just apps to be installed, to be removed, of specific categories (whenever that's officially supported by winget), etc.
- Might be possible to directly read from the same database file as winget reads from; that is, https://winget.azureedge.net/cache/source.msix. This would require using SQLite to read the database inside "Public\index.db" in the MSIX package, but it should be possible I hope. Had some issues so far with EntityFramework not wanting to install when installing System.Data.Sqlite from Nuget. May require increasing .Net version.
- Although it's probably unsupported by winget, maybe an alternate-functionality mode could directly use YAML files in the official repo to reduce how much would need to be downloaded. This could probably be a "Virtual Source", as it's not a database file and is only being used by guinget for search and listing.
