:: Starting Script at home page
:: Defining Startup page
@echo off
pushd "%CD%"
CD /D "%~dp0"
color 6
title Melody - Network Settings

:: Autotuning Internet Speed and making it persistent 
netsh.exe interface tcp set global autotuningl = experimental >nul
netsh.exe interface tcp set global autotuning = experimental >nul
netsh.exe interface tcp set heuristics disabled >nul

:: Setting the Congestion Provider for better Internet Speeds and Latency, to CTCP

netsh.exe interface tcp set supplemental Internet congestionprovider=ctcp >nul
netsh.exe interface tcp set supplemental InternetCustom congestionprovider=ctcp >nul

:: Reducing CPU for veryfast Internet Connections

netsh.exe interface tcp set global chimney=disabled >nul 
netsh.exe interface tcp set global dca=enabled >nul
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
netsh.exe interface 6to4 set state state=enabled >nul
:: some powershell.exe commands which apply to all present network adapters (optimizations for I/O Overhead and getting better ping in worse internet connections)

powershell.exe "Disable-NetAdapterChecksumOffload -Name "*"" >nul
powershell.exe "Enable-NetAdapterRss -Name "*"" >nul
powershell.exe "Disable-NetAdapterLso -Name "*"" >nul
powershell.exe "Set-NetOffloadGlobalSetting -PacketCoalescingFilter disabled" >nul 
powershell.exe "Disable-NetAdapterRsc -Name "*"" >nul
powershell.exe "Disable-NetAdapterQos -Name "*"" >nul

:: Firewall Rules

netsh.exe advfirewall firewall set rule group="Network Discovery" new enable=Yes >nul
netsh.exe advfirewall firewall set rule group="File and Printer Sharing" new enable=Yes >nul
netsh.exe advfirewall firewall set rule group="Delivery Optimization" new enable=No >nul
netsh.exe advfirewall firewall set rule group="Microsoft Family Safety" new enable=No >nul


:: Adding NetBios Options
for /f %%k in ('reg query HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces') do (
reg add %%k /v NetbiosOptions /t reg_dword /d 2 /f 
) >nul


:: Adding Network Adapters Options (can be modified in Advanced Device Options from Device Manager)

