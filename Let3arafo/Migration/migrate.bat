@echo off
if "%1" == "rollback" goto rollback
if "%1" == "" goto migrate

goto error

:migrate
migrate -db SqlServer2012 -connection "Server=.;Database=Let3arafo;Integrated Security=True;" -assembly "Let3arafo.Migration.dll"
goto done

:rollback
migrate -db SqlServer2012 -connection "Server=.;Database=Let3arafo;Integrated Security=True;" -assembly "Let3arafo.Migration.dll" -task rollback:all
goto done

:error
echo "No valid command"

:done
echo "Completed"
