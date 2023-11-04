:--------------------------------------
:: Starting the script
title [0 percent] Melody Script 14 & pushd "%CD%" & CD /D "%~dp0" >nul
:--------------------------------------

:--------------------------------------
wmic path Win32_PnPEntity where "name='High precision event timer'" call disable
wmic path Win32_PnPEntity where "name='Microsoft Hyper-V Virtualization Infrastructure Driver'" call disable
:--------------------------------------

:--------------------------------------
:: cleaning Windows AuditPol Logging
echo Cleaning Windows auditpol log...
Auditpol.exe /set /category:* /Success:disable /failure:disable >nul
Auditpol.exe /remove /allusers >nul
Auditpol.exe /clear /y >nul
:--------------------------------------

:--------------------------------------
:: Unsplit Services
for /f %%a in ('Reg query HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\InstallService\Stubification /v "EnableAppOffloading" /s ^| findstr  "HKEY"') do (
for /f %%i in ('Reg query "%%a" /v "EnableAppOffloading" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableAppOffloading" /t Reg_DWORD /d "0" /f) >nul)
for /f "tokens=2 delims==" %%i in ('wmic os get TotalVisibleMemorySize /format:value') do set mem=%%i
set /a ram=%mem% + 1024000
reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control" /v "SvcHostSplitThresholdInKB" /t REG_DWORD /d "%ram%" /f
:--------------------------------------

:--------------------------------------
:: Registry Tweaks Applying
title [5 percent] Melody Script 14
CLS & echo Applying registry tweaks...
FOR /R %%f IN (*.reg) DO regedit.exe /s "%%f" >nul
CLS & echo Applying System Registry Tweaks...
FOR /R %%f IN (*.reg) DO PowerRun.exe regedit.exe /s "%%f" >nul
:--------------------------------------

:--------------------------------------
:: Network Tweaks
title [10 percent] Melody Script 14
CLS & echo Applying network tweaks...

:: Autotuning Internet Speed and making it persistent
netsh.exe interface tcp set global autotuning = experimental >nul
netsh.exe interface tcp set heuristics disabled >nul

:: Setting the Congestion Provider for better Internet Speeds and Latency, to BBR2

netsh.exe interface tcp set supplemental Internet congestionprovider=bbr2
netsh.exe interface tcp set supplemental InternetCustom congestionprovider=bbr2

:: Reducing CPU for veryfast Internet Connections
netsh.exe int isatap set state disable >nul
netsh.exe interface tcp set global rsc=disabled >nul
netsh.exe interface tcp set global ecncapability=enabled >nul
netsh.exe interface tcp set global timestamps=disabled >nul
netsh.exe interface tcp set global nonsackrttresiliency=disabled >nul
netsh.exe interface tcp set global maxsynretransmissions=2 >nul
netsh.exe interface tcp set supplemental template=custom icw=10 >nul
netsh.exe interface tcp set global fastopen=enabled >nul
netsh.exe interface tcp set global fastopenfallback=enabled >nul
netsh.exe interface tcp set security mpp=disabled >nul
netsh.exe interface tcp set security profiles=disabled >nul
netsh.exe interface udp set global uro=enabled >nul
netsh.exe int 6to4 set state state=disabled >nul
netsh.exe interface ip set global multicastforwarding=disabled >nul
netsh.exe interface tcp set security mpp=disabled profiles=disabled >nul
netsh.exe interface ip set global icmpredirects=disabled >nul
netsh.exe interface tcp set global rss=enabled >nul
netsh interface ip set global neighborcachelimit=4096 defaultcurhoplimit=64 taskoffload=enabled >nul
netsh interface tcp set global hystart=disabled >nul
netsh interface tcp set global fastopen=enabled >nul

:: some powershell.exe commands which apply to all present network adapters (optimizations for I/O Overhead and getting better ping in worse internet connections)
powershell.exe "Disable-NetAdapterChecksumOffload -Name "*""
powershell.exe "Disable-NetAdapterLso -Name "*"" >nul
powershell.exe "Set-NetOffloadGlobalSetting -PacketCoalescingFilter disabled"
powershell.exe "Disable-NetAdapterRsc -Name "*"" >nul
powershell.exe Disable-NetAdapterBinding -Name "*" -ComponentID ms_pacer
powershell.exe "ForEach($adapter In Get-NetAdapter){Disable-NetAdapterPowerManagement -Name $adapter.Name -ErrorAction SilentlyContinue}"
powershell.exe "Get-NetAdapter -IncludeHidden | Set-NetIPInterface -WeakHostSend Enabled -WeakHostReceive Enabled -ErrorAction SilentlyContinue"

:: set DNS
powershell.exe Set-DNSClientServerAddress * -ServerAddresses ("94.140.14.14","94.140.15.15")

:: Firewall Rules

netsh.exe advfirewall firewall set rule group="Network Discovery" new enable=Yes >nul
netsh.exe advfirewall firewall set rule group="File and Printer Sharing" new enable=Yes >nul
netsh.exe advfirewall firewall set rule group="Delivery Optimization" new enable=No >nul

:: Adding NetBios Options
for /f %%k in ('reg query HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces') do (
reg add %%k /v NetbiosOptions /t reg_dword /d 2 /f
) >nul


:: Adding Network Adapters Options (can be modified in Advanced Device Options from Device Manager)

for /f "tokens=3*" %%a in ('reg query "HKLM\Software\Microsoft\Windows NT\CurrentVersion\NetworkCards" /k /v /f "Description" /s /e ^| findstr /ri "REG_SZ"') do (
	for /f %%g in ('reg query "HKLM\System\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}" /s /f "%%b" /d ^| findstr /C:"HKEY"') do (
		reg add "%%g" /v "MIMOPowerSaveMode" /t REG_SZ /d "3" /f
		reg add "%%g" /v "PowerSavingMode" /t REG_SZ /d "0" /f
		reg add "%%g" /v "EnableGreenEthernet" /t REG_SZ /d "0" /f
		reg add "%%g" /v "*EEE" /t REG_SZ /d "0" /f
		reg add "%%g" /v "EnableConnectedPowerGating" /t REG_DWORD /d "0" /f
		reg add "%%g" /v "EnableDynamicPowerGating" /t REG_SZ /d "0" /f
		reg add "%%g" /v "EnableSavePowerNow" /t REG_SZ /d "0" /f
		reg add "%%g" /v "PnPCapabilities" /t REG_SZ /d "24" /f
		reg add "%%g" /v "*NicAutoPowerSaver" /t REG_SZ /d "0" /f
		reg add "%%g" /v "*FlowControl" /t REG_SZ /d "0" /f
		reg add "%%g" /v "ULPMode" /t REG_SZ /d "0" /f
		reg add "%%g" /v "EnablePME" /t REG_SZ /d "0" /f
		reg add "%%g" /v "AlternateSemaphoreDelay" /t REG_SZ /d "0" /f
		reg add "%%g" /v "AutoPowerSaveModeEnabled" /t REG_SZ /d "0" /f
		reg add "%%g" /v "S5WakeOnLan" /t REG_SZ /d "0" /f
		reg add "%%g" /v "AutoDisableGigabit" /t REG_SZ /d "0" /f
		reg add "%%g" /v "GigaLite" /t REG_SZ /d "0" /f
		reg add "%%g" /v "NumRssQueues" /t REG_SZ /d "4" /f
		reg add "%%g" /v "*RSS" /t REG_SZ /d "1" /f
		reg add "%%g" /v "*IPChecksumOffloadIPv4" /t REG_SZ /d "0" /f
		reg add "%%g" /v "WakeOnLinkChange" /t REG_SZ /d "0" /f
		reg add "%%g" /v "ModernStandbyWoLMagicPacket" /t REG_SZ /d "0" /f
		reg add "%%g" /v "InterruptModeration" /t REG_SZ /d "0" /f
		reg add "%%g" /v "*PMNSOffload" /t REG_SZ /d "0" /f
		reg add "%%g" /v "*PMARPOffload" /t REG_SZ /d "0" /f
		reg add "%%g" /v "*JumboPacket" /t REG_SZ /d "1514" /f
		reg add "%%g" /v "*ReceiveBuffers" /t REG_SZ /d "512" /f
		reg add "%%g" /v "*TransmitBuffers" /t REG_SZ /d "128" /f
		reg add "%%g" /v "*LsoV2IPv6" /t REG_SZ /d "0" /f
		reg add "%%g" /v "*LsoV2IPv4" /t REG_SZ /d "0" /f
		reg add "%%g" /v "*SpeedDuplex" /t REG_SZ /d "6" /f
		reg add "%%g" /v "WolShutdownLinkSpeed" /t REG_SZ /d "2" /f
		reg add "%%g" /v "*WakeOnPattern" /t REG_SZ /d "0" /f
		reg add "%%g" /v "*WakeOnMagicPacket" /t REG_SZ /d "0" /f
		reg add "%%g" /v "ReduceSpeedOnPowerDown" /t REG_SZ /d "0" /f
		reg add "%%g" /v "EnablePowerManagement" /t REG_SZ /d "0" /f
		)
	)

:: Disabling Nagle's Algorithm for better Gaming Latency
for /f %%r in ('Reg query "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces" /f "1" /d /s^|Findstr HKEY_') do (
Reg add %%r /v "TCPNoDelay" /t Reg_DWORD /d "1" /f
Reg add %%r /v "TcpAckFrequency" /t Reg_DWORD /d "1" /f
Reg add %%r /v "TcpDelAckTicks" /t Reg_DWORD /d "0" /f
) >nul

:--------------------------------------


:--------------------------------------
:: Disable Hibernation (and Hiberboot), ReserveStorage to get free up to >10GB of Windows Storage
title [20 percent] Melody Script 14
powercfg -h off & DISM /Online /Set-ReservedStorageState /State:Disabled & reagentc /disable >nul
:--------------------------------------

:--------------------------------------
:: Configuration of Icons
title [40 percent] Melody Script 14
xcopy "GalleryInc.Core.MelodyScript.Configurations\Icons\*" "C:\ProgramData\Melody\Icon\" /y /e /h /c /i /d >nul
:--------------------------------------

:--------------------------------------
:: Configuration of HOSTS
title [50 percent] Melody Script 14
IF EXIST %windir%\SYSTEM32\DRIVERS\ETC\HOSTS*.* ATTRIB +A -H -R -S %windir%\SYSTEM32\DRIVERS\ETC\HOSTS*.*>NUL & IF EXIST %windir%\SYSTEM32\DRIVERS\ETC\HOSTS.BACK DEL %windir%\SYSTEM32\DRIVERS\ETC\HOSTS.BACK>NUL
IF EXIST %windir%\SYSTEM32\DRIVERS\ETC\HOSTS REN %windir%\SYSTEM32\DRIVERS\ETC\HOSTS HOSTS.BACK>NUL & IF EXIST %windir%\SYSTEM32\DRIVERS\ETC\NUL COPY /Y "GalleryInc.Core.MelodyScript.Configurations\Hosts\HOSTS" %windir%\SYSTEM32\DRIVERS\ETC>NUL & IF EXIST %windir%\SYSTEM32\DRIVERS\ETC\HOSTS.BACK ECHO Hosts Applied.
:--------------------------------------


:--------------------------------------
CLS & echo Please wait...
"powershell.exe" Enable-WindowsOptionalFeature -Online -FeatureName LegacyComponents -all -NoRestart
"powershell.exe" Enable-WindowsOptionalFeature -Online -FeatureName DirectPlay -all -NoRestart
:--------------------------------------

:--------------------------------------
::Toggler Installer
title [100 percent] Melody Script 14
start /wait cmd.exe /k "MelodyScript.IntegratedTools\Toggler\Toggler.bat"
:--------------------------------------

:--------------------------------------
:: echo
echo Melody Script Applied. This PC will reboot.
xcopy "MelodyScript.IntegratedTools\EmptyStandbyList\*" %windir% /y /e /h /c /i
start /wait powershell.exe -command %windir%\install.ps1
shutdown /r /f /t 0
:--------------------------------------