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

- [ ] ~~Allow the user to hide the progress bar and status label for loading so loading the package list goes faster~~ **The problem was having a text label updating; a progress bar is fine.**
- [X] Filtering/searching the package list (by id for now, but maybe name, description, and tags would be a good idea for a future version)
- [X] Dramatically speed up marking lots of packages at once by turning off auto-size columns while marking packages if we're marking an excessive amount at once, like 25 packages for example

## Version 0.1 Alpha

- [ ] Allow batch installing of packages
- [ ] ~~Make marking everything in the list for installation (or for doing nothing) an async operation, so it doesn't lock up the UI~~ **While this is a good idea, it might not be a problem for now since this operation has already gotten way faster in version 0.1 pre-alpha 2.**

## Version 0.2 Beta

- [ ] Keep search terms in a listbox for quick use until closing guinget
- [ ] Filters for things that aren't the search feature, like `Status`, `Source` (package source; this'll be `Microsoft/winget-pkgs` on GitHub by default and for now), `Custom filters` (things like marked changes)
- [ ] Show number of packages marked for changes, like Synaptic
- [ ] Allow filtering by things like name, description, and tags