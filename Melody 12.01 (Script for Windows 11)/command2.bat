:: Start with setting the location

pushd "%CD%"
CD /D "%~dp0"

:: Starting 
reg.exe add "HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32" /f /ve
PowerRun "Toggle Camera in menu.bat"
PowerRun "Toggle Microphone in menu.bat"
PowerRun.exe Regedit.exe /S fidelityreg_reg11.reg
Regedit.exe /S fidelityreg_reg11.reg
:: Enable DirectPlay 

"powershell.exe" Enable-WindowsOptionalFeature -Online -FeatureName LegacyComponents -all -NoRestart
"powershell.exe" Enable-WindowsOptionalFeature -Online -FeatureName DirectPlay -all -NoRestart

:: Installing Microsoft's Certs (because they removed sometime)...

echo Now installing Root certs
for /f "delims=" %%f in ('dir /b "%~dp0\certificates\*"') do (
	echo Installing %%f...
	certutil -f -addstore Root "%~dp0\certificates\%%f"
)

reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Fidelity" /v DisplayName /t reg_sz /d "Melody 12.0 (EAS, partially applied)" /f

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


::TTS Packs

dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ar-EG~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ar-SA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~bg-BG~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ca-ES~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~cs-CZ~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~da-DK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~de-AT~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~de-CH~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~de-DE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~el-GR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~en-AU~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~en-CA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~en-GB~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~en-IE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~en-IN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~en-US~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~es-ES~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~es-MX~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~fi-FI~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~fr-CA~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~fr-CH~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~fr-FR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~he-IL~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~hi-IN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~hr-HR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~hu-HU~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~id-ID~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~it-IT~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ja-JP~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ko-KR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ms-MY~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~nb-NO~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~nl-BE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~nl-NL~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~pl-PL~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~pt-BR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~pt-PT~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ro-RO~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ru-RU~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~sk-SK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~sl-SI~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~sv-SE~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~ta-IN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~th-TH~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~tr-TR~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~vi-VN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~zh-CN~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~zh-HK~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Language.TextToSpeech~~~zh-TW~0.0.1.0  /NoRestart

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
dism /Online /Remove-Capability /CapabilityName:Media.WindowsMediaPlayer~~~~0.0.12.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:OpenSSH.Server~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:OpenSSH.Server~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Accessibility.Braille~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Analog.Holographic.Desktop~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:App.StepsRecorder~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:App.Support.QuickAssist~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:App.WirelessDisplay.Connect~~~~0.0.1.0  /NoRestart
dism /Online /Remove-Capability /CapabilityName:Browser.InternetExplorer~~~~0.0.11.0 /NoRestart
dism /Online /Remove-Capability /CapabilityName:Hello.Face.20134~~~~0.0.1.0  /NoRestart
:: Applying Network Settings

netsh int tcp set heuristics disabled 
netsh int tcp set supp internet congestionprovider=ctcp
netsh int tcp set global rss=enabled
netsh int tcp set global chimney=disabled
netsh int tcp set global ecncapability=enabled
netsh int tcp set global timestamps=disabled
netsh int tcp set global initialRto=3000
netsh int tcp set global timestamps=disabled 
netsh int tcp set global rsc=disabled 
netsh int tcp set global nonsackttresiliency=disabled
netsh int tcp set global MaxSynRetransmissions=2 
netsh int tcp set global fastopen=enabled
netsh int tcp set global fastopenfallback=enabled
netsh int tcp set global pacingprofile=off
netsh int tcp set global hystart=disabled
netsh int tcp set heuristics disabled
netsh int tcp set global dca=enabled
netsh int tcp set global netdma=enabled
netsh int 6to4 set state state=enabled
netsh int udp set global uro=enabled
netsh winsock set autotuning on
netsh int tcp set supplemental template=custom icw=10
netsh interface teredo set state enterprise
netsh int tcp set security mpp=disabled
netsh int tcp set security profiles=disabled
netsh interface ipv4 set subinterface "Wi-Fi" mtu=1500 store=persistent
netsh interface ipv6 set subinterface "Ethernet" mtu=1500 store=persistent
netsh interface ipv6 set subinterface "Ethernet" mtu=1500 store=persistent
netsh interface ipv4 set subinterface "Wi-Fi" mtu=1500 store=persistent
netsh int tcp set global autotuning=experimental
netsh advfirewall firewall set rule group="Remote Assistance" new enable=no

for /f "tokens=3*" %%s in ('Reg query "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkCards" /f "ServiceName" /s^|findstr /i /l "ServiceName"') do (
	::Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Psched\Parameters\Adapters\%%s" /v "NonBestEffortLimit" /t Reg_DWORD /d "0" /f >nul
	::Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "DeadGWDetectDefault" /t Reg_DWORD /d "1" /f >nul
	::Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "PerformRouterDiscovery" /t Reg_DWORD /d "1" /f >nul
	::Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "TcpInitialRTT" /t Reg_DWORD /d "0" /f >nul
 	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "TCPNoDelay" /t Reg_DWORD /d "1" /f  >nul
	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "TcpAckFrequency" /t Reg_DWORD /d "1" /f >nul
	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "TcpDelAckTicks" /t Reg_DWORD /d "0" /f >nul
	)


