# How to use guinget

[Homepage](index) &bull; [Back to usage guide](How-to-use)

## Refreshing package cache

### Updating with the built-in cache updater
As of guinget version 0.1 alpha, refreshing the cache no longer relies on `update-manifests.bat`. Instead, it uses a much faster set of code provided by `libguinget`. All you have to do is click the `Refresh cache` button on the toolbar or use the `Package list>Refresh cache` menu item. You can also refresh the cache with `Ctrl+R`. Once you've started the update, just wait for it to complete, and try again if there are issues.

Loading the package list and details will take a bit and may lock up slightly on slower systems, such as virtual machines. Additionally, please be aware that the main window cannot be moved while loading the package list and details, though this is something I want to allow.

### Updating with update-manifests.bat
`update-manifests.bat` is deprecated in version 0.1 alpha, but if you still wish to use it until support is removed, open the guinget config file and change `UseBuiltinCacheUpdater` from `True` to `False`. Please be aware that support for `update-manifests.bat` may be fully removed without notice at some point in the future. The following usage instructions are unchanged from when `update-manifests.bat` was the only way to update the package list.

Refreshing the package cache is done either by using the `Refresh cache` button on the toolbar or by using the `Package list>Refresh cache` menu item. You can also refresh the cache with `Ctrl+R`. At the moment, refreshing the cache is partially done using a batch script named `update-manifests.bat`, and it doesn't support running automatically yet (which is something I want to allow but it was kinda difficult), so it has prompts that ask for input. Extracting the package cache may take a while as PowerShell's `Expand-Archive` command is kinda slow, so eventually I'll probably use a command-line 7-zip EXE file to do it instead. May be a good idea to allow the user to choose to use an already-installed copy of 7-zip if they want to slim down guinget's installation.

After following the prompts in the script, you'll click `OK` in a message box to let it know that you're ready to load the package list. Loading the package list may take a bit, and you won't be able to interact with the window during that time. I want to allow the window to be moved and resized during this operation, but that's something I need to figure out how to do properly first.

## Marking a package

To mark a package, you can double-click or right-click on it and select `Action>Install`, open the `Package list` menu and select `Selected package>Action>Install`, open the combobox dropdown menu for the package in the `Action` column (may take a few clicks to open the dropdown), or move the cell selection over to the `Action` column and press `spacebar` then use the arrow keys to select `Install`. This also applies to marking a package for uninstallation, or for marking a package as one you want to ignore (ignoring is `Do nothing`).

Using the arrow keys to move the cell selection may not work sometimes, as I had some issue getting it to work during testing.

Please be aware that [the package context menu may appear in the wrong area](https://github.com/DrewNaylor/guinget/issues/14), though this was fixed in version 0.1.2.

**NB:** Version 0.1.2 moved the package-marking menu items from the `Package list` menu into the `Selected packages` menu, so you'll need to use the `Selected packages>Action` menu to mark as necessary.

## Marking multiple packages

To mark multiple packages, either select them with the mouse (using `Shift` and `Ctrl` like you would for a list of files) or select them using `Shift` and the arrow keys. After selecting the packages you want to mark, right-click on one of the selected packages and use the `Action` menu, or use the `Package list>Selected package>Action` menu, to mark them as you wish.

**NB:** Version 0.1.2 moved the package-marking menu items from the `Package list` menu into the `Selected packages` menu, so you'll need to use the `Selected packages>Action` menu to mark as necessary.

## Applying marked changes

Marked changes are applied using the `Apply changes` dialog, accessible through either the `Apply changes...` toolbar button or via `Package list>Apply changes...`. Batch package installs (and uninstalls, when that's supported) are not supported yet, so you'll have to either double-click or press `Enter` on each package in the list to install it when ready.

Starting in version 0.1.1, you can have packages install interactively with the `Install interactively (-i)` checkbox in the `Apply changes` window. This will persist across closing the window and restarting the application.

## Searching for packages

You can search for packages using the search bar in the toolbar at the top of the window. As of version 0.1 pre-alpha 2, this only filters the `Package` column, but other columns are planned to be supported. To search, either click in the textbox, press `Ctrl+F` to automatically set focus to it, or use `Package list>Search`. After typing in what you want to search for, either press `Enter` or click the `Search` toolbar button. Please be aware that [using `Ctrl+A` to select all packages in the search results currently selects even non-filtered packages](https://github.com/DrewNaylor/guinget/issues/13).

Before version 0.1.2, you had to manually clear the search box and search again to get back to the non-filtered package list, but as described below in the `New in Version 0.1.2` section, you can use `Esc`/`Escape` or the sidebar search term list's `All` entry. Once you've finished searching, you can press the `Tab` key to focus the package list again.

**NB:** Version 0.1.2 renamed the `Package list>Search` menu item to `Package list>Focus search box`.

### New in Version 0.1.2

You can search for all packages containing the last-selected package's ID using `Search for last-selected ID` in either the package context menu or from the `Selected packages` menu.

Searches are now re-run after a cache update if there's text in the search box, but you can turn that off by unchecking `Re-run search after cache update` in the `Options` window as described in the `Sidebar` section.

If you don't want to manually clear the search box, you can now use the `Esc`/`Escape` key instead.

#### Sidebar
By default, there's a sidebar that shows your search terms from the current session, but you can hide it with the `X` button in its top-right corner; using `View>Sidebar`; or by opening the `Options` window from `Package list>Search options`, unchecking `Show sidebar`, and clicking `OK`.

You can clear all search terms or only selected search terms from the search terms list using the context menu.

**NB:** It may take extra `Tab` presses to get back to the package list from the search bar when the sidebar is shown.

Double-clicking/pressing `Enter` on the `All` entry at the top of the sidebar search terms list returns you to an unfiltered list.

## Showing unfinished controls

Controls that don't yet have their features implemented are hidden by default, but you can show them if you wish. There are two ways to do this detailed as follows:
- The first way is temporary until the next application start, and involves clicking on a hidden label in the bottom-left corner of the About window.
- The second way is semi-permanent and involves opening the config file and changing the value for `HideUnfinishedControls` from `True` to `False`. This setting may not persist guinget updates, however.
