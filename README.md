# guinget
Unofficial GUI for Microsoft's Windows Package Manager (winget). Kinda like Synaptic, but for Windows.

Not associated with Microsoft, and Microsoft does not endorse guinget.

Early screenshot:
![](/docs/images/screenshot.png?raw=true)

Even though it looks like the UI is complete, it's really not, and the package list is just a hard-coded example list (filled by clicking `File>Example package`) that's being used for testing until it's possible to load the real package list files used by winget. Additionally, the `Status` column cells just have arbitrary data for now; guinget doesn't check to see if an app is installed or not yet. The only thing that's being loaded from winget for now is the text in the package details textbox at the bottom.

TODO:
- Create graphical sources manager app, one that's kinda like Mintsources. May need a drop-down to select the primary source, since winget only uses one right now, but a list of sources would be a good idea to have at the same time.
- Create library that can be used by guinget (as well as other winget front-ends that want to use it) that makes it easier to get package info from winget.
- Everything that would make guinget a functional front-end.
- May need to fill in a bit for where winget lacks, such as the repo cache. As far as I know, it doesn't have a repo cache, so I'll have to do that manually (for stuff like package searching and listing available packages) and it can be something that other front-ends share, too. Would be a good idea to do what apt does with a lock file, though.
- Unless winget has this already, downloading a package installer without installing it would be a good addition. Maybe it could install to a configurable location or the user's Downloads folder, depending on what they want. Checking the SHA256 sum in guinget would be important for this feature.