for %%i in (svchost explorer edge steam steamclient operagx Fornite-Win64-Shipping EA explorer chrome notepad++ steamwebviewer winword powerpnt excel mysummercar metin2 csgo VALORANT-Win64-Shipping javaw FortniteClient-Win64-Shipping ModernWarfare r5apex) do (
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Application Name" /t Reg_SZ /d "%%i.exe" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Version" /t Reg_SZ /d "1.0" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Protocol" /t Reg_SZ /d "*" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Local Port" /t Reg_SZ /d "*" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Local IP" /t Reg_SZ /d "*" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Local IP Prefix Length" /t Reg_SZ /d "*" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Remote Port" /t Reg_SZ /d "*" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Remote IP" /t Reg_SZ /d "*" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Remote IP Prefix Length" /t Reg_SZ /d "*" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "DSCP Value" /t Reg_SZ /d "46" /f
    Reg add "HKLM\Software\Policies\Microsoft\Windows\QoS\%%i" /v "Throttle Rate" /t Reg_SZ /d "-1" /f
)

for /f %%r in ('Reg query "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002bE10318}" /f "PCI\VEN_" /d /s^|Findstr HKEY_') do (
Reg add %%r /v "AutoDisableGigabit" /t Reg_SZ /d "0" /f 
Reg add %%r /v "EnableGreenEthernet" /t Reg_SZ /d "0" /f 
Reg add %%r /v "GigaLite" /t Reg_SZ /d "0" /f
Reg add %%r /v "PowerSavingMode" /t Reg_SZ /d "0" /f
)

reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v MaxConnectionsPerServer /t REG_DWORD /d 8 /f 
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v MaxConnectionsPer1_0Server /t REG_DWORD /d 8 /f 
reg add "HKU\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v MaxConnectionsPerServer /t REG_DWORD /d 8 /f 
reg add "HKU\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v MaxConnectionsPer1_0Server /t REG_DWORD /d 8 /f 

