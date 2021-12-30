:: ****************************************************************************************
@echo off & title Turn on or off the microphone. & mode con cols=80 lines=13 & color 17
:: ****************************************************************************************
Set "【Item】=Toggle Microphone On or Off"
Set "【Name】=Microphone_on_off"
Set "【Path】=wscript.exe"
If not exist "%ProgramData%\Fidelity\" (mkdir "%ProgramData%\Fidelity\")
(REG Add "HKCR\DesktopBackground\Shell\%【Item】%\Command" /VE /D "schtasks /run /tn ""Apps\%【Name】%""" /F)
(REG Add "HKCR\DesktopBackground\Shell\%【Item】%" /V "Icon" /T REG_SZ /D "%WinDir%\System32\DDORes.dll,86" /F)
(REG Add "HKCR\DesktopBackground\Shell\%【Item】%" /V "Position" /T REG_SZ /D "Bottom" /F)  
Cls
If errorlevel 1 (echo.
echo ====================================================================
echo.	
echo          The script has failed to perform the operations.
echo          Press any key to exit.
echo.	        
echo ====================================================================
pause > nul & EXIT)
echo.
echo          The script is creating an elevated task with highest privileges.
echo          Please wait for a while.
echo.
:: ****************************************************************************************
Set "Folder=%ProgramData%\Fidelity\Turn_on_or_off_the_microphone"
If not exist "%Folder%" (MkDir "%Folder%")

Set "Script=%Folder%\+Turn_on_or_off_the_microphone.cmd"
If exist "%Script%" (del "%Script%")
(
echo :: ****************************************************************************************
echo @echo off ^& title Turn on or off the microphone. ^& mode con cols=68 lines=6 ^& color 17
echo :: ****************************************************************************************

echo cd /d "%%~dp0"
echo For /f "tokens=3" %%%%# in ^('REG QUERY "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\microphone" /V "Value"'^) Do ^(Set ✱=%%%%#^)
echo If "%%✱%%"=="Allow" ^(goto Turn_off_the_microphone^) ^& Exit
echo :: ****************************************************************************************
echo :Turn_on_the_microphone
echo ^(REG ADD "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\microphone" /V Value /T REG_SZ /D "Allow" /F^)
echo ^(Start "" "Enabled.vbs" ^& EXIT^)
echo :: ****************************************************************************************
echo :Turn_off_the_microphone
echo ^(REG ADD "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\microphone" /V Value /T REG_SZ /D "Deny" /F^)
echo ^(Start "" "Disabled.vbs" ^& EXIT^)
echo :: ****************************************************************************************
)> "%Script%"

