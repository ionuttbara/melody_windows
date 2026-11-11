# Remove Features.ps1

## Individual script audit

- **GUI status:** CONDITIONAL (UNAVAILABLE scripts cannot run)
- **Version evidence:** GUI build >=10240; feature command + target must actually exist.
- **Live runnable SHA-256:** `bf22f562c5d3da80ba75b8de28cce10cac494fca76d572524eb5c57589f50f90`
- **Original source SHA-256:** `2c025fc4074a71dded28a2c13d250f4132d9081a069af14a1860a96b69055f96`
- **Potential impact:** Exact allowlist TFTP, TelnetClient and SimpleTCP; inspect state == Enabled and use Disable-WindowsOptionalFeature without -Remove.
- **Risk:** Disables optional features if installed; may impact software depending on them.
- **Mandatory prerequisite:** Administrator, target feature name in the live image, State == Enabled, user opt-in, software dependencies reviewed.

## Every active source statement from original/reviewed script

The statements below are an exact indexed source inventory. **An enumerated command is not proof that it produces a benefit or works across Windows versions.**

- Line 3: `$flist = @("TFTP", "TIFFIFilter", "Containers", "MediaPlayback", "SimpleTCP", "WorkFolders-Client", "Client-ProjFS", "MicrosoftWindowsPowerShellV2", "MicrosoftWindowsPowerShellV2Root", "TelnetClient", "SearchEngine-Client-Package", "Printing-XPSServices-Features", "Windows-Defender-Default-Definitions", "Printing-PrintToPDFServices-Features","DirectoryServices-ADAM-Client","SearchEngine-Client-Package","SmbDirect","MSRDC-Infrastructure","Printing-Foundation-Features","Printing-Foundation-InternetPrinting-Client","Microsoft-RemoteDesktopConnection","MSRDC-Infrastructure")` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 5: `$fliste = @("LegacyComponents", "DirectPlay")` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 6: `foreach ($feature in $flist) {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 7: `if ((Get-WindowsOptionalFeature -Online -FeatureName $feature).State -eq 'Enabled') {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 8: `Write-Output "Disabling feature $feature"` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 9: `Disable-WindowsOptionalFeature -Online -FeatureName $feature -Remove -NoRestart` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 10: `}` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 11: `}` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 13: `foreach ($feature in $flist) {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 14: `if ((Get-WindowsOptionalFeature -Online -FeatureName $feature).State -eq 'Disabled') {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 15: `Write-Output "Disabling feature $feature"` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 16: `Disable-WindowsOptionalFeature -Online -FeatureName $feature -Remove -NoRestart` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 17: `}` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 18: `}` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 22: `foreach ($feature in $fliste) {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 23: `Enable-WindowsOptionalFeature -Online -FeatureName $feature -NoRestart` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 24: `}` — **Mechanism described in linked API; platform effect still requires checking.**

## Current executable payload

```powershell
# Carefully scoped and opt-in feature changes. No -Remove or OS servicing payload deletion.
$ErrorActionPreference = 'Stop'
if (-not (Get-Command Get-WindowsOptionalFeature -ErrorAction SilentlyContinue)) { throw 'DISM cmdlets are not available.' }
$available = @(Get-WindowsOptionalFeature -Online)
$target = @('TFTP','TelnetClient','SimpleTCP')
if (-not @($available | Where-Object { $_.FeatureName -in $target -and $_.State -eq 'Enabled' }).Count) { throw 'None of the approved optional features is enabled.' }
foreach ($name in $target) {
    $feature = $available | Where-Object { $_.FeatureName -eq $name } | Select-Object -First 1
    if (-not $feature) { Write-Host "Skip unavailable feature: $name"; continue }
    if ($feature.State -eq 'Enabled') { Disable-WindowsOptionalFeature -Online -FeatureName $name -NoRestart -ErrorAction Stop }
}
```

## Direct sources (scope-limited)
- Get-WindowsOptionalFeature detects exact features: https://learn.microsoft.com/en-us/powershell/module/dism/get-windowsoptionalfeature
- Disable-WindowsOptionalFeature documented mechanism: https://learn.microsoft.com/en-us/powershell/module/dism/disable-windowsoptionalfeature

## Unproven conditions

- No claim of operation on Windows 7/8/8.1, 10/11 without the listed source and **live target probe**.
- No hardware-tuning or performance promise is established by a cmdlet reference.
- This record documents the exact **file**, the exact **statements**, sources and remaining evidence gap.
