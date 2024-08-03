# A string list which has listed capabilities or FoD to be disabled and removed.
$flist = @("*Realtek*", "*Intel*", "*Broadcom*", "*Qualcomm*", "*Marvel*",
            "*Vmware*", "*Ethernet*", "*InternetExplorer*", "*StepsRecorder*",
            "*DirectX.Configuration.Database*", "*WindowsMediaPlayer*",
            "*Wallpapers*", "*PowerShell*", "*QuickAssist*", "*OneSync*", "*LA57*", "*Ralink*", "*Virtual*", "*TCP*", "*Hello*")

foreach ($item in $flist) {
    # Get the list of capabilities that match the current item
    $checkCapabilities = Get-WindowsCapability -Online | Where-Object { $_.Name -like $item }
    
    foreach ($checkCapability in $checkCapabilities) {
        if ($checkCapability.State -eq 'Installed') {
            try {
                # Remove each capability found
                Remove-WindowsCapability -Online -Name $checkCapability.Name -ErrorAction Stop
            } catch {
                Write-Host "Error at $($checkCapability.Name): $($_.Exception.Message)"
            }
        }
    }
}
