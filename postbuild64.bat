@echo off
REM Moves libraries into their own folder.

REM Check if lib folder exists first.
IF EXIST guinget\bin\x64\Debug\lib\ (
REM If it exists, re-create the folder.
rmdir /s /q guinget\bin\x64\Debug\lib
mkdir guinget\bin\x64\Debug\lib
REM Start moving.
GOTO STARTMOVE
) ELSE (
REM Folder doesn't exist, so create it.
mkdir guinget\bin\x64\Debug\lib
REM Start moving.
GOTO STARTMOVE
)

:STARTMOVE

REM Move all DLL files in the bin\Debug directory into the "lib" folder.
move guinget\bin\x64\Debug\*.dll guinget\bin\x64\Debug\lib\

REM Move the "runtimes" folder into \lib.
move guinget\bin\x64\Debug\runtimes\* guinget\bin\x64\Debug\lib\runtimes

REM Exit the script so VS doesn't say we exited with code 1.
exit