REM @echo off
REM Moves libraries into their own folder.

REM Check if lib folder exists first.
IF EXIST guinget\bin\Debug\lib\ (
rmdir /s /q lib
GOTO STARTMOVE
) ELSE (
mkdir lib
GOTO STARTMOVE
)

:STARTMOVE

move guinget\bin\Debug\*.dll guinget\bin\Debug\lib\