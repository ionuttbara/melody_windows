# Devices/Disable_Windows_Protected_Print_Mode.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `af16d41eb4e5a4c0ac6003e6678f0afedc59be910342430ed2be6e2427a83f42`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `26100+`
- **Runtime prerequisite / condiție runtime:** `wpp-policy-edition`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · DELETE-VALUE · `WindowsProtectedPrintGroupPolicyState`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\Printers\WPP`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Șterge valoarea politicii Windows Protected Print: sistemul revine la starea neconfigurată de această politică. NU dezactivează obligatoriu modul deja activat de utilizator. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Deletes the managed Windows Protected Print policy value: the policy becomes unconfigured. This does NOT necessarily disable a mode already activated by the user. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Protected Print policy operation.
- **OS support / versiuni:** `26100+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-printers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-printers
