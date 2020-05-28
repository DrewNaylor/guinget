These are proposed source types that guinget can get manifests from.

- guinget.ZipDownload (Default): Just a zip file that's downloaded and extracted. Doesn't support checking if any changes have occurred since the last manifest update before downloading.
- guinget.GitRepo: A git repository that's cloned and can be checked for differences before updating, to preserve bandwidth and make updating faster. Requires `git`.

The source types may not be supported by winget, as winget uses an SQLite database to get package info from, then it grabs the manifests from the remote source server as far as I know.
I'd like to support using this SQLite database, but it was too difficult for me to figure out.
