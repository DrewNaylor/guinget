@echo off
REM Moves libraries into their own folder.

REM Check if lib folder exists first.
IF EXIST lib\(
GOTO STARTMOVE
) ELSE (
mkdir lib
GOTO STARTMOVE
)

:STARTMOVE