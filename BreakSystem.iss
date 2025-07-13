[Setup]
AppName=BreakSystem
AppVersion=1.0.0
DefaultDirName={pf}\BreakSystem
DefaultGroupName=BreakSystem
OutputDir=.\Installer
OutputBaseFilename=BreakSystemSetup
Compression=lzma
SolidCompression=yes

[Files]
Source: "C:\Users\fxhxy\dev\BreakSystem\BreakSystem\bin\Release\net8.0-windows\win-x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

[Icons]
Name: "{group}\BreakSystem"; Filename: "{app}\BreakSystem.exe"
Name: "{group}\Uninstall BreakSystem"; Filename: "{uninstallexe}"
