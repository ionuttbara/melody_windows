# Disable HPET.ps1

## Individual script audit

- **GUI status:** UNAVAILABLE (UNAVAILABLE scripts cannot run)
- **Version evidence:** Original script used build >=10240; this is NOT a proven compatibility floor.
- **Live runnable SHA-256:** `9d90a2700bc6f58a721c0f130450412b4f53d731f5c672fded0ce0714df77c68`
- **Original source SHA-256:** `95d8c122e57e93190a3408ba4969552c6c167463bf2e7597eae7b344cf967f5b`
- **Potential impact:** The PnpDevice cmdlet can disable a device; this does not establish any measurable universal latency improvement.
- **Risk:** Disables an actual system PnP device, potentially affecting timer configuration.
- **Mandatory prerequisite:** Device and motherboard-specific validation, precise objective and recovery test. Script replaced by hard STOP.

## Every active source statement from original/reviewed script

The statements below are an exact indexed source inventory. **An enumerated command is not proof that it produces a benefit or works across Windows versions.**

- Line 1: `$ErrorActionPreference = 'Stop'` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 2: `if ([Environment]::OSVersion.Version.Build -lt 10240) { throw 'PnP device cmdlets are not guaranteed on this Windows build.' }` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 3: `if (-not (Get-Command Get-PnpDevice -ErrorAction SilentlyContinue) -or -not (Get-Command Disable-PnpDevice -ErrorAction SilentlyContinue)) { throw 'PnpDevice module unavailable.' }` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 4: `$devices = @(Get-PnpDevice -FriendlyName 'High precision event timer' -ErrorAction SilentlyContinue | Where-Object {$_.Status -eq 'OK'})` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 5: `if ($devices.Count -eq 0) { throw 'No active HPET device to disable.' }` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 6: `$devices | Disable-PnpDevice -Confirm:$false -ErrorAction Stop` — **No proven per-build safe effect; execution UNAVAILABLE.**

## Current executable payload

```powershell
# This method disables a physical PnP device. There is no proven OS-wide latency gain.
throw 'AUDIT UNAVAILABLE: Disabling HPET is blocked pending hardware-specific verification. See CompatibilityAudit/ScriptIndividualDocs.'
```

## Direct sources (scope-limited)
- Disable-PnpDevice, command API ONLY: https://learn.microsoft.com/en-us/powershell/module/pnpdevice/disable-pnpdevice

## Unproven conditions

- No claim of operation on Windows 7/8/8.1, 10/11 without the listed source and **live target probe**.
- No hardware-tuning or performance promise is established by a cmdlet reference.
- This record documents the exact **file**, the exact **statements**, sources and remaining evidence gap.
