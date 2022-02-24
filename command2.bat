:: Start with setting the location

pushd "%CD%"
CD /D "%~dp0"

:: Starting 
PowerRun.exe Regedit.exe /S fidelityreg_reg11.reg
Regedit.exe /S fidelityreg_reg11.reg
PowerRun.exe "wum2.bat"
:: Installing Microsoft's Certs (because they removed sometime)...

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
	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Psched\Parameters\Adapters\%%s" /v "NonBestEffortLimit" /t Reg_DWORD /d "0" /f
	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "DeadGWDetectDefault" /t Reg_DWORD /d "1" /f 
	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "PerformRouterDiscovery" /t Reg_DWORD /d "1" /f
	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "TcpInitialRTT" /t Reg_DWORD /d "0" /f
 	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "TCPNoDelay" /t Reg_DWORD /d "1" /f
	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "TcpAckFrequency" /t Reg_DWORD /d "1" /f
	Reg add "HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\%%s" /v "TcpDelAckTicks" /t Reg_DWORD /d "0" /f
	)


for /f %%r in ('Reg query "HKLM\SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002bE10318}" /f "PCI\VEN_" /d /s^|Findstr HKEY_') do (
Reg add %%r /v "AutoDisableGigabit" /t Reg_SZ /d "0" /f 
Reg add %%r /v "EnableGreenEthernet" /t Reg_SZ /d "0" /f 
Reg add %%r /v "GigaLite" /t Reg_SZ /d "0" /f
Reg add %%r /v "PowerSavingMode" /t Reg_SZ /d "0" /f
Reg add %%r /v "S5WakeOnLan" /t Reg_SZ /d "0" /f
)

reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v MaxConnectionsPerServer /t REG_DWORD /d a /f 
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v MaxConnectionsPer1_0Server /t REG_DWORD /d a /f 
reg add "HKU\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v MaxConnectionsPerServer /t REG_DWORD /d a /f 
reg add "HKU\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v MaxConnectionsPer1_0Server /t REG_DWORD /d a /f 

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
for /f %%i in ('Reg query "%%a" /v "*WakeOnMagicPacket" ^| findstr "HKEY"') do (Reg add "%%i" /v "*WakeOnMagicPacket" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*WakeOnPattern" ^| findstr "HKEY"') do (Reg add "%%i" /v "*WakeOnPattern" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*TCPChecksumOffloadIPv4" ^| findstr "HKEY"') do (Reg add "%%i" /v "*TCPChecksumOffloadIPv4" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*TCPChecksumOffloadIPv6" ^| findstr "HKEY"') do (Reg add "%%i" /v "*TCPChecksumOffloadIPv6" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*UDPChecksumOffloadIPv4" ^| findstr "HKEY"') do (Reg add "%%i" /v "*UDPChecksumOffloadIPv4" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*UDPChecksumOffloadIPv6" ^| findstr "HKEY"') do (Reg add "%%i" /v "*UDPChecksumOffloadIPv6" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "WolShutdownLinkSpeed" ^| findstr "HKEY"') do (Reg add "%%i" /v "WolShutdownLinkSpeed" /t Reg_SZ /d "2" /f)
for /f %%i in ('Reg query "%%a" /v "*SpeedDuplex" ^| findstr "HKEY"') do (Reg add "%%i" /v "*SpeedDuplex" /t Reg_SZ /d "6" /f)
for /f %%i in ('Reg query "%%a" /v "*LsoV2IPv4" ^| findstr "HKEY"') do (Reg add "%%i" /v "*LsoV2IPv4" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*LsoV2IPv6" ^| findstr "HKEY"') do (Reg add "%%i" /v "*LsoV2IPv6" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*TransmitBuffers" ^| findstr "HKEY"') do (Reg add "%%i" /v "*TransmitBuffers" /t Reg_SZ /d "128" /f)
for /f %%i in ('Reg query "%%a" /v "*ReceiveBuffers" ^| findstr "HKEY"') do (Reg add "%%i" /v "*ReceiveBuffers" /t Reg_SZ /d "512" /f)
for /f %%i in ('Reg query "%%a" /v "*JumboPacket" ^| findstr "HKEY"') do (Reg add "%%i" /v "*JumboPacket" /t Reg_SZ /d "9014" /f)
for /f %%i in ('Reg query "%%a" /v "*PMARPOffload" ^| findstr "HKEY"') do (Reg add "%%i" /v "*PMARPOffload" /t Reg_SZ /d "1" /f)
for /f %%i in ('Reg query "%%a" /v "*PMNSOffload" ^| findstr "HKEY"') do (Reg add "%%i" /v "*PMNSOffload" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*InterruptModeration" ^| findstr "HKEY"') do (Reg add "%%i" /v "*InterruptModeration" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*ModernStandbyWoLMagicPacket" ^| findstr "HKEY"') do (Reg add "%%i" /v "*ModernStandbyWoLMagicPacket" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "WakeOnLinkChange" ^| findstr "HKEY"') do (Reg add "%%i" /v "WakeOnLinkChange" /t Reg_SZ /d "0" /f)
for /f %%i in ('Reg query "%%a" /v "*IPChecksumOffloadIPv4" ^| findstr "HKEY"') do (Reg add "%%i" /v "*IPChecksumOffloadIPv4" /t Reg_SZ /d "3" /f)
for /f %%i in ('Reg query "%%a" /v "*RSS" ^| findstr "HKEY"') do (Reg add "%%i" /v "*RSS" /t Reg_SZ /d "1" /f)
for /f %%i in ('Reg query "%%a" /v "*NumRssQueues" ^| findstr "HKEY"') do (Reg add "%%i" /v "*NumRssQueues" /t Reg_SZ /d "4" /f)
) 

