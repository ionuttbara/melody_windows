:--------------------------------------
:: Starting the script
title [0 percent] Melody Script 15 & pushd "%CD%" & CD /D "%~dp0" >nul
:--------------------------------------

:--------------------------------------
:: disabling devices HPET + Virtualization HyperV for get better performance + latency
wmic path Win32_PnPEntity where "name='High precision event timer'" call disable
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
for /f %%a in ('Reg query HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\InstallService\Stubification /v "EnableAppOffloading" /s ^| findstr "HKEY"') do (
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

:: Setting the Congestion Provider for better Internet Speeds and Latency, to CTCP

netsh.exe interface tcp set supplemental Internet congestionprovider=ctcp
netsh.exe interface tcp set supplemental InternetCustom congestionprovider=ctcp

:: Reducing CPU for veryfast Internet Connections
netsh.exe int isatap set state disable >nul
netsh.exe int tcp set global rsc=disabled >nul
netsh.exe int tcp set global ecncapability=enabled >nul
netsh.exe int tcp set global ecn=enabled >nul
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
netsh.exe interface tcp set global rss=enabled chimney=disabled netdma=disabled dca=disabled >nul
netsh interface ip set global neighborcachelimit=4096 defaultcurhoplimit=64 taskoffload=enabled >nul
netsh interface tcp set global hystart=disabled >nul
netsh interface tcp set global fastopen=enabled >nul
netsh int tcp set global initialRto=3000 >nul

:: some powershell.exe commands which apply to all present network adapters (optimizations for I/O Overhead and getting better ping in worse internet connections)
powershell.exe "Disable-NetAdapterChecksumOffload -Name "*""
powershell.exe "Disable-NetAdapterLso -Name "*"" >nul
powershell.exe "Set-NetOffloadGlobalSetting -PacketCoalescingFilter disabled"
powershell.exe "Disable-NetAdapterRsc -Name "*"" >nul
powershell.exe Disable-NetAdapterBinding -Name "*" -ComponentID ms_pacer
powershell.exe "ForEach($adapter In Get-NetAdapter){Disable-NetAdapterPowerManagement -Name $adapter.Name -ErrorAction SilentlyContinue}"
powershell.exe "Get-NetAdapter -IncludeHidden | Set-NetIPInterface -WeakHostSend Enabled -WeakHostReceive Enabled -ErrorAction SilentlyContinue"
powershell.exe "Set-NetAdapterAdvancedProperty -Name * -RegistryKeyword “*JumboPacket” -Registryvalue 9014"

:: set DNS
powershell.exe Set-DNSClientServerAddress * -ServerAddresses ("94.140.14.14","94.140.15.15")

:: Firewall Rules
netsh.exe advfirewall firewall set rule group="Network Discovery" new enable=Yes >nul
netsh.exe advfirewall firewall set rule group="File and Printer Sharing" new enable=Yes >nul

:: Adding NetBios Options
for /f %%k in ('reg query HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces') do (
reg add %%k /v NetbiosOptions /t reg_dword /d 2 /f
) >nul


:: Adding Network Adapters Options (can be modified in Advanced Device Options from Device Manager)

for /f %%n in ('Reg query "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002bE10318}" /v "*SpeedDuplex" /s ^| findstr "HKEY"') do (
:: Configure Offloads
echo Configuring Offloads
reg add "%%n" /v "IPChecksumOffloadIPv4" /t REG_SZ /d "0" /f
reg add "%%n" /v "LsoV1IPv4" /t REG_SZ /d "0" /f
reg add "%%n" /v "LsoV2IPv4" /t REG_SZ /d "0" /f
reg add "%%n" /v "LsoV2IPv6" /t REG_SZ /d "0" /f
reg add "%%n" /v "PMARPOffload" /t REG_SZ /d "0" /f
reg add "%%n" /v "PMNSOffload" /t REG_SZ /d "0" /f
reg add "%%n" /v "TCPChecksumOffloadIPv4" /t REG_SZ /d "0" /f
reg add "%%n" /v "TCPChecksumOffloadIPv6" /t REG_SZ /d "0" /f
reg add "%%n" /v "UDPChecksumOffloadIPv6" /t REG_SZ /d "0" /f
reg add "%%n" /v "UDPChecksumOffloadIPv4" /t REG_SZ /d "0" /f
:: Disable Flow Control
echo Disabling Flow Control
reg add "%%n" /v "*FlowControl" /t REG_SZ /d "0" /f
reg add "%%n" /v "FlowControlCap" /t REG_SZ /d "0" /f
:: Remove Interrupt Delays
echo Removing Interrupt Delays
reg add "%%n" /v "TxIntDelay" /t REG_SZ /d "0" /f
reg add "%%n" /v "TxAbsIntDelay" /t REG_SZ /d "0" /f
reg add "%%n" /v "RxIntDelay" /t REG_SZ /d "0" /f
reg add "%%n" /v "RxAbsIntDelay" /t REG_SZ /d "0" /f
:: Remove Adapter Notification
echo Removing Adapter Notification Sending
reg add "%%n" /v "FatChannelIntolerant" /t REG_SZ /d "0" /f
:: Disable Interrupt Moderation
echo Disabling Interrupt Moderation
reg add "%%n" /v "*InterruptModeration" /t REG_SZ /d "0" /f
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
CLS & echo Enabling DirectPlay...
dism /online /Enable-Feature /FeatureName:DirectPlay /All /NoRestart
:--------------------------------------

:--------------------------------------
:: echo
echo Melody Script Applied. This PC will reboot.
shutdown /r /f /t 0
:--------------------------------------