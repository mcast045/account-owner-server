# Account-Owner Server 
This is an ASP.NET Core Web API application. It uses a MySQL database and employs a Repository pattern, generics, LINQ, and Entity Framework Core. The architecture and code organization uses multiple projects and services to demonstrate good practices, and to make the code more readable and maintainable.

It is deployed on Heroku as a Docker container at <YourUrlHere>
The front-end code is located at <YourFrontEndGithubRepository>

## Summary
* Created database schemas, tables and relations and populated the tables with data using MySQL Workbench/
* Created ASP.NET Core application. Used extension methods to configure CORS, IIS and other services.
* Created an external logging service. Used dependency injection and inversion of control to inject the service via controller constructors.
* Implemented a Repository pattern. Created models and model attributes. Created a context class and database connection. Created a wrapper around individual repository classes.
* Implemented routing, GET, POST, PUT and DELETE requests, and Data Transfer Objects (DTOs).
## Installation
* Use AccountOwner.sql to create MySQL database.
* Use OwnerData.sql to populate database.
* In AccountOwnerServer/appsettings.json, set the connection string to your database. 
* In AccountOwnerServer/nlog.config, set internalLogFile and fileName to your own file paths.
* Run server.

The front-end application is in my account-owner-client repository