:: ****************************************************************************************
Set "【VBS】=%Folder%\+Run_the_CMD_script.vbs"
If exist "%【VBS】%" (del "%【VBS】%")
(
echo Path = split^(wscript.scriptFullName, wscript.scriptname^)^(0^)
echo Item = Path ^& "+Turn_on_or_off_the_microphone.cmd" 
echo CreateObject^("wscript.shell"^).run^("""" ^& Item ^& ""^),0
echo WScript.Quit
)> "%【VBS】%"
:: ****************************************************************************************
Set "Enabled=%Folder%\Enabled.ps1"
If exist "%Enabled%" (del "%Enabled%")
(
echo [reflection.assembly]::loadwithpartialname^("System.Windows.Forms"^)
echo [reflection.assembly]::loadwithpartialname^("System.Drawing"^)
echo $X = new-object system.windows.forms.notifyicon
echo $X.icon = [System.Drawing.SystemIcons]::Information
echo $X.visible = $true
echo $X.showballoontip^(10,"", "Microphone enabled. Press the Windows + M keys for it to take effect if the microphone cannot be used.",[system.windows.forms.tooltipicon]::None^)
echo $X.dispose^(^)
echo ^(New-Object Media.SoundPlayer "C:\Windows\Media\Ring06.wav"^).PlaySync^(^);
)> "%Enabled%"
:: ****************************************************************************************
Set "Enabled✱=%Folder%\Enabled.vbs"
If exist "%Enabled✱%" (del "%Enabled✱%")
(
echo Set X = CreateObject^("WScript.Shell"^)
echo PS = "%Enabled%" 
echo X.run "powershell -executionpolicy bypass -file " ^& chr^(34^) ^& PS ^& chr^(34^), 0, true
)> "%Enabled✱%"
:: ****************************************************************************************
Set "Disabled=%Folder%\Disabled.ps1"
If exist "%Disabled%" (del "%Disabled%")
(
echo [reflection.assembly]::loadwithpartialname^("System.Windows.Forms"^)
echo [reflection.assembly]::loadwithpartialname^("System.Drawing"^)
echo $X = new-object system.windows.forms.notifyicon
echo $X.icon = [System.Drawing.SystemIcons]::Information
echo $X.visible = $true
echo $X.showballoontip^(10,"", "Microphone Disabled. Press the Windows + M keys for it to take effect if the microphone is being used.",[system.windows.forms.tooltipicon]::None^)
echo $X.dispose^(^)
echo ^(New-Object Media.SoundPlayer "C:\Windows\Media\Ring06.wav"^).PlaySync^(^);
)> "%Disabled%"
:: ****************************************************************************************
Set "Disabled✱=%Folder%\Disabled.vbs"
If exist "%Disabled✱%" (del "%Disabled✱%")
(
echo Set X = CreateObject^("WScript.Shell"^)
echo PS = "%Disabled%" 
echo X.run "powershell -executionpolicy bypass -file " ^& chr^(34^) ^& PS ^& chr^(34^), 0, true
)> "%Disabled✱%"
:: ****************************************************************************************
For /f "tokens=*" %%I in ('WhoAmI /user') Do (for %%A in (%%~I) Do (set "【SID】=%%A"))
IF EXIST "%temp%\%【Name】%.xml" (DEL "%temp%\%【Name】%.xml")	
IF EXIST "%temp%\Task.vbs" (DEL "%temp%\Task.vbs")	

echo Set X=CreateObject("Scripting.FileSystemObject") >> "%temp%\Task.vbs"
echo Set Z=X.CreateTextFile("%temp%\%【Name】%.xml",True,True)>> "%temp%\Task.vbs"
Set "W=echo Z.writeline "	
(	
%W%"<?xml version=""1.0"" encoding=""UTF-16""?>"
%W%"<Task version=""1.4"" xmlns=""http://schemas.microsoft.com/windows/2004/02/mit/task"">"
%W%"<RegistrationInfo>"
%W%"<Description>To run the application/CMD script as an administrator with no UAC prompt.</Description>"
%W%"</RegistrationInfo>"
%W%"<Triggers />"
%W%"<Principals>"
%W%"<Principal id=""Author"">"
%W%"<UserId>%【SID】%</UserId>"
%W%"<LogonType>InteractiveToken</LogonType>"
%W%"<RunLevel>HighestAvailable</RunLevel>"
%W%"</Principal>"
%W%"</Principals>"
%W%"<Settings>"
%W%"<MultipleInstancesPolicy>IgnoreNew</MultipleInstancesPolicy>"
%W%"<DisallowStartIfOnBatteries>false</DisallowStartIfOnBatteries>"
%W%"<StopIfGoingOnBatteries>true</StopIfGoingOnBatteries>"
%W%"<AllowHardTerminate>true</AllowHardTerminate>"
%W%"<StartWhenAvailable>false</StartWhenAvailable>"
%W%"<RunOnlyIfNetworkAvailable>false</RunOnlyIfNetworkAvailable>"
%W%"<IdleSettings>"
%W%"<StopOnIdleEnd>true</StopOnIdleEnd>"
%W%"<RestartOnIdle>false</RestartOnIdle>"
%W%"</IdleSettings>"
%W%"<AllowStartOnDemand>true</AllowStartOnDemand>"
%W%"<Enabled>true</Enabled>"
%W%"<Hidden>false</Hidden>"
%W%"<RunOnlyIfIdle>false</RunOnlyIfIdle>"
%W%"<DisallowStartOnRemoteAppSession>false</DisallowStartOnRemoteAppSession>"
%W%"<UseUnifiedSchedulingEngine>true</UseUnifiedSchedulingEngine>"
%W%"<WakeToRun>false</WakeToRun>"
%W%"<ExecutionTimeLimit>PT72H</ExecutionTimeLimit>"
%W%"<Priority>7</Priority>"
%W%"</Settings>"
%W%"<Actions Context=""Author"">"
%W%"<Exec>"
%W%"<Command>""%【Path】%""</Command>"
%W%"<Arguments>""%【VBS】%""</Arguments>"
%W%"</Exec>"
%W%"</Actions>"
%W%"</Task>"
)>> "%temp%\Task.vbs"	
echo Z.Close >> "%temp%\Task.vbs"	
"%temp%\Task.vbs"	
Del "%temp%\Task.vbs"	
schtasks /create /xml "%temp%\%【Name】%.xml" /tn "Apps\%【Name】%"

If %errorlevel%==1 (DEL "%temp%\%【Name】%.xml" & echo.
echo   ============================================================================
echo      The script has failed to create the task "%【Name】%".
echo      The task might already exist in "Task Scheduler Library"--^>"Apps". 
echo      Press any key to close this message. 
echo   ============================================================================
pause > nul & Exit) else (DEL "%temp%\%【Name】%.xml" & echo.
echo   ============================================================================
echo      The item "%【Item】%" has been added into the desktop context 
echo      menu ^(right-click menu^).
echo      The scheduled task is in "Task Scheduler Library"--^>"Apps".
echo      Please press any key to close this message.
echo   ============================================================================
pause > nul & Exit)