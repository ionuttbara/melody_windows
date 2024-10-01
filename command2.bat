:--------------------------------------
:: Starting the script
title [0 percent] Melody Script & pushd "%CD%" & CD /D "%~dp0" >nul
set "RegPath=HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}"
:--------------------------------------

:: Windows Update Services Failure Manager
:--------------------------------------
sc failure UsoSvc reset= 60 actions= "" actions= ""
sc failure bits reset= 60 actions= "" actions= ""
:--------------------------------------

:--------------------------------------
:: disabling HPET
Powershell -noprofile -executionpolicy bypass -file "%~dp0\Scripts\Disable HPET.ps1"
:: unsplit svchost.exe processes
Powershell -noprofile -executionpolicy bypass -file "%~dp0\Scripts\Unsplit Services.ps1"
:--------------------------------------

:--------------------------------------
:: disabling Turning Off devices to save power
Powershell -noprofile -executionpolicy bypass -file "%~dp0\Scripts\Disable Device to TurnOff this device to save power.ps1"
:--------------------------------------

:--------------------------------------
for /f %%n in ('Reg query HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\InstallService\Stubification /v "EnableAppOffloading" /s ^| findstr "HKEY"') do (
for /f %%i in ('Reg query "%%n" /v "EnableAppOffloading" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableAppOffloading" /t Reg_DWORD /d "0" /f) >nul)
:--------------------------------------

:--------------------------------------
:: Registry Tweaks Applying
FOR /R %%f IN (*.reg) DO regedit.exe /s "%%f" >nul
FOR /R %%f IN (*.reg) DO PowerRun.exe regedit.exe /s "%%f" >nul
:--------------------------------------

:--------------------------------------
:: Network Tweaks
Powershell -noprofile -executionpolicy bypass -file "%~dp0\Scripts\Networking Tweaks.ps1"
:--------------------------------------


:--------------------------------------
:: Disable Hibernation (and Hiberboot), ReserveStorage to get free up to >10GB of Windows Storage
title [20 percent] Melody Script
powercfg -h off & DISM /Online /Set-ReservedStorageState /State:Disabled & reagentc /disable >nul
:--------------------------------------

:--------------------------------------
:: Configuration of Icons
xcopy "GalleryInc.Core.MelodyScript.Configurations\Icons\*" "C:\ProgramData\Melody\Icon\" /y /e /h /c /i /d >nul
:--------------------------------------

:--------------------------------------
CLS & echo Enabling DirectPlay and Removing Features/Capabilities...
Powershell -noprofile -executionpolicy bypass -file "%~dp0\Scripts\Remove Features.ps1"
Powershell -noprofile -executionpolicy bypass -file "%~dp0\Scripts\Remove Capabilities.ps1"
Powershell -noprofile -executionpolicy bypass -file "%~dp0\Scripts\Enable DirectPlay.ps1"
:--------------------------------------

:--------------------------------------
taskkill /f /im explorer.exe & del /f /q "%localappdata%\Microsoft\GameDVR"
:--------------------------------------

:--------------------------------------
:: echo
echo Melody Script Applied. This PC will reboot.
shutdown /r /f /t 0
:--------------------------------------