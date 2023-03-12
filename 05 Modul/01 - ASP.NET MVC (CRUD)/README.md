<div align="center">

<!-- title -->

# Basic exercises for Web App ASP.NET MVC (CRUD)

<!-- description -->

List of exercise for data manipulation i MVC architecture. The exercises teach you how to create basic CRUD web applications.

</div>

## Exercise 1

1. Create a new ASP.NET Core MVC application using Visual Studio or the command line.
2. Add a new model class called "Book" with properties such as:
	* Id (int)
	* Title (string),
	* Author (string),
	* PublicationDate (int),
	* Genre (string)
3. Create a new controller called "BookController" with actions such as "Index", "Create", "Edit", and "Delete".
4. In the "Index" action, retrieve a list of books from a data source (e.g. JSON file, or hard-coded list) and pass it to the corresponding view to display.
5. In the "Create" action, display a form to allow users to enter the details of a new book, then save it to the data source and redirect to the "Index" action to display the updated list.
6. In the "Edit" action, retrieve the details of a book by its ID, display a form with the current values pre-populated, allow users to edit them, and save the updated book to the data source, then redirect to the "Index" action to display the updated list.
7. In the "Delete" action, retrieve the details of a book by its ID, display a confirmation message, then delete it from the data source and redirect to the "Index" action to display the updated list.


## Exercise 2

1. Create a new ASP.NET Core MVC application using Visual Studio or the command line.
2. Add a new model class called "Car" with properties such as:
	* Id (int)
    * Make (string),
    * Model (string),
    * Year (int),
    * Color (string),
    * Price (decimal)
3. Create a new controller called "CarController" with actions such as "Index", "Create", "Edit", and "Delete".
4. Use following demo data for your controller actions:
	```csharp
	List<Car> demoCarData = new List<Car> {
		new Car {Id = 11, Make = Toyota, Model = Corolla, Year = 2020, Color = Gray, Price = 25000},
		new Car {Id = 12, Make = Honda, Model = Civic, Year = 2021, Color = Red, Price = 28000},
		new Car {Id = 15, Make = Ford, Model = F-150, Year = 2018, Color = Blue, Price = 35000},
		new Car {Id = 16, Make = BMW, Model = X5, Year = 2019, Color = Black, Price = 50000},
		new Car {Id = 20, Make = Chevrolet, Model = Camaro, Year = 2016, Color = Yellow, Price = 42000}
	};
	```
5. In the "Index" action, retrieve a list of cars from a data source and pass it to the corresponding view to display.
6. In the "Create" action, display a form to allow users to enter the details of a new car, then save it to the data source and redirect to the "Index" action to display the updated list.
7. In the "Edit" action, retrieve the details of a car by its ID, display a form with the current values pre-populated, allow users to edit them, and save the updated car to the data source, then redirect to the "Index" action to display the updated list.
8. In the "Delete" action, retrieve the details of a car by its ID, display a confirmation message, then delete it from the data source and redirect to the "Index" action to display the updated list.


## Exercise 3

1. Create a new ASP.NET Core MVC project in Visual Studio.
2. Add a new "Football" model class to the Models folder with the following properties:
	* Id (int)
	* TeamName (string)
	* Country (string)
	* Stadium (string)
	* Founded (int)
3. Create a new "FootballController" controller class with an "Index" action method.
4. In the "Index" action method, create a List<Football> object and populate it with some dummy data (e.g. 5 Football objects).
5. Pass the List<Football> object to the corresponding "Index" view.
6. Create a new "Index.cshtml" view in the Views/Football folder and display the Football data in a table format.
7. Add a new "Details" action method to the "FootballController" and a corresponding "Details.cshtml" view in the Views/Football folder.
8. In the "Details" action method, retrieve the Football object with the specified ID (passed as a parameter).
9. Pass the Football object to the "Details" view.
10. In the "Details" view, display the details of the Football object in a user-friendly way.


## Exercise 4

1. Create a new ASP.NET Core MVC application using Visual Studio.
2. Create a Beer class with properties like:
	* Id (int)
	* Name (string)
	* Type (string)
	* AlcoholPercentage (double)
	* Brewery (string)
	* Country (string)
3. Use the following demo data for your controller actions:
	```csharp
	IEnumerable<Beer> beers = new List<Beer>
	{
		new Beer { Id = 1001, Name = "Heineken", Type = "Lager", AlcoholPercentage = 5, Brewery = "Heineken International", Country = "Netherlands" },
		new Beer { Id = 1002, Name = "Guinness", Type = "Stout", AlcoholPercentage = 4.2, Brewery = "Guinness & Co.", Country = "Ireland" },
		new Beer { Id = 1003, Name = "Corona", Type = "Lager", AlcoholPercentage = 4.5, Brewery = "Grupo Modelo", Country = "Mexico" },
		new Beer { Id = 1004, Name = "Budweiser", Type = "Lager", AlcoholPercentage = 5, Brewery = "Anheuser-Busch InBev", Country = "United States" },
		new Beer { Id = 1005, Name = "Stella Artois", Type = "Pilsner", AlcoholPercentage = 5, Brewery = "Anheuser-Busch InBev", Country = "Belgium" },
		new Beer { Id = 1006, Name = "Sapporo", Type = "Lager", AlcoholPercentage = 5, Brewery = "Sapporo Breweries Ltd.", Country = "Japan" },
		new Beer { Id = 1007, Name = "Peroni", Type = "Lager", AlcoholPercentage = 5.1, Brewery = "Peroni Brewery", Country = "Italy" },
		new Beer { Id = 1008, Name = "Asahi", Type = "Lager", AlcoholPercentage = 5, Brewery = "Asahi Breweries Ltd.", Country = "Japan" },
		new Beer { Id = 1009, Name = "Hoegaarden", Type = "Witbier", AlcoholPercentage = 4.9, Brewery = "InBev Belgium", Country = "Belgium" },
		new Beer { Id = 1020, Name = "Tsingtao", Type = "Lager", AlcoholPercentage = 4.7, Brewery = "Tsingtao Brewery Co. Ltd.", Country = "China" }
	};
	```
4. Add a "List" view that displays a list of all the beers from data source.
5. Add a "Details" view that displays the details of a single beer.
6. Add a "Create" view that allows users to add a new beer to the list.
7. Add validation to the "Create" view to ensure that all required fields are filled in.
8. Add the ability to edit and delete beers from data source.
9. Add search and filtering functionality to the "List" view, so users can search for beers by name, type, brewery, or country.