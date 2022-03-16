:: Start with setting the location

pushd "%CD%"
CD /D "%~dp0"

:: Latency Service
xcopy "TimerTool.exe" "C:\Windows" /Y /E /H /C /I
regedit /s "registry\Enable Latency Service.reg"

:: Copying SDL in System...

copy "%~dp0\SDL.dll" "C:\Windows\System32\SDL.dll" /Y
copy "%~dp0\SDL.dll" "C:\Windows\SysWOW64\SDL.dll" /Y

:: Copy Files to Windows Folder
xcopy "*.ico" "C:\Windows" /Y /E /H /C /I

:: Commands for Applying Tweaks
PowerRun.exe cmd.exe /c "command files\BCDEDIT_cmd.bat"
PowerRun.exe cmd.exe /c "command files\Network Tweaks.bat"
PowerRun.exe cmd.exe /c "command files\Remover.bat"
PowerRun.exe cmd.exe /c PowerRun2.bat

:: Software Telemetry

regedit /s "registry\Windows Telemetry DataCollection.reg"
regedit /s "registry\Windows Error Reporting.reg"
regedit /s "registry\Disable WMI Keylogger.reg"
regedit /s "registry\Apps Permision Optimization.reg"
regedit /s "registry\Firewall Rules.reg"

:: Services Optimizer

regedit /s "registry\Services Optimizer.reg"
regedit /s "registry\SVCHOST Split.reg"

:: Windows Operating System Tweaks

regedit /s "registry\Apparence Optimization.reg"
regedit /s "registry\AutoPlay Handlers.reg"
regedit /s "registry\Contextual Menu in English.reg"
regedit /s "registry\Disable Windows Disk Quota.reg"
regedit /s "registry\Disk Optimization.reg"
regedit /s "registry\Feature Manipulation.reg"
regedit /s "registry\FileSystem Tweak.reg"
regedit /s "registry\Google Chrome Tweaks.reg"
regedit /s "registry\GPU Optimization.reg"
regedit /s "registry\Input Tweaks.reg"
regedit /s "registry\Keyboard Flags.reg"
regedit /s "registry\Microsoft Edge Tweaks.reg"
regedit /s "registry\MMCSS Priorities.reg"
regedit /s "registry\No more Delay and Timeouts.reg"
regedit /s "registry\Notepad Tweaks.reg"
regedit /s "registry\Office Tweaks.reg"
regedit /s "registry\Power Tweaks.reg"
regedit /s "registry\PowerShell Execution Policy.reg"
regedit /s "registry\Push Notifications.reg"
regedit /s "registry\Realtek HDA.reg"
regedit /s "registry\Resource Management.reg"
regedit /s "registry\Set blank icon.reg"
regedit /s "registry\System Tweaks.reg"
regedit /s "registry\Windows Sandbox Optimization.reg"
regedit /s "registry\Windows Search Optimization (online).reg"
regedit /s "registry\Windows Update  - Derivery Optimization.reg"
regedit /s "registry\Windows Update.reg"
regedit /s "registry\Xbox Gaming Optimization.reg"
regedit /s "registry\IRQ Priority.reg"
regedit /s "registry\Internet Speed Optimization.reg"
regedit /s "registry\GPU Usage Optimization.reg"
regedit /s "registry\Application Priority and Affinities.reg"
regedit /s "registry\Windows Update - Disable Driver Search.reg"

:: Installing Microsoft's Certs (because they removed sometime)...
for /f "delims=" %%f in ('dir /b "%~dp0\certificates\*"') do (
	echo Installing %%f...
	certutil -f -addstore Root "%~dp0\certificates\%%f"
)
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\odex.melody" /v DisplayName /t reg_sz /d "Melody 12.0 (EAS, partially applied)" /f

:: Removal of Components

