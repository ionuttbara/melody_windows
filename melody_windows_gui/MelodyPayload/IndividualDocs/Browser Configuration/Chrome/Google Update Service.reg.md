# Browser Configuration/Chrome/Google Update Service.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `d246ee968ece72b9c7879d042bb9e5071caf2cf5641ee6d468a6244156fd4a18`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `chrome-update`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `UpdateDefault`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Update`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica implicită Google Update pentru aplicațiile administrate: permite actualizări (cod 1); politicile per-aplicație pot avea prioritate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Google Update default policy for managed apps: allows updates (code 1); per-app policy can override this. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

## Referințe / References

- https://chromeenterprise.google/policies/
