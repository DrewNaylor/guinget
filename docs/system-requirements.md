# System Requirements

To run guinget, your computer requires the following:

- [Microsoft .Net 4.6.1 Framework](https://www.microsoft.com/en-us/download/details.aspx?id=49981)
  - Ignore the ad on that page, scroll down, and click the orange Download button. Note that this is the web installer and it'll download its components after it's opened. May take a while to download. 
- [winget](https://github.com/microsoft/winget-cli/releases/latest)
  - I personally installed from there, but there are [other methods you could use instead](https://github.com/microsoft/winget-cli#installing-the-client)
- Windows versions: Windows 10 version 1903 or higher.
  - Windows 7-8.1 and Windows 10 versions prior to 1903 are untested although they might work for everything that's not directly reliant on winget, such as installing packages. winget requires Windows 10 version 1709 or greater.
- Architectures: x86 (32-bit) and x64 (64-bit.)
- Hardware requirements: At least a 1.2 GHz CPU; 1 GB of RAM or more.
- Disk space:
  - 32-bit: 3 GB space free.
  - 64-bit: 3 GB space free.
- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in guinget due to Visual Studio building problems, but VS2019 doesn't seem to have the setting that tends to cause issues anyway. There may also be a warning message on first start about Windows Defender SmartScreen saying it "prevented an unrecognized app from starting. Running this app might put your PC at risk." You can click the "More info" link, then the "Run anyway" button if you want to use it, though this may not be allowed on corporate networks.
- Disk space, RAM, and CPU frequency requirements are based on the .Net Framework 4.6.1 requirements. guinget itself is quite small.