::Handwriting
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~af-ZA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~bs-LATN-BA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~ca-ES~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~cs-CZ~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~cy-GB~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~da-DK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~de-DE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~el-GR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~en-GB~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~en-US~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~es-ES~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~es-MX~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~eu-ES~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~fi-FI~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~fr-FR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~ga-IE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~gd-GB~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~gl-ES~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~hi-IN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~hr-HR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~id-ID~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~it-IT~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~ja-JP~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~ko-KR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~lb-LU~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~mi-NZ~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~ms-BN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~ms-MY~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~nb-NO~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~nl-NL~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~nn-NO~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~nso-ZA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~pl-PL~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~pt-BR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~pt-PT~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~rm-CH~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~ro-RO~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~ru-RU~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~rw-RW~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~sk-SK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~sl-SI~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~sq-AL~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~sr-CYRL-RS~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~sr-LATN-RS~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~sv-SE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~sw-KE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~tn-ZA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~tr-TR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~wo-SN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~xh-ZA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~zh-CN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~zh-HK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~zh-TW~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Handwriting~~~zu-ZA~0.0.1.0  /NoRestart


::OCR

dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~ar-SA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~bg-BG~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~bs-LATN-BA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~cs-CZ~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~da-DK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~de-DE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~el-GR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~en-GB~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~en-US~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~es-ES~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~es-MX~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~fi-FI~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~fr-CA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~fr-FR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~hr-HR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~hu-HU~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~it-IT~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~ja-JP~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~ko-KR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~nb-NO~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~nl-NL~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~pl-PL~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~pt-BR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~pt-PT~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~ro-RO~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~ru-RU~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~sk-SK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~sl-SI~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~sr-CYRL-RS~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~sr-LATN-RS~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~sv-SE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~tr-TR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~zh-CN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~zh-HK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.OCR~~~zh-TW~0.0.1.0  /NoRestart

::Speech Recongnition

dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~da-DK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~de-DE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~en-AU~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~en-CA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~en-GB~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~en-IN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~en-US~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~es-ES~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~es-MX~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~fr-CA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~fr-FR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~it-IT~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~ja-JP~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~pt-BR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~zh-CN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~zh-HK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.Speech~~~zh-TW~0.0.1.0  /NoRestart

::Network Drivers
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Ethernet.Client.Intel.E1i68x64~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Ethernet.Client.Intel.E2f68~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Ethernet.Client.Vmware.Vmxnet3~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Ethernet.Client.Realtek.Rtcx21x64~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Broadcom.Bcmpciedhd63~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Broadcom.Bcmwl63al~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Broadcom.Bcmwl63a~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwbw02~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwew00~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwew01~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwlv64~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwns64~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwsw00~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwtw02~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwtw04~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwtw06~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwtw08~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Intel.Netwtw10~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Marvel.Mrvlpcie8897~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Qualcomm.Athw8x~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Qualcomm.Athwnx~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Qualcomm.Qcamain10x64~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Ralink.Netr28x~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Realtek.Rtl8187se~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Realtek.Rtl8192se~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Realtek.Rtl819xp~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Realtek.Rtl85n64~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Realtek.Rtwlane01~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Realtek.Rtwlane13~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.Wifi.Client.Realtek.Rtwlane~~~~0.0.1.0  /NoRestart

::Windows Tools
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.IoTDeviceUpdateCenter~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.PowerShell.ISE~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Microsoft.Windows.WordPad~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:OneCoreUAP.OneSync~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:OpenSSH.Client~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:OpenSSH.Server~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:OneCoreUAP.OneSync~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Print.Fax.Scan~~~~0.0.1.0 /NoRestart
dism /Online /Remove-Capability /CapabilityName:MathRecognizer~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:OpenSSH.Server~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:OpenSSH.Server~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Accessibility.Braille~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Analog.Holographic.Desktop~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:App.StepsRecorder~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:App.Support.QuickAssist~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:App.WirelessDisplay.Connect~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Browser.InternetExplorer~~~~0.0.11.0 /NoRestart
dism /Online /Remove-Capability /CapabilityName:Hello.Face.20134~~~~0.0.1.0  /NoRestart

:: Another Tweaks
for /f %%i in ('Reg query "HKLM\SYSTEM\CurrentControlSet\Services" /s /f DmaRemappingCompatible ^| find /i "Services\" ') do (Reg add "%%i" /v "DmaRemappingCompatible" /t Reg_DWORD /d "0" /f )
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\odex.melody" /v DisplayName /t reg_sz /d "Melody 12.07 (EAS)" /f
netsh interface tcp set global autotuningl=experimental
timeout 20
shutdown /r /f /t 0