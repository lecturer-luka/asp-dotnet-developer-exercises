<div align="center">

<!-- title -->

# Basic exercises for Entity Framework Core (code-first approach) in Web App ASP.NET MVC

<!-- description -->

The exercise set cover the most basic ways of **code first** approach. Define your classes with properties that represent the fields in your tables. Define relationships between your classes, and use data annotations to create primary/foreign keys in your database.

	* C# Data Annotations is a feature of the .NET framework that allows developers to apply metadata to class properties in order to validate or describe data.
	* This means that you can add special attributes to a class property to specify certain rules that the data must follow, such as its minimum and maximum length, whether it's required, or its data type.
</div>

	* The examples below use MS SQL server databases.


## Exercise 1

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Install the Entity Framework Core packages:
	* Microsoft.EntityFrameworkCore
	* Microsoft.EntityFrameworkCore.Tools
	* Microsoft.EntityFrameworkCore.SqlServer
3. Add a new model class called `Book` with properties such as:
	* Id (int)
	* Title (string),
	* Author (string),
	* PublicationDate (int),
	* Genre (string)
4. With help of the `Data Annotations` inside `Book` class use attributes to define primary key and required properties.
5. Add a new `DbContext` class called `BookDbContext` and use `DbSet` property to define the table in the database.
6. In `Program.cs` update service `AddDbContext` to use `UseSqlServer` options with your `connection string`.
7. Use the `Add-Migration` command in the `Package Manager Console` to create a migration that describes the changes you made to your entity classes.
	* `dotnet ef migrations add` command if you are using CLI.
8. Use the `Update-Database` command in the `Package Manager Console` to apply the migration to your database.
	* * `dotnet ef database update` command if you are using CLI.
9. Check if table `Book` is properly created in your database.


## Exercise 2

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Install the Entity Framework Core packages:
	* Microsoft.EntityFrameworkCore
	* Microsoft.EntityFrameworkCore.Tools
	* Microsoft.EntityFrameworkCore.SqlServer
3. Add a new model class called `Car` with properties such as:
	* Id (int)
    * Make (string),
    * Model (string),
    * Year (int),
    * Color (string),
    * Price (decimal)
4. With help of the `Data Annotations` inside `Car` class use attributes to define primary key and required properties.
5. Add a new `DbContext` class called `CarDbContext` and use `DbSet` property to define the table in the database.
6. In `Program.cs` update service `AddDbContext` to use `UseSqlServer` options with your `connection string`.
7. Use the `Add-Migration` command in the `Package Manager Console` to create a migration that describes the changes you made to your entity classes.
	* `dotnet ef migrations add` command if you are using CLI.
8. Use the `Update-Database` command in the `Package Manager Console` to apply the migration to your database.
	* * `dotnet ef database update` command if you are using CLI.
9. Check if table `Car` is properly created in your database.


## Exercise 3

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Install the Entity Framework Core packages:
	* Microsoft.EntityFrameworkCore
	* Microsoft.EntityFrameworkCore.Tools
	* Microsoft.EntityFrameworkCore.SqlServer
3. Create the `BeerStyle` model class:
	* Id (int)
	* Name (string)
4. Create the `Beer` model class:
	Id (int)
	Name (string)
	Price (decimal)
	BeerStyleId (int)
	BeerStyle (BeerStyle)
5. With help of the `Data Annotations` inside `Beer` and `BeerStyle` classes use attributes to define primary keys, required properties and data types.
6. Add a new `DbContext` class called `BeerDbContext` and use `DbSet` properties to define the tables in the database.
7. In `Program.cs` update service `AddDbContext` to use `UseSqlServer` options with your `connection string`.
8. Use the `Add-Migration` command in the `Package Manager Console` to create a migration that describes the changes you made to your entity classes.
	* `dotnet ef migrations add` command if you are using CLI.
9. Use the `Update-Database` command in the `Package Manager Console` to apply the migration to your database.
	* * `dotnet ef database update` command if you are using CLI.
10. Check if tables `Beer` and `BeerStyle` are properly created in your database.

## Exercise 4

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Install the Entity Framework Core packages:
	* Microsoft.EntityFrameworkCore
	* Microsoft.EntityFrameworkCore.Tools
	* Microsoft.EntityFrameworkCore.SqlServer
3. Create the `Author` model class:
	* Id (int)
	* Name (string) 
	* Books (List<Book>)
4. Create the `Book` model class:
	Id (int)
	Title (string)
	ISBN (string) // ISBN stands for "International Standard Book Number"
	Year (int)
	AuthorId (int)
	Author (Author)
5. With help of the `Data Annotations` inside `Book` and `Author` classes use attributes to define primary keys, required properties and data types.
6. Inside class `Author`, add attribute `[NotMapped]` for property `Books`.
6. Add a new `DbContext` class called `BookDbContext` and use `DbSet` properties to define the tables in the database.
7. In `Program.cs` update service `AddDbContext` to use `UseSqlServer` options with your `connection string`.
8. Use the `Add-Migration` command in the `Package Manager Console` to create a migration that describes the changes you made to your entity classes.
	* `dotnet ef migrations add` command if you are using CLI.
9. Use the `Update-Database` command in the `Package Manager Console` to apply the migration to your database.
	* * `dotnet ef database update` command if you are using CLI.
10. Check if tables `Book` and `Author` are properly created in your database.