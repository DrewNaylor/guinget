# Experimental options

This is a list of experimental options as of version 0.1.3, and they can all be configured from `Tools>Options...>Experimental`. To show the controls on this tab, first open the `About` window and click in the bottom-left corner, then re-open the `Options` window and go to the `Experimental` tab where the options will now be visible.

## Unfinished and experimental stuff

Checkbox text:
Hide unfinished controls and experimental stuff

Description:
Requires application restart. The rest of these options still apply even if this is on.

If unchecked, these options and other unfinished controls will remain visible even after restarting or upgrading guinget.

Defaults to `True`.

## Using winget's database file

Checkbox text:
(Experimental) Update and load package list from winget's default community database

Description:
This will ensure guinget only displays packages winget's default source knows about and may be faster in some cases. Details will still be loaded from manifests.

Defaults to `False`.

## Loading only the latest package versions

Checkbox text:
(Experimental) Load only the latest version of each package

Description:
Some packages may display a version number that's not really the latest version. Not sure how to fix this at the moment. Requires loading from the community database checkbox to be checked.

Defaults to `False`.

## Use 7-Zip for extraction

Checkbox text:
(Experimental) Use 7-Zip to extract manifests and database

Description:
7-Zip is Copyright (C) Igor Pavlov.
7-Zip may extract faster than the .NET extractor, but it's not fully tested for this purpose.

7-Zip would be used by default if it weren't for the fact that not all computers have it and that I don't know how to really parse command-line output yet. The issue with not all computers having it could be worked around by bundling it with guinget, but I don't really want to do that because it's another dependency and would make the package larger.

Defaults to `False`.

### 7z.exe path

`7z.exe` is used when using 7-Zip to extract the manifests and database. Not everyone has `7z.exe` installed to `"C:\Program Files\7-Zip\7z.exe"`, so you can change that here, with a `Browse` dialog for convenience.

Defaults to `"C:\Program Files\7-Zip\7z.exe"`.

## Use Robocopy for copying

Checkbox text:
(Experimental) Use Robocopy to copy manifests and database

Description:
Robocopy is Copyright (C) Microsoft Corporation. All rights reserved.
Robocopy may copy faster than the .NET copier, but it's not fully tested for this purpose.

If it weren't for Wine not having Robocopy by default and me not really understanding how to parse output from command-line programs yet, this would be checked by default since it's so much faster.

Defaults to `False`.