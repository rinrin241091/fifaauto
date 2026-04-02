@echo off
setlocal

:: Tim MSBuild tu Visual Studio hoac .NET SDK
set MSBUILD=
for /f "usebackq tokens=*" %%i in (`where msbuild 2^>nul`) do (
    set MSBUILD=%%i
    goto :found
)

:: Thu tim trong duong dan Visual Studio mac dinh
for %%v in (2022 2019 2017) do (
    for %%e in (Enterprise Professional Community BuildTools) do (
        if exist "C:\Program Files\Microsoft Visual Studio\%%v\%%e\MSBuild\Current\Bin\MSBuild.exe" (
            set "MSBUILD=C:\Program Files\Microsoft Visual Studio\%%v\%%e\MSBuild\Current\Bin\MSBuild.exe"
            goto :found
        )
        if exist "C:\Program Files (x86)\Microsoft Visual Studio\%%v\%%e\MSBuild\Current\Bin\MSBuild.exe" (
            set "MSBUILD=C:\Program Files (x86)\Microsoft Visual Studio\%%v\%%e\MSBuild\Current\Bin\MSBuild.exe"
            goto :found
        )
    )
)

echo [LOI] Khong tim thay MSBuild. Cai .NET SDK hoac Visual Studio truoc nhe.
pause
exit /b 1

:found
echo [INFO] Su dung MSBuild: %MSBUILD%
echo [INFO] Dang build...

"%MSBUILD%" "%~dp0FOL4AutoClick.sln" /p:Configuration=Debug /verbosity:minimal /nologo
if errorlevel 1 (
    echo [LOI] Build that bai!
    pause
    exit /b 1
)

set EXE=%~dp0FOL4AutoClick\bin\Debug\FOL4AutoClick.exe
if not exist "%EXE%" (
    echo [LOI] Khong tim thay file exe sau khi build: %EXE%
    pause
    exit /b 1
)

echo [OK] Dang chay app...
start "" "%EXE%"
