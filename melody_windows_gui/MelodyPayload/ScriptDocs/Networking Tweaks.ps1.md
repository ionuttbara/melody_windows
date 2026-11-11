# Networking Tweaks.ps1

## Individual script audit

- **GUI status:** UNAVAILABLE (UNAVAILABLE scripts cannot run)
- **Version evidence:** Requires individual NIC/chipset/driver qualification.
- **Live runnable SHA-256:** `0882c13b46c4cecae9960261acdd269b0d3ea44613722b632178f1703ae9079f`
- **Original source SHA-256:** `fcda5887a98fa6e2b0e0f16b380579a7efc21901ced855a543f7275649bef979`
- **Potential impact:** No machine-wide tuning guarantee or consistent rollback. Original saved for independent review.
- **Risk:** Legacy original sets adapter and networking parameters across installed hardware.
- **Mandatory prerequisite:** NIC model, driver, registry keyword, setting value, release-specific vendor docs, before/after measurements.

## Every active source statement from original/reviewed script

The statements below are an exact indexed source inventory. **An enumerated command is not proof that it produces a benefit or works across Windows versions.**

- Line 2: `Set-NetTCPSetting -SettingName * -ScalingHeuristics Disabled` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 3: `Set-NetTCPSetting -SettingName * -InitialRto 3000 -Timestamps Disabled -MemoryPressureProtection Disabled -NonSackRttResiliency Disabled -MaxSynRetransmissions 2` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 4: `Set-NetIPv4Protocol -IcmpRedirects Disabled -DefaultHopLimit 64 -MultipleArpAnnouncements Disabled` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 6: `netsh.exe interface tcp set supplemental Internet congestionprovider=ctcp` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 7: `netsh.exe interface tcp set supplemental InternetCustom congestionprovider=ctcp` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 8: `netsh.exe interface tcp set supplemental Datacenter congestionprovider=ctcp` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 9: `netsh.exe interface tcp set supplemental Compat congestionprovider=ctcp` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 10: `netsh.exe interface tcp set supplemental DatacenterCustom congestionprovider=ctcp` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 13: `Set-NetOffloadGlobalSetting -PacketCoalescingFilter disabled -Chimney Disabled -Taskoffload Enabled -ReceiveSideScaling Enabled -ReceiveSegmentCoalescing Disabled` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 16: `Disable-NetAdapterLso -Name *` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 17: `Disable-NetAdapterBinding -Name * -ComponentID ms_pacer` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 18: `Set-NetIPInterface -WeakHostSend Enabled -WeakHostReceive Enabled -ErrorAction SilentlyContinue` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 21: `netsh.exe int isatap set state disable | Out-Null` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 22: `netsh.exe int tcp set global ecncapability=enabled | Out-Null` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 23: `netsh.exe int tcp set global ecn=enabled | Out-Null` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 24: `netsh.exe interface tcp set global fastopen=enabled | Out-Null` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 25: `netsh.exe interface tcp set global fastopenfallback=enabled | Out-Null` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 26: `netsh.exe interface ip set global neighborcachelimit=4096 taskoffload=enabled | Out-Null` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 27: `netsh.exe interface tcp set global hystart=disabled | Out-Null` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 30: `function Set-RegKey {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 31: `param (` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 32: `[string]$path,` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 33: `[string]$name,` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 34: `[string]$value,` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 35: `[string]$type = "DWord"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 36: `)` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 38: `if ($type -eq "DWord") {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 39: `Set-ItemProperty -Path $path -Name $name -Value $value -Type DWord -Force` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 40: `} else {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 41: `Set-ItemProperty -Path $path -Name $name -Value $value -Type String -Force` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 42: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 43: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 46: `$netbtPath = "HKLM:\SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 47: `$interfaces = Get-ChildItem -Path $netbtPath` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 49: `foreach ($interface in $interfaces) {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 50: `Set-RegKey -path $interface.PSPath -name "NetbiosOptions" -value 1 -type "DWord"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 51: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 54: `$regPath = "HKLM:\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 55: `$networkInterfaces = Get-ChildItem -Path $regPath | Where-Object { $_.Name -match "000" }` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 57: `foreach ($interface in $networkInterfaces) {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 59: `Set-RegKey -path $interface.PSPath -name "*FlowControl" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 60: `Set-RegKey -path $interface.PSPath -name "FlowControlCap" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 63: `Set-RegKey -path $interface.PSPath -name "TxIntDelay" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 64: `Set-RegKey -path $interface.PSPath -name "TxAbsIntDelay" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 65: `Set-RegKey -path $interface.PSPath -name "RxIntDelay" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 66: `Set-RegKey -path $interface.PSPath -name "RxAbsIntDelay" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 69: `Set-RegKey -path $interface.PSPath -name "FatChannelIntolerant" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 72: `Set-RegKey -path $interface.PSPath -name "*InterruptModeration" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 75: `Set-RegKey -path $interface.PSPath -name "LogDisconnectEvent" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 76: `Set-RegKey -path $interface.PSPath -name "LogLinkStateEvent" -value 16 -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 79: `Set-RegKey -path $interface.PSPath -name "GigaLite" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 82: `Set-RegKey -path $interface.PSPath -name "*EEE" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 83: `Set-RegKey -path $interface.PSPath -name "AdvancedEEE" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 84: `Set-RegKey -path $interface.PSPath -name "AutoPowerSaveModeEnabled" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 85: `Set-RegKey -path $interface.PSPath -name "EnableEDT" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 86: `Set-RegKey -path $interface.PSPath -name "EnableGreenEthernet" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 87: `Set-RegKey -path $interface.PSPath -name "EEELinkAdvertisement" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 88: `Set-RegKey -path $interface.PSPath -name "ENPWMode" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 89: `Set-RegKey -path $interface.PSPath -name "GPPSW" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 90: `Set-RegKey -path $interface.PSPath -name "PowerSavingMode" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 91: `Set-RegKey -path $interface.PSPath -name "ULPMode" -value "0" -type "String"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 92: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 95: `$tcpipPath = "HKLM:\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 96: `$tcpInterfaces = Get-ChildItem -Path $tcpipPath | Where-Object { $_.Name -match "1" }` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 98: `foreach ($tcpInterface in $tcpInterfaces) {` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 99: `Set-RegKey -path $tcpInterface.PSPath -name "TCPNoDelay" -value 1 -type "DWord"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 100: `Set-RegKey -path $tcpInterface.PSPath -name "TcpAckFrequency" -value 1 -type "DWord"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 101: `Set-RegKey -path $tcpInterface.PSPath -name "TcpDelAckTicks" -value 0 -type "DWord"` — **No proven per-build safe effect; execution UNAVAILABLE.**
- Line 102: `}` — **No proven per-build safe effect; execution UNAVAILABLE.**

## Current executable payload

```powershell
throw 'AUDIT UNAVAILABLE: This legacy bulk script is disabled. See CompatibilityAudit for the original; use an individually reviewed recipe instead.'
```

## Direct sources (scope-limited)
- Microsoft network adapter advanced properties API, mechanism only: https://learn.microsoft.com/en-us/powershell/module/netadapter/set-netadapteradvancedproperty

## Unproven conditions

- No claim of operation on Windows 7/8/8.1, 10/11 without the listed source and **live target probe**.
- No hardware-tuning or performance promise is established by a cmdlet reference.
- This record documents the exact **file**, the exact **statements**, sources and remaining evidence gap.
