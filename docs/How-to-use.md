# How to use guinget

## Refreshing package cache

To refresh the cache, all you have to do is one of the following:
- Click the `Refresh cache` button on the toolbar
- Use the `Package list>Refresh cache` menu item
- Press `Ctrl+R`

Once you've started the update, just wait for it to complete, and try again if there are issues.

Loading the package list and details will take a bit and may lock up slightly on slower systems, such as virtual machines. Additionally, please be aware that the main window cannot be moved while loading the package list and details, though this is something I want to allow.

## Marking a package

Marking a package involves doing one of the following actions:
- Double-click or right-click on a selected package and click `Action: Install`
- Open the `Selected packages` menu and click `Action: Install`
- Press `Ctrl+I` (capital "i", in case it looks similar to a lowercase "L")
- Open the combobox dropdown menu for the selected package in the `Action` column (may take a few clicks to open the dropdown)
- Move the cell selection over to the `Action` column with the arrow keys then press `spacebar`, then use the arrow keys to select `Install`. May need to press `Enter` to apply the choice.

This also applies to marking a package for uninstallation (once that's available), or for marking a package as one you want to ignore (ignoring is `Do nothing`).

If you wish to unmark or ignore a package, press `Ctrl+D` or use `Action: Do nothing` in either the package context menu or the `Selected packages` menu. You can also use the combobox dropdown menu as described above.

Using the arrow keys to move the cell selection may not work sometimes, as I had some issue getting it to work during testing.

## Marking multiple packages

To mark multiple packages, use these instructions:
1. First, select them with the mouse (using `Shift` and `Ctrl` like you would for a list of files) or select them using `Shift` and the arrow keys.
2. After selecting the packages you want to mark, do one of the following to mark them as you wish:
  - Right-click on one of the selected packages and use `Action: (action)` menu items
  - Use the `Selected package>Action: (action)` menu items
  - Press `Ctrl+I` to mark them all for install or `Ctrl+D` to unmark/ignore them
  
Please refer to the `Marking a package` section for more details.

## Applying marked changes

Marked changes are applied using the `Apply changes` dialog, accessible through any of the following:
- The `Apply changes...` toolbar button
- `Package list>Apply changes...`
- Pressing `Ctrl+H` 

Using the `Confirm changes` button will bulk-apply all listed changes. Alternatively, you can apply one change at a time by double-clicking or pressing `Enter` on each package in the list to install (or uninstall, when that's available) it when ready.

### Installation options

The following installation options are available:
- Interactive installation: check the `Interactive install (-i)` checkbox to have winget give you an interactive installer instead of an automated one.
- Elevated winget: check the `Elevate winget (UAC)` checkbox to run winget as an administrator. This may help for some packages that complain about not having permissions when installing them. 
  - Typically it's used in case you usually run Windows from a standard/limited user account and have an administrator account for system modification and application installation. 
  - Please note that Windows 10 version 2004 might not be compatible with this option as it sometimes elevates package installers when necessary and says it can't run winget if it's started from an elevated CMD.

These will persist across closing the `Apply changes` window and restarting or upgrading guinget.
Additionally, some options may also apply to actions like uninstallation.

## Searching for packages

You can search for packages using the search bar in the toolbar at the top of the window. As of version 0.1 pre-alpha 2, this only filters the `Package` column, but other columns are planned to be supported. To search, either click in the textbox, press `Ctrl+F` to automatically set focus to it, or use `Package list>Search`. After typing in what you want to search for, either press `Enter` or click the `Search` toolbar button. Please be aware that [using `Ctrl+A` to select all packages in the search results currently selects even non-filtered packages](https://github.com/DrewNaylor/guinget/issues/13).

Before version 0.1.2, you had to manually clear the search box and search again to get back to the non-filtered package list, but as described below in the `New in Version 0.1.2` section, you can use `Esc`/`Escape` or the sidebar search term list's `All` entry. Once you've finished searching, you can press the `Tab` key to focus the package list again.

**NB:** Version 0.1.2 renamed the `Package list>Search` menu item to `Package list>Filter search box`.

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
