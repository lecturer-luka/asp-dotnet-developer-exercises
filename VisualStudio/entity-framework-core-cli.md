# Entity Framework Core and CLI cheat sheet

Basic **command-line interface (CLI)** tools for **Entity Framework Core Cheat Sheet** with the list of commands to use when learning C# and .NET 6

---


## Checks

The commands are an extension to the cross-platform **dotnet** commands.
Full documentation is available on (Microsoft website)[https://learn.microsoft.com/en-us/ef/core/cli/dotnet].


## Installing the tools

Installing `dotnet ef` as a global tool using the following command:

```dotnet
dotnet tool install --global dotnet-ef
```


## Standard NuGet packages

Standard NuGet packages for installation and use with the EF Core framework:
	* Microsoft.EntityFrameworkCore
	* Microsoft.EntityFrameworkCore.Tools
	* Microsoft.EntityFrameworkCore.SqlServer

```dotnet
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```


## Using the tools


### Adds a new migration

```dotnet
// Syntax
dotnet ef migrations add <NameOfTheMigration>

// Correct
dotnet ef migrations add CreateDatabase
```


### Adds a new migration

```dotnet
// Syntax
dotnet ef migrations add <NameOfTheMigration>

// Correct
dotnet ef migrations add CreateDatabase
```


### Updates the database

```dotnet

dotnet ef database update

```

### Resets the database

```dotnet

dotnet ef database update 0
```

### Removes the migration

```dotnet
// Syntax
dotnet ef migrations remove
// OR
dotnet ef migrations remove <NameOfTheMigration>


// Remove last migration
dotnet ef migrations remove

// Remove certain migration
dotnet ef migrations remove MyThirdMigration
```