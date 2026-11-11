# Old Codecs/fix fraunhofer iis mp3 codec.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `3404c7919678ea95df237455185fea3af127bea21f95554c567546d565fac365`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 6
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion\drivers.desc`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „drivers.desc” din ramura Wow6432Node / Microsoft / Windows NT, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “drivers.desc” key in registry branch Wow6432Node / Microsoft / Windows NT, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `%SYSTEMROOT%\\SysWOW64\\l3codecp.acm`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion\drivers.desc`
- **Raw .reg data:** `"Fraunhofer IIS MPEG Audio Layer-3 Codec (professional)"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează identificatorul „%SYSTEMROOT%\\SysWOW64\\l3codecp.acm” în ramura Wow6432Node / Microsoft / Windows NT la Fraunhofer IIS MPEG Audio Layer-3 Codec (professional) (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the identifier “%SYSTEMROOT%\\SysWOW64\\l3codecp.acm” in registry branch Wow6432Node / Microsoft / Windows NT to Fraunhofer IIS MPEG Audio Layer-3 Codec (professional) (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `msacm.l3acm`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion\Drivers32`
- **Raw .reg data:** `"%SYSTEMROOT%\\SysWOW64\\l3codecp.acm"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „msacm.l3acm” în ramura Wow6432Node / Microsoft / Windows NT la %SYSTEMROOT%\SysWOW64\l3codecp.acm (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “msacm.l3acm” option in registry branch Wow6432Node / Microsoft / Windows NT to %SYSTEMROOT%\SysWOW64\l3codecp.acm (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L12 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\drivers.desc`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „drivers.desc” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “drivers.desc” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `%SYSTEMROOT%\\System32\\l3codecp.acm`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\drivers.desc`
- **Raw .reg data:** `"Fraunhofer IIS MPEG Audio Layer-3 Codec (professional)"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează identificatorul „%SYSTEMROOT%\\System32\\l3codecp.acm” în ramura Microsoft / Windows NT / CurrentVersion la Fraunhofer IIS MPEG Audio Layer-3 Codec (professional) (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the identifier “%SYSTEMROOT%\\System32\\l3codecp.acm” in registry branch Microsoft / Windows NT / CurrentVersion to Fraunhofer IIS MPEG Audio Layer-3 Codec (professional) (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L17 · SET-VALUE · `msacm.l3acm`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Drivers32`
- **Raw .reg data:** `"%SYSTEMROOT%\\System32\\l3codecp.acm"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „msacm.l3acm” în ramura Microsoft / Windows NT / CurrentVersion la %SYSTEMROOT%\System32\l3codecp.acm (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “msacm.l3acm” option in registry branch Microsoft / Windows NT / CurrentVersion to %SYSTEMROOT%\System32\l3codecp.acm (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
