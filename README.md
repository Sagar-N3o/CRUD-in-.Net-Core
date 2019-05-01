# CRUD using .Net Core

## About Project
This project implemtnts CRUD operations for Employee using .Net core and Entity Framework Core with code first migrations.
This project uses Repository and Unit of Work design pattern for Data Access.
For database Project uses Sql database with code first migrations with Entity Framework Core.

## How to Edit
1. Clone this project and open visual studio 2017 or later version of Visual Studio or in any text editor.
2. Open file CodeFirstCrud/appsettings.json and change connection string so that it can be point to your database location. (default location will be at root of local sql server instance)
3. open package manager console in Visual Studio and run following commands :
    * add-migration "Initial-migration"
    * update-database
5. Edit any code if want or you can skip this step (**Remember** : If you change database model like *Employee.cs* or *Department.cs*, you need to migrate and update database. for this you can repeat step 3)
4. Now go ahed and run project you sould be good to go.
