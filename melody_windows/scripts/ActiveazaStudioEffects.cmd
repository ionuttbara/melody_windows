@echo off
:: 1. Verificare drepturi de administrator
NET SESSION >nul 2>&1
if %errorLevel% NEQ 0 (
    echo Eroare: Acest script TREBUIE rulat ca Administrator!
    echo Click dreapta pe fisier si alege "Run as administrator".
    pause
    exit /b
)

set "KEY_BASE=HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\DeviceClasses\{E5323777-F976-4F5B-9B55-B94699C46E44}"

echo Se cauta cheile de registru pentru camera...

:: 2. Modificare directa (Majoritatea sistemelor nu blocheaza scrierea aici daca esti Admin)
for /f "tokens=*" %%A in ('reg query "%KEY_BASE%" /s /f "Device Parameters" ^| findstr /i "Device Parameters"') do (
    echo Se seteaza efectele pentru: %%A
    reg add "%%A" /v FSMEnableMSEffects /t REG_DWORD /d 1 /f >nul
    reg add "%%A" /v UVC-FSMEnableMSEffects /t REG_DWORD /d 1 /f >nul
)

echo.
echo Gata! Deconectati si reconectati camera pentru a aplica modificarile.
