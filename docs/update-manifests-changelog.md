# update-manifests.bat Changelog

[Homepage](https://drew-naylor.com/guinget)

## Version 2021.01-1 - January 22, 2021

- Switched to using LocalAppData instead of Roaming since guinget also switched and anyone that still uses update-manifests.bat would have issues.
- Added a message at the end of the cache update that allows deleting the cache files in the old location.
- Updated copyright years.

NB: update-manifests.bat is deprecated and has been since guinget version 0.1 alpha. Please don't use it. If you're still using it, you can use the built-in cache updater by changing `UseBuiltinCacheUpdater` in the config file from `False` back to the default of `True`. A future version will remove support for update-manifests.bat, and will use the built-in cache updater by default.

## Version 2020.10-1 - October 5, 2020

- Added trailing backslash to zip file extraction destination.

## Version 2020.05-2 - May 31, 2020

- Fixed README URL.

## Version 2020.05-1 - May 27, 2020

- First version after forking from [UXL Autobuild Script](https://gist.github.com/DrewNaylor/22e3f1cded702fff494a46dabe643fde#file-changelog-md).