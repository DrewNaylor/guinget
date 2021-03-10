# How to use guinget

[Homepage](https://drew-naylor.com/guinget)

This guide is up-to-date as of version 0.2. You can get here at any time from `Help>How to use guinget`, or by pressing `F1`. There's a video showing [how to use guinget](https://youtu.be/t2OhzNE4yj0) available if you prefer watching videos, but it only covers up to version 0.1.0.1.

[Version 0.1.3's usage guide](https://drew-naylor.com/guinget/How-to-use_0.1.3) is available if you need one for that version.

## Running guinget as administrator

Please don't run guinget as administrator in version 0.1.3 or higher, as winget seems to have an issue updating its sources when running elevated from an account that's not marked as `Administrator` in the `Settings` app (which is what guinget does if guinget itself is elevated). If you need to install a package with winget elevated (this sometimes seems to be necessary even if your account is an `Administrator`), please use the `Elevate winget with UAC` checkbox in the `Options: Apply Changes` window accessible from the `Options...` link label in the bottom-left corner of the `Apply changes` window as described in the `Installation options` section below. Be sure to use the `Update winget sources` menu item described in the `Updating winget sources` section below if winget complains that it can't find that package/package version, then try installing that package again.

Sometimes winget won't let you run it elevated from a non-`Administrator` account, so you'll just have to either give yourself temporary permissions to install certain packages that require elevation, or log into your `Administrator` account for those packages. Most people don't run Windows like this, but it's safer. The issue with winget not allowing you to elevate like this seems to be a general issue with Store apps, as I tested this with the Windows Terminal and ran into the same problem.

If you do want to run winget elevated, you'll have to first install it in your `Administrator` account, then install it in your regular user account if it's not already installed. This shouldn't be required once it's included with Windows.

Hopefully someday requiring winget to be run elevated won't be a problem, but it will be until then.

## Refreshing package cache

To refresh the cache, all you have to do is one of the following:
- Click the `Refresh cache` button on the toolbar
- Use the `Package list>Refresh cache` menu item
- Press `Ctrl+R`

Once you've started the update, just wait for it to complete, and try again if there are issues.

Loading the package list and details will take a bit and may lock up slightly on slower systems, such as virtual machines. Additionally, please be aware that the main window cannot be moved while loading the package list and details, though this is something I want to allow.

### Updating winget sources

Sometimes winget's sources will be out of date when you try to install something (even though it should automatically update before installation). If that's the case, you can update winget's sources without dropping into CMD using `Package list>Update winget sources`. This will run `winget source update`.

After it's finished, the window will stay open and you can close it. Currently it stays open just in case there's a problem that has to be fixed manually.

## Viewing package details

In addition to a few details in the package list, full package details are displayed in the textbox below the package list. By default, the last package selected will have its details shown, but you can change it so only the first package selected (when using multi-select) has its details shown by unchecking `Show last-selected package details when selecting multiple packages` in `Tools>Options...>Package Details`.

Please be aware that showing the last-selected package details might not work properly if you [use `Shift+Click` and the selection switches to go above the first-selected package as that makes it show the first-clicked package's details.](https://github.com/DrewNaylor/guinget/issues/42#issuecomment-716090028)

### Show in winget

You can show a single package's details in winget in a few ways:
- `Ctrl+W`
- Right-clicking on a package and clicking `Show in winget...`
- `Selected package>Show in winget...`

Please note this isn't available if more than one package is selected at once.

## Marking a package

Marking a package involves doing one of the following actions:
- Open the `Selected packages` menu or Double-click or right-click on a selected package and click one of these:
  - `Action: Install`
  - `Action: Uninstall`
  - `Action: Upgrade` (unfortunately there's no better character to have the accelerator on for "upgrade" than the letter "p" as far as I know)
- Press one of these keyboard shortcuts:
  - `Ctrl+I` for install (capital "i", in case it looks similar to a lowercase "L")
  - `Ctrl+U` for uninstall
  - `Ctrl+P` for upgrade
- Open the combobox dropdown menu for the selected package in the `Action` column (may take a few clicks to open the dropdown) and use one of these items in the list:
  - `Install`
  - `Uninstall`
  - `Upgrade`
- Move the cell selection over to the `Action` column with the arrow keys then press `spacebar`, then use the arrow keys to select `Install`, `Uninstall`, or `Upgrade`. Pressing `Enter` will move to the next package row.

This also applies to marking a package as one you want to ignore (ignoring is `Do nothing`). If you wish to unmark or ignore a package, press `Ctrl+D` or use `Action: Do nothing` in either the package context menu or the `Selected packages` menu. You can also use the combobox dropdown menu as described above.

Using the arrow keys to move the cell selection may not work sometimes, as I had some issue getting it to work during testing.

### Marking multiple packages

To mark multiple packages, use these instructions:
1. First, select them with the mouse (using `Shift` and `Ctrl` like you would for a list of files) or select them using `Shift` and the arrow keys. You might be able to use `Ctrl` and `spacebar` with the arrow keys, but that's untested.
2. After selecting the packages you want to mark, do one of the following to mark them as you wish:
  - Right-click on one of the selected packages and use `Action: (action)` menu items
  - Use the `Selected packages>Action: (action)` menu items
  - Press keyboard shortcuts to mark them as desired
  
Please refer to the `Marking a package` section for more details.

## Applying marked changes

Marked changes are applied using the `Apply changes` dialog, accessible through any of the following:
- The `Apply changes...` toolbar button
- `Package list>Apply changes...`
- Pressing `Ctrl+H` 

Using the `Confirm changes` button will bulk-apply all listed changes. Alternatively, you can apply one change at a time by double-clicking or pressing `Enter` on each package in the list to install, uninstall, or upgrade it when ready.

If you have issues with winget while applying changes, you can reset the status of some or all the packages by right-clicking on the list and selecting either `Reset status for selected package` or `Reset status for all packages` to reset the controls and packages to the `Ready` state to try again, perhaps with different options as described below.

In case there's a package you forgot was marked or had its status reset and you don't want to apply changes to that package again without unmarking it or installing packages individually, you can right-click on it and choose `Skip selected package`. Any package with the `Current status` of `Skip` will be ignored until the `Apply changes` window is re-opened or the status for that package is reset.

### Apply changes options

Options for `Apply changes` are accessible from both `Tools>Options...>Apply changes` and `Package list>Apply changes>Options... (linklabel)>Options: Apply Changes`. All the checkboxes that were in the `Apply changes` window are now in the `Options: Apply Changes` mini-form, and it now duplicates the `Apply changes` tab in the `Options` window for the most part.

The following `Apply changes` options are available:
- Running interactively: Check the `Run interactively (winget -i)` checkbox to have winget give you an interactive installer instead of an automated one. Even though this is usually used for installers, it should also work for uninstallers. Upgrades should work ok, too.
- Elevated winget: check the `Elevate winget with UAC` checkbox to run winget as an administrator. This may help for some packages that complain about not having permissions when installing them. 
  - Typically it's used in case you usually run Windows from a standard/limited user account and have an administrator account for system modification and application installation. 
  - Please note that some installations of Windows might not be compatible with this option as it sometimes says it can't run winget if it's started from an elevated CMD. The issue seems to be that it can have trouble running APPX/MSIX packages elevated.
  - Since this is one of the only reasons winget would need to be run elevated, **it's not recommended to run guinget as administrator as of version 0.1.3**.
- Specify version number...
  - `When installing`
  - `When uninstalling`
  - `When upgrading`
  - Note: Not specifying a version number will just use the latest version according to winget. You may want to use this when installing, but maybe not when upgrading or uninstalling as that may cause issues.
- Automatically open the mini-form
  - Mini-form text: `Automatically open this window when the Apply Changes window is opened`
  - Options window text: `Automatically open the mini Options window when the Apply Changes window is opened`
  
There are also two buttons at the bottom of the mini-form: `Defaults` and `Close`. `Close` just closes the window and `Defaults` sets all the checkboxes back to default. Please be aware that the settings are automatically saved after resetting the checkboxes, as this window is intended to have the option to leave it open when applying changes and stuff, unlike the regular `Options` window.

These will persist across closing the `Apply changes` window and restarting or upgrading guinget.

## Searching for packages

You can search for packages using the search bar in the toolbar at the top of the window. This only filters the `Package` column for now, but other columns are planned to be supported. To start a search, do one of the following:
- Click in the search textbox
- Press `Ctrl+F` to automatically set focus to it
- Use `Package list>Focus search box`

After typing in what you want to search for, either press `Enter` or click the `Search` toolbar button. Once you've finished searching, you can press `Ctrl+F` again to set focus back to the package list if the search box is still focused. Please be aware that [using `Ctrl+A` to select all packages in the search results currently selects even non-filtered packages](https://github.com/DrewNaylor/guinget/issues/13).

You can use `Esc`/`Escape` and press `Enter` or, as described below, double-click the sidebar search term list's `All` entry at the top to get back to the full package list.

`Search for package ID` in either the package context menu or in the `Selected packages` menu will, as the name implies, search for the package ID as long as only one package is selected. This won't be available if more than one package is selected at a time in version 0.1.3 and above.

### Sidebar
By default, there's a sidebar that shows your search terms from the current session, but you can hide it in a few ways:
- With the `X` button in its top-right corner
- Using `View>Sidebar`
- By unchecking the `Show sidebar` checkbox from `Tools>Options...>Layout`

Double-clicking/pressing `Enter` on the `All` entry at the top of the sidebar search terms list returns you to an unfiltered list.

You can clear all search terms or only selected search terms from the search terms list using the context menu. Please note that the `All` entry at the top will always be there and trying to remove it by clearing all search terms will put it back.

### Search options

Search options can be changed from the `Tools>Options...>Search` tab, though there's a shortcut to this tab available in the following ways:
- `Ctrl+Shift+F`
- `Package list>Search options...`
- `Search options...` from the `Search` toolbar button dropdown menu

Searches are now re-run after a cache update if there's text in the search box at the time of re-loading the package list, but you can turn that off by unchecking the `Re-run search after cache update` checkbox from the search options tab as described above.

By default, using the selected package ID search feature will do an exact match, but you can turn that off using the `Use exact match for selected package ID search` checkbox in the search options tab as described above.

## Edit winget settings

You can edit winget's settings using `Tools>Edit winget settings`. If you wish to edit winget's settings for an administrator account, use `Tools>Edit winget settings as admin (UAC)` instead. Both will run `winget settings`, with the second one running it elevated.

## Resetting guinget's options to default

If something breaks, you can use the `Defaults` button in the bottom-left corner of the `Options` window to reset everything, then click `OK` to save the default values. Some options like the one to hide unfinished controls and experimental stuff requires guinget to be restarted to take effect. Please be aware that if the guinget cache is what's broken, you'll have to manually delete it from `%AppData%\winget-frontends\source` for now. However, if winget's cache is broken, that may require resetting its sources from a command-line since there's no option for that in guinget yet.

## Switch tabs with mouse scroll wheel

You can switch tab control tabs like the ones in the `Options` window using the mouse scroll wheel, just like many Linux applications. This is provided by [libscrollswitchtabs](https://drew-naylor.com/drews-libs/libscrollswitchtabs-how-to-use.html).

## Showing unfinished controls

Controls that don't yet have their features implemented are hidden by default, but you can show them if you wish. Here's how to do this:
1. Uncheck `Hide unfinished controls and experimental stuff` from `Tools>Options...>Experimental`.
2. Reopen the tab.

You may need to restart guinget for this change to take full effect, though unchecking it should show everything without requiring a restart.

Version 0.1.3 also hides [experimental options](experimental-options) behind this feature, so you'll have to show experimental controls if you want to change experimental options. Please note that experimental options will stay active even if the controls are hidden again.
