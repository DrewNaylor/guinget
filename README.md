# guinget
Unofficial GUI for Microsoft's Windows Package Manager (winget). Kinda like Synaptic, but for Windows.

TODO:
- Create graphical sources manager app, one that's kinda like Mintsources. May need a drop-down to select the primary source, since winget only uses one right now, but a list of sources would be a good idea to have at the same time.
- Create library that can be used by guinget (as well as other winget front-ends that want to use it) that makes it easier to get package info from winget.
- Everything that would make guinget a functional front-end.
- May need to fill in a bit for where winget lacks, such as the repo cache. As far as I know, it doesn't have a repo cache, so I'll have to do that manually (for stuff like package searching and listing available packages) and it can be something that other front-ends share, too. Would be a good idea to do what apt does with a lock file, though.
