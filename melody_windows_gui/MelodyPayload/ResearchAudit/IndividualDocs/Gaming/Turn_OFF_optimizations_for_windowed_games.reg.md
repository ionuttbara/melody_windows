# Gaming/Turn_OFF_optimizations_for_windowed_games.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `8cd5055c9fc6f62da9d4e9d8b03b0abbebf219ac11e43b79d06f6940fae3087a`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `22000+`
- **Runtime prerequisite / condiție runtime:** `existing-exe`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `SwapEffectUpgradeCache`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\GraphicsSettings`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Swap Effect Upgrade Cache” în ramura Microsoft / DirectX / GraphicsSettings la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Swap Effect Upgrade Cache” option in registry branch Microsoft / DirectX / GraphicsSettings to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `22000+`

### L7 · SET-VALUE · `DirectXUserGlobalSettings`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"SwapEffectUpgradeEnable=0;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Direct XUser Global Settings” în preferințele GPU per aplicație la SwapEffectUpgradeEnable=0; (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Direct XUser Global Settings” option in per-application GPU preferences to SwapEffectUpgradeEnable=0; (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference
