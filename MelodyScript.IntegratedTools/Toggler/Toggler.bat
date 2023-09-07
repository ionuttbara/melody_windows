@set @version=12.07 /* &title Privacy Toggle
@echo off
echo Applying Script..
if %1.==. timeout /t 0 &call wscript /e:JScript "%~f0" runas setup &exit &rem : no arguments, run setup elevated
if %1.==shift. shift &shift &rem : if loaded by WScript, shift args to prevent loop and restore %0
if %1.==. echo ERROR! &timeout /t 5 &exit/b : must have at least one arg

:: Setup executable blocking via ifeo
set notifier=EOSNotify MusNotification
set upgrader=Windows10UpgraderApp Windows10Upgrade WindowsUpdateBox SetupHost setupprep wuauclt
set searcher=SearchUI SearchHost StartMenuExperienceHost MiniSearchHost 

set "exe=%notifier% %upgrader% %installer% %reporter%"
set "noop=%SystemRoot%\system32\systray.exe"
set "ifeo=HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options"
set "wut=HKCR\DesktopBackground\shell\WUT"
set "menu=%wut%\shell"
set "f0=%SystemRoot%\windows_update_toggle.bat"
set ".=>nul 2>nul"
set "verbose="

for /f "tokens=2 delims=1234567890" %%# in ('shutdown /?^|findstr /bc:"E"') do set "[T]=%%#" &rem : cosmetic usage in menus
if defined verbose (echo on &set ".=" &set "window=") else set "window=hide"
call :%~1 %2 %3 %4 %5 %6 %7 %8 %9 &rem : launch secondary functions below dinamically, passing next args
echo.
echo Done! Use the Desktop right-click context menu to toggle
exit
::---------------------------------------------------------------------------------------------------------------------------------

:refresh context menu
echo %0 %*
call :reg_query "HKLM\SOFTWARE\WUT.bat" NoBlock noblock
if "%noblock%"=="Enable" exit/b
call :reg_query "%wut%0pending" MUIVerb pending
if defined pending exit/b
for %%# in ("1hide" "2unhide" "3apply") do reg delete "%wut%%%~#" /f %.%
reg add "%wut%0pending" /v MUIVerb /d "Pending.." /f %.%
reg add "%wut%0pending" /v Icon /d "ieframe.dll,11" /f %.%
reg add "%wut%0pending" /v SubCommands /d "" /f %.%
call :reg_query "HKLM\SOFTWARE\WUT.bat" NoRefresh norefresh
if "%norefresh%"=="Disable" (set "toggle=39") else set "toggle=38"
reg add "%menu%\2Lists"  /v Icon /d "ieframe.dll,%toggle%" /f %.%
if "%norefresh%"=="Disable" start "WUT" wscript /e:JScript "%f0%" WUTRefresh
call :status SetupHost 3Upgrades
call :status SearchUI 83Search
if "%norefresh%"=="Enable" reg delete "%wut%0pending" /f %.%
exit/b

:status %1:exe %2:submenu
call :reg_query "%ifeo%\%~1.exe" Debugger block
if defined block (set "toggle=38") else set "toggle=39"
reg add "%menu%\%~2"  /v Icon /d "ieframe.dll,%toggle%" /f %.%
exit/b

:flip %1:exe %2:submenu
call :reg_query "%ifeo%\%~1.exe" Debugger block
if defined block (set "toggle=39") else set "toggle=38"
reg add "%menu%\%~2"  /v Icon /d "ieframe.dll,%toggle%" /f %.%
exit/b

:toggle WUT
echo %0 %*
call :reg_query "HKLM\SOFTWARE\WUT.bat" NoBlock noblock
if "%noblock%"=="Disable" (set "toggle=Enable") else set "toggle=Disable"
for %%# in (NoBlock NoRefresh) do reg add "HKLM\SOFTWARE\WUT.bat" /v %%# /d "%toggle%" /f %.%
set "task=wscript.exe /e:JScript \"%f0%\" schtasks WUT"
:: Generate WUT main context menu
for %%# in ("" "0pending" "1hide" "2unhide" "3apply") do reg delete "%wut%%%~#" /f %.%
reg add "%wut%" /v MUIVerb /d "Toggler" /f %.%
reg add "%wut%" /v Icon /d "comres.dll,4" /f %.%
reg add "%wut%" /v SubCommands /d "" /f %.%
reg add "%menu%\9Setup" /v MUIVerb /d "Configure Toggler" /f %.%
reg add "%menu%\9Setup" /v SubCommands /d "" /f %.%
reg add "%menu%\9Setup\shell\1Toggle"  /v MUIVerb /d "%toggle%" /f %.%
reg add "%menu%\9Setup\shell\3Remove"  /v MUIVerb /d "Remove" /f %.%
reg add "%menu%\9Setup\shell\1Toggle\command" /ve /d "%task%\toggle" /f %.%
reg add "%menu%\9Setup\shell\3Remove\command" /ve /d "%task%\remove" /f %.%
if "%toggle%"=="Disable" (
 reg add "%menu%\1Refresh"    /v MUIVerb /d "Refresh" /f %.%
 reg add "%menu%\2Lists"      /v MUIVerb /d "Windows Updates Autocheck and Listing" /f %.%
 reg add "%menu%\3Upgrades"   /v MUIVerb /d "Toggle Windows Updates %[T]% setuphost" /f %.%
 reg add "%menu%\83Search"    /v MUIVerb /d "Toggle prelaunch for search & Start Menu Application" /f %.%
 reg add "%menu%\1Refresh\command" /ve   /d "%task%\refresh" /f %.%
 reg add "%menu%\2Lists\command" /ve     /d "%task%\lists" /f %.%
 reg add "%menu%\3Upgrades\command" /ve  /d "%task%\upgrades" /f %.%
 reg add "%menu%\83Search\command" /ve   /d "%task%\search" /f %.%
)
:: Default services
sc config wuauserv type= share depend= rpcss %.%
sc config TrustedInstaller type= own depend= / %.%
:: Toggle ifeo exe blocking
for %%# in (%exe%  %search%) do reg delete "%ifeo%\%%#.exe" /f %.%
if "%toggle%"=="Enable" exit/b WUT disabled, so skip the code below
for %%# in (%exe%) do reg add "%ifeo%\%%#.exe" /v Debugger /d "%noop%" /f %.% &taskkill /im "%%#.exe" /t /f %.%
:: WUTRefresh hijacking
for %%# in (MusNotification EOSNotify) do reg add "%ifeo%\%%#.exe" /v Debugger /d "%SystemRoot%\WUTRefresh.bat" /f %.%
call :refresh menu
exit/b
:hide update
echo %0 %*
call :reg_query "%wut%1hide\shell\%~1" MUIVerb updatefound
echo -%updatefound%
if not defined updatefound exit/b
call wscript /e:JScript "%f0%" hide "%updatefound%"
exit/b

:unhide update
echo %0 %*
call :reg_query "%wut%2unhide\shell\%~1" MUIVerb updatefound
echo -%updatefound%
if not defined updatefound exit/b
call wscript /e:JScript "%f0%" unhide "%updatefound%"
exit/b

:apply update
echo %0 %*
call :reg_query "%wut%3apply\shell\%~1" MUIVerb updatefound
echo -%updatefound%
if not defined updatefound exit/b
:: Cache current blocks status, because Apply will unblock downloads and installs in the WScript stage
call :reg_query "%ifeo%\wuauclt.exe" Debugger installs_blocked
call wscript /e:JScript "%f0%" apply "%updatefound%"
:: Restore cached blocks
if defined installs_blocked reg add "%ifeo%\wuauclt.exe" /v Debugger /d "%noop%" /f %.% &taskkill /im "wuauclt.exe" /t /f %.%
exit/b

:lists
echo %0 %*
call :reg_query "HKLM\SOFTWARE\WUT.bat" NoRefresh norefresh
if "%norefresh%"=="Disable" ( set "norefresh=Enable" &set "toggle=38") else set "norefresh=Disable" &set "toggle=39"
reg add "HKLM\SOFTWARE\WUT.bat" /v NoRefresh /d "%norefresh%" /f %.%
reg add "%menu%\2Lists"  /v Icon /d "ieframe.dll,%toggle%" /f %.%
if "%norefresh%"=="Enable" (
 reg delete "%wut%1hide" /f %.% &reg delete "%wut%2unhide" /f %.% &reg delete "%wut%3apply" /f %.%
 reg delete "%wut%0pending" /f %.%
)
call :refresh lists
exit/b

:upgrades
echo %0 %*
call :flip SetupHost 3Upgrades
for %%# in (%upgrader%) do if defined block (
 reg delete "%ifeo%\%%#.exe" /f %.%
) else (
 reg add "%ifeo%\%%#.exe" /v Debugger /d "%noop%" /f %.% &taskkill /im "%%#.exe" /t /f %.%
)
exit/b

:search
echo %0 %*
call :flip SearchUI 83Search
for %%# in (%searcher%) do if defined block ( reg delete "%ifeo%\%%#.exe" /f %.% ) else (
 reg add "%ifeo%\%%#.exe" /v Debugger /d "%noop%" /f %.% &taskkill /im "%%#.exe" /t /f %.%
)
exit/b

:setup
echo %0 %*
pushd %SystemRoot%
if /i "%~f0"=="%f0%" (set "initial_setup=") else copy /y "%~f0" "%f0%" %.%
:: Create WUTUndo for emergencies
 >WUTUndo.bat echo/pushd %%~dp0system32\config
>>WUTUndo.bat echo/reg load HKLM\WUTUndo1 SOFTWARE
>>WUTUndo.bat echo/set "koff=HKLM\WUTUndo1\Microsoft\Windows NT\CurrentVersion\Image File Execution Options" ^&set "kon=%ifeo%"
>>WUTUndo.bat echo/for %%%%B in (%exe%) do for %%%%K in ("%%koff%%" "%%kon%%") do reg delete "%%%%~K\%%%%B.exe" /f 2^>nul
>>WUTUndo.bat echo/reg unload HKLM\WUTUndo1
>>WUTUndo.bat echo/reg load HKLM\WUTUndo2 SYSTEM
>>WUTUndo.bat echo/for %%%%K in (WUTUndo2 SYSTEM) do (
>>WUTUndo.bat echo/ reg delete "HKLM\%%%%~K\ControlSet001\Services\TrustedInstaller" /v DependOnService /f 2^>nul
>>WUTUndo.bat echo/ reg delete "HKLM\%%%%~K\CurrentControlSet\Services\TrustedInstaller" /v DependOnService /f 2^>nul
>>WUTUndo.bat echo/)
>>WUTUndo.bat echo/reg unload HKLM\WUTUndo2
:: Create WUTRefresh to hijack update notifications and refresh context menu in addition to preventing forced reboots
>WUTRefresh.bat echo/@start "WUTRefresh" /min wscript.exe /e:JScript "%f0%" WUTRefresh
:: Create tasks to run context menu entries with proper access and no output window
start "WUT" wscript /e:JScript "%~f0" cmd "call `%~f0` setup_schtasks"
:: WUT options
for %%# in (NoBlock NoRefresh) do reg add "HKLM\SOFTWARE\WUT.bat" /v %%# /d "Enable" /f %.%
call :toggle blocking
exit/b

:setup_schtasks - no stalling separate process
set "strun=wscript.exe /e:JScript \"%f0%\" run%window%"
for %%t in (refresh lists upgrades installs downloads service repair search toggle remove) do (
 schtasks /create /ru "%username%" /sc once /tn "WUT\%%t" /tr "%strun% %%t" /st "00:00:00" /it /rl highest /f %.%
)
for %%t in (hide unhide apply) do for /l %%n in (101,1,116) do (
 schtasks /create /ru "%username%" /sc once /tn "WUT\%%t\%%n" /tr "%strun% %%t %%n" /st "00:00:00" /it /rl highest /f %.%
)
exit/b

:remove
echo %0 %*
for %%# in (NoBlock NoRefresh) do reg add "HKLM\SOFTWARE\WUT.bat" /v %%# /d "Disable" /f %.%
call :toggle off
reg delete "HKLM\SOFTWARE\WUT.bat" /f %.%
for %%# in ("" "0pending" "1hide" "2unhide" "3apply") do reg delete "%wut%%%~#" /f %.%
for %%t in (refresh lists upgrades installs downloads service repair search toggle remove) do (
 schtasks /delete /tn "WUT\%%t" /f %.%
)
for %%t in (hide unhide apply) do for /l %%n in (101,1,116) do schtasks /delete /tn "WUT\%%t\%%n" /f %.%
for %%t in (hide unhide apply) do schtasks /delete /tn "WUT\%%t" /f %.%
schtasks /delete /tn "WUT" /f %.%
sc config wuauserv type= share depend= rpcss %.%
sc config TrustedInstaller type= own depend= / %.%
pushd %SystemRoot%
del /f /q WUT.bat WUT.old WUTRefresh.bat WUTUndo.bat "%f0%" %.%
exit/b

:reg_query %1:KeyName %2:ValueName %3:OutputVariable %4:other_options[example: "/t REG_DWORD"]
setlocal & for /f "skip=2 delims=" %%s in ('reg query "%~1" /v "%~2" /z 2^>nul') do set "rq=%%s" & call set "rv=%%rq:*)    =%%"
endlocal & set "%~3=%rv%" & exit/b &rem                                         AveYo: call :reg_query "HKCU\MyKey" "MyValue" MyVar

::---------------------------------------------------------------------------------------------------------------------------------
:JScript_functions                                                                 AveYo: Switch syntax highlighter to 'javascript'
::-------------------------------------------------------------------------------------------------------------------------------*/
f0=WSH.ScriptFullName; run=WSH.Arguments(0); args=''; for(i=1;i<WSH.Arguments.length;i++) args+=' "'+WSH.Arguments(i)+'"';
function sex(exe,args){WSH.CreateObject('Shell.Application').ShellExecute(exe,args,'','',0);}; function reg(s){ sex('reg.exe',s); }

