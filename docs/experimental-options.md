# Experimental options

[Homepage](index) &bull; [Back to usage guide](How-to-use)

This is a list of experimental options as of version 0.1.3, and they can all be configured from `Tools>Options...>Experimental`. To show the controls on this tab, first open the `About` window and click in the bottom-left corner, then re-open the `Options` window and go to the `Experimental` tab where the options will now be visible.

If something breaks, you can use the `Defaults` button in the bottom-left corner of the `Options` window to reset everything, then click `OK` to save the default values. Some options like the one to hide unfinished controls and experimental stuff requires guinget to be restarted to take effect. Please be aware that if the guinget cache is what's broken, you'll have to manually delete it from `%AppData%\winget-frontends\source` for now. However, if winget's cache is broken, that may require resetting its sources from a command-line since there's no option for that in guinget yet.

## Unfinished and experimental stuff

Checkbox text:
Hide unfinished controls and experimental stuff

Description:
Requires application restart. The rest of these options still apply even if this is on.

If unchecked, these options and other unfinished controls will remain visible even after restarting or upgrading guinget.

Defaults to `True`.

## Using winget's database file

Checkbox text:
Update and load package list from winget's default community database

Description:
This will ensure guinget only displays packages winget's default source knows about and may be faster in some cases. Details will still be loaded from manifests.

Defaults to `False`.

## Loading only latest versions

Checkbox text:
Load only the latest version of each package

Description:
Some packages may display a version number that's not really the latest version. Not sure how to fix this at the moment. Requires loading from the community database checkbox to be checked.

Defaults to `False`.

## Use 7-Zip

Checkbox text:
Use 7-Zip to extract manifests and database

Description:
7-Zip is Copyright (C) Igor Pavlov.<br>
7-Zip may extract faster than the .NET extractor, but it's not fully tested for this purpose.

7-Zip would be used by default if it weren't for the fact that not all computers have it and that I don't know how to really parse command-line output yet. The issue with not all computers having it could be worked around by bundling it with guinget, but I don't really want to do that because it's another dependency and would make the package larger.

Defaults to `False`.

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

Defaults to `False`.

## Search when typing

Instead of requiring you to press `Enter` or click `Search` on the toolbar, you can just wait a bit (325 milliseconds by default) for search to run automatically. This feature would probably have been a regular, non-experimental one had it been implemented sooner and not within a week of the expected release phase.

Defaults to `False`.

### Wait time (ms)

This is how long it'll wait after you finish typing before running a search (in milliseconds).<br>
Minimum value is `1`, and maximum value is `9999`.

Defaults to `325`.