# Experimental options

[Homepage](https://drew-naylor.com/guinget) &bull; [Back to usage guide](https://drew-naylor.com/guinget/How-to-use)

This is a list of experimental options as of version 0.2, and they can all be configured from `Tools>Options...>Experimental`. To show the controls on this tab, first uncheck the `Hide unfinished controls and experimental stuff` checkbox on the `Tools>Options...>Experimental` tab, then click `OK`. You may need to restart guinget for this change to take full effect, though unchecking it should show everything without requiring a restart.

If something breaks, you can use the `Defaults` button in the bottom-left corner of the `Options` window to reset everything, then click `OK` to save the default values. Some options like the one to hide unfinished controls and experimental stuff requires/may require guinget to be restarted to take full effect. Please be aware that if the guinget cache is what's broken, you can use the `Delete cache files in Local AppData` button under `Tools>Options...>Maintenance`. However, if winget's cache is broken, that may require resetting its sources from a command-line since there's no option for that in guinget yet.

## Hide unfinished controls and experimental stuff

Config file setting name:
`HideUnfinishedControls`

Description:
May require application restart to take full effect. The rest of these options still apply even if this is on.

If unchecked, these options and other unfinished controls will remain visible even after restarting or upgrading guinget.

Defaults to `True`/checked.

## Use 7-Zip to extract manifests and database

Config file setting name:
`Use7zipForExtraction`

Description:
7-Zip is Copyright (C) Igor Pavlov.<br>
7-Zip may extract faster than the .NET extractor, but it's not fully tested for this purpose.

7-Zip would be used by default if it weren't for the fact that not all computers have it and that I don't know how to really parse command-line output yet. The issue with not all computers having it could be worked around by bundling it with guinget, but I don't really want to do that because it's another dependency and would make the package larger.

If 7-Zip can't be found in what's set in the 7z.exe path, extraction will fail.

Defaults to `False`/unchecked.

### 7z.exe path

Config file setting name:
`PathTo7zip`

`7z.exe` is used when using 7-Zip to extract the manifests and database. Not everyone has `7z.exe` installed to `"C:\Program Files\7-Zip\7z.exe"`, so you can change that here, with a `Browse` dialog for convenience.

If the path contains `://`, it'll be reset to default.

Defaults to `"C:\Program Files\7-Zip\7z.exe"`.

## Use Robocopy to copy manifests and database

Config file setting name:
`UseRobocopyForCopying`

Description:
Robocopy is Copyright (C) Microsoft Corporation. All rights reserved.<br>
Robocopy may copy faster than the .NET copier, but it's not fully tested for this purpose.

If it weren't for Wine not having Robocopy by default and me not really understanding how to parse output from command-line programs yet, this would be checked by default since it's so much faster.

Defaults to `False`/unchecked.

## Notes on using 7-Zip and Robocopy

During testing on my laptop, using 7-Zip and Robocopy reduced the cache updating time from 1 minute 40 seconds to about 1 minute 4 seconds.

Closing guinget before the cache update is completed if using Robocopy and/or 7-Zip will leave those programs open and you'll have to close them manually. This should be changed in a future version to automatically close them when closing guinget.

## HiDPI Mode

Config file setting name:
`HiDPIMode`

For now, only doubles the height of items in the package list and the `Apply changes` window.<br>
May eventually be expanded to cover the rest of the controls that are difficult to use on HiDPI devices.

Defaults to `False`/unchecked.

## Default source name

Config file setting name:
`DefaultSourceName`

In case the default source for winget is renamed, you can change it so guinget still works. This is used when passing packages to winget to do things like show or install them, because it gets confused when a package is available in multiple sources and there are multiple sources active. One affected package is Windows Terminal.

Defaults to `"winget"`.