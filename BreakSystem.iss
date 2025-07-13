[Setup]
AppName=BreakSystem
AppVersion=1.0.0
DefaultDirName={pf}\BreakSystem
DefaultGroupName=BreakSystem
OutputDir=.\Installer
OutputBaseFilename=BreakSystemSetup
Compression=lzma
SolidCompression=yes
SetupIconFile="C:\Users\fxhxy\dev\BreakSystem\assets\favicon.ico"

[Files]
Source: "C:\Users\fxhxy\dev\BreakSystem\BreakSystem\bin\Release\net8.0-windows\win-x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs
Source: "C:\Users\fxhxy\dev\BreakSystem\assets\favicon.ico"; DestDir: "{app}"; DestName: "favicon.ico"; Flags: ignoreversion

[Icons]
Name: "{group}\BreakSystem"; Filename: "{app}\BreakSystem.exe"; IconFilename: "{app}\favicon.ico"
Name: "{group}\Uninstall BreakSystem"; Filename: "{uninstallexe}"
