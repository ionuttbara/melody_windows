:: Start with setting the location

pushd "%CD%"
CD /D "%~dp0"

:: BCDEDIT
:: Boot Parameters

bcdedit /timeout 0
bcdedit /set hypervisorlaunchtype Off 
bcdedit /set debug No
bcdedit /set sos Yes 
bcdedit /set ems No 
bcdedit /set noumex Yes 
bcdedit /set bootems No 
bcdedit /set perfmem 0 
bcdedit /set onecpu No
bcdedit /set nolowmem Yes
bcdedit /set vm No
bcdedit /set MSI Default
bcdedit /set vsmlaunchtype Off 
bcdedit /set nx AlwaysOff
bcdedit /set pae ForceEnable
bcdedit /set extendedinput Yes 
bcdedit /set highestmode Yes 
bcdedit /set forcefipscrypto No 
bcdedit /set clustermodeaddressing 1 
bcdedit /set uselegacyapicmode No 
bcdedit /set halbreakpoint No 
bcdedit /set forcelegacyplatform No 
bcdedit /set tpmbootentropy ForceDisable 
bcdedit /set allowedinmemorysettings 0x0 
bcdedit /set isolatedcontext No 
bcdedit /set configaccesspolicy Default
bcdedit /set usephysicaldestination No
bcdedit /set usefirmwarepcisettings No
bcdedit /set usephysicaldestination No 
bcdedit /set graphicsmodedisabled No 
bcdedit /set linearaddress57 OptOut
bcdedit /set increaseuserva 268435328
bcdedit /set firstmegabytepolicy UseAll
bcdedit /set avoidlowmemory 0x8000000
bcdedit /set disableelamdrivers yes  
bcdedit /set useplatformclock No
bcdedit /set vsmlaunchtype off
bcdedit /set recoveryenabled NO 
bcdedit /set x2apicpolicy enable 
bcdedit /set tscsyncpolicy legacy
bcdedit /set disabledynamictick yes 
bcdedit /set useplatformtick yes
bcdedit /deletevalue useplatformclock 
bcdedit /set bootmenupolicy Legacy 
bcdedit -set NOINTEGRITYCHECKS OFF
bcdedit -set TESTSIGNING OFF
