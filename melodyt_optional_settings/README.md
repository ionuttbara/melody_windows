# Optional Melody settings — compatibility integration

The sibling `melody_windows_gui/MelodyPayload/Registry/Legacy Optional/` folder
contains the approved optional variants used by the OS-aware Melody GUI.
All are **off by default**. Existing files here remain original reference
material and are **not automatically imported**.

- Windows 7-only: GWX policy (without the original IFEO executable debugger override).
- Windows 7/8/8.1 + selected Windows 10 builds: a safe IE UI option (not the original IE policy collection that disables security features); legacy Windows Media Player and Windows Connect Now policies.
- Windows 8.1/10: original `This PC` folder removals, opt-in and backup-tracked.
- Windows 10: safer Quick Access HubMode-only option.
- Compatible Windows 10/11 builds: Sandbox policy (available only from the designated build range).
- Any supported OS: optional Office 2016/365 sign-in policy.

`disable meltdown spectre.reg` is intentionally not embedded or offered by Melody.
`deprecated_Settings/` is intentionally not embedded or offered.
