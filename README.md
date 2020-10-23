# csharp_pure_input2stdout
does not uses VB controls for input-box, but self-drown controls and form that acts like this, console application with (optional) title/prompt/default control and global binding to ENTER/ESCAPE.


currently accepts nothing or -prompt= -title= -default=
on <kbd>ENTER</kbd> the stdout will be written the output, no new line feed afterwards, and exit-code of 0 (success).
on <kbd>ESCAPE</kbd> there will be no use of stdout just the program will exit with exit code of 1 (error).

you can capture the output with

```cmd
@echo off
::support Unicode
chcp 65001 1>nul 2>nul

::make sure you have variable to capture %ErrorLevel% right-after-the-command-ends!!!
set "EXIT_CODE=0"

::make sure the variable is pre-cleaned.
set "USERCOMMAND="

::grab STDOUT if exists
for /f "tokens=*" %%a in ('call input2stdout.exe "-title=hello" "-prompt=please be cool" "-default=smile a lot!" 2^>nul ') do ( set "USERCOMMAND=%%a" )
set "EXIT_CODE=%ErrorLevel%"
if ["%EXIT_CODE%"] NEQ ["0"]  ( goto ERROR_NO_INPUT )
if ["%USERCOMMAND%"] EQU [""] ( goto ERROR_NO_INPUT )

:ERROR_NO_INPUT 
  echo [ERROR] you either pressed ESCAPE or entered nothing..
  goto END

:END
  echo [INFO] Done. [EXIT_CODE: %EXIT_CODE%]
  pause
  exit /b %EXIT_CODE%
```