::Search
sc config WSearch start= disabled

::VR Services

sc config perceptionsimulation start= disabled
sc config SharedRealitySvc start= disabled
sc config spectrum start= disabled
sc config MixedRealityOpenXRSvc start= disabled


::Virtual Machine
sc config VMAuthdService start=demand
sc config VMnetDHCP start= demand
sc config VMware NAT Service start= demand
sc config VMUSBArbService start= demand
sc config VMwareHostd start= demand
Reg.exe add "HKCU\Control Panel\Sound" /v "Beep" /t REG_SZ /d "no" /f 


:: Driver Service 2

Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\rdbss" /v "Start" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\lltdio" /v "Start" /t REG_DWORD /d "2" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\hwpolicy" /v "Start" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\vdrvroot" /v "Start" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Services\tcpipreg" /v "Start" /t REG_DWORD /d "2" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\TrustedInstaller" /v "Start" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\srvnet" /v "Start" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\rspndr" /v "Start" /t REG_DWORD /d "2" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Services\Schedule" /v "Start" /t REG_DWORD /d "2" /f

:: Task Remover

del "C:\Windows\System32\Tasks\Microsoft\VisualStudio\*" /F /S /Q
del "C:\Windows\System32\Tasks\FxSound\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\.NET Framework\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Active Directory Rights Management Services Client\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Application Experience\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\AppxDeploymentClient\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Autochk\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Chkdsk\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Customer Experience Improvement Program\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Data Integrity Scan\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Defrag\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\DeviceDirectoryClient\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Diagnosis\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\DiskCleanup\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\DiskDiagnostic\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\DiskFootprint\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\DUSM\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\EnterpriseMgmt\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\ExploitGuard\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Feedback\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\FileHistory\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Input\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Location\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Maintenance\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Maps\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\MemoryDiagnostic\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\NetTrace\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Offline Files\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\PLA\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Power Efficiency Diagnostics\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Registry\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\RemoteAssistance\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\RetailDemo\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Servicing\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\SettingSync\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Setup\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Shell\FamilySafetyMonitor" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Shell\FamilySafetyRefreshTask" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\SoftwareProtectionPlatform\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\SpacePort\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Speech\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Storage Tiers Management\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Sysmain\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Task Manager\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Time Synchronization\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\UNP\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\UpdateOrchestrator\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\WaaSMedic\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\WCM\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\WDI\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Windows Defender\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Windows Error Reporting\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Windows Media Sharing\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\WindowsColorSystem\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\Work Folders\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\WwanSvc\*" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Windows\WindowsUpdate\Automatic Update" /F /S /Q
del "C:\Windows\System32\Tasks\Microsoft\Office\*" /F /S /Q

