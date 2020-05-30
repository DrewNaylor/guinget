# Version 0.1 Pre-Alpha 1

- [X] Update package list using temporary batch script
- [X] Load package list from cache
- [X] Display package details, some in columns and entire manifest in a textbox
- [X] Allow sorting by column
- [X] Marking package (or multiple packages, if you wish) for install or ignoring package(s)
- [X] Passing a package id and version to winget for installation
  - Currently requires double-clicking or pressing "Enter" on a package in the Apply changes window, though eventually this won't be required and you'll be able to do batch installs.
  - For now, a CMD window displaying winget's output is shown, but eventually this output will be displayed in a textbox below the list of packages in the Apply changes window.
- [ ] An option to run `winget source update` before updating guinget's package list cache, so they're both as up to date as possible
- [ ] Functionality for `File>Exit` and `Help>About`
- [ ] Hide controls that don't have features fully implemented, with a config option to show them

# Version 0.1 Pre-Alpha 2

- [ ] Make marking everything in the list for installation (or for doing nothing) an async operation, so it doesn't lock up the UI
- ~~[ ] Allow the user to hide the progress bar and status label for loading so loading the package list goes faster~~
  - The problem was having a text label updating; a progress bar is fine.
- [ ] Pass the list of apps marked for installation to winget, so they can be installed
- [ ] Filtering/searching the package list (by name, id, and description for now, but maybe tags would be a good idea) and keeping these search terms in a listbox for quick use until closing guinget
- [ ] Filters for things that aren't the search feature, like `Status`, `Source` (package source; this'll be `Microsoft/winget-pkgs` on GitHub by default and for now), `Custom filters` (things like marked changes)
