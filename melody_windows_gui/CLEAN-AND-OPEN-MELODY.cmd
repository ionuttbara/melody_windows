@echo off
setlocal
cd /d "%~dp0"
if exist "artifacts" rmdir /s /q "artifacts"
if exist "bin" rmdir /s /q "bin"
if exist "obj" rmdir /s /q "obj"
start "" "%~dp0Melody.sln"
