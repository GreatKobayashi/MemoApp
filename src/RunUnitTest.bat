@echo off
echo Start Unit test...

dotnet test TestMemoApp -s .runsettings

if exist ".\coveragereport" (
    del /Q ".\coveragereport\*"
)

setlocal enabledelayedexpansion

set "TARGET_DIR=.\TestResults"

set "LATEST_DIR="

for /d %%D in ("%TARGET_DIR%\*") do (
    if not defined LATEST_DIR (
        set "LATEST_DIR=%%D"
    ) else (
        for %%T in ("%%D") do for %%U in ("!LATEST_DIR!") do (
            if %%~tT GTR %%~tU set "LATEST_DIR=%%D"
        )
    )
)

if defined LATEST_DIR (
    for %%F in ("!LATEST_DIR!") do set "LATEST_DIR_NAME=%%~nxF"
)

reportgenerator -reports:"TestResults\!LATEST_DIR_NAME!\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html >nul 2>nul

echo Unit test has finished.

endlocal
pause