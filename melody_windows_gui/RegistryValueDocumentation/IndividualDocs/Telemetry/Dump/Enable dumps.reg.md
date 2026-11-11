# Telemetry/Dump/Enable dumps.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `d450a161992063be0bfb01f897d8f143f15aaafff7912677320c455999270a77`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `DumpType`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează WER LocalDumps pentru minidump (DumpType=1). Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Configures WER LocalDumps for a minidump (DumpType=1). The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** LocalDumps corrected to documented REG_DWORD DumpType/DumpCount and default dump folder.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/wer/collecting-user-mode-dumps`

### L6 · SET-VALUE · `DumpCount`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Windows Error Reporting\LocalDumps`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Păstrează până la 10 dump-uri locale WER (DumpCount=10). Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Keeps up to 10 WER local dumps (DumpCount=10). The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** LocalDumps corrected to documented REG_DWORD DumpType/DumpCount and default dump folder.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/wer/collecting-user-mode-dumps`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/wer/collecting-user-mode-dumps