:: Remove Telemetry
rmdir /s /q "C:\Program Files (x86)\Microsoft\EdgeUpdate"
rmdir /s /q "C:\Program Files (x86)\Microsoft\EdgeCore"
rmdir /s /q "C:\Program Files (x86)\Microsoft\EdgeWebview"
rmdir /s /q "C:\Windows\SystemApps\Microsoft.MicrosoftEdge_8wekyb3d8bbwe"
rmdir /s /q "C:\Windows\SystemApps\Microsoft.MicrosoftEdgeDevToolsClient_8wekyb3d8bbwe"
rmdir /s /q "C:\Windows\SystemApps\Microsoft.Windows.AppRep.ChxApp_cw5n1h2txyewy"
rmdir /s /q "C:\Windows\SystemApps\microsoft.windows.narratorquickstart_8wekyb3d8bbwe"
rmdir /s /q "C:\Windows\SystemApps\Microsoft.Windows.PeopleExperienceHost_cw5n1h2txyewy"
rmdir /s /q "C:\Windows\SystemApps\ParentalControls_cw5n1h2txyewy"
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

:: Boot Parameters

bcdedit /timeout 0
bcdedit /set hypervisorlaunchtype Off 
bcdedit /set debug No
bcdedit /set sos Yes 
bcdedit /set ems No 
bcdedit /set noumex Yes 
bcdedit /set bootems No 
bcdedit /set perfmem 0 
bcdedit /set onecpu No
bcdedit /set nolowmem Yes
bcdedit /set vm No
bcdedit /set MSI Default
bcdedit /set vsmlaunchtype Off 
bcdedit /set nx AlwaysOff
bcdedit /set pae ForceEnable
bcdedit /set extendedinput Yes 
bcdedit /set highestmode Yes 
bcdedit /set forcefipscrypto No 
bcdedit /set clustermodeaddressing 1 
bcdedit /set uselegacyapicmode No 
bcdedit /set halbreakpoint No 
bcdedit /set forcelegacyplatform No 
bcdedit /set tpmbootentropy ForceDisable 
bcdedit /set allowedinmemorysettings 0x0 
bcdedit /set isolatedcontext No 
bcdedit /set configaccesspolicy Default
bcdedit /set usephysicaldestination No
bcdedit /set usefirmwarepcisettings No
bcdedit /set usephysicaldestination No 
bcdedit /set graphicsmodedisabled No 
bcdedit /set linearaddress57 OptOut
bcdedit /set increaseuserva 268435328
bcdedit /set firstmegabytepolicy UseAll
bcdedit /set avoidlowmemory 0x8000000
bcdedit /set disableelamdrivers yes  
bcdedit /set useplatformclock No
bcdedit /set vsmlaunchtype off
bcdedit /set recoveryenabled NO 
bcdedit /set x2apicpolicy enable 
bcdedit /set tscsyncpolicy legacy
bcdedit /set disabledynamictick yes 
bcdedit /set useplatformtick yes
bcdedit /deletevalue useplatformclock 
bcdedit /set bootmenupolicy Legacy 
bcdedit -set NOINTEGRITYCHECKS OFF
bcdedit -set TESTSIGNING OFF

:: Copy Files to Windows Folder
xcopy "*.ico" "C:\Windows" /Y /E /H /C /I

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

:: Another Tweaks
for /f %%i in ('Reg query "HKLM\SYSTEM\CurrentControlSet\Services" /s /f DmaRemappingCompatible ^| find /i "Services\" ') do (Reg add "%%i" /v "DmaRemappingCompatible" /t Reg_DWORD /d "0" /f )
netsh Advfirewall set allprofiles state on
fsutil behavior set disable8dot3 1
fsutil behavior set disableLastAccess 0
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Fidelity" /v DisplayName /t reg_sz /d "Melody 12.03 (EAS)" /f

shutdown /r /f /t 0