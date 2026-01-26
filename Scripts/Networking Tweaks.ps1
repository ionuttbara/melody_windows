# Autotuning Internet Speed and making it persistent
Set-NetTCPSetting -SettingName * -AutoTuningLevelLocal Experimental -ScalingHeuristics Disabled
Set-NetTCPSetting -SettingName * -InitialRto 3000 -Timestamps Disabled -MemoryPressureProtection Disabled -NonSackRttResiliency Disabled -MaxSynRetransmissions 2
Set-NetIPv4Protocol -IcmpRedirects Disabled -DefaultHopLimit 64 -MultipleArpAnnouncements Disabled


# Setting the Congestion Provider for better Internet Speeds and Latency, to CTCP
netsh.exe interface tcp set supplemental Internet congestionprovider=ctcp
netsh.exe interface tcp set supplemental InternetCustom congestionprovider=ctcp
netsh.exe interface tcp set supplemental Datacenter congestionprovider=ctcp
netsh.exe interface tcp set supplemental Compat congestionprovider=ctcp
netsh.exe interface tcp set supplemental DatacenterCustom congestionprovider=ctcp

# OffloadGlobal Settings

Set-NetOffloadGlobalSetting -PacketCoalescingFilter disabled -Chimney Disabled -Taskoffload Enabled -ReceiveSideScaling Enabled -ReceiveSegmentCoalescing Disabled

# tweaking features from network adapters
Disable-NetAdapterPowerManagement *
Disable-NetAdapterChecksumOffload -Name *
Disable-NetAdapterLso -Name *
Disable-NetAdapterBinding -Name * -ComponentID ms_pacer
Disable-NetAdapterBinding -Name * -ComponentID ms_msclient
Disable-NetAdapterChecksumOffload -Name *
Set-NetIPInterface -WeakHostSend Enabled -WeakHostReceive Enabled -ErrorAction SilentlyContinue

# TCP/IP Protocole Tweaks
netsh.exe int isatap set state disable | Out-Null
netsh.exe int tcp set global ecncapability=enabled | Out-Null
netsh.exe int tcp set global ecn=enabled | Out-Null
netsh.exe interface tcp set global fastopen=enabled | Out-Null
netsh.exe interface tcp set global fastopenfallback=enabled | Out-Null
netsh.exe interface ip set global neighborcachelimit=4096 taskoffload=enabled | Out-Null
netsh.exe interface tcp set global hystart=disabled | Out-Null


# Function to add or update registry keys
function Set-RegKey {
    param (
        [string]$path,
        [string]$name,
        [string]$value,
        [string]$type = "DWord"
    )

    if ($type -eq "DWord") {
        Set-ItemProperty -Path $path -Name $name -Value $value -Type DWord -Force
    } else {
        Set-ItemProperty -Path $path -Name $name -Value $value -Type String -Force
    }
}

# Adding NetBIOS Options
$netbtPath = "HKLM:\SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces"
$interfaces = Get-ChildItem -Path $netbtPath

foreach ($interface in $interfaces) {
    Set-RegKey -path $interface.PSPath -name "NetbiosOptions" -value 2 -type "DWord"
}

# Updating registry keys for network interfaces
$regPath = "HKLM:\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces"
$networkInterfaces = Get-ChildItem -Path $regPath | Where-Object { $_.Name -match "000" }

foreach ($interface in $networkInterfaces) {
    # Disable Flow Control
    Set-RegKey -path $interface.PSPath -name "*FlowControl" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "FlowControlCap" -value "0" -type "String"

    # Remove Interrupt Delays
    Set-RegKey -path $interface.PSPath -name "TxIntDelay" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "TxAbsIntDelay" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "RxIntDelay" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "RxAbsIntDelay" -value "0" -type "String"

    # Remove Adapter Notification
    Set-RegKey -path $interface.PSPath -name "FatChannelIntolerant" -value "0" -type "String"

    # Disable Interrupt Moderation
    Set-RegKey -path $interface.PSPath -name "*InterruptModeration" -value "0" -type "String"

    # Disable - Allow the computer to turn off this device to save power
    Set-RegKey -path $interface.PSPath -name "LogDisconnectEvent" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "LogLinkStateEvent" -value 16 -type "String"

    # Disable - Reduce network speed to 10/100
    Set-RegKey -path $interface.PSPath -name "GigaLite" -value "0" -type "String"

    # Disabling Green Ethernet
    Set-RegKey -path $interface.PSPath -name "*EEE" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "AdvancedEEE" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "AutoPowerSaveModeEnabled" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "EnableEDT" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "EnableGreenEthernet" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "EEELinkAdvertisement" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "ENPWMode" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "GPPSW" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "PowerSavingMode" -value "0" -type "String"
    Set-RegKey -path $interface.PSPath -name "ULPMode" -value "0" -type "String"
}

# Disabling Nagle's Algorithm for better Gaming Latency
$tcpipPath = "HKLM:\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces"
$tcpInterfaces = Get-ChildItem -Path $tcpipPath | Where-Object { $_.Name -match "1" }

foreach ($tcpInterface in $tcpInterfaces) {
    Set-RegKey -path $tcpInterface.PSPath -name "TCPNoDelay" -value 1 -type "DWord"
    Set-RegKey -path $tcpInterface.PSPath -name "TcpAckFrequency" -value 1 -type "DWord"
    Set-RegKey -path $tcpInterface.PSPath -name "TcpDelAckTicks" -value 0 -type "DWord"
}