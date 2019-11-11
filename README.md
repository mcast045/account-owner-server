# Account-Owner Server 
This is an ASP.NET Core Web API application. It uses a MySQL database and employs a Repository pattern, generics, LINQ, and Entity Framework Core. The architecture and code organization uses multiple projects and services to demonstrate good practices, and to make the code more readable and maintainable.

It is deployed on Heroku as a Docker container at <YourUrlHere>
The front-end code is located at <YourFrontEndGithubRepository>


## Installation
* Use AccountOwner.sql to create MySQL database.
* Use OwnerData.sql to populate database.
* In AccountOwnerServer/appsettings.json, set the connection string to your database. 
* In AccountOwnerServer/nlog.config, set internalLogFile and fileName to your own file paths.
* Run server.

The front-end application is in my account-owner-client repository
