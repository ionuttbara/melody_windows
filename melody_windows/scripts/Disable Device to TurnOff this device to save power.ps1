    # Disable 'Allow the computer to turn off this device to save power' on all possible devices. (Only effective if D3Cold/hot is enabled)
    $device = Get-WmiObject Win32_PnPEntity
    $powerMgmt = Get-WmiObject MSPower_DeviceEnable -Namespace root\wmi
    foreach ($p in $powerMgmt)
    {
    	$IN = $p.InstanceName.ToUpper()
    	foreach ($h in $device)
    	{
    		$PNPDI = $h.PNPDeviceID
                    if ($IN -like "*$PNPDI*")
                    {
                         $p.enable = $False
                         $p.psbase.put()
                    }
    	}
    }
   
   # Disable 'Allow this device to wake the computer' on all possible devices.
   $device = Get-WmiObject Win32_PnPEntity
    $powerMgmt = Get-WmiObject MSPower_DeviceWakeEnable -Namespace root\wmi
    foreach ($p in $powerMgmt)
    {
    	$IN = $p.InstanceName.ToUpper()
    	foreach ($h in $device)
    	{
    		$PNPDI = $h.PNPDeviceID
                    if ($IN -like "*$PNPDI*")
                    {
                         $p.enable = $False
                         $p.psbase.put()
                    }
    	}
    }