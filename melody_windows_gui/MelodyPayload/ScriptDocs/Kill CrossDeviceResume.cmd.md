# Kill CrossDeviceResume.cmd

## Individual script audit

- **GUI status:** UNAVAILABLE (UNAVAILABLE scripts cannot run)
- **Version evidence:** Unverified PolicyManager user-SID subpath; not permitted on any build.
- **Live runnable SHA-256:** `002e96c89099a512a07c51c48eb5b2bc9fcff65c0827920f730435b536ccb454`
- **Original source SHA-256:** `50afa18a73326850f40e7df48d0baca25a3084d516d018759580ba48b7ec4f6e`
- **Potential impact:** Neither the exact key path nor this provider flag has independent vendor-backed release semantics.
- **Risk:** Writes machine PolicyManager under a user SID, including *_ProviderSet, rather than a verified supported policy store.
- **Mandatory prerequisite:** Vendor-published policy/CSP registry mapping with tested scope and per-build evidence. Replaced with no-op error stub.

## Every active source statement from original/reviewed script

The statements below are an exact indexed source inventory. **An enumerated command is not proof that it produces a benefit or works across Windows versions.**

- Line 2: `for /f %%I in ('powershell -Command "[System.Security.Principal.WindowsIdentity]::GetCurrent().User.Value"') do set "USER_SID=%%I"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 3: `set "REG_KEY=HKLM\SOFTWARE\Microsoft\PolicyManager\current\%USER_SID%\Connectivity"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 4: `reg add "%REG_KEY%" /v "DisableCrossDeviceResume" /t REG_DWORD /d 1 /f` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 5: `reg add "%REG_KEY%" /v "DisableCrossDeviceResume_ProviderSet" /t REG_DWORD /d 1 /f` — **No proven per-build safe effect; execution UNAVAILABLE.**

## Current executable payload

```bat
@echo off
echo AUDIT UNAVAILABLE: Unverified PolicyManager SID keys; no registry changes permitted.
exit /b 17
```

## Direct sources (scope-limited)
- No exact vendor source for the custom action; keep UNAVAILABLE.

## Unproven conditions

- No claim of operation on Windows 7/8/8.1, 10/11 without the listed source and **live target probe**.
- No hardware-tuning or performance promise is established by a cmdlet reference.
- This record documents the exact **file**, the exact **statements**, sources and remaining evidence gap.
