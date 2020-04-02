# Kanban

#### A visual system for managing work as it moves through a process, 03.29.2020

#### By **Jiwon Han**

[![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip)
![LastCommit](https://img.shields.io/github/last-commit/jiwon-seattle/VendorOrderTracker.Solution)
![Languages](https://img.shields.io/github/languages/top/jiwon-seattle/VendorOrderTracker.Solution)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## 1. User Flow

1. Team members are able to learn what is kanban in the main page
2. Team member is able to register a Kanban system and login and logout
3. Team members are not able to see if they are not logged in to the system
4. Team member is able to enter personal information into system with name, contact, registered date, position and current status
5. Team memebers are able to enter a new project with details such as project name, description, kicoff date, due date, and active status
6. Team members are able to assign status of project : Idea, ToDo, Doing or Done
7. Team members are able to assign people to the project
 

//To be continued..

Parking Lot/Improvement Opportunities:
- Kanban Board and general UI/UX design 
- form-control in member.cshtml
- identity

## 2. Development
### Tech stack:
+ [.NET CORE](https://dotnet.microsoft.com/download/dotnet-core/) for package management
+ [MySQL](https://dev.mysql.com/downloads/file/?id=484919) 

### To run dev mode locally:
```bash
  $ git clone https://github.com/jiwon-seattle/Kanban.Solution.git
  $ cd Kanban
  $ dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0
  $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0
  $ dotnet build
  $ dotnet ef migrations add MigrationName
  $ dotnet ef database update  
  # After successfull pkg installtion
  $ dotnet run
```
Now, it will automatically open http://localhost:5000 and show you the Kanban main page.

You might encounter a MySql database related errors on initial loading since this application needs a specific data route to fetch data.

## 3. Known Bugs

There are no known bug at this moment

## 4. Support and contact details

Any feedback is appreciated! Please contact at email: jiwon1.han@gmail.com

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Jiwon Han_**
