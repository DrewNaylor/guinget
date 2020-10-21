# Project roadmap

## Version 0.1 Pre-Alpha 1

GitHub milestone:
https://github.com/DrewNaylor/guinget/milestone/1

- [X] Update package list using temporary batch script
- [X] Load package list from cache
- [X] Display package details, some in columns and entire manifest in a textbox
- [X] Allow sorting by column
- [X] Marking package (or multiple packages, if you wish) for install or ignoring package(s)
- [X] Passing a package id and version to winget for installation
  - Currently requires double-clicking or pressing "Enter" on a package in the Apply changes window, though eventually this won't be required and you'll be able to do batch installs.
  - For now, a CMD window displaying winget's output is shown, but eventually this output will be displayed in a textbox below the list of packages in the Apply changes window.
- [X] Don't hang if we can't find the package manifest cache ([issue #8](https://github.com/DrewNaylor/guinget/issues/8))
- [ ] ~~An option to run `winget source update` before updating guinget's package list cache, so they're both as up to date as possible~~
  - Probably unimportant, since winget will just update its sources on installing an app anyway.
- [X] Functionality for `File>Exit` and `Help>About`
- [X] Hide controls that don't have features fully implemented, with a config option to show them
  - It's also possible to click a hidden label in the bottom-left corner of the About window to show hidden controls until next time guinget is opened.

## Version 0.1 Pre-Alpha 2

GitHub milestone:
https://github.com/DrewNaylor/guinget/milestone/2

- [ ] ~~Allow the user to hide the progress bar and status label for loading so loading the package list goes faster~~ **The problem was having a text label updating; a progress bar is fine.**
- [X] Filtering/searching the package list (by id for now, but maybe name, description, and tags would be a good idea for a future version)
- [X] Dramatically speed up marking lots of packages at once by turning off auto-size columns while marking packages if we're marking an excessive amount at once, like 25 packages for example

## Version 0.1 Alpha

GitHub milestone:
https://github.com/DrewNaylor/guinget/milestone/3

- [ ] ~~Use 7z.exe (7-Zip CLI) for extracting the manifests instead of PowerShell Extract-Archive to speed things up~~ **Since this version will default to a built-in updater, it probably wouldn't be a good idea to work more on update-manifests.bat as this version will deprecate update-manifests.bat**
- [X] Default to using the built-in updater, which uses the .Net `ZipFile` class for extraction, so it's much faster
- [X] Deprecate `update-manifests.bat`
- [ ] ~~Make marking everything in the list for installation (or for doing nothing) an async operation, so it doesn't lock up the UI~~ **While this is a good idea, it might not be a problem for now since this operation has already gotten way faster in version 0.1 pre-alpha 2.**

## Version 0.1.1 Alpha

- [X] Allow choosing whether to install packages interactively or just to have installers run silently with progress, which is the default ([issue #26](https://github.com/DrewNaylor/guinget/issues/26))

## Version 0.1.2 Alpha

GitHub milestone: [Version 0.1.2](https://github.com/DrewNaylor/guinget/milestone/4)

- [X] Re-do searches after updating manifests ([issue #27](https://github.com/DrewNaylor/guinget/issues/27))
- [X] Keep search terms in a listbox for quick use until closing guinget
- [X] Hide sidebar tab control tabs and use a dropdown to switch between them ([issue #22](https://github.com/DrewNaylor/guinget/issues/22))
- [X] Add a button to the top-right of the sidebar to close it and a menu item to determine if the sidebar should be shown on application startup ([issue #21](https://github.com/DrewNaylor/guinget/issues/21))

## Version 0.1.3 Alpha

- [ ] Allow batch installing of packages ([issue #30](https://github.com/DrewNaylor/guinget/issues/30))
- [ ] Check whether a package is currently installed ([issue #23](https://github.com/DrewNaylor/guinget/issues/23))
- [ ] Allow packages to be re-installed (also issue #23)

## Version 0.1.4 Alpha

- [ ] Allow users to show only packages that are listed in the SQLite database file, so that entries aren't duplicated with multiple versions (showing only the latest version may take longer to figure out as all the versions are in the database file) ([issue #35](https://github.com/DrewNaylor/guinget/issues/35))

## Version 0.1.5 Alpha

- [ ] Allow searching through things like friendly name, description, and tags
- [ ] Filters for things that aren't the search feature, like `Status`, `Source` (package source; this'll be `Microsoft/winget-pkgs` on GitHub by default and for now), `Custom filters` (things like marked changes)
- [ ] Show number of packages marked for changes, like Synaptic

## Version 0.2 Beta

- [ ] Load the package list and package details async so that the UI doesn't lock up
<br>Seems like this page has some good ideas on how to do this:
https://stackoverflow.com/questions/570537/update-label-while-processing-in-windows-forms

## Some later version

- [ ] If the user wants to, allow batch package installs to go through the package list in the Apply changes window individually rather than passing them all to winget at once
