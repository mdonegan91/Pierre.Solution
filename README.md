# 🍲 Pierre's 🍲

#### By Molly Donegan

#### _A MVC app that allows Pierre to market his sweet and savory treats._

## 🧂 Technologies Used 🧂
 
* _C#_
* _.NET_
* _HTML_
* _MVC_
* _SQL Workbench_
* _Entity Framework_
* _CSS_

## 🧂 Description 🧂

* A user can add a recipe with TreatDescription and instructions, to remember how to prepare favorite dishes.

## 🧂 Setup/Installation Requirements 🧂

* _Clone this repo._
* _Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "RecipeBox"._
* _In the command line, run the command ``dotnet run`` to compile and execute the application._
* _Optionally, you can run ``dotnet build`` to compile this app without running it._
* _This program was built using `Microsoft .NET SDK 6.0`, and may not be compatible with other versions._
* _Open the browser to [https://localhost:5001]. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, visit: [Redirecting to HTTPS and Issuing a Security Certificate.](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate)_

## 🧂 SQL Workbench Configuration 🧂
* _Create an `appsetting.json` file in the "RecipeBox" directory of the project._
* _Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL._ 
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=pierre;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* _If you'd like to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore first._
* _Once "appsettings.json" file has been created, follow the below directions for Entity Framework Migration Configuration._ 

## 🧂 Entity Framework Migration Configuration 🧂

* _In root directory of project folder "RecipeBox", run `dotnet ef migrations add restoreDatabase`_
* _Then run $ `dotnet ef database update`_
* _Open SQL Workbench._
* _Navigate to `"pierre"` schema._
* _Click the drop down, select "Tables" drop down._
* _Verify the tables._

## 🥟 Known Bugs 🥟

* _No known bugs._

* _Please reach out with any questions or concerns_

## 🥟 License 🥟

_[MIT](https://opensource.org/license/mit/)_

Copyright (c) _2023_ _Molly Donegan_