# Remove Windows Telemetry Service 2

> Melody 16.0 — validated on real Windows. Each existing service key is backed up as a complete tree before deletion. Missing targets are skipped safely.

### L1 · DELETE-KEY · `ALG`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\ALG`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `ALG` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L2 · DELETE-KEY · `BDESVC`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\BDESVC`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `BDESVC` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L3 · DELETE-KEY · `lfsvc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\lfsvc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `lfsvc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L4 · DELETE-KEY · `LocalKdc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LocalKdc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `LocalKdc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L5 · DELETE-KEY · `MSiSCSI`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\MSiSCSI`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `MSiSCSI` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L6 · DELETE-KEY · `CscService`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\CscService`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `CscService` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L7 · DELETE-KEY · `defragsvc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\defragsvc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `defragsvc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L8 · DELETE-KEY · `PhoneSvc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PhoneSvc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `PhoneSvc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L9 · DELETE-KEY · `WdNisSvc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WdNisSvc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `WdNisSvc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L10 · DELETE-KEY · `wcncsvc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\wcncsvc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `wcncsvc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L11 · DELETE-KEY · `Wecsvc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Wecsvc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `Wecsvc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L12 · DELETE-KEY · `PushToInstall`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PushToInstall`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `PushToInstall` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L13 · DELETE-KEY · `cloudidsvc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\cloudidsvc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `cloudidsvc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L14 · DELETE-KEY · `WdFilter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WdFilter`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `WdFilter` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L15 · DELETE-KEY · `WdBoot`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WdBoot`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `WdBoot` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L16 · DELETE-KEY · `WdAiNisDrv`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WdAiNisDrv`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `WdAiNisDrv` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L17 · DELETE-KEY · `wesp`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\wesp`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `wesp` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L18 · DELETE-KEY · `wespelam`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\wespelam`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `wespelam` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L19 · DELETE-KEY · `SEMgrSvc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SEMgrSvc`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `SEMgrSvc` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L20 · DELETE-KEY · `PktMon`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PktMon`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `PktMon` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L21 · DELETE-KEY · `PktMonApi`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PktMonApi`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `PktMonApi` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L22 · DELETE-KEY · `PenService`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PenService`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `PenService` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.

### L23 · DELETE-KEY · `PenService_3ead8`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PenService_3ead8`
- **Raw .reg data:** `DELETE KEY`
- **Type / tip:** `REG_KEY`
- **What it configures / EN:** Removes the `PenService_3ead8` service registration when that exact service exists. Melody captures the complete key tree before deletion so Restore can recreate it.
- **Evidence level:** verified
- **Evidence / EN:** Validated on real Windows by the project owner. Runtime application is conditional on the exact service key being present.
- **OS support / versiuni:** Windows 7 build 7600+; individual services may exist only on later releases.
