@echo off
setlocal
chcp 65001 >nul
title NVIDIA Profile Inspector - Import profile.nip

REM Pune acest BAT, nvidiaProfileInspector.exe si profile.nip in acelasi folder.
set "NPI=%~dp0nvidiaProfileInspector.exe"
set "NIP=%~dp0profile1.nip"

if not exist "%NPI%" (
    echo [EROARE] Nu gasesc nvidiaProfileInspector.exe in:
    echo "%~dp0"
    echo Pune BAT-ul langa executabilul NVIDIA Profile Inspector.
    pause
    exit /b 1
)

if not exist "%NIP%" (
    echo [EROARE] Nu gasesc profile.nip in:
    echo "%~dp0"
    echo Pune fisierul profile.nip langa acest BAT sau schimba variabila NIP din script.
    pause
    exit /b 1
)

echo.

echo.
echo [1/1] Import profile.nip...
echo Daca apare o fereastra Merge/Replace, verifica ce profiluri sunt incluse si alege optiunea dorita.
"%NPI%" "%NIP%"

echo.
echo Comanda de import s-a incheiat. Verifica profilul in NVIDIA Profile Inspector.
pause
endlocal
