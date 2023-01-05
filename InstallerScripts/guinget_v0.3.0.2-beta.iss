; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "guinget"
#define MyAppVersion "0.3.0.2"
#define MyAppPublisher "Drew Naylor"
#define MyAppURL "https://github.com/DrewNaylor/guinget"
#define MyAppUpdatesURL "https://github.com/DrewNaylor/guinget/releases/latest"
#define MyAppHelpURL "https://drew-naylor.com/guinget/How-to-use"
#define MyAppExeName "guinget.exe"

; Variables that are used to make updating installer scripts
; faster and more reliable.
#define CurrentVersion "v0.3.0.2-beta"
#define PreviousVersion "v0.3.0.1-beta"
#define SourcesRootPath "C:\DrewN Desktop Apps\Binaries"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{18980A21-0836-42CA-8200-5BC7273F7DE2}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} version {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppHelpURL}
AppUpdatesURL={#MyAppUpdatesURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName=DrewNaylor
LicenseFile={#SourcesRootPath}\guinget\{#CurrentVersion}\LICENSE.txt
InfoBeforeFile={#SourcesRootPath}\guinget\{#CurrentVersion}\README for guinget.txt
InfoAfterFile={#SourcesRootPath}\guinget\{#CurrentVersion}\{#CurrentVersion}_changelog_from-{#PreviousVersion}.txt
OutputDir={#SourcesRootPath}\guinget\{#CurrentVersion}\
OutputBaseFilename=guinget_{#CurrentVersion}
Compression=lzma
SolidCompression=yes
AppCopyright=Copyright 2020-2022 Drew Naylor. Licensed under Apache License 2.0.
ShowLanguageDialog=no
UninstallDisplayIcon={uninstallexe},5
UninstallDisplayName={#MyAppName}
MinVersion=0,6.1sp1
CreateUninstallRegKey=yes
EnableDirDoesntExistWarning=True
DirExistsWarning=no
VersionInfoVersion={#MyAppVersion}
AlwaysShowGroupOnReadyPage=True
AlwaysShowDirOnReadyPage=True
DisableStartupPrompt=True
DisableDirPage=auto
DisableProgramGroupPage=auto
WizardStyle=modern
WizardResizable=True
PrivilegesRequiredOverridesAllowed=commandline dialog

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\guinget.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\README for guinget.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\source-code.zip"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\{#CurrentVersion}_changelog_from-{#PreviousVersion}.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\LICENSE-YamlDotNet.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\LICENSE-MicrosoftDataSqlite.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\LICENSE-SQLitePCLRaw.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\LICENSE-SysNumsVects_SysBuffs_SysMem.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\LICENSE-SysRuntimeCompSvcUnsafe.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\DisableLongPathsEnabled.reg"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\EnableLongPathsEnabled.reg"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\docs\*"; DestDir: "{app}\docs"; Flags: ignoreversion createallsubdirs recursesubdirs
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\guinget.exe_migratesettings_.config"; DestDir: "{app}"; DestName: "guinget.exe.config"; Flags: ignoreversion
Source: "{#SourcesRootPath}\guinget\{#CurrentVersion}\lib\*"; DestDir: "{app}\lib"; Flags: ignoreversion createallsubdirs recursesubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Messages]
UninstalledAll=%1 was successfully removed from your computer. Configuration files may still be present in (username)\AppData\Local\winget-frontends and (username)\AppData\Local\guinget, where (username) is your user profile usually in C:\Users.

[InstallDelete]
Type: files; Name: "{app}\libguinget.dll"
Type: files; Name: "{app}\YamlDotNet.dll"
Type: files; Name: "{app}\update-manifests.bat"