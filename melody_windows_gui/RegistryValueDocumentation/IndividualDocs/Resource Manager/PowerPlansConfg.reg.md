# Resource Manager/PowerPlansConfg.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `6865b8343482b7879e6c8fefdeeef6b61c3dfc61debb963dcde7abff3ce05a77`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 344
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0e796bdb-100d-47d6-a2d5-f7d2daa51f51`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 0e796bdb-100d-47d6-a2d5-f7d2daa51f51, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 0e796bdb-100d-47d6-a2d5-f7d2daa51f51 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L7 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0e796bdb-100d-47d6-a2d5-f7d2daa51f51`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 0e796bdb-100d-47d6-a2d5-f7d2daa51f51, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 0e796bdb-100d-47d6-a2d5-f7d2daa51f51 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L10 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\29F6C1DB-86DA-48C5-9FDB-F2B67B1F44DA`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 29F6C1DB-86DA-48C5-9FDB-F2B67B1F44DA, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 29F6C1DB-86DA-48C5-9FDB-F2B67B1F44DA to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L11 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\29F6C1DB-86DA-48C5-9FDB-F2B67B1F44DA`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 29F6C1DB-86DA-48C5-9FDB-F2B67B1F44DA, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 29F6C1DB-86DA-48C5-9FDB-F2B67B1F44DA to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\309dce9b-bef4-4119-9921-a851fb12f0f4`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „309dce9b-bef4-4119-9921-a851fb12f0f4” din politicile de alimentare Windows, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Deletes the entire “309dce9b-bef4-4119-9921-a851fb12f0f4” key in Windows power policies, including all values and subkeys. Exact key semantics are unverified. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L16 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\3C0BC021-C8A8-4E07-A973-6B14CBCB2B7E`
- **Raw .reg data:** `dword:0000012c`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 3C0BC021-C8A8-4E07-A973-6B14CBCB2B7E, la 300 (0x0000012C). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 3C0BC021-C8A8-4E07-A973-6B14CBCB2B7E to 300 (0x0000012C). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L17 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\3C0BC021-C8A8-4E07-A973-6B14CBCB2B7E`
- **Raw .reg data:** `dword:0000012c`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 3C0BC021-C8A8-4E07-A973-6B14CBCB2B7E, la 300 (0x0000012C). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 3C0BC021-C8A8-4E07-A973-6B14CBCB2B7E to 300 (0x0000012C). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L20 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\5CA83367-6E45-459F-A27B-476B1D01C936`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 5CA83367-6E45-459F-A27B-476B1D01C936, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 5CA83367-6E45-459F-A27B-476B1D01C936 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L21 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\5CA83367-6E45-459F-A27B-476B1D01C936`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 5CA83367-6E45-459F-A27B-476B1D01C936, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 5CA83367-6E45-459F-A27B-476B1D01C936 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L24 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\637EA02F-BBCB-4015-8E2C-A1C7B9C0B546`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 637EA02F-BBCB-4015-8E2C-A1C7B9C0B546, la 3 (0x00000003). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 637EA02F-BBCB-4015-8E2C-A1C7B9C0B546 to 3 (0x00000003). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L27 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6738E2C4-E8A5-4A42-B16A-E040E769756E`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6738E2C4-E8A5-4A42-B16A-E040E769756E, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6738E2C4-E8A5-4A42-B16A-E040E769756E to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L28 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6738E2C4-E8A5-4A42-B16A-E040E769756E`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6738E2C4-E8A5-4A42-B16A-E040E769756E, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6738E2C4-E8A5-4A42-B16A-E040E769756E to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L31 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7648EFA3-DD9C-4E3E-B566-50F929386280`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7648EFA3-DD9C-4E3E-B566-50F929386280, la 3 (0x00000003). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7648EFA3-DD9C-4E3E-B566-50F929386280 to 3 (0x00000003). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L32 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7648EFA3-DD9C-4E3E-B566-50F929386280`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7648EFA3-DD9C-4E3E-B566-50F929386280, la 3 (0x00000003). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7648EFA3-DD9C-4E3E-B566-50F929386280 to 3 (0x00000003). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L35 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7bc4a2f9-d8fc-4469-b07b-33eb785aaca0`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7bc4a2f9-d8fc-4469-b07b-33eb785aaca0, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7bc4a2f9-d8fc-4469-b07b-33eb785aaca0 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L36 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7bc4a2f9-d8fc-4469-b07b-33eb785aaca0`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7bc4a2f9-d8fc-4469-b07b-33eb785aaca0, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7bc4a2f9-d8fc-4469-b07b-33eb785aaca0 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L39 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\8183ba9a-e910-48da-8769-14ae6dc1170a`
- **Raw .reg data:** `dword:0000000f`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 8183ba9a-e910-48da-8769-14ae6dc1170a, la 15 (0x0000000F). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 8183ba9a-e910-48da-8769-14ae6dc1170a to 15 (0x0000000F). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L42 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\90959D22-D6A1-49B9-AF93-BCE885AD335B`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 90959D22-D6A1-49B9-AF93-BCE885AD335B, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 90959D22-D6A1-49B9-AF93-BCE885AD335B to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L43 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\90959D22-D6A1-49B9-AF93-BCE885AD335B`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 90959D22-D6A1-49B9-AF93-BCE885AD335B, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 90959D22-D6A1-49B9-AF93-BCE885AD335B to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L46 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\94ac6d29-73ce-41a6-809f-6363ba21b47e`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 94ac6d29-73ce-41a6-809f-6363ba21b47e (Repaus hibrid), la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 94ac6d29-73ce-41a6-809f-6363ba21b47e (Hybrid sleep) to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L47 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\94ac6d29-73ce-41a6-809f-6363ba21b47e`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 94ac6d29-73ce-41a6-809f-6363ba21b47e (Repaus hibrid), la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 94ac6d29-73ce-41a6-809f-6363ba21b47e (Hybrid sleep) to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L50 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\96996BC0-AD50-47EC-923B-6F41874DD9EB`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 96996BC0-AD50-47EC-923B-6F41874DD9EB, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 96996BC0-AD50-47EC-923B-6F41874DD9EB to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L51 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\96996BC0-AD50-47EC-923B-6F41874DD9EB`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 96996BC0-AD50-47EC-923B-6F41874DD9EB, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 96996BC0-AD50-47EC-923B-6F41874DD9EB to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L54 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\9A66D8D7-4FF7-4EF9-B5A2-5A326CA2A469`
- **Raw .reg data:** `dword:00000005`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 9A66D8D7-4FF7-4EF9-B5A2-5A326CA2A469, la 5 (0x00000005). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 9A66D8D7-4FF7-4EF9-B5A2-5A326CA2A469 to 5 (0x00000005). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L57 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\9D7815A6-7EE4-497E-8888-515A05F02364`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 9D7815A6-7EE4-497E-8888-515A05F02364, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 9D7815A6-7EE4-497E-8888-515A05F02364 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L58 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\9D7815A6-7EE4-497E-8888-515A05F02364`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 9D7815A6-7EE4-497E-8888-515A05F02364, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 9D7815A6-7EE4-497E-8888-515A05F02364 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L61 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\A4B195F5-8225-47D8-8012-9D41369786E2`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul A4B195F5-8225-47D8-8012-9D41369786E2, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID A4B195F5-8225-47D8-8012-9D41369786E2 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L62 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\A4B195F5-8225-47D8-8012-9D41369786E2`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul A4B195F5-8225-47D8-8012-9D41369786E2, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID A4B195F5-8225-47D8-8012-9D41369786E2 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L65 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\A7066653-8D6C-40A8-910E-A1F54B84C7E5`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul A7066653-8D6C-40A8-910E-A1F54B84C7E5, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID A7066653-8D6C-40A8-910E-A1F54B84C7E5 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L66 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\A7066653-8D6C-40A8-910E-A1F54B84C7E5`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul A7066653-8D6C-40A8-910E-A1F54B84C7E5, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID A7066653-8D6C-40A8-910E-A1F54B84C7E5 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L69 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\abfc2519-3608-4c2a-94ea-171b0ed546ab`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul abfc2519-3608-4c2a-94ea-171b0ed546ab, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID abfc2519-3608-4c2a-94ea-171b0ed546ab to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L70 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\abfc2519-3608-4c2a-94ea-171b0ed546ab`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul abfc2519-3608-4c2a-94ea-171b0ed546ab, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID abfc2519-3608-4c2a-94ea-171b0ed546ab to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L73 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\B7A27025-E569-46c2-A504-2B96CAD225A1`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul B7A27025-E569-46c2-A504-2B96CAD225A1, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID B7A27025-E569-46c2-A504-2B96CAD225A1 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L74 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\B7A27025-E569-46c2-A504-2B96CAD225A1`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul B7A27025-E569-46c2-A504-2B96CAD225A1, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID B7A27025-E569-46c2-A504-2B96CAD225A1 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L77 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bcded951-187b-4d05-bccc-f7e51960c258`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul bcded951-187b-4d05-bccc-f7e51960c258, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID bcded951-187b-4d05-bccc-f7e51960c258 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L80 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d4c1d4c8-d5cc-43d3-b83e-fc51215cb04d`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d4c1d4c8-d5cc-43d3-b83e-fc51215cb04d, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d4c1d4c8-d5cc-43d3-b83e-fc51215cb04d to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L81 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d4c1d4c8-d5cc-43d3-b83e-fc51215cb04d`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d4c1d4c8-d5cc-43d3-b83e-fc51215cb04d, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d4c1d4c8-d5cc-43d3-b83e-fc51215cb04d to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L84 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d8742dcb-3e6a-4b3c-b3fe-374623cdcf06`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d8742dcb-3e6a-4b3c-b3fe-374623cdcf06, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d8742dcb-3e6a-4b3c-b3fe-374623cdcf06 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L87 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\E69653CA-CF7F-4F05-AA73-CB833FA90AD4`
- **Raw .reg data:** `dword:0000000f`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul E69653CA-CF7F-4F05-AA73-CB833FA90AD4, la 15 (0x0000000F). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID E69653CA-CF7F-4F05-AA73-CB833FA90AD4 to 15 (0x0000000F). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L88 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\E69653CA-CF7F-4F05-AA73-CB833FA90AD4`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul E69653CA-CF7F-4F05-AA73-CB833FA90AD4, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID E69653CA-CF7F-4F05-AA73-CB833FA90AD4 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L91 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f15576e8-98b7-4186-b944-eafa664402d9`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul f15576e8-98b7-4186-b944-eafa664402d9, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID f15576e8-98b7-4186-b944-eafa664402d9 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L92 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f15576e8-98b7-4186-b944-eafa664402d9`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul f15576e8-98b7-4186-b944-eafa664402d9, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID f15576e8-98b7-4186-b944-eafa664402d9 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L95 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f1fbfde2-a960-4165-9f88-50667911ce96`
- **Raw .reg data:** `dword:00000028`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul f1fbfde2-a960-4165-9f88-50667911ce96, la 40 (0x00000028). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID f1fbfde2-a960-4165-9f88-50667911ce96 to 40 (0x00000028). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L96 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f1fbfde2-a960-4165-9f88-50667911ce96`
- **Raw .reg data:** `dword:00000028`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul f1fbfde2-a960-4165-9f88-50667911ce96, la 40 (0x00000028). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID f1fbfde2-a960-4165-9f88-50667911ce96 to 40 (0x00000028). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L99 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\F3C5027D-CD16-4930-AA6B-90DB844A8F00`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul F3C5027D-CD16-4930-AA6B-90DB844A8F00, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID F3C5027D-CD16-4930-AA6B-90DB844A8F00 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L102 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\be337238-0d82-4146-a960-4f3749d470c7`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul be337238-0d82-4146-a960-4f3749d470c7, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID be337238-0d82-4146-a960-4f3749d470c7 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L103 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\be337238-0d82-4146-a960-4f3749d470c7`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul be337238-0d82-4146-a960-4f3749d470c7, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID be337238-0d82-4146-a960-4f3749d470c7 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L107 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\48e6b7a6-50f5-4782-a5d4-53bb8f07e226`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 48e6b7a6-50f5-4782-a5d4-53bb8f07e226, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 48e6b7a6-50f5-4782-a5d4-53bb8f07e226 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L108 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\48e6b7a6-50f5-4782-a5d4-53bb8f07e226`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 48e6b7a6-50f5-4782-a5d4-53bb8f07e226, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 48e6b7a6-50f5-4782-a5d4-53bb8f07e226 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L112 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\29f6c1db-86da-48c5-9fdb-f2b67b1f44da`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 29f6c1db-86da-48c5-9fdb-f2b67b1f44da, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 29f6c1db-86da-48c5-9fdb-f2b67b1f44da to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L113 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\29f6c1db-86da-48c5-9fdb-f2b67b1f44da`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 29f6c1db-86da-48c5-9fdb-f2b67b1f44da, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 29f6c1db-86da-48c5-9fdb-f2b67b1f44da to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L117 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d639518a-e56d-4345-8af2-b9f32fb26109`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d639518a-e56d-4345-8af2-b9f32fb26109, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d639518a-e56d-4345-8af2-b9f32fb26109 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L118 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d639518a-e56d-4345-8af2-b9f32fb26109`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d639518a-e56d-4345-8af2-b9f32fb26109, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d639518a-e56d-4345-8af2-b9f32fb26109 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L122 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d3d55efd-c1ff-424e-9dc3-441be7833010`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d3d55efd-c1ff-424e-9dc3-441be7833010, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d3d55efd-c1ff-424e-9dc3-441be7833010 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L123 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d3d55efd-c1ff-424e-9dc3-441be7833010`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d3d55efd-c1ff-424e-9dc3-441be7833010, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d3d55efd-c1ff-424e-9dc3-441be7833010 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L127 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0b2d69d7-a2a1-449c-9680-f91c70521c60`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 0b2d69d7-a2a1-449c-9680-f91c70521c60, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 0b2d69d7-a2a1-449c-9680-f91c70521c60 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L128 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0b2d69d7-a2a1-449c-9680-f91c70521c60`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 0b2d69d7-a2a1-449c-9680-f91c70521c60, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 0b2d69d7-a2a1-449c-9680-f91c70521c60 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L132 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\dab60367-53fe-4fbc-825e-521d069d2456`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul dab60367-53fe-4fbc-825e-521d069d2456, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID dab60367-53fe-4fbc-825e-521d069d2456 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L133 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\dab60367-53fe-4fbc-825e-521d069d2456`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul dab60367-53fe-4fbc-825e-521d069d2456, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID dab60367-53fe-4fbc-825e-521d069d2456 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L136 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0cc5b647-c1df-4637-891a-dec35c318583`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 0cc5b647-c1df-4637-891a-dec35c318583, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 0cc5b647-c1df-4637-891a-dec35c318583 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L137 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0cc5b647-c1df-4637-891a-dec35c318583`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 0cc5b647-c1df-4637-891a-dec35c318583, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 0cc5b647-c1df-4637-891a-dec35c318583 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L140 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0cc5b647-c1df-4637-891a-dec35c318584`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 0cc5b647-c1df-4637-891a-dec35c318584, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 0cc5b647-c1df-4637-891a-dec35c318584 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L141 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0cc5b647-c1df-4637-891a-dec35c318584`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 0cc5b647-c1df-4637-891a-dec35c318584, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 0cc5b647-c1df-4637-891a-dec35c318584 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L144 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12a0ab44-fe28-4fa9-b3bd-4b64f44960a6`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 12a0ab44-fe28-4fa9-b3bd-4b64f44960a6, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 12a0ab44-fe28-4fa9-b3bd-4b64f44960a6 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L145 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12a0ab44-fe28-4fa9-b3bd-4b64f44960a6`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 12a0ab44-fe28-4fa9-b3bd-4b64f44960a6, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 12a0ab44-fe28-4fa9-b3bd-4b64f44960a6 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L148 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12a0ab44-fe28-4fa9-b3bd-4b64f44960a7`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 12a0ab44-fe28-4fa9-b3bd-4b64f44960a7, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 12a0ab44-fe28-4fa9-b3bd-4b64f44960a7 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L149 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12a0ab44-fe28-4fa9-b3bd-4b64f44960a7`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 12a0ab44-fe28-4fa9-b3bd-4b64f44960a7, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 12a0ab44-fe28-4fa9-b3bd-4b64f44960a7 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L153 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687f9e-e3a5-4dbf-b1dc-15eb381c6863`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 36687f9e-e3a5-4dbf-b1dc-15eb381c6863, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 36687f9e-e3a5-4dbf-b1dc-15eb381c6863 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L154 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687f9e-e3a5-4dbf-b1dc-15eb381c6863`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 36687f9e-e3a5-4dbf-b1dc-15eb381c6863, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 36687f9e-e3a5-4dbf-b1dc-15eb381c6863 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L158 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687f9e-e3a5-4dbf-b1dc-15eb381c6864`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 36687f9e-e3a5-4dbf-b1dc-15eb381c6864, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 36687f9e-e3a5-4dbf-b1dc-15eb381c6864 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L159 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687f9e-e3a5-4dbf-b1dc-15eb381c6864`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 36687f9e-e3a5-4dbf-b1dc-15eb381c6864, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 36687f9e-e3a5-4dbf-b1dc-15eb381c6864 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L162 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d639518a-e56d-4345-8af2-b9f32fb26109`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d639518a-e56d-4345-8af2-b9f32fb26109, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d639518a-e56d-4345-8af2-b9f32fb26109 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L163 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d639518a-e56d-4345-8af2-b9f32fb26109`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d639518a-e56d-4345-8af2-b9f32fb26109, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d639518a-e56d-4345-8af2-b9f32fb26109 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L166 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\dbc9e238-6de9-49e3-92cd-8c2b4946b472`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul dbc9e238-6de9-49e3-92cd-8c2b4946b472, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID dbc9e238-6de9-49e3-92cd-8c2b4946b472 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L167 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\dbc9e238-6de9-49e3-92cd-8c2b4946b472`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul dbc9e238-6de9-49e3-92cd-8c2b4946b472, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID dbc9e238-6de9-49e3-92cd-8c2b4946b472 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L170 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\fc95af4d-40e7-4b6d-835a-56d131dbc80e`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul fc95af4d-40e7-4b6d-835a-56d131dbc80e, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID fc95af4d-40e7-4b6d-835a-56d131dbc80e to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L171 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\fc95af4d-40e7-4b6d-835a-56d131dbc80e`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul fc95af4d-40e7-4b6d-835a-56d131dbc80e, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID fc95af4d-40e7-4b6d-835a-56d131dbc80e to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L175 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\ee12f906-d277-404b-b6da-e5fa1a576df5`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul ee12f906-d277-404b-b6da-e5fa1a576df5, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID ee12f906-d277-404b-b6da-e5fa1a576df5 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L176 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\ee12f906-d277-404b-b6da-e5fa1a576df5`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul ee12f906-d277-404b-b6da-e5fa1a576df5, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID ee12f906-d277-404b-b6da-e5fa1a576df5 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L182 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0cc5b647-c74e-4111-92e3-3b129533f4d5`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 0cc5b647-c74e-4111-92e3-3b129533f4d5, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 0cc5b647-c74e-4111-92e3-3b129533f4d5 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L183 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0cc5b647-c74e-4111-92e3-3b129533f4d5`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 0cc5b647-c74e-4111-92e3-3b129533f4d5, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 0cc5b647-c74e-4111-92e3-3b129533f4d5 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L187 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\ea0653f4-9251-4ca4-99a3-324b3d2b0636`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul ea0653f4-9251-4ca4-99a3-324b3d2b0636, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID ea0653f4-9251-4ca4-99a3-324b3d2b0636 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L188 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\ea0653f4-9251-4ca4-99a3-324b3d2b0636`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul ea0653f4-9251-4ca4-99a3-324b3d2b0636, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID ea0653f4-9251-4ca4-99a3-324b3d2b0636 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L192 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\2430ab6f-a544-49aa-a9d7-2b7ab794b238`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 2430ab6f-a544-49aa-a9d7-2b7ab794b238, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 2430ab6f-a544-49aa-a9d7-2b7ab794b238 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L193 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\2430ab6f-a544-49aa-a9d7-2b7ab794b238`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 2430ab6f-a544-49aa-a9d7-2b7ab794b238, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 2430ab6f-a544-49aa-a9d7-2b7ab794b238 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L197 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\df142941-20f3-4edf-9a4a-9c8398d99316`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul df142941-20f3-4edf-9a4a-9c8398d99316, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID df142941-20f3-4edf-9a4a-9c8398d99316 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L198 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\df142941-20f3-4edf-9a4a-9c8398d99316`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul df142941-20f3-4edf-9a4a-9c8398d99316, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID df142941-20f3-4edf-9a4a-9c8398d99316 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L202 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\24331756-9f37-4a91-8aa2-cd24f05145b1`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 24331756-9f37-4a91-8aa2-cd24f05145b1, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 24331756-9f37-4a91-8aa2-cd24f05145b1 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L203 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\24331756-9f37-4a91-8aa2-cd24f05145b1`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 24331756-9f37-4a91-8aa2-cd24f05145b1, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 24331756-9f37-4a91-8aa2-cd24f05145b1 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L207 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\a55612aa-f62a-4414-bdc9-1157d0d01477`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul a55612aa-f62a-4414-bdc9-1157d0d01477, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID a55612aa-f62a-4414-bdc9-1157d0d01477 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L208 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\a55612aa-f62a-4414-bdc9-1157d0d01477`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul a55612aa-f62a-4414-bdc9-1157d0d01477, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID a55612aa-f62a-4414-bdc9-1157d0d01477 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L212 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7354e7bc-61d6-4765-b384-839981369279`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7354e7bc-61d6-4765-b384-839981369279, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7354e7bc-61d6-4765-b384-839981369279 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L213 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7354e7bc-61d6-4765-b384-839981369279`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7354e7bc-61d6-4765-b384-839981369279, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7354e7bc-61d6-4765-b384-839981369279 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L217 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6161914b-2401-4061-a4a0-76169c08044b`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6161914b-2401-4061-a4a0-76169c08044b, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6161914b-2401-4061-a4a0-76169c08044b to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L218 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6161914b-2401-4061-a4a0-76169c08044b`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6161914b-2401-4061-a4a0-76169c08044b, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6161914b-2401-4061-a4a0-76169c08044b to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L224 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b92d772-746b-4dc8-bc01-e63086603a11`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 4b92d772-746b-4dc8-bc01-e63086603a11, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 4b92d772-746b-4dc8-bc01-e63086603a11 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L225 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b92d772-746b-4dc8-bc01-e63086603a11`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 4b92d772-746b-4dc8-bc01-e63086603a11, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 4b92d772-746b-4dc8-bc01-e63086603a11 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L229 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7b224883-ad29-4c39-ad36-f310058e3393`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7b224883-ad29-4c39-ad36-f310058e3393, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7b224883-ad29-4c39-ad36-f310058e3393 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L230 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7b224883-ad29-4c39-ad36-f310058e3393`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7b224883-ad29-4c39-ad36-f310058e3393, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7b224883-ad29-4c39-ad36-f310058e3393 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L236 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee03-5242-4113-8214-4362fe445d4d`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 893dee03-5242-4113-8214-4362fe445d4d, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 893dee03-5242-4113-8214-4362fe445d4d to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L237 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee03-5242-4113-8214-4362fe445d4d`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 893dee03-5242-4113-8214-4362fe445d4d, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 893dee03-5242-4113-8214-4362fe445d4d to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L241 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bc5038f7-23e0-4960-96da-33abaf5935ec`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul bc5038f7-23e0-4960-96da-33abaf5935ec, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID bc5038f7-23e0-4960-96da-33abaf5935ec to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L242 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bc5038f7-23e0-4960-96da-33abaf5935ec`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul bc5038f7-23e0-4960-96da-33abaf5935ec, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID bc5038f7-23e0-4960-96da-33abaf5935ec to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L246 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\45bcc044-d885-43e2-8605-ee0ec6e96b59`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 45bcc044-d885-43e2-8605-ee0ec6e96b59, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 45bcc044-d885-43e2-8605-ee0ec6e96b59 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L247 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\45bcc044-d885-43e2-8605-ee0ec6e96b59`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 45bcc044-d885-43e2-8605-ee0ec6e96b59, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 45bcc044-d885-43e2-8605-ee0ec6e96b59 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L251 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\06cadf0e-64ed-447a-ad35-13f31347019a`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 06cadf0e-64ed-447a-ad35-13f31347019a, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 06cadf0e-64ed-447a-ad35-13f31347019a to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L252 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\06cadf0e-64ed-447a-ad35-13f31347019a`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 06cadf0e-64ed-447a-ad35-13f31347019a, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 06cadf0e-64ed-447a-ad35-13f31347019a to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L256 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\984c071e-2352-4220-8044-03cf06c03b2f`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 984c071e-2352-4220-8044-03cf06c03b2f, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 984c071e-2352-4220-8044-03cf06c03b2f to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L257 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\984c071e-2352-4220-8044-03cf06c03b2f`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 984c071e-2352-4220-8044-03cf06c03b2f, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 984c071e-2352-4220-8044-03cf06c03b2f to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L261 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\40fb19d1-5c9a-4c1d-8c41-2ca4ca564e05`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 40fb19d1-5c9a-4c1d-8c41-2ca4ca564e05, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 40fb19d1-5c9a-4c1d-8c41-2ca4ca564e05 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L262 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\40fb19d1-5c9a-4c1d-8c41-2ca4ca564e05`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 40fb19d1-5c9a-4c1d-8c41-2ca4ca564e05, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 40fb19d1-5c9a-4c1d-8c41-2ca4ca564e05 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L266 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12a0abc1-4b95-46f3-80f3-c7a035c34a4c`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 12a0abc1-4b95-46f3-80f3-c7a035c34a4c, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 12a0abc1-4b95-46f3-80f3-c7a035c34a4c to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L267 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12a0abc1-4b95-46f3-80f3-c7a035c34a4c`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 12a0abc1-4b95-46f3-80f3-c7a035c34a4c, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 12a0abc1-4b95-46f3-80f3-c7a035c34a4c to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L271 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d806336b-ee4a-4a9d-9f1c-596c463b322a`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d806336b-ee4a-4a9d-9f1c-596c463b322a, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d806336b-ee4a-4a9d-9f1c-596c463b322a to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L272 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d806336b-ee4a-4a9d-9f1c-596c463b322a`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d806336b-ee4a-4a9d-9f1c-596c463b322a, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d806336b-ee4a-4a9d-9f1c-596c463b322a to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L276 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\03310071-7006-4444-88f6-ec61386127e2`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 03310071-7006-4444-88f6-ec61386127e2, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 03310071-7006-4444-88f6-ec61386127e2 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L277 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\03310071-7006-4444-88f6-ec61386127e2`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 03310071-7006-4444-88f6-ec61386127e2, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 03310071-7006-4444-88f6-ec61386127e2 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L283 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\8baa4a8a-3315-4420-b301-3e6601b0f0a4`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 8baa4a8a-3315-4420-b301-3e6601b0f0a4, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 8baa4a8a-3315-4420-b301-3e6601b0f0a4 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L284 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\8baa4a8a-3315-4420-b301-3e6601b0f0a4`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 8baa4a8a-3315-4420-b301-3e6601b0f0a4, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 8baa4a8a-3315-4420-b301-3e6601b0f0a4 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L288 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687e9e-e3a5-4dbf-b1dc-15eb31c7448b`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 36687e9e-e3a5-4dbf-b1dc-15eb31c7448b, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 36687e9e-e3a5-4dbf-b1dc-15eb31c7448b to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L289 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687e9e-e3a5-4dbf-b1dc-15eb31c7448b`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 36687e9e-e3a5-4dbf-b1dc-15eb31c7448b, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 36687e9e-e3a5-4dbf-b1dc-15eb31c7448b to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L293 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\461a3406-018d-4f10-9118-8f53a479a95f`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 461a3406-018d-4f10-9118-8f53a479a95f, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 461a3406-018d-4f10-9118-8f53a479a95f to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L294 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\461a3406-018d-4f10-9118-8f53a479a95f`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 461a3406-018d-4f10-9118-8f53a479a95f, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 461a3406-018d-4f10-9118-8f53a479a95f to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L300 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c4581d15-9658-4ac2-8953-2d10f285aa5b`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul c4581d15-9658-4ac2-8953-2d10f285aa5b, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID c4581d15-9658-4ac2-8953-2d10f285aa5b to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L301 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c4581d15-9658-4ac2-8953-2d10f285aa5b`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul c4581d15-9658-4ac2-8953-2d10f285aa5b, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID c4581d15-9658-4ac2-8953-2d10f285aa5b to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L305 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d6138075-8025-467f-8592-349818804975`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d6138075-8025-467f-8592-349818804975, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d6138075-8025-467f-8592-349818804975 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L306 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d6138075-8025-467f-8592-349818804975`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d6138075-8025-467f-8592-349818804975, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d6138075-8025-467f-8592-349818804975 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L310 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\30169123-d349-4184-9134-8c8713fca3b3`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 30169123-d349-4184-9134-8c8713fca3b3, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 30169123-d349-4184-9134-8c8713fca3b3 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L311 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\30169123-d349-4184-9134-8c8713fca3b3`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 30169123-d349-4184-9134-8c8713fca3b3, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 30169123-d349-4184-9134-8c8713fca3b3 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L317 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\75e83fb4-118d-4f18-a648-4321040c4e13`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 75e83fb4-118d-4f18-a648-4321040c4e13, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 75e83fb4-118d-4f18-a648-4321040c4e13 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L318 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\75e83fb4-118d-4f18-a648-4321040c4e13`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 75e83fb4-118d-4f18-a648-4321040c4e13, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 75e83fb4-118d-4f18-a648-4321040c4e13 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L322 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\230c3d33-3d02-4bf1-8935-779836371f4b`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 230c3d33-3d02-4bf1-8935-779836371f4b, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 230c3d33-3d02-4bf1-8935-779836371f4b to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L323 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\230c3d33-3d02-4bf1-8935-779836371f4b`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 230c3d33-3d02-4bf1-8935-779836371f4b, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 230c3d33-3d02-4bf1-8935-779836371f4b to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L327 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7f2492b6-6011-457a-85c0-514a510ed951`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7f2492b6-6011-457a-85c0-514a510ed951, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7f2492b6-6011-457a-85c0-514a510ed951 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L328 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7f2492b6-6011-457a-85c0-514a510ed951`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7f2492b6-6011-457a-85c0-514a510ed951, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7f2492b6-6011-457a-85c0-514a510ed951 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L332 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c7499445-3172-46aa-9d41-39994c9657f8`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul c7499445-3172-46aa-9d41-39994c9657f8, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID c7499445-3172-46aa-9d41-39994c9657f8 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L333 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c7499445-3172-46aa-9d41-39994c9657f8`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul c7499445-3172-46aa-9d41-39994c9657f8, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID c7499445-3172-46aa-9d41-39994c9657f8 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L337 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b000397d-9d0d-4dfd-9afd-be5045091a13`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul b000397d-9d0d-4dfd-9afd-be5045091a13, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID b000397d-9d0d-4dfd-9afd-be5045091a13 to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L338 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b000397d-9d0d-4dfd-9afd-be5045091a13`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul b000397d-9d0d-4dfd-9afd-be5045091a13, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID b000397d-9d0d-4dfd-9afd-be5045091a13 to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L342 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6317c06e-8260-47b2-8789-532669e46950`
- **Raw .reg data:** `dword:0000005a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6317c06e-8260-47b2-8789-532669e46950, la 90 (0x0000005A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6317c06e-8260-47b2-8789-532669e46950 to 90 (0x0000005A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L343 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6317c06e-8260-47b2-8789-532669e46950`
- **Raw .reg data:** `dword:0000005a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6317c06e-8260-47b2-8789-532669e46950, la 90 (0x0000005A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6317c06e-8260-47b2-8789-532669e46950 to 90 (0x0000005A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L347 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\10a28bdc-3834-4bc1-9034-45300305a414`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 10a28bdc-3834-4bc1-9034-45300305a414, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 10a28bdc-3834-4bc1-9034-45300305a414 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L348 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\10a28bdc-3834-4bc1-9034-45300305a414`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 10a28bdc-3834-4bc1-9034-45300305a414, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 10a28bdc-3834-4bc1-9034-45300305a414 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L354 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee03-5242-4113-8214-4362fe445d4e`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 893dee03-5242-4113-8214-4362fe445d4e, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 893dee03-5242-4113-8214-4362fe445d4e to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L355 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee03-5242-4113-8214-4362fe445d4e`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 893dee03-5242-4113-8214-4362fe445d4e, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 893dee03-5242-4113-8214-4362fe445d4e to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L359 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bc5038f7-23e0-4960-96da-33abaf5935ed`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul bc5038f7-23e0-4960-96da-33abaf5935ed, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID bc5038f7-23e0-4960-96da-33abaf5935ed to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L360 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bc5038f7-23e0-4960-96da-33abaf5935ed`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul bc5038f7-23e0-4960-96da-33abaf5935ed, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID bc5038f7-23e0-4960-96da-33abaf5935ed to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L364 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\45bcc044-d885-43e2-8605-ee0ec6e96b5a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 45bcc044-d885-43e2-8605-ee0ec6e96b5a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 45bcc044-d885-43e2-8605-ee0ec6e96b5a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L365 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\45bcc044-d885-43e2-8605-ee0ec6e96b5a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 45bcc044-d885-43e2-8605-ee0ec6e96b5a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 45bcc044-d885-43e2-8605-ee0ec6e96b5a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L369 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\06cadf0e-64ed-447a-ad35-13f31347019b`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 06cadf0e-64ed-447a-ad35-13f31347019b, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 06cadf0e-64ed-447a-ad35-13f31347019b to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L370 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\06cadf0e-64ed-447a-ad35-13f31347019b`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 06cadf0e-64ed-447a-ad35-13f31347019b, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 06cadf0e-64ed-447a-ad35-13f31347019b to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L374 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\984c071e-2352-4220-8044-03cf06c03b30`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 984c071e-2352-4220-8044-03cf06c03b30, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 984c071e-2352-4220-8044-03cf06c03b30 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L375 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\984c071e-2352-4220-8044-03cf06c03b30`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 984c071e-2352-4220-8044-03cf06c03b30, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 984c071e-2352-4220-8044-03cf06c03b30 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L379 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\40fb19d1-5c9a-4c1d-8c41-2ca4ca564e06`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 40fb19d1-5c9a-4c1d-8c41-2ca4ca564e06, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 40fb19d1-5c9a-4c1d-8c41-2ca4ca564e06 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L380 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\40fb19d1-5c9a-4c1d-8c41-2ca4ca564e06`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 40fb19d1-5c9a-4c1d-8c41-2ca4ca564e06, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 40fb19d1-5c9a-4c1d-8c41-2ca4ca564e06 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L384 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12a0abc1-4b95-46f3-80f3-c7a035c34a4d`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 12a0abc1-4b95-46f3-80f3-c7a035c34a4d, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 12a0abc1-4b95-46f3-80f3-c7a035c34a4d to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L385 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12a0abc1-4b95-46f3-80f3-c7a035c34a4d`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 12a0abc1-4b95-46f3-80f3-c7a035c34a4d, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 12a0abc1-4b95-46f3-80f3-c7a035c34a4d to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L389 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d806336b-ee4a-4a9d-9f1c-596c463b322b`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d806336b-ee4a-4a9d-9f1c-596c463b322b, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d806336b-ee4a-4a9d-9f1c-596c463b322b to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L390 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d806336b-ee4a-4a9d-9f1c-596c463b322b`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d806336b-ee4a-4a9d-9f1c-596c463b322b, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d806336b-ee4a-4a9d-9f1c-596c463b322b to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L394 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\03310071-7006-4444-88f6-ec61386127e3`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 03310071-7006-4444-88f6-ec61386127e3, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 03310071-7006-4444-88f6-ec61386127e3 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L395 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\03310071-7006-4444-88f6-ec61386127e3`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 03310071-7006-4444-88f6-ec61386127e3, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 03310071-7006-4444-88f6-ec61386127e3 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L399 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\461a3406-018d-4f10-9118-8f53a479a960`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 461a3406-018d-4f10-9118-8f53a479a960, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 461a3406-018d-4f10-9118-8f53a479a960 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L400 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\461a3406-018d-4f10-9118-8f53a479a960`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 461a3406-018d-4f10-9118-8f53a479a960, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 461a3406-018d-4f10-9118-8f53a479a960 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L406 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6737e22e-7d14-4acb-a3fa-a69006900405`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6737e22e-7d14-4acb-a3fa-a69006900405, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6737e22e-7d14-4acb-a3fa-a69006900405 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L407 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6737e22e-7d14-4acb-a3fa-a69006900405`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6737e22e-7d14-4acb-a3fa-a69006900405, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6737e22e-7d14-4acb-a3fa-a69006900405 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L411 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f7358ef9-bb6e-473d-b4f0-466548777771`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul f7358ef9-bb6e-473d-b4f0-466548777771, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID f7358ef9-bb6e-473d-b4f0-466548777771 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L412 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f7358ef9-bb6e-473d-b4f0-466548777771`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul f7358ef9-bb6e-473d-b4f0-466548777771, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID f7358ef9-bb6e-473d-b4f0-466548777771 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L416 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b000397d-9d0d-4dfd-9afd-be5045091a14`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul b000397d-9d0d-4dfd-9afd-be5045091a14, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID b000397d-9d0d-4dfd-9afd-be5045091a14 to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L417 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b000397d-9d0d-4dfd-9afd-be5045091a14`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul b000397d-9d0d-4dfd-9afd-be5045091a14, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID b000397d-9d0d-4dfd-9afd-be5045091a14 to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L421 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6317c06e-8260-47b2-8789-532669e46951`
- **Raw .reg data:** `dword:0000005a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6317c06e-8260-47b2-8789-532669e46951, la 90 (0x0000005A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6317c06e-8260-47b2-8789-532669e46951 to 90 (0x0000005A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L422 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6317c06e-8260-47b2-8789-532669e46951`
- **Raw .reg data:** `dword:0000005a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6317c06e-8260-47b2-8789-532669e46951, la 90 (0x0000005A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6317c06e-8260-47b2-8789-532669e46951 to 90 (0x0000005A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L428 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\75b0ae3f-bce0-45a7-8c89-c9611c251100`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 75b0ae3f-bce0-45a7-8c89-c9611c251100, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 75b0ae3f-bce0-45a7-8c89-c9611c251100 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L429 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\75b0ae3f-bce0-45a7-8c89-c9611c251100`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 75b0ae3f-bce0-45a7-8c89-c9611c251100, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 75b0ae3f-bce0-45a7-8c89-c9611c251100 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L433 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\75b0ae3f-bce0-45a7-8c89-c9611c251101`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 75b0ae3f-bce0-45a7-8c89-c9611c251101, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 75b0ae3f-bce0-45a7-8c89-c9611c251101 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L434 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\75b0ae3f-bce0-45a7-8c89-c9611c251101`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 75b0ae3f-bce0-45a7-8c89-c9611c251101, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 75b0ae3f-bce0-45a7-8c89-c9611c251101 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L438 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\be337238-0d82-4146-a960-4f3749d470c2`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul be337238-0d82-4146-a960-4f3749d470c2, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID be337238-0d82-4146-a960-4f3749d470c2 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L439 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\be337238-0d82-4146-a960-4f3749d470c2`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul be337238-0d82-4146-a960-4f3749d470c2, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID be337238-0d82-4146-a960-4f3749d470c2 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L445 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\93b22d1d-9513-4bc7-ad42-1e967313f2e4`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 93b22d1d-9513-4bc7-ad42-1e967313f2e4, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 93b22d1d-9513-4bc7-ad42-1e967313f2e4 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L446 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\93b22d1d-9513-4bc7-ad42-1e967313f2e4`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 93b22d1d-9513-4bc7-ad42-1e967313f2e4, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 93b22d1d-9513-4bc7-ad42-1e967313f2e4 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L450 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bae08b81-2d5e-4688-ad6a-13243356654b`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul bae08b81-2d5e-4688-ad6a-13243356654b, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID bae08b81-2d5e-4688-ad6a-13243356654b to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L451 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bae08b81-2d5e-4688-ad6a-13243356654b`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul bae08b81-2d5e-4688-ad6a-13243356654b, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID bae08b81-2d5e-4688-ad6a-13243356654b to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L457 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\82643a6d-9610-4493-9c86-13da7601d006`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 82643a6d-9610-4493-9c86-13da7601d006, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 82643a6d-9610-4493-9c86-13da7601d006 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L458 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\82643a6d-9610-4493-9c86-13da7601d006`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 82643a6d-9610-4493-9c86-13da7601d006, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 82643a6d-9610-4493-9c86-13da7601d006 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L462 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\a2283733-1492-49d6-b516-724e335f9923`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul a2283733-1492-49d6-b516-724e335f9923, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID a2283733-1492-49d6-b516-724e335f9923 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L463 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\a2283733-1492-49d6-b516-724e335f9923`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul a2283733-1492-49d6-b516-724e335f9923, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID a2283733-1492-49d6-b516-724e335f9923 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L467 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\05658661-f09c-48c9-9407-743a60b73cf2`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 05658661-f09c-48c9-9407-743a60b73cf2, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 05658661-f09c-48c9-9407-743a60b73cf2 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L468 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\05658661-f09c-48c9-9407-743a60b73cf2`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 05658661-f09c-48c9-9407-743a60b73cf2, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 05658661-f09c-48c9-9407-743a60b73cf2 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L472 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0762957b-7b3b-4876-9694-8840da70877a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 0762957b-7b3b-4876-9694-8840da70877a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 0762957b-7b3b-4876-9694-8840da70877a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L473 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\0762957b-7b3b-4876-9694-8840da70877a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 0762957b-7b3b-4876-9694-8840da70877a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 0762957b-7b3b-4876-9694-8840da70877a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L479 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\cfeda3d0-7697-4566-a922-a9086cd3632a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul cfeda3d0-7697-4566-a922-a9086cd3632a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID cfeda3d0-7697-4566-a922-a9086cd3632a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L480 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\cfeda3d0-7697-4566-a922-a9086cd3632a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul cfeda3d0-7697-4566-a922-a9086cd3632a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID cfeda3d0-7697-4566-a922-a9086cd3632a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L486 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\5702737c-659f-4491-b4d0-4061a9954a20`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 5702737c-659f-4491-b4d0-4061a9954a20, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 5702737c-659f-4491-b4d0-4061a9954a20 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L487 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\5702737c-659f-4491-b4d0-4061a9954a20`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 5702737c-659f-4491-b4d0-4061a9954a20, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 5702737c-659f-4491-b4d0-4061a9954a20 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L493 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687e9e-e3a5-4dbf-b1dc-15eb31c7448b`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 36687e9e-e3a5-4dbf-b1dc-15eb31c7448b, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 36687e9e-e3a5-4dbf-b1dc-15eb31c7448b to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L494 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687e9e-e3a5-4dbf-b1dc-15eb31c7448b`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 36687e9e-e3a5-4dbf-b1dc-15eb31c7448b, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 36687e9e-e3a5-4dbf-b1dc-15eb31c7448b to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L498 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687e9e-e3a5-4dbf-b1dc-15eb31c7448c`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 36687e9e-e3a5-4dbf-b1dc-15eb31c7448c, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 36687e9e-e3a5-4dbf-b1dc-15eb31c7448c to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L499 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\36687e9e-e3a5-4dbf-b1dc-15eb31c7448c`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 36687e9e-e3a5-4dbf-b1dc-15eb31c7448c, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 36687e9e-e3a5-4dbf-b1dc-15eb31c7448c to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L502 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d4e98f31-5ffe-4ce1-be31-1b38b384c009`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d4e98f31-5ffe-4ce1-be31-1b38b384c009, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d4e98f31-5ffe-4ce1-be31-1b38b384c009 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L503 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d4e98f31-5ffe-4ce1-be31-1b38b384c009`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d4e98f31-5ffe-4ce1-be31-1b38b384c009, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d4e98f31-5ffe-4ce1-be31-1b38b384c009 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L506 · SET-VALUE · `ThreadDpcEnable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Kernel`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Thread Dpc Enable” în ramura CurrentControlSet / Control / Session Manager la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Thread Dpc Enable” option in registry branch CurrentControlSet / Control / Session Manager to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L509 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\10778347-1370-4ee0-8bbd-33bdacaade49`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 10778347-1370-4ee0-8bbd-33bdacaade49, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 10778347-1370-4ee0-8bbd-33bdacaade49 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L510 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\10778347-1370-4ee0-8bbd-33bdacaade49`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 10778347-1370-4ee0-8bbd-33bdacaade49, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 10778347-1370-4ee0-8bbd-33bdacaade49 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L516 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\3166bc41-7e98-4e03-b34e-ec0f5f2b218e`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 3166bc41-7e98-4e03-b34e-ec0f5f2b218e, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 3166bc41-7e98-4e03-b34e-ec0f5f2b218e to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L517 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\3166bc41-7e98-4e03-b34e-ec0f5f2b218e`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 3166bc41-7e98-4e03-b34e-ec0f5f2b218e, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 3166bc41-7e98-4e03-b34e-ec0f5f2b218e to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L521 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c36f0eb4-2988-4a70-8eee-0884fc2c2433`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul c36f0eb4-2988-4a70-8eee-0884fc2c2433, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID c36f0eb4-2988-4a70-8eee-0884fc2c2433 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L522 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c36f0eb4-2988-4a70-8eee-0884fc2c2433`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul c36f0eb4-2988-4a70-8eee-0884fc2c2433, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID c36f0eb4-2988-4a70-8eee-0884fc2c2433 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L526 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c42b79aa-aa3a-484b-a98f-2cf32aa90a28`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul c42b79aa-aa3a-484b-a98f-2cf32aa90a28, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID c42b79aa-aa3a-484b-a98f-2cf32aa90a28 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L527 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c42b79aa-aa3a-484b-a98f-2cf32aa90a28`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul c42b79aa-aa3a-484b-a98f-2cf32aa90a28, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID c42b79aa-aa3a-484b-a98f-2cf32aa90a28 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L531 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\2bfc24f9-5ea2-4801-8213-3dbae01aa39d`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 2bfc24f9-5ea2-4801-8213-3dbae01aa39d, la 3 (0x00000003). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 2bfc24f9-5ea2-4801-8213-3dbae01aa39d to 3 (0x00000003). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L532 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\2bfc24f9-5ea2-4801-8213-3dbae01aa39d`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 2bfc24f9-5ea2-4801-8213-3dbae01aa39d, la 3 (0x00000003). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 2bfc24f9-5ea2-4801-8213-3dbae01aa39d to 3 (0x00000003). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L536 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\73cde64d-d720-4bb2-a860-c755afe77ef2`
- **Raw .reg data:** `dword:00002710`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 73cde64d-d720-4bb2-a860-c755afe77ef2, la 10000 (0x00002710). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 73cde64d-d720-4bb2-a860-c755afe77ef2 to 10000 (0x00002710). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L537 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\73cde64d-d720-4bb2-a860-c755afe77ef2`
- **Raw .reg data:** `dword:00002710`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 73cde64d-d720-4bb2-a860-c755afe77ef2, la 10000 (0x00002710). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 73cde64d-d720-4bb2-a860-c755afe77ef2 to 10000 (0x00002710). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L541 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d6ba4903-386f-4c2c-8adb-5c21b3328d25`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d6ba4903-386f-4c2c-8adb-5c21b3328d25, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d6ba4903-386f-4c2c-8adb-5c21b3328d25 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L542 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d6ba4903-386f-4c2c-8adb-5c21b3328d25`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d6ba4903-386f-4c2c-8adb-5c21b3328d25, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d6ba4903-386f-4c2c-8adb-5c21b3328d25 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L545 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\3b04d4fd-1cc7-4f23-ab1c-d1337819c4bb`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 3b04d4fd-1cc7-4f23-ab1c-d1337819c4bb, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 3b04d4fd-1cc7-4f23-ab1c-d1337819c4bb to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L546 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\3b04d4fd-1cc7-4f23-ab1c-d1337819c4bb`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 3b04d4fd-1cc7-4f23-ab1c-d1337819c4bb, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 3b04d4fd-1cc7-4f23-ab1c-d1337819c4bb to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L550 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\40fbefc7-2e9d-4d25-a185-0cfd8574bac6`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 40fbefc7-2e9d-4d25-a185-0cfd8574bac6, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 40fbefc7-2e9d-4d25-a185-0cfd8574bac6 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L551 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\40fbefc7-2e9d-4d25-a185-0cfd8574bac6`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 40fbefc7-2e9d-4d25-a185-0cfd8574bac6, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 40fbefc7-2e9d-4d25-a185-0cfd8574bac6 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L555 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\40fbefc7-2e9d-4d25-a185-0cfd8574bac7`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 40fbefc7-2e9d-4d25-a185-0cfd8574bac7, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 40fbefc7-2e9d-4d25-a185-0cfd8574bac7 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L556 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\40fbefc7-2e9d-4d25-a185-0cfd8574bac7`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 40fbefc7-2e9d-4d25-a185-0cfd8574bac7, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 40fbefc7-2e9d-4d25-a185-0cfd8574bac7 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L560 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\2430ab6f-a520-44a2-9601-f7f23b5134b1`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 2430ab6f-a520-44a2-9601-f7f23b5134b1, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 2430ab6f-a520-44a2-9601-f7f23b5134b1 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L561 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\2430ab6f-a520-44a2-9601-f7f23b5134b1`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 2430ab6f-a520-44a2-9601-f7f23b5134b1, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 2430ab6f-a520-44a2-9601-f7f23b5134b1 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L564 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\97cfac41-2217-47eb-992d-618b1977c907`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 97cfac41-2217-47eb-992d-618b1977c907, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 97cfac41-2217-47eb-992d-618b1977c907 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L565 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\97cfac41-2217-47eb-992d-618b1977c907`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 97cfac41-2217-47eb-992d-618b1977c907, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 97cfac41-2217-47eb-992d-618b1977c907 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L569 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\2ddd5a84-5a71-437e-912a-db0b8c788732`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 2ddd5a84-5a71-437e-912a-db0b8c788732, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 2ddd5a84-5a71-437e-912a-db0b8c788732 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L570 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\2ddd5a84-5a71-437e-912a-db0b8c788732`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 2ddd5a84-5a71-437e-912a-db0b8c788732, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 2ddd5a84-5a71-437e-912a-db0b8c788732 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L574 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4bdaf4e9-d103-46d7-a5f0-6280121616ef`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 4bdaf4e9-d103-46d7-a5f0-6280121616ef, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 4bdaf4e9-d103-46d7-a5f0-6280121616ef to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L575 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4bdaf4e9-d103-46d7-a5f0-6280121616ef`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 4bdaf4e9-d103-46d7-a5f0-6280121616ef, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 4bdaf4e9-d103-46d7-a5f0-6280121616ef to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L579 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\943c8cb6-6f93-4227-ad87-e9a3feec08d1`
- **Raw .reg data:** `dword:00000005`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 943c8cb6-6f93-4227-ad87-e9a3feec08d1, la 5 (0x00000005). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 943c8cb6-6f93-4227-ad87-e9a3feec08d1 to 5 (0x00000005). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L580 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\943c8cb6-6f93-4227-ad87-e9a3feec08d1`
- **Raw .reg data:** `dword:00000005`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 943c8cb6-6f93-4227-ad87-e9a3feec08d1, la 5 (0x00000005). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 943c8cb6-6f93-4227-ad87-e9a3feec08d1 to 5 (0x00000005). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L584 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b0deaf6b-59c0-4523-8a45-ca7f40244114`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul b0deaf6b-59c0-4523-8a45-ca7f40244114, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID b0deaf6b-59c0-4523-8a45-ca7f40244114 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L585 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b0deaf6b-59c0-4523-8a45-ca7f40244114`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul b0deaf6b-59c0-4523-8a45-ca7f40244114, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID b0deaf6b-59c0-4523-8a45-ca7f40244114 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L589 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b28a6829-c5f7-444e-8f61-10e24e85c532`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul b28a6829-c5f7-444e-8f61-10e24e85c532, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID b28a6829-c5f7-444e-8f61-10e24e85c532 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L590 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b28a6829-c5f7-444e-8f61-10e24e85c532`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul b28a6829-c5f7-444e-8f61-10e24e85c532, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID b28a6829-c5f7-444e-8f61-10e24e85c532 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L593 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b669a5e9-7b1d-4132-baaa-49190abcfeb6`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul b669a5e9-7b1d-4132-baaa-49190abcfeb6, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID b669a5e9-7b1d-4132-baaa-49190abcfeb6 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L594 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\b669a5e9-7b1d-4132-baaa-49190abcfeb6`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul b669a5e9-7b1d-4132-baaa-49190abcfeb6, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID b669a5e9-7b1d-4132-baaa-49190abcfeb6 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L597 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c7be0679-2817-4d69-9d02-519a537ed0c6`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul c7be0679-2817-4d69-9d02-519a537ed0c6, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID c7be0679-2817-4d69-9d02-519a537ed0c6 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L598 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\c7be0679-2817-4d69-9d02-519a537ed0c6`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul c7be0679-2817-4d69-9d02-519a537ed0c6, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID c7be0679-2817-4d69-9d02-519a537ed0c6 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L601 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d8edeb9b-95cf-4f95-a73c-b061973693c8`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d8edeb9b-95cf-4f95-a73c-b061973693c8, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d8edeb9b-95cf-4f95-a73c-b061973693c8 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L602 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d8edeb9b-95cf-4f95-a73c-b061973693c8`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d8edeb9b-95cf-4f95-a73c-b061973693c8, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d8edeb9b-95cf-4f95-a73c-b061973693c8 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L606 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d8edeb9b-95cf-4f95-a73c-b061973693c9`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d8edeb9b-95cf-4f95-a73c-b061973693c9, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d8edeb9b-95cf-4f95-a73c-b061973693c9 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L607 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d8edeb9b-95cf-4f95-a73c-b061973693c9`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d8edeb9b-95cf-4f95-a73c-b061973693c9, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d8edeb9b-95cf-4f95-a73c-b061973693c9 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L611 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d92998c2-6a48-49ca-85d4-8cceec294570`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul d92998c2-6a48-49ca-85d4-8cceec294570, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID d92998c2-6a48-49ca-85d4-8cceec294570 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L612 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\d92998c2-6a48-49ca-85d4-8cceec294570`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul d92998c2-6a48-49ca-85d4-8cceec294570, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID d92998c2-6a48-49ca-85d4-8cceec294570 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L616 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\dfd10d17-d5eb-45dd-877a-9a34ddd15c82`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul dfd10d17-d5eb-45dd-877a-9a34ddd15c82, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID dfd10d17-d5eb-45dd-877a-9a34ddd15c82 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L617 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\dfd10d17-d5eb-45dd-877a-9a34ddd15c82`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul dfd10d17-d5eb-45dd-877a-9a34ddd15c82, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID dfd10d17-d5eb-45dd-877a-9a34ddd15c82 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L621 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f735a673-2066-4f80-a0c5-ddee0cf1bf5d`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul f735a673-2066-4f80-a0c5-ddee0cf1bf5d, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID f735a673-2066-4f80-a0c5-ddee0cf1bf5d to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L622 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f735a673-2066-4f80-a0c5-ddee0cf1bf5d`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul f735a673-2066-4f80-a0c5-ddee0cf1bf5d, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID f735a673-2066-4f80-a0c5-ddee0cf1bf5d to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L626 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f8861c27-95e7-475c-865b-13c0cb3f9d6b`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul f8861c27-95e7-475c-865b-13c0cb3f9d6b, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID f8861c27-95e7-475c-865b-13c0cb3f9d6b to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L627 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f8861c27-95e7-475c-865b-13c0cb3f9d6b`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul f8861c27-95e7-475c-865b-13c0cb3f9d6b, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID f8861c27-95e7-475c-865b-13c0cb3f9d6b to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L631 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f8861c27-95e7-475c-865b-13c0cb3f9d6c`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul f8861c27-95e7-475c-865b-13c0cb3f9d6c, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID f8861c27-95e7-475c-865b-13c0cb3f9d6c to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L632 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\f8861c27-95e7-475c-865b-13c0cb3f9d6c`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul f8861c27-95e7-475c-865b-13c0cb3f9d6c, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID f8861c27-95e7-475c-865b-13c0cb3f9d6c to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L638 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bf903d33-9d24-49d3-a468-e65e0325046a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul bf903d33-9d24-49d3-a468-e65e0325046a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID bf903d33-9d24-49d3-a468-e65e0325046a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L639 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\bf903d33-9d24-49d3-a468-e65e0325046a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul bf903d33-9d24-49d3-a468-e65e0325046a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID bf903d33-9d24-49d3-a468-e65e0325046a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L643 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7f2f5cfa-f10c-4823-b5e1-e93ae85f46b5`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7f2f5cfa-f10c-4823-b5e1-e93ae85f46b5, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7f2f5cfa-f10c-4823-b5e1-e93ae85f46b5 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L644 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7f2f5cfa-f10c-4823-b5e1-e93ae85f46b5`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7f2f5cfa-f10c-4823-b5e1-e93ae85f46b5, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7f2f5cfa-f10c-4823-b5e1-e93ae85f46b5 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L648 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b70f900-cdd9-4e66-aa26-ae8417f98173`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 4b70f900-cdd9-4e66-aa26-ae8417f98173, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 4b70f900-cdd9-4e66-aa26-ae8417f98173 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L649 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b70f900-cdd9-4e66-aa26-ae8417f98173`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 4b70f900-cdd9-4e66-aa26-ae8417f98173, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 4b70f900-cdd9-4e66-aa26-ae8417f98173 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L653 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b70f900-cdd9-4e66-aa26-ae8417f98174`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 4b70f900-cdd9-4e66-aa26-ae8417f98174, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 4b70f900-cdd9-4e66-aa26-ae8417f98174 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L654 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b70f900-cdd9-4e66-aa26-ae8417f98174`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 4b70f900-cdd9-4e66-aa26-ae8417f98174, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 4b70f900-cdd9-4e66-aa26-ae8417f98174 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L658 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b70f900-cdd9-4e66-aa26-ae8417f98175`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 4b70f900-cdd9-4e66-aa26-ae8417f98175, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 4b70f900-cdd9-4e66-aa26-ae8417f98175 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L659 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b70f900-cdd9-4e66-aa26-ae8417f98175`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 4b70f900-cdd9-4e66-aa26-ae8417f98175, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 4b70f900-cdd9-4e66-aa26-ae8417f98175 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L663 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\619b7505-003b-4e82-b7a6-4dd29c300973`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 619b7505-003b-4e82-b7a6-4dd29c300973, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 619b7505-003b-4e82-b7a6-4dd29c300973 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L664 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\619b7505-003b-4e82-b7a6-4dd29c300973`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 619b7505-003b-4e82-b7a6-4dd29c300973, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 619b7505-003b-4e82-b7a6-4dd29c300973 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L668 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\828423eb-8662-4344-90f7-52bf15870f5a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 828423eb-8662-4344-90f7-52bf15870f5a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 828423eb-8662-4344-90f7-52bf15870f5a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L669 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\828423eb-8662-4344-90f7-52bf15870f5a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 828423eb-8662-4344-90f7-52bf15870f5a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 828423eb-8662-4344-90f7-52bf15870f5a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L672 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\fddc842b-8364-4edc-94cf-c17f60de1c80`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul fddc842b-8364-4edc-94cf-c17f60de1c80, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID fddc842b-8364-4edc-94cf-c17f60de1c80 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L673 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\fddc842b-8364-4edc-94cf-c17f60de1c80`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul fddc842b-8364-4edc-94cf-c17f60de1c80, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID fddc842b-8364-4edc-94cf-c17f60de1c80 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L677 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\e0007330-f589-42ed-a401-5ddb10e785d3`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul e0007330-f589-42ed-a401-5ddb10e785d3, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID e0007330-f589-42ed-a401-5ddb10e785d3 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L678 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\e0007330-f589-42ed-a401-5ddb10e785d3`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul e0007330-f589-42ed-a401-5ddb10e785d3, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID e0007330-f589-42ed-a401-5ddb10e785d3 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L682 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\ea062031-0e34-4ff1-9b6d-eb1059334028`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul ea062031-0e34-4ff1-9b6d-eb1059334028, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID ea062031-0e34-4ff1-9b6d-eb1059334028 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L683 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\ea062031-0e34-4ff1-9b6d-eb1059334028`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul ea062031-0e34-4ff1-9b6d-eb1059334028, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID ea062031-0e34-4ff1-9b6d-eb1059334028 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L686 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\ea062031-0e34-4ff1-9b6d-eb1059334029`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul ea062031-0e34-4ff1-9b6d-eb1059334029, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID ea062031-0e34-4ff1-9b6d-eb1059334029 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L687 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\ea062031-0e34-4ff1-9b6d-eb1059334029`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul ea062031-0e34-4ff1-9b6d-eb1059334029, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID ea062031-0e34-4ff1-9b6d-eb1059334029 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L691 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\1facfc65-a930-4bc5-9f38-504ec097bbc0`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 1facfc65-a930-4bc5-9f38-504ec097bbc0, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 1facfc65-a930-4bc5-9f38-504ec097bbc0 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L692 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\1facfc65-a930-4bc5-9f38-504ec097bbc0`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 1facfc65-a930-4bc5-9f38-504ec097bbc0, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 1facfc65-a930-4bc5-9f38-504ec097bbc0 to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L696 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\447235c7-6a8d-4cc0-8e24-9eaf70b96e2b`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 447235c7-6a8d-4cc0-8e24-9eaf70b96e2b, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 447235c7-6a8d-4cc0-8e24-9eaf70b96e2b to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L697 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\447235c7-6a8d-4cc0-8e24-9eaf70b96e2b`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 447235c7-6a8d-4cc0-8e24-9eaf70b96e2b, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 447235c7-6a8d-4cc0-8e24-9eaf70b96e2b to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L700 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\447235c7-6a8d-4cc0-8e24-9eaf70b96e2c`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 447235c7-6a8d-4cc0-8e24-9eaf70b96e2c, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 447235c7-6a8d-4cc0-8e24-9eaf70b96e2c to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L701 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\447235c7-6a8d-4cc0-8e24-9eaf70b96e2c`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 447235c7-6a8d-4cc0-8e24-9eaf70b96e2c, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 447235c7-6a8d-4cc0-8e24-9eaf70b96e2c to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L705 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\71021b41-c749-4d21-be74-a00f335d582b`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 71021b41-c749-4d21-be74-a00f335d582b, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 71021b41-c749-4d21-be74-a00f335d582b to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L706 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\71021b41-c749-4d21-be74-a00f335d582b`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 71021b41-c749-4d21-be74-a00f335d582b, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 71021b41-c749-4d21-be74-a00f335d582b to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L709 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\68afb2d9-ee95-47a8-8f50-4115088073b1`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 68afb2d9-ee95-47a8-8f50-4115088073b1, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 68afb2d9-ee95-47a8-8f50-4115088073b1 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L710 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\68afb2d9-ee95-47a8-8f50-4115088073b1`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 68afb2d9-ee95-47a8-8f50-4115088073b1, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 68afb2d9-ee95-47a8-8f50-4115088073b1 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L714 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\93b8b6dc-0698-4d1c-9ee4-0644e900c85d`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 93b8b6dc-0698-4d1c-9ee4-0644e900c85d, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 93b8b6dc-0698-4d1c-9ee4-0644e900c85d to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L715 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\93b8b6dc-0698-4d1c-9ee4-0644e900c85d`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 93b8b6dc-0698-4d1c-9ee4-0644e900c85d, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 93b8b6dc-0698-4d1c-9ee4-0644e900c85d to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L719 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee8e-2bef-41e0-89c6-b55d0929964c`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 893dee8e-2bef-41e0-89c6-b55d0929964c, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 893dee8e-2bef-41e0-89c6-b55d0929964c to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L720 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee8e-2bef-41e0-89c6-b55d0929964c`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 893dee8e-2bef-41e0-89c6-b55d0929964c, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 893dee8e-2bef-41e0-89c6-b55d0929964c to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L724 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee8e-2bef-41e0-89c6-b55d0929964d`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 893dee8e-2bef-41e0-89c6-b55d0929964d, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 893dee8e-2bef-41e0-89c6-b55d0929964d to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L725 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee8e-2bef-41e0-89c6-b55d0929964d`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 893dee8e-2bef-41e0-89c6-b55d0929964d, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 893dee8e-2bef-41e0-89c6-b55d0929964d to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L729 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee8e-2bef-41e0-89c6-b55d0929964e`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 893dee8e-2bef-41e0-89c6-b55d0929964e, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 893dee8e-2bef-41e0-89c6-b55d0929964e to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L730 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\893dee8e-2bef-41e0-89c6-b55d0929964e`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 893dee8e-2bef-41e0-89c6-b55d0929964e, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 893dee8e-2bef-41e0-89c6-b55d0929964e to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L736 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7f2492b6-60b1-45e5-ae55-773f8cd5caec`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7f2492b6-60b1-45e5-ae55-773f8cd5caec, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7f2492b6-60b1-45e5-ae55-773f8cd5caec to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L737 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7f2492b6-60b1-45e5-ae55-773f8cd5caec`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7f2492b6-60b1-45e5-ae55-773f8cd5caec, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7f2492b6-60b1-45e5-ae55-773f8cd5caec to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L741 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7d24baa7-0b84-480f-840c-1b0743c00f5f`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7d24baa7-0b84-480f-840c-1b0743c00f5f, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7d24baa7-0b84-480f-840c-1b0743c00f5f to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L742 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7d24baa7-0b84-480f-840c-1b0743c00f5f`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7d24baa7-0b84-480f-840c-1b0743c00f5f, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7d24baa7-0b84-480f-840c-1b0743c00f5f to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L746 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7d24baa7-0b84-480f-840c-1b0743c00f60`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7d24baa7-0b84-480f-840c-1b0743c00f60, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7d24baa7-0b84-480f-840c-1b0743c00f60 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L747 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7d24baa7-0b84-480f-840c-1b0743c00f60`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7d24baa7-0b84-480f-840c-1b0743c00f60, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7d24baa7-0b84-480f-840c-1b0743c00f60 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L753 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\9943e905-9a30-4ec1-9b99-44dd3b76f7a2`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 9943e905-9a30-4ec1-9b99-44dd3b76f7a2, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 9943e905-9a30-4ec1-9b99-44dd3b76f7a2 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L754 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\9943e905-9a30-4ec1-9b99-44dd3b76f7a2`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 9943e905-9a30-4ec1-9b99-44dd3b76f7a2, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 9943e905-9a30-4ec1-9b99-44dd3b76f7a2 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L758 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\984cf492-3bed-4488-a8f9-4286c97bf5aa`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 984cf492-3bed-4488-a8f9-4286c97bf5aa, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 984cf492-3bed-4488-a8f9-4286c97bf5aa to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L759 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\984cf492-3bed-4488-a8f9-4286c97bf5aa`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 984cf492-3bed-4488-a8f9-4286c97bf5aa, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 984cf492-3bed-4488-a8f9-4286c97bf5aa to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L763 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\984cf492-3bed-4488-a8f9-4286c97bf5ab`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 984cf492-3bed-4488-a8f9-4286c97bf5ab, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 984cf492-3bed-4488-a8f9-4286c97bf5ab to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L764 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\984cf492-3bed-4488-a8f9-4286c97bf5ab`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 984cf492-3bed-4488-a8f9-4286c97bf5ab, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 984cf492-3bed-4488-a8f9-4286c97bf5ab to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L770 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\64fcee6b-5b1f-45a4-a76a-19b2c36ee290`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 64fcee6b-5b1f-45a4-a76a-19b2c36ee290, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 64fcee6b-5b1f-45a4-a76a-19b2c36ee290 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L771 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\64fcee6b-5b1f-45a4-a76a-19b2c36ee290`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 64fcee6b-5b1f-45a4-a76a-19b2c36ee290, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 64fcee6b-5b1f-45a4-a76a-19b2c36ee290 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L775 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6ff13aeb-7897-4356-9999-dd9930af065f`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6ff13aeb-7897-4356-9999-dd9930af065f, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6ff13aeb-7897-4356-9999-dd9930af065f to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L776 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6ff13aeb-7897-4356-9999-dd9930af065f`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6ff13aeb-7897-4356-9999-dd9930af065f, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6ff13aeb-7897-4356-9999-dd9930af065f to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L780 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7b224883-b3cc-4d79-819f-8374152cbe7c`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 7b224883-b3cc-4d79-819f-8374152cbe7c, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 7b224883-b3cc-4d79-819f-8374152cbe7c to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L781 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7b224883-b3cc-4d79-819f-8374152cbe7c`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 7b224883-b3cc-4d79-819f-8374152cbe7c, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 7b224883-b3cc-4d79-819f-8374152cbe7c to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L787 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6788488b-1b90-4d11-8fa7-973e470dff47`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6788488b-1b90-4d11-8fa7-973e470dff47, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6788488b-1b90-4d11-8fa7-973e470dff47 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L788 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6788488b-1b90-4d11-8fa7-973e470dff47`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6788488b-1b90-4d11-8fa7-973e470dff47, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6788488b-1b90-4d11-8fa7-973e470dff47 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L792 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\69439b22-221b-4830-bd34-f7bcece24583`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 69439b22-221b-4830-bd34-f7bcece24583, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 69439b22-221b-4830-bd34-f7bcece24583 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L793 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\69439b22-221b-4830-bd34-f7bcece24583`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 69439b22-221b-4830-bd34-f7bcece24583, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 69439b22-221b-4830-bd34-f7bcece24583 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L797 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6c2993b0-8f48-481f-bcc6-00dd2742aa06`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6c2993b0-8f48-481f-bcc6-00dd2742aa06, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6c2993b0-8f48-481f-bcc6-00dd2742aa06 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L798 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6c2993b0-8f48-481f-bcc6-00dd2742aa06`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6c2993b0-8f48-481f-bcc6-00dd2742aa06, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6c2993b0-8f48-481f-bcc6-00dd2742aa06 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L802 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6ece9e1f-b6dd-42bf-b1b7-5a512b10c092`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 6ece9e1f-b6dd-42bf-b1b7-5a512b10c092, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 6ece9e1f-b6dd-42bf-b1b7-5a512b10c092 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L803 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\6ece9e1f-b6dd-42bf-b1b7-5a512b10c092`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 6ece9e1f-b6dd-42bf-b1b7-5a512b10c092, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 6ece9e1f-b6dd-42bf-b1b7-5a512b10c092 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L808 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b92d758-5a24-4851-a470-815d78aee119`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 4b92d758-5a24-4851-a470-815d78aee119, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 4b92d758-5a24-4851-a470-815d78aee119 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L809 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4b92d758-5a24-4851-a470-815d78aee119`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 4b92d758-5a24-4851-a470-815d78aee119, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 4b92d758-5a24-4851-a470-815d78aee119 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L813 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4d2b0152-7d5c-498b-88e2-34345392a2c5`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 4d2b0152-7d5c-498b-88e2-34345392a2c5, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 4d2b0152-7d5c-498b-88e2-34345392a2c5 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L814 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4d2b0152-7d5c-498b-88e2-34345392a2c5`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 4d2b0152-7d5c-498b-88e2-34345392a2c5, la 1 (0x00000001). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 4d2b0152-7d5c-498b-88e2-34345392a2c5 to 1 (0x00000001). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L820 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4e4450b3-6179-4e91-b8f1-5bb9938f81a1`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 4e4450b3-6179-4e91-b8f1-5bb9938f81a1, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 4e4450b3-6179-4e91-b8f1-5bb9938f81a1 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L821 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\4e4450b3-6179-4e91-b8f1-5bb9938f81a1`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 4e4450b3-6179-4e91-b8f1-5bb9938f81a1, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 4e4450b3-6179-4e91-b8f1-5bb9938f81a1 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L825 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\603fe9ce-8d01-4b48-a968-1d706c28fd5c`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 603fe9ce-8d01-4b48-a968-1d706c28fd5c, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 603fe9ce-8d01-4b48-a968-1d706c28fd5c to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L826 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\603fe9ce-8d01-4b48-a968-1d706c28fd5c`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 603fe9ce-8d01-4b48-a968-1d706c28fd5c, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 603fe9ce-8d01-4b48-a968-1d706c28fd5c to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L830 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\603fe9ce-8d01-4b48-a968-1d706c28fd5d`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 603fe9ce-8d01-4b48-a968-1d706c28fd5d, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 603fe9ce-8d01-4b48-a968-1d706c28fd5d to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L831 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\603fe9ce-8d01-4b48-a968-1d706c28fd5d`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 603fe9ce-8d01-4b48-a968-1d706c28fd5d, la 100 (0x00000064). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 603fe9ce-8d01-4b48-a968-1d706c28fd5d to 100 (0x00000064). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L837 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\60fbe21b-efd9-49f2-b066-8674d8e9f423`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 60fbe21b-efd9-49f2-b066-8674d8e9f423, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 60fbe21b-efd9-49f2-b066-8674d8e9f423 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L838 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\60fbe21b-efd9-49f2-b066-8674d8e9f423`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 60fbe21b-efd9-49f2-b066-8674d8e9f423, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 60fbe21b-efd9-49f2-b066-8674d8e9f423 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L844 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\06cadf0e-64ed-448a-8927-ce7bf90eb35d`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 06cadf0e-64ed-448a-8927-ce7bf90eb35d, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 06cadf0e-64ed-448a-8927-ce7bf90eb35d to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L845 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\06cadf0e-64ed-448a-8927-ce7bf90eb35d`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 06cadf0e-64ed-448a-8927-ce7bf90eb35d, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 06cadf0e-64ed-448a-8927-ce7bf90eb35d to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L849 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\06cadf0e-64ed-448a-8927-ce7bf90eb35e`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 06cadf0e-64ed-448a-8927-ce7bf90eb35e, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 06cadf0e-64ed-448a-8927-ce7bf90eb35e to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L850 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\06cadf0e-64ed-448a-8927-ce7bf90eb35e`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 06cadf0e-64ed-448a-8927-ce7bf90eb35e, la 10 (0x0000000A). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 06cadf0e-64ed-448a-8927-ce7bf90eb35e to 10 (0x0000000A). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L854 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\465e1f50-b610-473a-ab58-00d1077dc418`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 465e1f50-b610-473a-ab58-00d1077dc418, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 465e1f50-b610-473a-ab58-00d1077dc418 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L855 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\465e1f50-b610-473a-ab58-00d1077dc418`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 465e1f50-b610-473a-ab58-00d1077dc418, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 465e1f50-b610-473a-ab58-00d1077dc418 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L859 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\465e1f50-b610-473a-ab58-00d1077dc419`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 465e1f50-b610-473a-ab58-00d1077dc419, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 465e1f50-b610-473a-ab58-00d1077dc419 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L860 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\465e1f50-b610-473a-ab58-00d1077dc419`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 465e1f50-b610-473a-ab58-00d1077dc419, la 2 (0x00000002). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 465e1f50-b610-473a-ab58-00d1077dc419 to 2 (0x00000002). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L866 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowferSettings\4009efa7-e72d-4cba-9edf-91084ea8cbc3`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ACSetting Index” în ramura Policies / Microsoft / Power la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ACSetting Index” option in registry branch Policies / Microsoft / Power to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L867 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowferSettings\4009efa7-e72d-4cba-9edf-91084ea8cbc3`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DCSetting Index” în ramura Policies / Microsoft / Power la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “DCSetting Index” option in registry branch Policies / Microsoft / Power to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L871 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12fd031f-53d2-4bf4-ac6d-c699fc9538c7`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 12fd031f-53d2-4bf4-ac6d-c699fc9538c7, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 12fd031f-53d2-4bf4-ac6d-c699fc9538c7 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L872 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\12fd031f-53d2-4bf4-ac6d-c699fc9538c7`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 12fd031f-53d2-4bf4-ac6d-c699fc9538c7, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 12fd031f-53d2-4bf4-ac6d-c699fc9538c7 to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L876 · SET-VALUE · `ACSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\1a98ad09-af22-42ca-8e61-f0a5802c270a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare la priză (AC), identificatorul 1a98ad09-af22-42ca-8e61-f0a5802c270a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the AC / plugged-in power power-policy index for GUID 1a98ad09-af22-42ca-8e61-f0a5802c270a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

### L877 · SET-VALUE · `DCSettingIndex`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\1a98ad09-af22-42ca-8e61-f0a5802c270a`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează indicele politicii de energie pentru alimentare pe baterie (DC), identificatorul 1a98ad09-af22-42ca-8e61-f0a5802c270a, la 0 (0x00000000). Unitatea, intervalul permis și buildul minim pentru acest GUID necesită verificare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the DC / battery power power-policy index for GUID 1a98ad09-af22-42ca-8e61-f0a5802c270a to 0 (0x00000000). Valid units, allowed range and GUID-specific minimum build need verification. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Power policy GUID setting; apply only if the corresponding power setting exists on the target system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/`

## Referințe / References

- https://learn.microsoft.com/en-us/windows-hardware/customize/power-settings/
