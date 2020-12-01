# Experimental options

[Homepage](https://drew-naylor.com/guinget) &bull; [Back to usage guide](https://drew-naylor.com/guinget/How-to-use)

This is a list of experimental options as of version 0.1.3, and they can all be configured from `Tools>Options...>Experimental`. To show the controls on this tab, first open the `About` window and click in the bottom-left corner, then re-open the `Options` window and go to the `Experimental` tab where the options will now be visible.

If something breaks, you can use the `Defaults` button in the bottom-left corner of the `Options` window to reset everything, then click `OK` to save the default values. Some options like the one to hide unfinished controls and experimental stuff requires guinget to be restarted to take effect. Please be aware that if the guinget cache is what's broken, you'll have to manually delete it from `%AppData%\winget-frontends\source` for now. However, if winget's cache is broken, that may require resetting its sources from a command-line since there's no option for that in guinget yet.

## Unfinished and experimental stuff

Checkbox text:
Hide unfinished controls and experimental stuff

Description:
Requires application restart. The rest of these options still apply even if this is on.

If unchecked, these options and other unfinished controls will remain visible even after restarting or upgrading guinget.

Defaults to `True`/checked.

## Using winget's database file

Checkbox text:
Update and load package list from winget's default community database

Description:
This will ensure guinget only displays packages winget's default source knows about and may be faster in some cases. Details will still be loaded from manifests.

Notes:
- The package list will be loaded using the same SQLite database as winget uses by default, located at https://winget.azureedge.net/cache/source.msix. This still relies on the manifests to get the package descriptions as those aren't directly available in the database, though.
- Each package version is listed as a separate entry even when loading from the database, though using the database will make sure only packages winget can display right now are shown.
- Some packages may be in a different order compared to loading all the manifests at once, but this shouldn't be much of an issue, and clicking the Package column header should sort them as expected.
- Loading the descriptions may still take a bit as we have to take the package ID and version number and figure out where its manifest is, instead of just grabbing all the manifests and loading from them. In case we can't find a package's manifest, we'll just look through all the manifests until we find the right one. Figuring out where each package's manifest is stored is done in three ways:
  - If replacing all instances of "." in the package ID and appending the package version to the end of the path along with ".yaml" finds a file that exists, then that's great and we'll use that file. This is the fastest method.
  - If that doesn't work, then we only replace the first instance of the "." in the ID and try again with the version thing. This should be fast, too.
  - If neither of those work, then we fall back to looking for manifests with the package's version number in their filename, opening each file match we find, checking the package ID in the file, and if it's a match, we use it. Otherwise we keep going until finding the manifest. At the moment, this doesn't check to make sure that a file exists, so it may crash if it can't find a matching manifest. The Visual Studio profiler says there's a lot of garbage collection going on as well, so this will probably need to be changed to something like Using to keep automatic garbage collection to a minimum.
- You may need to manually delete the package list cache located in `%AppData%\winget-frontends\source` before using the database as it may get confused if the manifest directory (`winget-pkgs`) exists but the database one (`winget-db`) doesn't. This'll be changed when loading from the database is officially supported.

Defaults to `False`/unchecked.

## Loading only latest versions

Checkbox text:
Load only the latest version of each package

Description:
Some packages may display a version number that's not really the latest version. Not sure how to fix this at the moment. Requires loading from the community database checkbox to be checked.

Defaults to `False`/unchecked.

## Use 7-Zip

Checkbox text:
Use 7-Zip to extract manifests and database

Description:
7-Zip is Copyright (C) Igor Pavlov.<br>
7-Zip may extract faster than the .NET extractor, but it's not fully tested for this purpose.

7-Zip would be used by default if it weren't for the fact that not all computers have it and that I don't know how to really parse command-line output yet. The issue with not all computers having it could be worked around by bundling it with guinget, but I don't really want to do that because it's another dependency and would make the package larger.

If 7-Zip can't be found in what's set in the 7z.exe path, extraction will fail.

Defaults to `False`/unchecked.

### 7z.exe path

`7z.exe` is used when using 7-Zip to extract the manifests and database. Not everyone has `7z.exe` installed to `"C:\Program Files\7-Zip\7z.exe"`, so you can change that here, with a `Browse` dialog for convenience.

Defaults to `"C:\Program Files\7-Zip\7z.exe"`.

## Use Robocopy

Checkbox text:
Use Robocopy to copy manifests and database

Description:
Robocopy is Copyright (C) Microsoft Corporation. All rights reserved.<br>
Robocopy may copy faster than the .NET copier, but it's not fully tested for this purpose.

If it weren't for Wine not having Robocopy by default and me not really understanding how to parse output from command-line programs yet, this would be checked by default since it's so much faster.

Defaults to `False`/unchecked.

## Notes on using 7-Zip and Robocopy

During testing on my laptop, using 7-Zip and Robocopy reduced the cache updating time from 1 minute 40 seconds to about 1 minute 4 seconds.

Closing guinget before the cache update is completed if using Robocopy and/or 7-Zip will leave those programs open and you'll have to close them manually. This should be changed in a future version to automatically close them when closing guinget.

## Search when typing

Instead of requiring you to press `Enter` or click `Search` on the toolbar, you can just wait a bit (325 milliseconds by default) for search to run automatically. This feature would probably have been a regular, non-experimental one had it been implemented sooner and not within a week of the expected release phase.

Defaults to `False`/unchecked.

### Wait time (ms)

This is how long it'll wait after you finish typing before running a search (in milliseconds).<br>
Minimum value is `1`, and maximum value is `9999`.

Defaults to `325`.

## HiDPI Mode

For now, only doubles the height of items in the package list.
May eventually be expanded to cover the rest of the controls that are difficult to use on HiDPI devices.

Defaults to `False`/unchecked.

## Default source name

In case the default source for winget is renamed, you can change it so guinget still works. This is used when passing packages to winget to do things like show or install them, because it gets confused when a package is available in multiple sources and there are multiple sources active. One affected package is Windows Terminal.

Defaults to `"winget"`.