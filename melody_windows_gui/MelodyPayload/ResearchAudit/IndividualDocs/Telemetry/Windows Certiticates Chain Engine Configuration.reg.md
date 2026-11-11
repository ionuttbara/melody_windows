# Telemetry/Windows Certiticates Chain Engine Configuration.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `3442e4f1fcd7f1641bc8de86afe2daa3f1ce61f7472df137070344764401ed91`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 4
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `ChainRevAccumulativeUrlRetrievalTimeoutMilliseconds`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\SystemCertificates\ChainEngine\Config`
- **Raw .reg data:** `dword:0000000e`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Chain Rev Accumulative Url Retrieval Timeout Milliseconds” în ramura Policies / Microsoft / SystemCertificates la 14 (0x0000000E) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Chain Rev Accumulative Url Retrieval Timeout Milliseconds” option in registry branch Policies / Microsoft / SystemCertificates to 14 (0x0000000E) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `ChainUrlRetrievalTimeoutMilliseconds`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\SystemCertificates\ChainEngine\Config`
- **Raw .reg data:** `dword:0000000e`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Chain Url Retrieval Timeout Milliseconds” în ramura Policies / Microsoft / SystemCertificates la 14 (0x0000000E) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Chain Url Retrieval Timeout Milliseconds” option in registry branch Policies / Microsoft / SystemCertificates to 14 (0x0000000E) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `CrossCertDownloadIntervalHours`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\SystemCertificates\ChainEngine\Config`
- **Raw .reg data:** `dword:000000a8`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cross Cert Download Interval Hours” în ramura Policies / Microsoft / SystemCertificates la 168 (0x000000A8) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cross Cert Download Interval Hours” option in registry branch Policies / Microsoft / SystemCertificates to 168 (0x000000A8) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `Options`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\SystemCertificates\ChainEngine\Config`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Options” în ramura Policies / Microsoft / SystemCertificates la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Options” option in registry branch Policies / Microsoft / SystemCertificates to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
