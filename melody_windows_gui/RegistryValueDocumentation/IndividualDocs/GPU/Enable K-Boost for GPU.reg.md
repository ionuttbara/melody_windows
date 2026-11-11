# GPU/Enable K-Boost for GPU.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `f15301a5ff184bb4205fefb0eb6d4a1a006c127be8b897651c0bdcad155c434a`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 16
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · DELETE-VALUE · `PerfLevelSrc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Perf Level Src” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Perf Level Src” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `PowerMizerEnable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Power Mizer Enable” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Power Mizer Enable” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L6 · DELETE-VALUE · `PowerMizerLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Power Mizer Level” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Power Mizer Level” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L7 · DELETE-VALUE · `PowerMizerLevelAC`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Power Mizer Level AC” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Power Mizer Level AC” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L10 · DELETE-VALUE · `PerfLevelSrc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Perf Level Src” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Perf Level Src” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `PowerMizerEnable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Power Mizer Enable” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Power Mizer Enable” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L12 · DELETE-VALUE · `PowerMizerLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Power Mizer Level” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Power Mizer Level” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L13 · DELETE-VALUE · `PowerMizerLevelAC`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Power Mizer Level AC” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Power Mizer Level AC” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L16 · DELETE-VALUE · `PerfLevelSrc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Perf Level Src” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Perf Level Src” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L17 · SET-VALUE · `PowerMizerEnable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Power Mizer Enable” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Power Mizer Enable” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L18 · DELETE-VALUE · `PowerMizerLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Power Mizer Level” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Power Mizer Level” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L19 · DELETE-VALUE · `PowerMizerLevelAC`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Power Mizer Level AC” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Power Mizer Level AC” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L22 · DELETE-VALUE · `PerfLevelSrc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Perf Level Src” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Perf Level Src” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L23 · SET-VALUE · `PowerMizerEnable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Power Mizer Enable” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Power Mizer Enable” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L24 · DELETE-VALUE · `PowerMizerLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Power Mizer Level” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Power Mizer Level” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L25 · DELETE-VALUE · `PowerMizerLevelAC`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Power Mizer Level AC” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “Power Mizer Level AC” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
