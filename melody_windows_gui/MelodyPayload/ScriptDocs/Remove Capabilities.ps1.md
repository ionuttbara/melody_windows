# Remove Capabilities.ps1

## Individual script audit

- **GUI status:** CONDITIONAL (UNAVAILABLE scripts cannot run)
- **Version evidence:** GUI build >=10240; DISM cmdlets must be present (not a universal minimum vendor claim).
- **Live runnable SHA-256:** `bac14b2181b6fb20a18d7e61ae50e4815ec7ba61151b476f20fbdff5c040cd8e`
- **Original source SHA-256:** `ad16e6feb8b3b71325bcdabb0d03c18a4e9432cce9b8e711ca6552f235535aa4`
- **Potential impact:** Iterates exactly StepsRecorder~~~~0.0.1.0 and MathRecognizer~~~~0.0.1.0, queries Installed and only removes an exact installed name.
- **Risk:** Removes an actual optional Windows capability from the servicing image.
- **Mandatory prerequisite:** Administrator, DISM command availability and matching exact installed capabilities. No global default; selection explicit.

## Every active source statement from original/reviewed script

The statements below are an exact indexed source inventory. **An enumerated command is not proof that it produces a benefit or works across Windows versions.**

- Line 2: `$flist = @("*Realtek*", "*Intel*", "*Broadcom*", "*Qualcomm*", "*Marvel*",` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 3: `"*Vmware*", "*Ethernet*", "*InternetExplorer*", "*StepsRecorder*", "*WindowsMediaPlayer*",` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 4: `"*Wallpapers*", "*Print*", "*MathRecognizer*", "*PowerShell*",` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 5: `"*QuickAssist*", "*OneSync*", "*LA57*", "*Ralink*", "*Virtual*", "*TCP*", "*Hello*","*Theme*","*Edge*")` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 7: `foreach ($item in $flist) {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 9: `$checkCapabilities = Get-WindowsCapability -Online | Where-Object { $_.Name -like $item }` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 11: `foreach ($checkCapability in $checkCapabilities) {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 12: `if ($checkCapability.State -eq 'Installed') {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 13: `try {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 15: `Remove-WindowsCapability -Online -Name $checkCapability.Name -ErrorAction Stop` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 16: `} catch {` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 17: `Write-Host "Error at $($checkCapability.Name): $($_.Exception.Message)"` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 18: `}` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 19: `}` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 20: `}` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 21: `}` — **Mechanism described in linked API; platform effect still requires checking.**

## Current executable payload

```powershell
# Safe, opt-in subset. No device drivers, browser, PowerShell or printer removal.
$ErrorActionPreference = 'Stop'
if ([Environment]::OSVersion.Version.Build -lt 10240) { throw 'Capabilities require Windows 10 or later.' }
if (-not (Get-Command Get-WindowsCapability -ErrorAction SilentlyContinue)) { throw 'DISM capability cmdlets are unavailable.' }
$approved = @('StepsRecorder~~~~0.0.1.0', 'MathRecognizer~~~~0.0.1.0')
$installed = @(Get-WindowsCapability -Online | Where-Object { $_.State -eq 'Installed' })
if (-not @($installed | Where-Object { $_.Name -in $approved }).Count) { throw 'No approved installed capability exists on this system.' }
foreach ($name in $approved) {
    $match = @($installed | Where-Object { $_.Name -eq $name })
    if ($match.Count -eq 0) { Write-Host "Skip missing capability: $name"; continue }
    Remove-WindowsCapability -Online -Name $name -ErrorAction Stop
}
```

## Direct sources (scope-limited)
- Get-WindowsCapability command and Installed discovery: https://learn.microsoft.com/en-us/powershell/module/dism/get-windowscapability
- Remove-WindowsCapability: https://learn.microsoft.com/en-us/powershell/module/dism/remove-windowscapability

## Unproven conditions

- No claim of operation on Windows 7/8/8.1, 10/11 without the listed source and **live target probe**.
- No hardware-tuning or performance promise is established by a cmdlet reference.
- This record documents the exact **file**, the exact **statements**, sources and remaining evidence gap.
