# How to use guinget

## Refreshing package cache

Refreshing the package cache is done either by using the `Refresh cache` button on the toolbar or by using the `Package list>Refresh cache` menu item. You can also refresh the cache with `Ctrl+R`. At the moment, refreshing the cache is partially done using a batch script named `update-manifests.bat`, and it doesn't support running automatically yet (which is something I want to allow but it was kinda difficult), so it has prompts that ask for input. Extracting the package cache may take a while as PowerShell's `Expand-Archive` command is kinda slow, so eventually I'll probably use a command-line 7-zip EXE file to do it instead. May be a good idea to allow the user to choose to use an already-installed copy of 7-zip if they want to slim down guinget's installation.

After following the prompts in the script, you'll click `OK` in a message box to let it know that you're ready to load the package list. Loading the package list may take a bit, and you won't be able to interact with the window during that time. I want to allow the window to be moved and resized during this operation, but that's something I need to figure out how to do properly first.

## Marking a package

To mark a package, you can double-click or right-click on it and select `Action>Install`, open the `Package list` menu and select `Selected package>Action>Install`, open the combobox dropdown menu for the package in the `Action` column (may take a few clicks to open the dropdown), or move the cell selection over to the `Action` column and press `spacebar` then use the arrow keys to select `Install`. This also applies to marking a package for uninstallation, or for marking a package as one you want to ignore (ignoring is `Do nothing`).

## Marking multiple packages

To mark multiple packages, either select them with the mouse (using `Shift` and `Ctrl` like you would for a list of files) or select them using `Shift` and the arrow keys. After selecting the packages you want to mark, right-click on one of the selected packages and use the `Action` menu, or use the `Package list>Selected package>Action` menu, to mark them as you wish.

## Applying marked changes

Marked changes are applied using the `Apply changes` dialog, accessible through either the `Apply changes...` toolbar button or via `Package list>Apply changes...`. Batch package installs (and uninstalls, when that's supported) are not supported yet, so you'll have to either double-click or press `Enter` on each package in the list to install it when ready.

## Showing unfinished controls

Controls that don't yet have their features implemented are hidden by default, but you can show them if you wish. There are two ways to do this detailed as follows:
- The first way is temporary until the next application start, and involves clicking on a hidden label in the bottom-left corner of the About window.
- The second way is semi-permanent and involves opening the config file and changing the value for `HideUnfinishedControls` from `True` to `False`. This setting may not persist guinget updates, however.