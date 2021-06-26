# System Requirements

[Homepage](https://drew-naylor.com/guinget)

To run guinget, your computer requires the following:

- guinget version 0.1.1 or older
  - [Microsoft .NET Framework 4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49981)
    - Ignore the ad on that page, scroll down, and click the orange Download button. Note that this is the web installer and it'll download its components after it's opened. May take a while to download.
- guinget version 0.1.2 or newer
  - [Microsoft .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)
    - Click "Download .NET Framework 4.8 Runtime" under the "Runtime" header on the right near the top. Note that this is the web installer and it'll download its components after it's opened. May take a while to download.
	- This is only required for Windows versions older than Windows 10 1903, except for Windows 8.0 as it doesn't support that version.
- [winget](https://github.com/microsoft/winget-cli/releases/latest)
  - I personally installed from there, but there are [other methods you could use instead](https://github.com/microsoft/winget-cli#installing-the-client)
- Windows versions: Windows 10 version 1903 or higher recommended.
  - guinget has only been tested on Windows 10 versions 1803, 1903, 1909, 2004, and 20H2. Windows 7 SP1, 8.0, 8.1, all other versions of Windows 10, and 11 are untested although they might work for everything that's not directly reliant on winget, such as installing packages.
  - As .NET Framework 4.8 doesn't appear to be compatible with Windows 8.0, guinget version 0.1.2 or newer may not work on that version of Windows.
  - winget requires Windows 10 version 1809 or greater.
- Architectures: x86 (32-bit) and x64 (64-bit). May also work on Windows 10 on ARM as a 32-bit application, though that's untested.
- Hardware requirements: 
  - Minimum: At least a 1.2 GHz CPU; 1 GB of RAM or more.
  - Recommended: At least a 2.5 GHz dual-core CPU; 2 GB of RAM or more.
  - The recommended may not be enough in some cases to prevent lockups when loading the package list and details, but it should be ok. Performance improvements in guinget v0.3 should prevent most lockups related to loading the package list, though things may still be slow sometimes. Restarting guinget a few times may improve performance as that'll cause .NET Framework to compile it to machine code.
- Disk space:
  - guinget version 0.1.1 or older
    - 32-bit: 3 GB space free
    - 64-bit: 3 GB space free
  - guinget version 0.1.2 or newer
    - 32-bit: 5 GB space free
    - 64-bit: 5 GB space free
- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in guinget due to Visual Studio building problems, but VS2019 doesn't seem to have the setting that tends to cause issues anyway. There may also be a warning message on first start about Windows Defender SmartScreen saying it "prevented an unrecognized app from starting. Running this app might put your PC at risk." You can click the "More info" link, then the "Run anyway" button if you want to use it, though this may not be allowed on corporate networks.
- Disk space, RAM, and CPU frequency minimum requirements are based on the .NET Framework 4.6.1 and 4.8 requirements. guinget itself is quite small, although some packages and the cache may take up more space.
