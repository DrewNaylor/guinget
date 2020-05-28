These are proposed source types that guinget can get manifests from.

- guinget.ZipDownload (Default): Just a zip file that's downloaded and extracted. Doesn't support checking if any changes have occurred since the last manifest update before downloading.
- guinget.GitRepo: A git repository that's cloned and can be checked for differences before updating, to preserve bandwidth and make updating faster. Requires `git`.

The source types may not be supported by winget, as winget uses an SQLite database to get package info from, then it grabs the manifests from the remote source server as far as I know.
I'd like to support using this SQLite database, but it was too difficult for me to figure out.

Maybe this could work for checking if a git repo is up to date:
(See screenshot with long filename in ./images)
"`git rev-list HEAD...origin/master --count` will give you the total number of "different" commits between the two. – Jake Berger Feb 5 '13 at 19:23"
https://stackoverflow.com/a/50737015

Another solution by thuovila:

https://stackoverflow.com/a/32965236
(See the other screenshot with a long filename)
>There are many very feature rich and ingenious answers already. To provide some contrast, I could make do with a very simple line.
>
>```
># Check return value to see if there are incoming updates.
>if ! git diff --quiet remotes/origin/HEAD; then
> # pull or whatever you want to do
>fi
>```
