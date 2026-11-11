# Devices/CD Read Speed Maximum Performance.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `f60dfd9ecb0a16ca67c9b3de5fcc440297d88ca25ec3f1d639f9931aad96cf8c`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 3
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `PrefetchTail`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem\CDFS`
- **Raw .reg data:** `dword:00004000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Prefetch Tail” în ramura CurrentControlSet / Control / FileSystem la 16384 (0x00004000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Prefetch Tail” option in registry branch CurrentControlSet / Control / FileSystem to 16384 (0x00004000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L5 · SET-VALUE · `CacheSize`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem\CDFS`
- **Raw .reg data:** `hex(3):FF,FF,00,00`
- **Type / tip:** `REG_BINARY`
- **Ce face / RO:** Configurează opțiunea „Cache Size” în ramura CurrentControlSet / Control / FileSystem la date hexazecimale / hexadecimal data (REG_BINARY / typed hex). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cache Size” option in registry branch CurrentControlSet / Control / FileSystem to date hexazecimale / hexadecimal data (REG_BINARY / typed hex). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L6 · SET-VALUE · `Prefetch`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem\CDFS`
- **Raw .reg data:** `dword:00004000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Prefetch” în ramura CurrentControlSet / Control / FileSystem la 16384 (0x00004000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Prefetch” option in registry branch CurrentControlSet / Control / FileSystem to 16384 (0x00004000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry
