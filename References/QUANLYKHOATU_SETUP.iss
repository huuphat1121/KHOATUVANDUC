; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{8F8194C8-BB14-4478-8CDE-D0762846FAE1}
AppName=QuanLyKhoaTu
AppVersion=1.0
;AppVerName=QuanLyKhoaTu 1.0
AppPublisher=Le Huu Phat, Mr.
DefaultDirName=D://Quan Ly Khoa Tu/QuanLyKhoaTu
DefaultGroupName=QuanLyKhoaTu
AllowNoIcons=yes
OutputDir=U:\Work\Sources\KHOATUVANDUC\KHOATUVANDUC\References
OutputBaseFilename=QUANLYPHATTU_SETUP
SetupIconFile=U:\Work\Sources\KHOATUVANDUC\KHOATUVANDUC\Image\if_web-management_49630.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "U:\Work\Sources\KHOATUVANDUC\KHOATUVANDUC\QL_HocVien\bin\Release\QL_HocVien.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "U:\Work\Sources\KHOATUVANDUC\KHOATUVANDUC\QL_HocVien\bin\Release\BLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "U:\Work\Sources\KHOATUVANDUC\KHOATUVANDUC\QL_HocVien\bin\Release\DAL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "U:\Work\Sources\KHOATUVANDUC\KHOATUVANDUC\QL_HocVien\bin\Release\KeepAutomation.Barcode.Windows.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "U:\Work\Sources\KHOATUVANDUC\KHOATUVANDUC\QL_HocVien\bin\Release\log4net.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "U:\Work\Sources\KHOATUVANDUC\KHOATUVANDUC\QL_HocVien\bin\Release\npgsql.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "U:\TheKhoaTuCu.docx"; DestDir: "{app}"; Flags: ignoreversion
Source: "U:\TheKhoaTuMoi.docx"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\QuanLyKhoaTu"; Filename: "{app}\QL_HocVien.exe"
Name: "{group}\{cm:UninstallProgram,QuanLyKhoaTu}"; Filename: "{uninstallexe}"
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\QuanLyKhoaTu"; Filename: "{app}\QL_HocVien.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\QL_HocVien.exe"; Description: "{cm:LaunchProgram,QuanLyKhoaTu}"; Flags: nowait postinstall skipifsilent
