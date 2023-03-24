# 🥐 Pierre's 🥐

#### By Molly Donegan

#### _A MVC app that allows Pierre to market his sweet and savory treats._

## 🧁 Technologies Used 🧁
 
* _C#_
* _.NET_
* _HTML_
* _MVC_
* _SQL Workbench_
* _Entity Framework_
* _CSS_

## 🧁 Description 🧁

* Users can log in and log out.

* Only logged in users have create, update, and delete functionality. 

* All users should be able to have read functionality.

*  Users able to navigate to a splash page that lists all treats and flavors.

* Users are able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## 🍩 How To Run This Project 🍩

### 🍩 Install Tools 🍩

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

```
dotnet tool install --global dotnet-ef --version 6.0.0
```

### 🍩 Set Up and Run Project 🍩

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "Pierre".
3. Within the production directory "Pierre", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing `[YOUR-USERNAME]` and `[YOUR_PASSWORD]` values with your own username and password for MySQL. 

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=pierre;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```

5. Create the database using the migrations in the To Do List project. Open your shell (e.g., Terminal or GitBash) to the production directory "Pierre", and run `dotnet ef database update`. 
    - To optionally create a migration, run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration in UpperCamelCase. To learn more about migrations, visit the LHTP lesson [Code First Development and Migrations](https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations).
6. Within the production directory "Pierre", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## 🥪 Known Bugs 🥪

* _No known bugs._

* _Please reach out with any questions or concerns [mollyrdonegan@gmail.com](mollyrdonegan@gmail.com)_

## 🥪 License 🥪

_[MIT](https://github.com/mdonegan91/Pierre.Solution/blob/main/LICENSE)_

Copyright (c) _2023_ _Molly Donegan_