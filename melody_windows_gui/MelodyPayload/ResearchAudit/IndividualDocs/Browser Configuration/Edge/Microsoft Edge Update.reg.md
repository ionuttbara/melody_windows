# Browser Configuration/Edge/Microsoft Edge Update.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `e303a6f35f9500847e8e61454d775480502f7f70ce976f733b2b3268824a65a5`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `10240+`
- **Runtime prerequisite / condiție runtime:** `edge-update-domain`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `UpdateDefault`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\EdgeUpdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica Microsoft Edge Update permite toate actualizările implicit, pentru toate canalele (cod 1). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Microsoft Edge Update policy: allow all updates, by default for all channels (code 1). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Documented Edge Update policy; requires installed supported Edge/Updater/WebView2/domain prerequisites.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-update-policies`

### L6 · SET-VALUE · `Update{F3017226-FE2A-4295-8BDF-00C3A9A7E4C5}`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\EdgeUpdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica Microsoft Edge Update permite toate actualizările pentru aplicația identificată de sufixul GUID (cod 1). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Microsoft Edge Update policy: allow all updates, for the app identified by its GUID suffix (code 1). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Documented Edge Update policy; requires installed supported Edge/Updater/WebView2/domain prerequisites.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-update-policies`

## Referințe / References

- https://learn.microsoft.com/en-us/deployedge/microsoft-edge-update-policies