// Open external commands in new hidden cmd instance - backquotes replaced to quotes
if (run=='cmd') sex('cmd','/c '+args.replace(/`/g,'"'));

// Context menu entries trigger - elevated with no popups
if (run=='schtasks') sex('SCHTASKS.EXE','/Run /TN '+args);

// Shift to CMD if loaded by WScript - pass arguments, prevent loop, run as admin at setup, hide window at context-menu
function cmd(adm,win){WSH.CreateObject('Shell.Application').ShellExecute('cmd','/c call "'+f0+'" shift "'+f0+'"'+args,'',adm,win);}
if (run=='run') cmd('',1); if (run=='runhide') cmd('',0); if (run=='runas') cmd('runas',1); if (run=='runashide') cmd('runas',0);

// WUT Hide/Unhide/Apply lists
if (run=='WUTRefresh' || run=='hide' || run=='unhide' || run=='apply') {
  SRP=GetObject("winmgmts:StdRegProv"); pending=SRP.GetStringValue(2147483650,'SOFTWARE\\WUT.bat','Pending');
  if (pending===0) WSH.quit(); else SRP.SetStringValue(2147483650,'SOFTWARE\\WUT.bat','Pending','yes'); // prevent instances
  k='HKCR\\DesktopBackground\\shell\\WUT'; hk=k+'1hide'; uk=k+'2unhide'; ik=k+'3apply'; pk=k+'0pending';// short list keys
  reg('delete "'+hk+'" /f');reg('delete "'+uk+'" /f');reg('delete "'+ik+'" /f'); reg('add "'+pk+'" /v MUIVerb /d "Pending.." /f');
  reg('add "'+pk+'" /v SubCommands /d "" /f'); reg('add "'+pk+'" /v Icon /d "ieframe.dll,11" /f');
  // Check for updates
  count=0; wuthide=[]; wutunhide=[];
  try{
  session=WSH.CreateObject("Microsoft.Update.Session"); reboot=WSH.CreateObject("Microsoft.Update.SystemInfo").RebootRequired;
  searcher=session.CreateUpdateSearcher();
  sresult=searcher.Search("IsInstalled=0"); Updatelist=sresult.Updates; count=sresult.Updates.Count;
  for(i=0;i<count;i++) {
    itemTitle=Updatelist.Item(i).Title;
    minsize=Updatelist.Item(i).MinDownloadSize; maxsize=Updatelist.Item(i).MaxDownloadSize; wutsize='';
    if (maxsize > 1073741824) wutsize=' ['+Math.round(minsize/10737418.24)/100+' - '+Math.round(maxsize/10737418.24)/100+'GB]';
    else if (maxsize > 1048576) wutsize=' ['+Math.round(minsize/10485.76)/100+' - '+Math.round(maxsize/10485.76)/100+'MB]';
    else if (maxsize > 1024) wutsize=' ['+Math.round(minsize/10.24)/100+' - '+Math.round(maxsize/10.24)/100+'KB]';
    else if (maxsize > 0) wutsize=' ['+(minsize)+' - '+(maxsize)+'B]';
    wutTitle=Updatelist.Item(i).Title + wutsize;
    if (run=='apply' && WSH.Arguments(1).indexOf(itemTitle) > -1) {
      // Add matching entry to UpdateColl
      UpdateColl=WSH.CreateObject("Microsoft.Update.UpdateColl"); UpdateColl.Add(Updatelist.Item(i));
      // Download update
      downloader=session.CreateUpdateDownloader(); downloader.Updates=UpdateColl; dresult=downloader.Download();
      if (dresult.ResultCode==2) {
        // Unblock apply
        sex('sc','config TrustedInstaller type= own depend= /');
        KeyPath='SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wuauclt.exe';
        SRP.DeleteKey(2147483650,KeyPath);
        WSH.Sleep(1000);
        //Apply update
        installer=session.CreateUpdateInstaller(); installer.Updates=UpdateColl; iresult=installer.Install();
        if (iresult.ResultCode==2) continue;
      }
    }
    // hide and unhide are very simple bool flip compared to apply
    if (run=='hide' && WSH.Arguments(1).indexOf(itemTitle) > -1) {
      Updatelist.Item(i).IsHidden=true; wutunhide.push(wutTitle); continue;
    }
    if (run=='unhide' && WSH.Arguments(1).indexOf(itemTitle) > -1) {
      Updatelist.Item(i).IsHidden=false; wuthide.push(wutTitle); continue;
    }
    // Sorting lists
    if (Updatelist.Item(i).IsHidden) wutunhide.push(wutTitle); else wuthide.push(wutTitle);
  }
  // Generate Hide context menu
  if (wuthide.length>0){
    reg('add "'+hk+'" /v MUIVerb /d "Hide '+"\t"+wuthide.length+'" /f');
    reg('add "'+hk+'" /v Icon /d "ieframe.dll,42" /f');
    reg('add "'+hk+'" /v SubCommands /d "" /f');
    for(i=101,n=wuthide.length+101;i<n;i++) {
      reg('add "'+hk+'\\shell\\'+i+'" /v MUIVerb /d "'+wuthide[i-101]+'" /f');
      reg('add "'+hk+'\\shell\\'+i+'\\command" /ve /d "wscript.exe /e:JScript \\"'+f0+'\\" schtasks WUT\\hide\\'+i+'" /f');
    }
  }
  // Generate Unhide context menu
  if (wutunhide.length>0){
    reg('add "'+uk+'" /v MUIVerb /d "Unhide '+"\t"+wutunhide.length+'" /f');
    reg('add "'+uk+'" /v Icon /d "ieframe.dll,42" /f');
    reg('add "'+uk+'" /v SubCommands /d "" /f');
    for(i=101,n=wutunhide.length+101;i<n;i++) {
      reg('add "'+uk+'\\shell\\'+i+'" /v MUIVerb /d "'+wutunhide[i-101]+'" /f');
      reg('add "'+uk+'\\shell\\'+i+'\\command" /ve /d "wscript.exe /e:JScript \\"'+f0+'\\" schtasks WUT\\unhide\\'+i+'" /f');
    }
  }
  // Generate Apply context menu
  if (wuthide.length>0){
    reg('add "'+ik+'" /v MUIVerb /d "Apply '+"\t"+((reboot) ? 'must reboot ' : wuthide.length)+'" /f');
    reg('add "'+ik+'" /v Icon /d "ieframe.dll,42" /f');
    reg('add "'+ik+'" /v SubCommands /d "" /f');
    for(i=101,n=wuthide.length+101;i<n;i++) {
      reg('add "'+ik+'\\shell\\'+i+'" /v MUIVerb /d "'+wuthide[i-101]+'" /f');
      reg('add "'+ik+'\\shell\\'+i+'\\command" /ve /d "wscript.exe /e:JScript \\"'+f0+'\\" schtasks WUT\\apply\\'+i+'" /f');
    }
  }
  }catch(e){} // supress all errors since we're working with com objects
  reg('delete "'+pk+'" /f'); SRP.DeleteValue(2147483650,'SOFTWARE\\WUT.bat','Pending'); // Remove Pending.. temporary entry
}

