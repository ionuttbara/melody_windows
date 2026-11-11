@echo off
for /f %%I in ('powershell -Command "[System.Security.Principal.WindowsIdentity]::GetCurrent().User.Value"') do set "USER_SID=%%I"
set "REG_KEY=HKLM\SOFTWARE\Microsoft\PolicyManager\current\%USER_SID%\Connectivity"
reg add "%REG_KEY%" /v "DisableCrossDeviceResume" /t REG_DWORD /d 1 /f
reg add "%REG_KEY%" /v "DisableCrossDeviceResume_ProviderSet" /t REG_DWORD /d 1 /f