for /f %%a in ('Reg query HKLM /v "*WakeOnMagicPacket" /s ^| findstr  "HKEY"') do (
for /f %%i in ('Reg query "%%a" /v "*EEE" ^| findstr "HKEY"') do (Reg add "%%i" /v "*EEE" /t Reg_DWORD /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*FlowControl" ^| findstr "HKEY"') do (Reg add "%%i" /v "*FlowControl" /t Reg_DWORD /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "EnableSavePowerNow" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableSavePowerNow" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "EnablePowerManagement" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnablePowerManagement" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "EnableDynamicPowerGating" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableDynamicPowerGating" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "EnableConnectedPowerGating" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableConnectedPowerGating" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "AutoPowerSaveModeEnabled" ^| findstr "HKEY"') do (Reg add "%%i" /v "AutoPowerSaveModeEnabled" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "AdvancedEEE" ^| findstr "HKEY"') do (Reg add "%%i" /v "AdvancedEEE" /t Reg_DWORD /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "ULPMode" ^| findstr "HKEY"') do (Reg add "%%i" /v "ULPMode" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "ReduceSpeedOnPowerDown" ^| findstr "HKEY"') do (Reg add "%%i" /v "ReduceSpeedOnPowerDown" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "EnablePME" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnablePME" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*WakeOnMagicPacket" ^| findstr "HKEY"') do (Reg add "%%i" /v "*WakeOnMagicPacket" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*WakeOnPattern" ^| findstr "HKEY"') do (Reg add "%%i" /v "*WakeOnPattern" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "WolShutdownLinkSpeed" ^| findstr "HKEY"') do (Reg add "%%i" /v "WolShutdownLinkSpeed" /t Reg_SZ /d "2" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*SpeedDuplex" ^| findstr "HKEY"') do (Reg add "%%i" /v "*SpeedDuplex" /t Reg_SZ /d "6" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*LsoV2IPv4" ^| findstr "HKEY"') do (Reg add "%%i" /v "*LsoV2IPv4" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*LsoV2IPv6" ^| findstr "HKEY"') do (Reg add "%%i" /v "*LsoV2IPv6" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*TransmitBuffers" ^| findstr "HKEY"') do (Reg add "%%i" /v "*TransmitBuffers" /t Reg_SZ /d "128" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*ReceiveBuffers" ^| findstr "HKEY"') do (Reg add "%%i" /v "*ReceiveBuffers" /t Reg_SZ /d "512" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*JumboPacket" ^| findstr "HKEY"') do (Reg add "%%i" /v "*JumboPacket" /t Reg_SZ /d "9014" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*PMARPOffload" ^| findstr "HKEY"') do (Reg add "%%i" /v "*PMARPOffload" /t Reg_SZ /d "1" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*PMNSOffload" ^| findstr "HKEY"') do (Reg add "%%i" /v "*PMNSOffload" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*InterruptModeration" ^| findstr "HKEY"') do (Reg add "%%i" /v "*InterruptModeration" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*ModernStandbyWoLMagicPacket" ^| findstr "HKEY"') do (Reg add "%%i" /v "*ModernStandbyWoLMagicPacket" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "WakeOnLinkChange" ^| findstr "HKEY"') do (Reg add "%%i" /v "WakeOnLinkChange" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*IPChecksumOffloadIPv4" ^| findstr "HKEY"') do (Reg add "%%i" /v "*IPChecksumOffloadIPv4" /t Reg_SZ /d "3" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*RSS" ^| findstr "HKEY"') do (Reg add "%%i" /v "*RSS" /t Reg_SZ /d "1" /f) >nul
for /f %%i in ('Reg query "%%a" /v "*NumRssQueues" ^| findstr "HKEY"') do (Reg add "%%i" /v "*NumRssQueues" /t Reg_SZ /d "4" /f) >nul
for /f %%i in ('Reg query "%%a" /v "EnableGreenEthernet" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableGreenEthernet" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "GigaLite" ^| findstr "HKEY"') do (Reg add "%%i" /v "GigaLite" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "PowerSavingMode" ^| findstr "HKEY"') do (Reg add "%%i" /v "PowerSavingMode" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "S5WakeOnLan" ^| findstr "HKEY"') do (Reg add "%%i" /v "S5WakeOnLan" /t Reg_SZ /d "0" /f) >nul
for /f %%i in ('Reg query "%%a" /v "AutoDisableGigabit" ^| findstr "HKEY"') do (Reg add "%%i" /v "AutoDisableGigabit" /t Reg_SZ /d "0" /f) >nul
) >nul

:: Disabling Nagle's Algorithm for better Gaming Latency

for /f %%r in ('Reg query "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces" /f "1" /d /s^|Findstr HKEY_') do (
Reg add %%r /v "NonBestEffortLimit" /t Reg_DWORD /d "0" /f >nul
Reg add %%r /v "DeadGWDetectDefault" /t Reg_DWORD /d "1" /f >nul
Reg add %%r /v "PerformRouterDiscovery" /t Reg_DWORD /d "1" /f >nul
Reg add %%r /v "TCPNoDelay" /t Reg_DWORD /d "1" /f >nul
Reg add %%r /v "TcpAckFrequency" /t Reg_DWORD /d "1" /f >nul
Reg add %%r /v "TcpInitialRTT" /t Reg_DWORD /d "2" /f >nul
Reg add %%r /v "TcpDelAckTicks" /t Reg_DWORD /d "0" /f >nul
Reg add %%r /v "MTU" /t Reg_DWORD /d "1500" /f >nul
Reg add %%r /v "UseZeroBroadcast" /t Reg_DWORD /d "0" /f >nul
) >nul

CLS >nul
echo Finalised
exit