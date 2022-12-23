### Test Website MyCity Plans  

### 1) Prepare & How to use it?
  Install Extensions & NuGet: 
 
      - Microsoft.EntityFrameworkCore.Sqlite V3.1.3
      - Microsoft.EntityFrameworkCore.Tools V3.1.3

  Run it in VisualStudio 22 V 17.26

    You need to setup your solution:
      Docker
      WSL - Ubuntu (vsdbg-linux-x64.tar.gz)
      Windows

### 2) How to migrate & update SQlite Db with EntityFramework
  Create new DB Build Process
    
      Add-Migration MigrationNameV1.0.x -Project entiframe

  Update DB after changes in ER-Modell

      Update-Database -Project entiframe
