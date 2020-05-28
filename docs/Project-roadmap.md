# Version 0.1 Pre-Alpha 1

- [X] Update package list using temporary batch script
- [X] Load package list from cache
- [X] Display package details, some in columns and entire manifest in a textbox
- [X] Allow sorting by column
- [X] Marking package for install or ignoring package
- [ ] An option to run `winget source update` before updating guinget's package list cache, so they're both as up to date as possible
- [ ] Functionality for `File>Exit` and `Help>About`
- [ ] Hide controls that don't have features fully implemented, with a config option to show them

# Version 0.1 Pre-Alpha 2

- [ ] Make marking everything in the list for installation (or for doing nothing) an async operation, so it doesn't lock up the UI
- [ ] Pass the list of apps marked for installation to winget, so they can be installed
- [ ] Filtering/searching the package list (by name, id, and description for now, but maybe tags would be a good idea) and keeping these search terms in a listbox for quick use until closing guinget
- [ ] Filters for things that aren't the search feature, like `Status`, `Source` (package source; this'll be `Microsoft/winget-pkgs` on GitHub by default and for now), `Custom filters` (things like marked changes)
