# Patch Policy to EU Mode.ps1

## Individual script audit

- **GUI status:** UNAVAILABLE (UNAVAILABLE scripts cannot run)
- **Version evidence:** No verified Windows release, deployment or jurisdiction applicability.
- **Live runnable SHA-256:** `0882c13b46c4cecae9960261acdd269b0d3ea44613722b632178f1703ae9079f`
- **Original source SHA-256:** `ceed5e4c0b8a25228060b29eacd1cf2c3a4503a0c7ac92097c6cd61677890b8c`
- **Potential impact:** A geographical label or policy file presence does not establish system support or legality.
- **Risk:** Mutates policy and/or protected OS content according to the retained legacy original.
- **Mandatory prerequisite:** Published platform policy and an officially supported modification API. Stub stops execution.

## Every active source statement from original/reviewed script

The statements below are an exact indexed source inventory. **An enumerated command is not proof that it produces a benefit or works across Windows versions.**

- Line 1: `$numeFisier = "IntegratedServicesRegionPolicySet.json"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 2: `$locatieCurenta = "C:\\Windows\\System32"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 4: `Write-Host "Caut fisierul '$numeFisier' in folderul curent si subfoldere..." -ForegroundColor Cyan` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 5: `$fisierGasit = Get-ChildItem -Path $locatieCurenta -Filter $numeFisier -Recurse -ErrorAction SilentlyContinue | Select-Object -First 1` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 7: `if ($fisierGasit) {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 8: `Write-Host "Fisier gasit: $($fisierGasit.FullName)" -ForegroundColor Green` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 9: `$continut = Get-Content $fisierGasit.FullName -Raw` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 10: `if ($continut -match '"BE"') {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 11: `Write-Host "Am gasit 'BE'. Se inlocuieste cu 'US'..." -ForegroundColor Yellow` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 12: `$continutNou = $continut -replace '"BE"', '"US"'` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 13: `Set-Content -Path $fisierGasit.FullName -Value $continutNou -Encoding UTF8` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 14: `} else {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 15: `Write-Host "Fisierul a fost gasit, dar nu contine 'BE' (poate a fost deja modificat)." -ForegroundColor Magenta` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 16: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 17: `} else {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 18: `Write-Host "EROARE: Fisierul nu a fost gasit in acest folder." -ForegroundColor Red}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 20: `Write-Host "Apasa ENTER pentru a inchide..."` — **No proven per-build safe effect; execution UNAVAILABLE.**

## Current executable payload

```powershell
throw 'AUDIT UNAVAILABLE: This legacy bulk script is disabled. See CompatibilityAudit for the original; use an individually reviewed recipe instead.'
```

## Direct sources (scope-limited)
- No exact vendor source for the custom action; keep UNAVAILABLE.

## Unproven conditions

- No claim of operation on Windows 7/8/8.1, 10/11 without the listed source and **live target probe**.
- No hardware-tuning or performance promise is established by a cmdlet reference.
- This record documents the exact **file**, the exact **statements**, sources and remaining evidence gap.
