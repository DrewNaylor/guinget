# Devlog based on readme

Early screenshot:
![](images/screenshot.png?raw=true)

Even though it looks like the UI is complete, it's really not, and the package list is just a hard-coded example list (filled by clicking `File>Example package`) that's being used for testing until it's possible to load the real package list files used by winget. Additionally, the `Status` column cells just have arbitrary data for now; guinget doesn't check to see if an app is installed or not yet. The only thing that's being loaded from winget for now is the text in the package details textbox at the bottom.

Just a few hours after this screenshot was taken, guinget gained the ability to load package names from a manually-downloaded copy of the sources package. To use it, for now you'll have to manually download and extract the [source MSIX package from Microsoft](https://winget.azureedge.net/cache/source.msix) and change the file path in the code, then re-compile. The database is stored in `Public\index.db` in this MSIX package.

Turns out that the YAML manifests are stored on the same server as `source.msix`. In the case of VLC, that's in `https://winget.azureedge.net/cache/manifests/VideoLAN/VLC/369c-3.0.10.yaml`. This probably varies between versions, but at least the location is known. I found this out by reading one of winget's log files.

Screenshot with more-complete UI (as of May 25, 2020), but with incomplete package list as the SQL isn't finished:
![](images/screenshot-morecompleteui_butincompletepkglist.png?raw=true)

Please note that some columns and panels were resized for the screenshot; it won't look exactly like this when it starts. winget may also output junk characters on occasion, usually when guinget first calls it but sometimes it can happen a few minutes later. Could be a result of winget re-downloading the package list. Might be a good idea to do a `String.Replace()` (replacing the weird characters with underscores or something that'll look like a progress bar like pound signs, perhaps? or maybe just replacing with `String.Empty`) on the output to get rid of `â–ˆ` and `â–’` as shown below:
![](images/screenshot-sometimes-winget-makes-a-mess-of-the-details.png?raw=true)

Turned out to be difficult to get information from the SQLite database file, so I'll probably just grab the YAML files from the `winget-pkgs` repo as a zip file instead.

Yeah, I've stopped using the SQLite database and started just reading from a package list cache stored in `%AppData%\winget-frontends\source\winget-pkgs\pkglist\manifests`, which is downloaded from `Microsoft\winget-pkgs` on GitHub. The `update-manifests.bat` script can be used to automate the downloading and updating of these manifests.

Screenshot as of the middle of the night on May 26/27th, 2020, featuring a mostly-complete package list from the YAML files:
![](images/screenshot-mostly-complete-packagelist.png?raw=true)

Loading these YAML files takes a bit at the moment, as it's not async. I'd like to make it async, but for now this is good enough. Besides, there's a progress bar and progress label at the bottom and a label that says "please wait", so it's not like the window shows nothing while it loads. One issue is the window can't be moved around while it loads, which is something async loading would fix. Something that's ended up making it faster is just loading details directly from the YAML files, bypassing `winget show -e` entirely.

Here's what it looks like when loading the package list:
![](images/screenshot-loading-progress.png?raw=true)

The data grid view that's used for the package list is hidden while loading so that things go faster. If the data grid view were still visible, it would show all the rows as they're added and slow things down until rows that aren't on screen are being added, at which point it would speed up a lot.