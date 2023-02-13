# Visual Studio Code and dotnet cheat sheet

Basic .NET CLI Cheat Sheet with the list of commands and to use when learning .NET 6, the command line and Visual Studio Code

---

## Checks

Check installed CLI version:

```dotnet
dotnet --version
```

Show available templates:

```dotnet
dotnet new
```


## Solutions

In the simplest terms, a Solution is a directory for projects.

Create a solution with the custom name of the folder:

```dotnet
dotnet new sln --name MySolutionName

// OR

dotnet new sln -o MySolutionName
```


## Project templates

In the simplest terms, a project template represents the type of application that will be built.

#### Add a console project to a solution:

```dotnet
cd MySolutionName

dotnet new console --framework net6.0 -o MyProjectName
```

#### Add a console project to a solution (with namespace, class and Main() method):

```dotnet
cd MySolutionName

dotnet new console --framework net6.0 -o MyProjectName --use-program-main
```

#### Add a class library project to a solution:

```dotnet
cd MySolutionName

dotnet new classlib --framework net6.0 -o MyLibraryName

dotnet sln add MyLibraryName\MyLibraryName.csproj
```

#### Add a ASP.NET Core Web App (MVC) project to a solution:

```dotnet
cd MySolutionName

dotnet new mvc --framework net6.0 -o MvcProjectName

dotnet sln add .\MvcProjectName\MvcProjectName.csproj
```

#### Add a ASP.NET Core Web App (MVC) project to a solution (with namespace, class and Main() method in Program file):

```dotnet
cd MySolutionName

dotnet new mvc --framework net6.0 --use-program-main -o MvcProjectName

dotnet sln add .\MvcProjectName\MvcProjectName.csproj
```


## Project reference

The dotnet add reference command provides a convenient option to add project references to a project. After running the command, the project reference elements are added to the project file.

```dotnet
dotnet new sln -o MySolutionName
cd MySolutionName

dotnet new console -o FirstProject --framework net6.0  --use-program-main

dotnet new console -o SecondProject --framework net6.0  --use-program-main


// Adds "SecondProject.csproj" folder reference to "FirstProject.csproj" folder
dotnet add FirstProject/FirstProject.csproj reference SecondProject/SecondProject.csproj
```


##  Install or update packages to existing project with NuGet

Find package name and version on https://www.nuget.org/ website.


#### Install or update a package



```dotnet
cd MySolutionName/MvcProjectName

// dotnet add package <PACKAGE_NAME>
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

#### Install a specific version of a package

```dotnet
cd MySolutionName/MvcProjectName

// dotnet add package <PACKAGE_NAME> -v <VERSION>
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.2

```

#### Remove a package

```dotnet
cd MySolutionName/MvcProjectName

// dotnet remove package <PACKAGE_NAME>
dotnet remove package Microsoft.EntityFrameworkCore.SqlServer

```

#### List all packages

```dotnet
cd MySolutionName/MvcProjectName

dotnet list package
```


## Project building and runing

Build current’s folder solution or project:

```dotnet
dotnet build
```

Run current’s folder project:

```dotnet
dotnet run
```

### More soon...