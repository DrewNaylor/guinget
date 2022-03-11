@echo off
REM Moves libraries into their own folder.

REM Define destination root dir.
set "rootdir=Release"

REM Check if lib folder exists first.
IF EXIST guinget\bin\%rootdir%\lib\ (
REM If it exists, re-create the folder.
rmdir /s /q guinget\bin\%rootdir%\lib
mkdir guinget\bin\%rootdir%\lib
REM Start moving.
GOTO STARTMOVE
) ELSE (
REM Folder doesn't exist, so create it.
mkdir guinget\bin\%rootdir%\lib
REM Start moving.
GOTO STARTMOVE
)

:STARTMOVE

REM Move all DLL files in the bin\Debug directory into the "lib" folder.
move guinget\bin\%rootdir%\*.dll guinget\bin\%rootdir%\lib\

REM Move the "runtimes" folder into \lib.
move guinget\bin\%rootdir%\runtimes\* guinget\bin\%rootdir%\lib\runtimes

REM Exit the script so VS doesn't say we exited with code 1.
exit