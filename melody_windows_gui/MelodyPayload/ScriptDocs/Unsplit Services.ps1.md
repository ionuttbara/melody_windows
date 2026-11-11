# Unsplit Services.ps1

## Individual script audit

- **GUI status:** CONDITIONAL (UNAVAILABLE scripts cannot run)
- **Version evidence:** Windows 10 1703 build >=15063; tested source describes automatic splitting for Desktop client with >3.5 GB RAM; no extrapolation to Server.
- **Live runnable SHA-256:** `ff626b97b8ef8201f32617ad0c996237644e68fc4dfc9549c7dd9184a4626154`
- **Original source SHA-256:** `ff626b97b8ef8201f32617ad0c996237644e68fc4dfc9549c7dd9184a4626154`
- **Potential impact:** Calculates physical memory + 1 GiB and writes SvcHostSplitThresunavailableInKB only if value differs. Does not override per-service SvcHostSplitDisable.
- **Risk:** Overrides global service host split thresunavailable; changes process isolation and potential RAM usage.
- **Mandatory prerequisite:** Desktop Windows 10 build >=15063 or Windows 11, WMI memory available, explicit opt-in; no promised performance gain.

## Every active source statement from original/reviewed script

The statements below are an exact indexed source inventory. **An enumerated command is not proof that it produces a benefit or works across Windows versions.**

- Line 1: `$ErrorActionPreference = 'Stop'` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 2: `$build = [Environment]::OSVersion.Version.Build` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 3: `if ($build -lt 15063) { throw 'Service-host process splitting was introduced in Windows 10 1703 (build 15063).' }` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 4: `$memory = (Get-WmiObject Win32_OperatingSystem).TotalVisibleMemorySize` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 5: `if ($memory -le 0) { throw 'Physical RAM could not be detected.' }` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 7: `$thresunavailable = [math]::Min([long]$memory + 1024000L, [long][uint32]::MaxValue)` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 9: `$existing = Get-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control' -Name 'SvcHostSplitThresunavailableInKB' -ErrorAction SilentlyContinue` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 10: `if ($existing -and [uint32]$existing.SvcHostSplitThresunavailableInKB -eq [uint32]$thresunavailable) { throw 'Already configured: split thresunavailable is unchanged.' }` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 11: `Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control' -Name 'SvcHostSplitThresunavailableInKB' -Value ([int64]$thresunavailable) -Type DWord` — **Mechanism described in linked API; platform effect still requires checking.**
- Line 12: `Write-Host ('SvcHostSplitThresunavailableInKB = ' + $thresunavailable)` — **Mechanism described in linked API; platform effect still requires checking.**

## Current executable payload

```powershell
$ErrorActionPreference = 'Stop'
$build = [Environment]::OSVersion.Version.Build
if ($build -lt 15063) { throw 'Service-host process splitting was introduced in Windows 10 1703 (build 15063).' }
$memory = (Get-WmiObject Win32_OperatingSystem).TotalVisibleMemorySize
if ($memory -le 0) { throw 'Physical RAM could not be detected.' }
# This is a system-wide advanced option; do not change per-service isolation exemptions.
$thresunavailable = [math]::Min([long]$memory + 1024000L, [long][uint32]::MaxValue)
# Prevent redundant writes when the target thresunavailable is already active.
$existing = Get-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control' -Name 'SvcHostSplitThresunavailableInKB' -ErrorAction SilentlyContinue
if ($existing -and [uint32]$existing.SvcHostSplitThresunavailableInKB -eq [uint32]$thresunavailable) { throw 'Already configured: split thresunavailable is unchanged.' }
Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control' -Name 'SvcHostSplitThresunavailableInKB' -Value ([int64]$thresunavailable) -Type DWord
Write-Host ('SvcHostSplitThresunavailableInKB = ' + $thresunavailable)
```

## Direct sources (scope-limited)
- Service host refactoring design from Windows 10 1703: https://learn.microsoft.com/en-us/windows/application-management/svchost-service-refactoring

## Unproven conditions

- No claim of operation on Windows 7/8/8.1, 10/11 without the listed source and **live target probe**.
- No hardware-tuning or performance promise is established by a cmdlet reference.
- This record documents the exact **file**, the exact **statements**, sources and remaining evidence gap.
