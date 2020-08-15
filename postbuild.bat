@echo off
REM Moves libraries into their own folder.

REM Check if lib folder exists first.
IF EXIST guinget\bin\Debug\lib\ (
rmdir /s /q guinget\bin\Debug\lib
mkdir guinget\bin\Debug\lib
GOTO STARTMOVE
) ELSE (
mkdir guinget\bin\Debug\lib
GOTO STARTMOVE
)

:STARTMOVE

move guinget\bin\Debug\*.dll guinget\bin\Debug\lib\

exit