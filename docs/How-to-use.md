# How to use guinget

This guide is up-to-date as of version 0.1.3. [Version 0.1.2's usage guide](https://github.com/DrewNaylor/guinget/blob/master/docs/How-to-use_0.1.2.md) isn't as refined, but it only describes features that are in version 0.1.2.

## Refreshing package cache

To refresh the cache, all you have to do is one of the following:
- Click the `Refresh cache` button on the toolbar
- Use the `Package list>Refresh cache` menu item
- Press `Ctrl+R`

Once you've started the update, just wait for it to complete, and try again if there are issues.

Loading the package list and details will take a bit and may lock up slightly on slower systems, such as virtual machines. Additionally, please be aware that the main window cannot be moved while loading the package list and details, though this is something I want to allow.

## Updating winget sources

Sometimes winget's sources will be out of date when you try to install something (even though it should automatically update before installation). If that's the case, you can update winget's sources without dropping into CMD using one of the choices below:
- `Package list>Update winget sources`
- `Ctrl+U` (or whatever it is; be sure to put that in here)

After it's finished, the window will stay open and you can close it. Currently it stays open just in case there's a problem that has to be fixed manually.

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

If you have issues with winget while applying changes, you can close and reopen the `Apply changes` window to reset the controls and packages to the `Ready` state to try again, perhaps with different options as described below.

### Installation options

The following installation options are available:
- Interactive installation: check the `Interactive install (-i)` checkbox to have winget give you an interactive installer instead of an automated one.
- Elevated winget: check the `Elevate winget (UAC)` checkbox to run winget as an administrator. This may help for some packages that complain about not having permissions when installing them. 
  - Typically it's used in case you usually run Windows from a standard/limited user account and have an administrator account for system modification and application installation. 
  - Please note that Windows 10 version 2004 might not be compatible with this option as it sometimes elevates package installers when necessary and says it can't run winget if it's started from an elevated CMD.
  - Since this is one of the only reasons winget would need to be run elevated, **it's not recommended to run guinget as administrator as of version 0.1.3**.

These will persist across closing the `Apply changes` window and restarting or upgrading guinget.
Additionally, some options may also apply to actions like uninstallation.

## Searching for packages

You can search for packages using the search bar in the toolbar at the top of the window. This only filters the `Package` column for now, but other columns are planned to be supported. To start a search, do one of the following:
- Click in the search textbox
- Press `Ctrl+F` to automatically set focus to it
- Use `Package list>Focus search box`

After typing in what you want to search for, either press `Enter` or click the `Search` toolbar button. Once you've finished searching, you can press the `Tab` key to focus the package list again. If the sidebar is showing, it may take a few times to get back to the list and I don't know how to fix that. Please be aware that [using `Ctrl+A` to select all packages in the search results currently selects even non-filtered packages](https://github.com/DrewNaylor/guinget/issues/13).

You can use `Esc`/`Escape` and press `Enter` or, as described below, double-click the sidebar search term list's `All` entry at the top to get back to the full package list.

`Search for package ID` in either the package context menu or in the `Selected packages` menu will, as the name implies, search for the package ID as long as only one package is selected. This won't be available if more than one package is selected at a time in version 0.1.3 and above.

### Sidebar
By default, there's a sidebar that shows your search terms from the current session, but you can hide it in a few ways:
- With the `X` button in its top-right corner
- Using `View>Sidebar`
- By unchecking the `Show sidebar` checkbox from `Tools>Options...>Layout`

You can clear all search terms or only selected search terms from the search terms list using the context menu.

**NB:** It may take extra `Tab` presses to get back to the package list from the search bar when the sidebar is shown as mentioned previously.

Double-clicking/pressing `Enter` on the `All` entry at the top of the sidebar search terms list returns you to an unfiltered list.

### Search options

Search options can be changed from the `Tools>Options...>Search` tab, though there's a shortcut to this tab available in the following ways:
- `Ctrl+Shift+F`
- `Package list>Search options...`
- `Search options...` from the `Search` toolbar button dropdown menu

Searches are now re-run after a cache update if there's text in the search box at the time of re-loading the package list, but you can turn that off by unchecking the `Re-run search after cache update` checkbox from the search options tab as described above.

By default, using the selected package ID search feature will do an exact match, but you can turn that off using the `Use exact match for selected package ID search` checkbox in the search options tab as described above.

## Showing unfinished controls

Controls that don't yet have their features implemented are hidden by default, but you can show them if you wish. Here's how to do this:
1. Click the hidden label in the bottom-left corner of the About window.
2. (Optional) Uncheck `Hide unfinished controls and experimental stuff` from `Tools>Options...>Experimental` if you wish to keep these controls visible the next time guinget starts and across updates.

Version 0.1.3 also hides experimental options behind this feature, so you'll have to show experimental controls if you want to change experimental options. Please note that experimental options will stay active even if the controls are hidden again.
