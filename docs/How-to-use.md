# How to use guinget

[Homepage](https://drew-naylor.com/guinget)

This guide is up-to-date as of version 0.3. You can get here at any time from `Help>How to use guinget`, or by pressing `F1`. There's a video showing [how to use guinget](https://youtu.be/t2OhzNE4yj0) available if you prefer watching videos, but it only covers up to version 0.1.0.1.

[Version 0.2.0.2's usage guide](https://drew-naylor.com/guinget/How-to-use_0.2.0.2) is available if you need one for that version. Version 0.2.0.3 only backported fixes, so a new usage guide wasn't required.

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

### Refresh cache options

Some options are available to modify the behavior when refreshing the cache. They're listed below and accessible from `Tools>Options...>Refresh Cache`.

- `Delete temporary files after cache update` checkbox
  - Temporary files are always deleted before refreshing the cache.
- `Load only the latest version of each package` checkbox
  - Some packages may display a version number that's not really the latest version. Not sure how to fix this at the moment.
  - Requires loading from the community database checkbox to be checked, which it will be unless it was turned off in a previous version and the zip file version of guinget is used, or it's turned off manually from the config file. If it's off, you can use the `Defaults` button in the bottom-left of the `Options` window to turn it back on.
	
#### Notes on loading from the database

- The package list will be loaded using the same SQLite database as winget uses by default, located at https://winget.azureedge.net/cache/source.msix. As briefly mentioned above, this still relies on the manifests to get the package details as those aren't directly available in the database.
- Each package version is listed as a separate entry even when loading from the database, though using the database will make sure only packages winget can display right now are shown.
- Loading the details may still take a bit as we have to take the package ID and version number and figure out where its manifest is, instead of just grabbing all the manifests and loading from them. In case we can't find a package's manifest, we'll just look through all the manifests until we find the right one. Figuring out where each package's manifest is stored is done in three ways:
  - If forming a path using the package ID and version according to the manifest format v1 finds a file that exists, then that's great and we'll use that file. This is the fastest method.
  - If that doesn't work, then we only replace the first instance of the "." in the ID and try again with the rest. This should be fast, too.
  - If neither of those work, then we fall back to looking for manifests with the package's ID in their filename immediately followed by ".yaml", opening each file match we find, checking the package version in the file, and if it's a match, we use it. Otherwise we keep going until we find the manifest. The Visual Studio profiler says there's a lot of garbage collection going on, so this will probably need to be changed to something like Using to keep automatic garbage collection to a minimum.

### Updating winget sources

Sometimes winget's sources will be out of date when you try to install something (even though it should automatically update before installation). If that's the case, you can update winget's sources without dropping into CMD using `Package list>Update winget sources`. This will run `winget source update`.

After it's finished, the window will stay open and you can close it. Currently it stays open just in case there's a problem that has to be fixed manually.

An elevated winget session does pick up the source updates done from a non-elevated user account if you have a standard/limited account you usually use and a separate one for administrative activity, so it should work fine if you use that menu item then install a package with winget elevated by guinget.

## Viewing package details

In addition to a few details in the package list, full package details are displayed in the textbox below the package list. By default, the last package selected will have its details shown, but you can change it so only the first package selected (when using multi-select) has its details shown by unchecking `Show last-selected package details when selecting multiple packages` in `Tools>Options...>Package List + Details`.

Links in the package details textbox can be clicked, which will open a confirmation dialog asking you if you want to visit the page.

Please be aware that showing the last-selected package details might not work properly if you [use `Shift+Click` and the selection switches to go above the first-selected package as that makes it show the first-clicked package's details.](https://github.com/DrewNaylor/guinget/issues/99)

### Show in winget

You can show a single package's details in winget in a few ways:
- `Ctrl+W`
- Right-clicking on a package and clicking `Show in winget...`
- `Selected package>Show in winget...`

Please note this isn't available if more than one package is selected at once.

## Marking a package

Marking a package involves doing one of the following actions:
- Open the `Selected packages` menu or double-click or right-click on a selected package and click one of these:
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

Please be aware that using `Uninstall` and `Upgrade` may require the corresponding experimental features to be on in winget if they're not already available by default.

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
  - MSIX packages like Windows Terminal might not install properly if your account used for administrative actions is logged out at the moment.
  - The account used for administrative actions must have winget installed, so what you'll probably have to do is this if it's not already installed:
    1. Log into your administrator account.
    2. Download and install winget in your administrator account.
    3. Log back into your regular account.
    4. Download and install winget in your regular account (if you don't, it won't be able to run for some reason).
    5. Make sure winget still runs in both an elevated and non-elevated CMD window (just `winget` should be enough).
    6. Update winget's sources, perhaps using `Package list>Update winget sources`, or manually type `winget source update` in CMD. For some reason, winget doesn't update its sources if it's running elevated from a non-administrator account.
    7. Now you can use the `Elevate winget (UAC)` checkbox.
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

## Showing available upgrades

If `list` and `upgrade` are available in winget and they're set to on, you can use `View>Available upgrades...` to run `winget upgrade` and display packages that can be updated. For the moment, Store apps aren't supported in guinget, so you'll have to upgrade those manually through a command line or the Store itself.

## Showing installed packages

By default, `View>Installed packages...` opens the `Apps & features` Settings app page if possible, or the Control Panel's `Programs and Features` page if it's not. You can change this to a few different things using `Tools>Options...>Apps and UIs`. The available choices in the `Installed packages` dropdown are as follows:

- `Settings app: Apps & features (default)`
- `CMD: winget list`
- `Control Panel: Programs and Features`

Please note that the `winget list` option requires the `list` experimental feature to be set to on in winget's config file if it's not already a default feature.

## Importing and exporting packages

You can import and export the list of packages from the respective menu items under `File`. `Ctrl+O` and `Ctrl+S` are also available as keyboard shortcuts for import and export, respectively.

Support for configuring which (if any) import and export flags are passed to winget will be added in a future version of guinget.

## Searching and filtering for packages

You can search for packages using the search bar in the toolbar at the top of the window. This only filters the `Package` column for now, but other columns are planned to be supported. To start a search, do one of the following:
- Click in the search textbox
- Press `Ctrl+F` to automatically set focus to it
- Use `Package list>Focus search box`

After typing in what you want to search for, either press `Enter` or click the `Search` toolbar button. Once you've finished searching, you can press `Ctrl+F` again to set focus back to the package list if the search box is still focused. Please be aware that [using `Ctrl+A` to select all packages in the search results currently selects even non-filtered packages](https://github.com/DrewNaylor/guinget/issues/13). That's not a problem if you mark all the ones you've selected in the search as we only mark visible packages.

You can use `Esc`/`Escape` and press `Enter` or, as described below, double-click the sidebar search term list's `All` entry at the top to get back to the full package list.

`Search for package ID` in either the package context menu or in the `Selected packages` menu will, as the name implies, search for the package ID as long as only one package is selected. This won't be available if more than one package is selected at a time in version 0.1.3 and above.

### Sidebar

By default, there's a sidebar that shows your search terms from the current session and other filters, but you can hide it in a few ways:
- With the `X` button in its top-right corner
- Using `View>Sidebar`
- By unchecking the `Show sidebar` checkbox from `Tools>Options...>Layout`

You can double-click or press `Enter` on any of the items in the various sidebar lists to filter/search based on which list is being shown in the dropdown at the top.

Double-clicking/pressing `Enter` on the `All` entry at the top of the sidebar search terms list/filters lists returns you to an unfiltered list.

### Sidebar: `Search terms` list

You can clear all search terms or only selected search terms from the search terms list using the context menu. Please note that the `All` entry at the top will always be there and trying to remove it by clearing all search terms will put it back.

### Sidebar: `Action` filters

This list has filters that correspond to the `Action` column to make it easier to change how packages are marked or to simply view them, kinda like Synaptic.

### Search options

Search options can be changed from the `Tools>Options...>Search` tab, though there's a shortcut to this tab available in the following ways:
- `Ctrl+Shift+F`
- `Package list>Search options...`
- `Search options...` from the `Search` toolbar button dropdown menu

The available options are as follows:
- `Re-run search after cache update` checkbox
  - Searches are now re-run after a cache update if there's text in the search box at the time of re-loading the package list, but you can turn that off if desired.
- `Use exact match for selected package ID search` checkbox
  - By default, using the selected package ID search feature will do an exact match, but you can turn that off if you want.
- `Search when typing` checkbox
  - Searches are performed after a configurable wait time with no typing that defaults to 325 milliseconds. You can change the wait time with the number box below the `Search when typing` checkbox. Minimum value for wait time is `1`, and maximum value is `9999`.
  
## Validating manifests

`Tools>Validate manifest...` displays a window that allows you to enter or browse for a manifest to validate so that you don't have to use as many commands if you don't want to. 

By default, it uses a folder browse window for use with multi-file manifests, but you can check the `Browse for singleton manifest` checkbox below the textbox to use a file open dialog, which will let you select a single-file manifest.

When you're ready for validation, simply click the `Validate` button at the bottom-right and the manifest will be passed to winget with output displayed in CMD.

"In Soviet Russia, manifest validates you."

## Edit winget settings

You can edit winget's settings using `Tools>Edit winget settings`. If you wish to edit winget's settings for an administrator account, use `Tools>Edit winget settings as admin (UAC)` instead. Both will run `winget settings`, with the second one running it elevated.

If the default JSON file type editor differs between your limited account and the administrator account, the settings file will open in different programs when editing winget settings as admin. Changing the default when logged into the other account will change it in this situation as well.

## Resetting guinget's options to default

If something breaks, you can use the `Defaults` button in the bottom-left corner of the `Options` window to reset everything, then click `OK` to save the default values. Some options like the one to hide unfinished controls and experimental stuff may require guinget to be restarted to take full effect. Please be aware that if the guinget cache is what's broken, you can use the `Delete cache files in Local AppData` button under `Tools>Options...>Maintenance`. However, if winget's cache is broken, that may require resetting its sources from a command-line since there's no option for that in guinget yet.

## Maintenance

Some maintenance-related buttons are available under `Tools>Options...>Maintenance`:

- `Delete cache files in Roaming`
  - Older versions of guinget stored their cache files in %AppData% instead of %LocalAppData%. You can delete them with this button, if you wish.
- `Delete cache files in Local AppData`
  - You can delete the cache files guinget uses with this button if you want to have a clean uninstall or if you're having issues. These files are stored in %LocalAppData%.
  
Eventually this tab will be moved to a sources manager app. If a particular folder doesn't exist, the button to delete it won't be available.

## Running CMD

In case there's something you need to drop into a terminal for, you can do it with `File>Run CMD`. There's also a way to run it elevated using `File>Run CMD elevated (UAC)`. There are keyboard shortcuts for both, the non-elevated one being `Ctrl+Alt+T` and the elevated one being `Ctrl+Alt+Shift+T`.

Please be aware that [running CMD from guinget on 64-bit Windows causes filesystem redirection to occur, resulting in anything that has to be launched from the "real" System32 not working correctly](https://github.com/DrewNaylor/guinget/issues/98). This shouldn't impact most people, but it will if you need to run something like `SystemPropertiesProtection.exe`. The only workaround I can offer is to just run CMD from the Start menu or something else instead. I could tell Windows to run CMD from `SysNative`, but that doesn't work when running it elevated since it just crashes. A real solution would be to compile a 64-bit version of guinget, but that's a little too much to manage.

## KDE-style fast resize

By default, guinget uses KDE-style fast resize to keep things responsive. This works by temporarily replacing the package list with a screenshot of itself, which is then stretched until you're done resizing the window. 

One side-effect of this is that the package list will flicker after moving the window because moving a window counts as resizing it. Not sure how to make it only use the fast resizing during an actual resize and not a move. Additionally, any windows above the package list will show up in the screenshot while resizing it. Not sure how to prevent that from happening, but it's not really that big of an issue.

This is on by default, and can be turned off by unchecking the `Use KDE-style fast resize for the package list so that resizing the window is smooth when there are a lot of packages listed` checkbox under `Tools>Options...>Package List + Details`. Doing so will return to standard Windows-style resizing behavior.

## Switch tabs with mouse scroll wheel

You can switch tab control tabs like the ones in the `Options` window using the mouse scroll wheel, just like in many Linux applications. This is provided by [libscrollswitchtabs](https://drew-naylor.com/drews-libs/libscrollswitchtabs-how-to-use.html).

## Showing unfinished controls

Controls that don't yet have their features implemented are hidden by default, but you can show them if you wish. Here's how to do this:
1. Uncheck `Hide unfinished controls and experimental stuff` from `Tools>Options...>Experimental`.
2. Click `OK`.

You may need to restart guinget for this change to take full effect.

Version 0.1.3 and newer also hide [experimental options](experimental-options) behind this feature, so you'll have to show experimental controls if you want to change experimental options. Please note that experimental options will stay active even if the controls are hidden again.