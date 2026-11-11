# Disable Device to TurnOff this device to save power.ps1

## Individual script audit

- **GUI status:** UNAVAILABLE (UNAVAILABLE scripts cannot run)
- **Version evidence:** No supported blanket matrix
- **Live runnable SHA-256:** `0882c13b46c4cecae9960261acdd269b0d3ea44613722b632178f1703ae9079f`
- **Original source SHA-256:** `a190b3ee8bdbd69d11db41067a4c0dcd35aebf7a97ebc5b3ad3214bbbc688155`
- **Potential impact:** Previous implementation changes Win32_PnPEntity power-management flags across all devices. There is no generic safe matrix.
- **Risk:** Bulk change of per-device power management across different buses and drivers.
- **Mandatory prerequisite:** A specific PnP device, its hardware ID, driver/provider documentation, device capability and a tested undo path.

## Every active source statement from original/reviewed script

The statements below are an exact indexed source inventory. **An enumerated command is not proof that it produces a benefit or works across Windows versions.**

- Line 2: `$device = Get-WmiObject Win32_PnPEntity` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 3: `$powerMgmt = Get-WmiObject MSPower_DeviceEnable -Namespace root\wmi` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 4: `foreach ($p in $powerMgmt)` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 5: `{` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 6: `$IN = $p.InstanceName.ToUpper()` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 7: `foreach ($h in $device)` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 8: `{` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 9: `$PNPDI = $h.PNPDeviceID` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 10: `if ($IN -like "*$PNPDI*")` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 11: `{` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 12: `$p.enable = $False` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 13: `$p.psbase.put()` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 14: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 15: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 16: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 19: `$device = Get-WmiObject Win32_PnPEntity` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 20: `$powerMgmt = Get-WmiObject MSPower_DeviceWakeEnable -Namespace root\wmi` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 21: `foreach ($p in $powerMgmt)` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 22: `{` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 23: `$IN = $p.InstanceName.ToUpper()` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 24: `foreach ($h in $device)` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 25: `{` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 26: `$PNPDI = $h.PNPDeviceID` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 27: `if ($IN -like "*$PNPDI*")` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 28: `{` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 29: `$p.enable = $False` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 30: `$p.psbase.put()` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 31: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 32: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 33: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**

## Current executable payload

```powershell
throw 'AUDIT UNAVAILABLE: This legacy bulk script is disabled. See CompatibilityAudit for the original; use an individually reviewed recipe instead.'
```

## Direct sources (scope-limited)
- WMI Win32_PnPEntity class (mechanism only): https://learn.microsoft.com/en-us/windows/win32/cimwin32prov/win32-pnpentity

## Unproven conditions

- No claim of operation on Windows 7/8/8.1, 10/11 without the listed source and **live target probe**.
- No hardware-tuning or performance promise is established by a cmdlet reference.
- This record documents the exact **file**, the exact **statements**, sources and remaining evidence gap.