for /f %%a in ('Reg query HKLM /v "*WakeOnMagicPacket" /s ^| findstr  "HKEY"') do (
for /f %%i in ('Reg query "%%a" /v "*EEE" ^| findstr "HKEY"') do (Reg add "%%i" /v "*EEE" /t Reg_DWORD /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*FlowControl" ^| findstr "HKEY"') do (Reg add "%%i" /v "*FlowControl" /t Reg_DWORD /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "EnableSavePowerNow" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableSavePowerNow" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "EnablePowerManagement" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnablePowerManagement" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "EnableDynamicPowerGating" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableDynamicPowerGating" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "EnableConnectedPowerGating" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnableConnectedPowerGating" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "AutoPowerSaveModeEnabled" ^| findstr "HKEY"') do (Reg add "%%i" /v "AutoPowerSaveModeEnabled" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "AdvancedEEE" ^| findstr "HKEY"') do (Reg add "%%i" /v "AdvancedEEE" /t Reg_DWORD /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "ULPMode" ^| findstr "HKEY"') do (Reg add "%%i" /v "ULPMode" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "ReduceSpeedOnPowerDown" ^| findstr "HKEY"') do (Reg add "%%i" /v "ReduceSpeedOnPowerDown" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "EnablePME" ^| findstr "HKEY"') do (Reg add "%%i" /v "EnablePME" /t Reg_SZ /d "0" /f)
) 

PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& {Start-Process PowerShell -ArgumentList '-NoProfile -ExecutionPolicy Bypass -File ""%~dp0.\ma.ps1""' -Verb RunAs}"

Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001" /v "*RSSProfile" /t REG_SZ /d "3" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001\Ndi\Params\*RSSProfile" /v "ParamDesc" /t REG_SZ /d "RSS load balancing profile" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001\Ndi\Params\*RSSProfile" /v "default" /t REG_SZ /d "1" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001\Ndi\Params\*RSSProfile" /v "type" /t REG_SZ /d "enum" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001\Ndi\Params\*RSSProfile\Enum" /v "1" /t REG_SZ /d "ClosestProcessor" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001\Ndi\Params\*RSSProfile\Enum" /v "2" /t REG_SZ /d "ClosestProcessorStatic" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001\Ndi\Params\*RSSProfile\Enum" /v "3" /t REG_SZ /d "NUMAScaling" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001\Ndi\Params\*RSSProfile\Enum" /v "4" /t REG_SZ /d "NUMAScalingStatic" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001\Ndi\Params\*RSSProfile\Enum" /v "5" /t REG_SZ /d "ConservativeScaling" /f

powershell -Command "Disable-NetAdapterChecksumOffload -Name * -IpIPv4 -TcpIPv4 -TcpIPv6 -UdpIPv4 -UdpIPv6" 

:: Services Part

sc config MsKeyboardFilter start= disabled
sc config GraphicsPerfSvc start= disabled
sc config DiagTrack start= disabled
sc config TroubleshootingSvc start= disabled
sc config RemoteRegistry start= disabled
sc config shpamsvc start= disabled
sc config UevAgentService start= disabled
sc config MSiSCSI start= disabled
sc config NetTcpPortSharing start= disabled
sc config diagnosticshub.standardcollector.service start= disabled
sc config diagsvc start= disabled
sc config dmwappushservice start= disabled
sc config edgeupdate start= disabled

::Search

sc config WSearch start= disabled

::Remote Desktop Native

sc config tsusbflt start= disabled
sc config tsusbhub start= disabled
sc config TsUsbGD start= disabled
sc config TermService start= disabled
sc config SessionEnv start= disabled

::Networking Services

sc config PNRPsvc start= disabled
sc config p2psvc start= disabled
sc config p2pimsvc start= disabled
sc config PeerDistSvc start= disabled
sc config PerfHost start= disabled
sc config PNRPAutoReg start= disabled
sc config ALG start= disabled
sc config Fax start= disabled
sc config SNMPTrap start= disabled
sc config autotimesvc start= disabled
sc config LanmanWorkstation start= disabled
sc config LanmanServer start= disabled
sc config webthreatdefsvc start= disabled
sc config webthreatdefusersvc_63b8d start= disabled
sc config InventorySvc start= disabled
sc config MapsBroker start= disabled
sc config pla start= disabled

::VR Services

sc config perceptionsimulation start= disabled
sc config SharedRealitySvc start= disabled
sc config spectrum start= disabled
sc config MixedRealityOpenXRSvc start= disabled

::Retail Demo

sc config RetailDemo start= disabled

::Virtual Machine

sc config HvHost start= disabled
sc config vmickvpexchange start= disabled
sc config vmicguestinterface start= disabled
sc config vmicshutdown start= disabled
sc config vmicheartbeat start= disabled
sc config vmicvmsession start= disabled
sc config vmicrdv start= disabled
sc config vmictimesync start= disabled
sc config vmicvss start= disabled
sc config VMAuthdService start=demand
sc config VMnetDHCP start= demand
sc config VMware NAT Service start= demand
sc config VMUSBArbService start= demand
sc config VMwareHostd start= demand
sc config wcncsvc start= disabled
reg add "HKLM\SYSTEM\CurrentControlSet\Services\MessagingService" /v "Start" /t REG_DWORD /d "4" /f 
Reg.exe add "HKCU\Control Panel\Sound" /v "Beep" /t REG_SZ /d "no" /f 

::Blotware


sc config lfsvc start= disabled
sc config GoogleChromeBetaElevationService start= demand
sc config gupdate start= demand
sc config gupdatem start= demand
sc config GamingServices start= demand
sc config sppsvc start= demand
sc config DoSvc start= demand
sc config CDPSvc start= demand
sc config ClickToRunSvc start= demand
sc config DtsApo4Service start= demand
sc config TrkWks start= demand
sc config VacSvc start= disabled
sc config VSStandardCollectorService150
sc config ss_conn_service start= demand
sc config ss_conn_service2 start= demand
sc config AudioEndpointBuilder start= demand
sc config RpcLocator start= disabled
sc config Sense start= disabled
sc config TapiSrv start= disabled
sc config KtmRm start= disabled
sc config SEMgrSvc start= disabled
sc config SCardSvr start= disabled
sc config ScDeviceEnum start= disabled
sc config AppVClient start= disabled
sc config SysMain start= disabled
sc config SSDPSRV start= disabled
sc config IKEEXT start= demand
sc config FontCache3.0.0.0 start= disabled
sc config WinRM start= disabled
sc config AxInstSV start= disabled
sc config WpcMonSvc start= disabled
sc config pla start= disabled
sc config COMSysApp start= disabled
sc config AGMService start= disabled
sc config AGSService start= disabled
sc stop TroubleshootingSvc 
sc config TroubleshootingSvc start=disabled 
sc stop MapsBroker 
sc config MapsBroker start=disabled 
sc stop SysMain 
sc config SysMain start=disabled
sc config DusmSvc start= disabled
reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WpcMonSvc" /v "Start" /t REG_DWORD /d "4" /f

:: Driver Service 2
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\rdbss" /v "Start" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\pcmcia" /v "Start" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\lltdio" /v "Start" /t REG_DWORD /d "2" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\hwpolicy" /v "Start" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\vdrvroot" /v "Start" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Services\tcpipreg" /v "Start" /t REG_DWORD /d "2" /
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\TrustedInstaller" /v "Start" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\srvnet" /v "Start" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\rspndr" /v "Start" /t REG_DWORD /d "2" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Services\Schedule" /v "Start" /t REG_DWORD /d "2" /f
Reg.exe add "HKLM\SYSTEM\ControlSet001\Services\TrkWks" /v "Start" /t REG_DWORD /d "3" /f
reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\GoogleChromeElevationService" /v "Start" /t REG_DWORD /d "4" /f 
reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\BcastDVRUserService" /v "Start" /t REG_DWORD /d "4" /f 
reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PhoneSvc" /v "Start" /t REG_DWORD /d "4" /f 
reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Fax" /v "Start" /t REG_DWORD /d "4" /f 

::TabletPC

sc config SensorDataService start= disabled
sc config SensrSvc start= disabled
sc config SensorService start= disabled
sc config SmsRouter start= disabled
sc config PhoneSvc start= disabled
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\wscsvc" /v "Start" /t REG_DWORD /d "4" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DEFRAGSVC" /v "Start" /t REG_DWORD /d "4" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\upnphost" /v "Start" /t REG_DWORD /d "4" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SSDPSRV" /v "Start" /t REG_DWORD /d "4" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\MessagingService_1c6e8" /v "Start" /t REG_DWORD /d "4" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\webthreatdefusersvc_77ac1" /v "Start" /t REG_DWORD /d "4" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\MessagingService" /v "Start" /t REG_DWORD /d "4" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\stisvc" /v "Start" /t REG_DWORD /d "2" /f
REG ADD "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\irmon" /v Start /t REG_DWORD /d "4" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\AxInstSV" /v "Start" /t REG_DWORD /d "3" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\WinRM" /v "Start" /t REG_DWORD /d "3" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\WinHttpAutoProxySvc" /v "Start" /t REG_DWORD /d "3" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\TrkWks" /v "Start" /t REG_DWORD /d "3" /f
Reg.exe add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\luafv" /v "Start" /t REG_DWORD /d "4" /f

::Task Disabler 
::.net

schtasks /Change /TN "Microsoft\Windows\.NET Framework\.NET Framework NGEN v4.0.30319" /disable
schtasks /Change /TN "Microsoft\Windows\.NET Framework\.NET Framework NGEN v4.0.30319 64" /disable
schtasks /Change /TN "Microsoft\Windows\.NET Framework\.NET Framework NGEN v4.0.30319 Critical" /disable
schtasks /Change /TN "Microsoft\Windows\.NET Framework\.NET Framework NGEN v4.0.30319 64 Critical" /disable

::ad tms management

schtasks /Change /TN "\Microsoft\Windows\Active Directory Rights Management Services Client\AD RMS Rights Policy Template Management (Manual)" /disable
schtasks /Change /TN "\Microsoft\Windows\Active Directory Rights Management Services Client\AD RMS Rights Policy Template Management (Automated)" /disable 

::Mentenanta

schtasks /Change /TN "\Microsoft\Windows\Chkdsk\ProactiveScan" /disable
schtasks /Change /TN "\Microsoft\Windows\Chkdsk\SyspartRepair" /disable
schtasks /Change /TN "\Microsoft\Windows\Data Integrity Scan\Data Integrity Check And Scan" /disable
schtasks /Change /TN "\Microsoft\Windows\Data Integrity Scan\Data Integrity Scan" /disable
schtasks /Change /TN "\Microsoft\Windows\Data Integrity Scan\Data Integrity Scan for Crash Recovery" /disable
schtasks /Change /TN "\Microsoft\Windows\Defrag\ScheduledDefrag" /disable
schtasks /Change /TN "\Microsoft\Windows\DiskCleanup\SilentCleanup" /disable
schtasks /Change /TN "\Microsoft\Windows\FileHistory\File History (maintenance mode)" /disable
schtasks /Change /TN "\Microsoft\Windows\RecoveryEnvironment\VerifyWinRE" /disable
schtasks /Change /TN "\Microsoft\Windows\Registry\RegIdleBackup" /disable

:: telemetry 
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\BthSQM" /disable
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\Consolidator" /disable
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\KernelCeipTask" /disable
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\Uploader" /disable
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\UsbCeip" /disable
schtasks /change /TN "\Microsoft\Windows\Autochk\Proxy" /disable
schtasks /Change /TN "Microsoft\Windows\Application Experience\AitAgent" /disable
schtasks /Change /TN "Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser" /disable
schtasks /Change /TN "Microsoft\Windows\Application Experience\PcaPatchDbTask" /disable
schtasks /Change /TN "Microsoft\Windows\Application Experience\ProgramDataUpdater" /disable
schtasks /Change /TN "Microsoft\Windows\Application Experience\StartupAppTask" /disable
schtasks /Change /TN "Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector" /disable
schtasks /Change /TN "Microsoft\Windows\DiskFootprint\Diagnostics" /disable
schtasks /Change /TN "Microsoft\Windows\Windows Error Reporting\QueueReporting" /disable
schtasks /Change /TN "\Microsoft\Windows\Power Efficiency Diagnostics\AnalyzeSystem" /disable
schtasks /Change /TN "\Microsoft\Windows\NetTrace\GatherNetworkInfo" /disable
schtasks /Change /TN "\Microsoft\Windows\Feedback\Siuf\DmClient" /disable
schtasks /Change /TN "\Microsoft\Windows\Feedback\Siuf\DmClientOnScenarioDownload" /disable
schtasks /Change /TN "\Microsoft\Windows\Diagnosis\RecommendedTroubleshootingScanner" /disable
schtasks /Change /TN "\Microsoft\Windows\Diagnosis\Scheduled" /disable
schtasks /Change /TN "\Microsoft\Windows\Application Experience\PcaPatchDbTask" /disable
schtasks /Change /TN "\Microsoft\Windows\Device information\Device" /disable
schtasks /Change /TN "\Microsoft\Windows\Device Setup\Metadata Refresh" /disable
schtasks /Change /TN "\Microsoft\Windows\Flighting\OneSettings\RefreshCache" /disable
schtasks /Change /TN "\Microsoft\Windows\Location\Notifications" /disable
schtasks /Change /TN "\Microsoft\Windows\Speech\SpeechModelDownloadTask" /disable
schtasks /Change /TN "\Microsoft\Windows\Maintenance\WinSAT" /disable
schtasks /Change /TN "\Microsoft\Windows\PI\Sqm-Tasks" /disable
del /F /Q "C:\Windows\System32\Tasks\Microsoft\Windows\SettingSync\*" 
schtasks /Change /TN "\Microsoft\Windows\AppListBackup\Backup" /disable
schtasks /Change /TN "\Microsoft\Windows\Device Information\Device" /disable
schtasks /Change /TN "\Microsoft\Windows\Device Information\Device User" /disable
schtasks /Change /TN "\Microsoft\Windows\Device Setup\Metadata Refresh" /disable
schtasks /Change /TN "\Microsoft\Windows\Diagnosis\RecommendedTroubleshootingScanner" /disable
schtasks /Change /TN "\Microsoft\Windows\Diagnosis\Scheduled" /disable
schtasks /Change /TN "\Microsoft\Windows\DirectX\DXGIAdapterCache" /disable
schtasks /Change /TN "\Microsoft\Windows\DirectX\DirectXDatabaseUpdater" /disable
schtasks /Change /TN "\Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector" /disable
schtasks /Change /TN "\Microsoft\Windows\DiskFootprint\Diagnostics" /disable
schtasks /Change /TN "\Microsoft\Windows\DiskFootprint\StorageSense" /disable
schtasks /Change /TN "\Microsoft\Windows\DUSM\dusmtask" /disable
schtasks /Change /TN "\Microsoft\Windows\ExploitGuard\ExploitGuard MDM policy Refresh" /disable
schtasks /Change /TN "\Microsoft\Windows\Feedback\Siuf\DmClient" /disable
schtasks /Change /TN "\Microsoft\Windows\Feedback\Siuf\DmClientOnScenarioDownload" /disable
schtasks /Change /TN "\Microsoft\Windows\Flighting\FeatureConfig\ReconcileFeatures" /disable
schtasks /Change /TN "\Microsoft\Windows\Flighting\FeatureConfig\UsageDataFlushing" /disable
schtasks /Change /TN "\Microsoft\Windows\Flighting\FeatureConfig\UsageDataReporting" /disable
schtasks /Change /TN "\Microsoft\Windows\Flighting\OneSettings\RefreshCache" /disable
schtasks /Change /TN "\Microsoft\Windows\Input\LocalUserSyncDataAvailable" /disable
schtasks /Change /TN "\Microsoft\Windows\Input\MouseSyncDataAvailable" /disable
schtasks /Change /TN "\Microsoft\Windows\Input\PenSyncDataAvailable" /disable
schtasks /Change /TN "\Microsoft\Windows\Input\TouchpadSyncDataAvailable" /disable
schtasks /Change /TN "\Microsoft\Windows\International\Synchronize Language Settings" /disable
schtasks /Change /TN "\Microsoft\Windows\Kernel\La57Cleanup" /disable
schtasks /Change /TN "\Microsoft\Windows\Location\WindowsActionDialog" /disable
schtasks /Change /TN "\Microsoft\Windows\Management\Provisioning\Logon" /disable
schtasks /Change /TN "\Microsoft\Windows\Management\Provisioning\Cellular" /disable
schtasks /Change /TN "\Microsoft\Windows\Maps\MapsToastTask" /disable
schtasks /Change /TN "\Microsoft\Windows\MemoryDiagnostic\ProcessMemoryDiagnosticEvents" /disable
schtasks /Change /TN "\Microsoft\Windows\MemoryDiagnostic\RunFullMemoryDiagnostic" /disable
schtasks /Change /TN "\Microsoft\Windows\NlaSvc\WiFiTask" /disable
schtasks /Change /TN "\Microsoft\Windows\RemoteAssistance\RemoteAssistanceTask" /disable
schtasks /Change /TN "\Microsoft\Windows\RetailDemo\CleanupOfflineContent" /disable
schtasks /Change /TN "\Microsoft\Windows\Servicing\StartComponentCleanup" /disable
schtasks /Change /TN "\Microsoft\Windows\Shell\FamilySafetyRefreshTask" /disable
schtasks /Change /TN "\Microsoft\Windows\Shell\FamilySafetyMonitor" /disable
schtasks /Change /TN "\Microsoft\Windows\Sysmain\WsSwapAssessmentTask" /disable
schtasks /Change /TN "\Microsoft\Windows\Sysmain\ResPriStaticDbSync" /disable
schtasks /Change /TN "\Microsoft\Windows\SystemRestore\SR" /disable
schtasks /Change /TN "\Microsoft\Windows\TPM\Tpm-HASCertRetr" /disable
schtasks /Change /TN "\Microsoft\Windows\TPM\Tpm-Maintenance" /disable
schtasks /Change /TN "\Microsoft\Windows\UPnP\UPnPHostConfig" /disable
schtasks /Change /TN "\Microsoft\Windows\WlanSvc\CDSSync" /disable
schtasks /Change /TN "\Microsoft\Windows\WwanSvc\NotificationTask" /disable
schtasks /Change /TN "\Microsoft\Windows\WwanSvc\OobeDiscovery" /disable


::automatic App Update Windows
schtasks /Change /TN "Microsoft\Windows\WindowsUpdate\Automatic Update" /disable

:: Office Telemetry Disable

schtasks /Change /TN "\Microsoft\Office\OfficeTelemetryAgentFallBack2016" /disable
schtasks /Change /TN "\Microsoft\Office\OfficeTelemetryAgentLogOn2016" /disable


schtasks /Change /TN "\Microsoft\Windows\DeviceDirectoryClient\HandleCommand" /disable
schtasks /Change /TN "\Microsoft\Windows\DeviceDirectoryClient\HandleWnsCommand" /disable
schtasks /Change /TN "\Microsoft\Windows\DeviceDirectoryClient\LocateCommandUserSession" /disable
schtasks /Change /TN "\Microsoft\Windows\DeviceDirectoryClient\RegisterDevicePolicyChange" /disable
schtasks /Change /TN "\Microsoft\Windows\DeviceDirectoryClient\RegisterDeviceProtectionStateChanged" /disable
schtasks /Change /TN "\Microsoft\Windows\DeviceDirectoryClient\RegisterDeviceSettingChange" /disable

:: Remove Telemetry

takeown /f C:\Windows\System32\smartscreen.exe
cacls C:\Windows\System32\smartscreen.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\smartscreen.exe"
takeown /f C:\Windows\System32\smartscreenps.dll
cacls C:\Windows\System32\smartscreenps.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\smartscreenps.dll"
takeown /f C:\Windows\System32\DeviceCensus.exe
cacls C:\Windows\System32\DeviceCensus.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\DeviceCensus.exe"
takeown /f C:\Windows\System32\CompatTelRunner.exe
cacls C:\Windows\System32\CompatTelRunner.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\CompatTelRunner.exe"
takeown /f C:\Windows\System32\dmclient.exe
cacls C:\Windows\System32\dmclient.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\dmclient.exe"
takeown /f C:\Windows\hh.exe
cacls C:\Windows\hh.exe /E /P %username%:F
del /F /Q "C:\Windows\hh.exe"
takeown /f C:\Windows\HelpPane.exe
cacls C:\Windows\HelpPane.exe /E /P %username%:F
del /F /Q "C:\Windows\HelpPane.exe"


:: Boot Parameters
bcdedit /set allowedinmemorysettings 0 
bcdedit /set hypervisorlaunchtype Off 
bcdedit /set tscsyncpolicy Enhanced 
bcdedit /set debug No 
bcdedit /set isolatedcontext No 
bcdedit /set bootmenupolicy Legacy 
bcdedit /set usefirmwarepcisettings No 
bcdedit /set sos Yes 
bcdedit /set x2apicpolicy Enable 
bcdedit /set vsmlaunchtype Off 
bcdedit /set usephysicaldestination No 
bcdedit /set ems No 
bcdedit /set firstmegabytepolicy UseAll 
bcdedit /set configaccesspolicy Default 
bcdedit /set linearaddress57 optin 
bcdedit /set noumex Yes 
bcdedit /set bootems No 
bcdedit /set graphicsmodedisabled No 
bcdedit /set extendedinput Yes 
bcdedit /set highestmode Yes 
bcdedit /set forcefipscrypto No 
bcdedit /set perfmem 0 
bcdedit /set clustermodeaddressing 1 
bcdedit /set usefirmwarepcisettings No 
bcdedit /set uselegacyapicmode No 
bcdedit /set onecpu No
bcdedit /set halbreakpoint No 
bcdedit /set forcelegacyplatform No 
bcdedit /set tpmbootentropy ForceDisable 
bcdedit /timeout 0
bcdedit /set allowedinmemorysettings 0x0 
bcdedit /set isolatedcontext No 
bcdedit /set configaccesspolicy Default
bcdedit /set MSI Default
bcdedit /set usephysicaldestination No
bcdedit /set usefirmwarepcisettings No
bcdedit /set linearaddress57 OptOut
bcdedit /set increaseuserva 268435328
bcdedit /set firstmegabytepolicy UseAll
bcdedit /set avoidlowmemory 0x8000000
bcdedit /set nolowmem Yes
bcdedit /set allowedinmemorysettings 0x0
bcdedit /set vm No
bcdedit /set pae ForceEnable
bcdedit /set useplatformclock No
bcdedit /set {current} recoveryenabled no
bcdedit /create {0cb3b571-2f2e-4343-a879-d86a476d7215} /d
bcdedit /set {bootmgr} bootsequence {0cb3b571-2f2e-4343-a879-d86a476d7215}
bcdedit /set {0cb3b571-2f2e-4343-a879-d86a476d7215} loadoptions DISABLE-LSA-ISO,,DISABLE-VBS
bcdedit /set {current} disableelamdrivers yes  
bcdedit /set vsmlaunchtype off
bcdedit /set recoveryenabled NO 
bcdedit -set NOINTEGRITYCHECKS OFF
bcdedit -set TESTSIGNING OFF
bcdedit /set tscsyncpolicy legacy
bcdedit /set x2apicpolicy enable 
bcdedit /set disabledynamictick yes 
bcdedit /deletevalue useplatformclock 
bcdedit /set useplatformtick yes
bcdedit /set nx AlwaysOff
bcdedit /set bootmenupolicy Legacy 


:: Copy Files to Windows Folder
xcopy secdrv.sys ""C:\Windows\system32\drivers" /Y
xcopy "*.ico" "C:\Windows" /Y

:: Mitigation Stuff 

powershell "ForEach($v in (Get-Command -Name \"Set-ProcessMitigation\").Parameters[\"Disable\"].Attributes.ValidValues){Set-ProcessMitigation -System -Disable $v.ToString().Replace(\" \", \"\").Replace(\"`n\", \"\") -ErrorAction SilentlyContinue}"
powershell "Set-ProcessMitigation -System -Enable CFG"
powershell "Set-ProcessMitigation -Name vgc.exe -Enable AuditDynamicCode"
powershell "Set-ProcessMitigation -Name vgc.exe -Enable CFG"
powershell "Set-ProcessMitigation -Name csgo.exe -Disable CFG"
powershell "Set-ProcessMitigation -Name FarCry6.exe -Disable CFG"

echo Security Tweaks

Reg add "HKLM\System\CurrentControlSet\Control\Class{4d36e96c-e325-11ce-bfc1-08002be10318}" /v "UpperFilters" /t Reg_MULTI_SZ /d "" /f 
Reg add "HKLM\System\CurrentControlSet\Control\Class{4d36e967-e325-11ce-bfc1-08002be10318}" /v "LowerFilters" /t Reg_MULTI_SZ /d "" /f 
Reg add "HKLM\System\CurrentControlSet\Control\Class{6bdd1fc6-810f-11d0-bec7-08002be2092f}" /v "UpperFilters" /t Reg_MULTI_SZ /d "" /f 
Reg add "HKLM\System\CurrentControlSet\Control\Class{71a27cdd-812a-11d0-bec7-08002be2092f}" /v "LowerFilters" /t Reg_MULTI_SZ /d "" /f 
Reg add "HKLM\System\CurrentControlSet\Control\Class{71a27cdd-812a-11d0-bec7-08002be2092f}" /v "UpperFilters" /t Reg_MULTI_SZ /d "" /f 
Reg add "HKLM\System\CurrentControlSet\Control\Class{ca3e7ab9-b4c3-4ae6-8251-579ef933890f}" /v "UpperFilters" /t Reg_MULTI_SZ /d "" /f
 
xcopy "*.exe" "C:\Windows\System32" /Y


:: File Remover
takeown /f C:\Windows\System32\GamePanel.exe
cacls C:\Windows\System32\GamePanel.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\GamePanel.exe"
takeown /f C:\Windows\System32\wermgr.exe
cacls C:\Windows\System32\wermgr.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\wermgr.exe"
takeown /f C:\Windows\System32\wersvc.dll
cacls C:\Windows\System32\wersvc.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\wersvc.dll"
takeown /f C:\Windows\System32\werui.dll
cacls C:\Windows\System32\werui.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\werui.dll"
takeown /f C:\Windows\System32\WerEnc.dll
cacls C:\Windows\System32\WerEnc.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\WerEnc.dll"
takeown /f C:\Windows\System32\WerFault.exe
cacls C:\Windows\System32\WerFault.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\WerFault.exe"
takeown /f C:\Windows\System32\wercplsupport.dll
cacls C:\Windows\System32\wercplsupport.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\wercplsupport.dll"
takeown /f C:\Windows\System32\werdiagcontroller.dll
cacls C:\Windows\System32\werdiagcontroller.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\werdiagcontroller.dll"
takeown /f C:\Windows\System32\lfsvc.dll
cacls C:\Windows\System32\lfsvc.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\lfsvc.dll"
takeown /f C:\Windows\System32\WerEnc.dll
cacls C:\Windows\System32\WerEnc.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\WerEnc.dll"
takeown /f C:\Windows\System32\werui.dll
cacls C:\Windows\System32\werui.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\werui.dll"
takeown /f C:\Windows\System32\WerFaultSecure.exe
cacls C:\Windows\System32\WerFaultSecure.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\WerFaultSecure.exe"
takeown /f C:\Windows\System32\gameux.dll
cacls C:\Windows\System32\gameux.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\gameux.dll"
takeown /f C:\Windows\System32\GamePanelExternalHook.dll
cacls C:\Windows\System32\GamePanelExternalHook.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\GamePanelExternalHook.dll"
takeown /f C:\Windows\System32\GamePanel.exe
cacls C:\Windows\System32\GamePanel.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\GamePanel.exe"
takeown /f C:\Windows\System32\gamemode.dll
cacls C:\Windows\System32\gamemode.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\gamemode.dll"
takeown /f C:\Windows\System32\GameBarPresenceWriter.exe
cacls C:\Windows\System32\GameBarPresenceWriter.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\GameBarPresenceWriter.exe"
takeown /f C:\Windows\System32\zipcontainer.dll
cacls C:\Windows\System32\zipcontainer.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\zipcontainer.dll"
takeown /f C:\Windows\System32\msfeeds.dll
cacls C:\Windows\System32\msfeeds.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\msfeeds.dll"
takeown /f C:\Windows\System32\MsSpellCheckingHost.exe
cacls C:\Windows\System32\MsSpellCheckingHost.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\MsSpellCheckingHost.exe"
takeown /f C:\Windows\System32\ieapfltr.dll
cacls C:\Windows\System32\ieapfltr.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\ieapfltr.dll"
takeown /f C:\Windows\System32\MsSpellCheckingFacility.dll
cacls C:\Windows\System32\MsSpellCheckingFacility.dll /E /P %username%:F
del /F /Q "C:\Windows\System32\MsSpellCheckingFacility.dll"
takeown /f C:\Windows\System32\LocationNotificationWindows.exe
cacls C:\Windows\System32\LocationNotificationWindows.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\LocationNotificationWindows.exe"
takeown /f C:\Windows\System32\msfeedssync.exe
cacls C:\Windows\System32\msfeedssync.exe /E /P %username%:F
del /F /Q "C:\Windows\System32\msfeedssync.exe"
takeown /f C:\Windows\winhlp32.exe
cacls C:\Windows\winhlp32.exe /E /P %username%:F
del /F /Q "C:\Windows\winhlp32.exe"
takeown /f C:\Windows\System32\WpcMon.exe
cacls "C:\Windows\System32\WpcMon.exe" /E /P %username%:F
del /F /Q "C:\Windows\System32\WpcMon.exe"
takeown /f C:\Windows\System32\atieclxx.exe
cacls "C:\Windows\System32\atieclxx.exe" /E /P %username%:F
del /F /Q "C:\Windows\System32\atieclxx.exe"

:: Windows Error Reporting
Reg.exe add "HKLM\Software\Microsoft\Windows\Windows Error Reporting\Assert Filtering Policy" /v "ReportAndContinue" /t REG_DWORD /d "0" /f 
sc delete WerSvc
sc delete wercplsupport 

:: Disable Windows Update Driver Search

reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\DriverSearching" /v "SearchOrderConfig" /t REG_DWORD /d "3" /f 
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\DriverMetadata" /v "PreventDeviceMetadataFromNetwork" /t REG_DWORD /d "1" /f
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate" /v "ExcludeWUDriversInQualityUpdate" /t REG_DWORD /d "1" /f
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\default\Update" /v "ExcludeWUDriversInQualityUpdate" /t REG_DWORD /d "1" /f
reg add "HKLM\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings" /v "ExcludeWUDriversInQualityUpdate" /t REG_DWORD /d "1" /f
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\current\device\Update" /v "ExcludeWUDriversInQualityUpdate" /t REG_DWORD /d "1" /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DriverSearching" /v "DontSearchWindowsUpdate" REG_DWORD /d "1" /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DriverSearching" /v "DontPromptForWindowsUpdate" REG_DWORD /d "1" /f

:: Copying SDL in System 32...

copy "%~dp0\SDL.dll" "C:\Windows\System32\SDL.dll" /Y
copy "%~dp0\SDL.dll" "C:\Windows\SysWOW64\SDL.dll" /Y

:: Windows Defender Configuration

reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System" /v "EnableSmartScreen" /t REG_DWORD /d 0 /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\MicrosoftEdge\PhishingFilter" /v "EnabledV9" /t REG_DWORD /d 0 /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender" /v "DisableRoutinelyTakingAction" /t REG_DWORD /d 1 /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Reporting" /v "DisableEnhancedNotifications" /t REG_DWORD /d 1 /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\SmartScreen" /v "ConfigureAppInstallControlEnabled" /t REG_DWORD /d 0 /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Threats\ThreatSeverityDefaultAction" /v "1" /t REG_SZ /d "6" /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Threats\ThreatSeverityDefaultAction" /v "2" /t REG_SZ /d "6" /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Threats\ThreatSeverityDefaultAction" /v "4" /t REG_SZ /d "6" /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Threats\ThreatSeverityDefaultAction" /v "5" /t REG_SZ /d "6" /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\UX Configuration" /v "Notification_Suppress" /t REG_DWORD /d 1 /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Spynet" /v SpyNetReporting /t REG_DWORD /d 0 /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Spynet" /v SubmitSamplesConsent /t REG_DWORD /d 2 /f
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Spynet" /v DontReportInfectionInformation /t REG_DWORD /d 1 /f

netsh Advfirewall set allprofiles state on


:: Another Tweaks
for /f %%i in ('Reg query "HKLM\SYSTEM\CurrentControlSet\Services" /s /f DmaRemappingCompatible ^| find /i "Services\" ') do (
Reg add "%%i" /v "DmaRemappingCompatible" /t Reg_DWORD /d "0" /f )
reg add "HKU\!USER_SID!\Control Panel\Mouse" /v "SmoothMouseXCurve" /t REG_BINARY /d "0000000000000000c0cc0c0000000000809919000000000040662600000000000033330000000000" /f
reg add "HKU\!USER_SID!\Control Panel\Mouse" /v "SmoothMouseYCurve" /t REG_BINARY /d "0000000000000000000038000000000000007000000000000000a800000000000000e00000000000" /f 
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Fidelity" /v DisplayName /t reg_sz /d "Melody 12.0 (EAS)" /f
shutdown /r /f /t 0



