<div align="center">

<!-- title -->

# Introductory exercises for Web App ASP.NET MVC

<!-- description -->

List of exercise for a introductory level of data manipulation i MVC architecture. The exercises teach you how to pass data from the controller to the view.

</div>

Basic ways of forwarding data:
* Model object - refers to the model data that is passed from the controller to the view. This data can be of any type, but typically it is an instance of a class that represents the data that the view needs to display.
* ViewBag - a dynamic object in C# that is used to pass data between a controller and a view in ASP.NET applications. It is a property of the Controller base class that allows you to store data and then access it from the view.
* ViewData - object used to pass data from a controller action to a view. It is a dictionary that stores key-value pairs, where the key is a string and the value can be any object.


## Exercise 1

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Add a new model class called "Book" with properties such as:
	* Title (string), 
	* Author (string), 
	* PublicationDate (int), 
	* Genre (string)
3. Create a new controller called "BookController" with action "Index"
4. Inside "BookController" create a private method "DemoBookCollection" which will return a collection of books that will contain 4 objects of the "Book" class filled with arbitrary data.
5. In the "Index" action, retrieve a list of all books from a data source and pass it to the corresponding view to display.

## Exercise 2

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Add a new model class called "Car" with properties such as:
	* Make (string), 
	* Model (string), 
	* Year (int), 
	* Color (string), 
	* Price (decimal)
3. Create a new controller called "CarController" with actions "Index", "FilterByYear" and "FilterByColor".
4. Use following demo data for your controller actions:
	 ```csharp
	List<Car> demoCarData = new List<Car> {
		new Car {Make = Toyota, Model = Corolla, Year = 2020, Color = Gray, Price = 25000},
		new Car {Make = Honda, Model = Civic, Year = 2021, Color = Red, Price = 28000},
		new Car {Make = Ford, Model = F-150, Year = 2018, Color = Blue, Price = 35000},
		new Car {Make = BMW, Model = X5, Year = 2019, Color = Black, Price = 50000},
		new Car {Make = Chevrolet, Model = Camaro, Year = 2016, Color = Yellow, Price = 42000}
	};
	```
5. In the "Index" action, retrieve a list of all cars from a data source and pass it to the corresponding view to display.
6. In the "FilterByYear" action, retrieve a list of cars older then 2020, and pass it to the corresponding view to display.
6. In the "FilterByColor" action, retrieve a list of cars where color contains letter "L", and pass it to the corresponding view to display.

## Exercise 3

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Add a new "Football" model class to the Models folder with the following properties:
	* TeamName (string)
	* Country (string)
	* Stadium (string)
	* Founded (int)
3. Create a new "FootballController" controller class with an "Index" action method.
4. In the "Index" action method, create a List<Football> object and populate it with some dummy data (e.g. 5 Football objects).
5. Pass the List<Football> object to the corresponding "Index" view.
6. Create a new "Index.cshtml" view in the Views/Football folder and display the Football data in a table format.

## Exercise 4

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Add a new "Beer" model class to the Models folder with the following properties:
	* Name (string)
	* Type (string)
	* AlcoholPercentage (double)
	* Brewery (string)
	* Country (string)
3. Use the following demo data for your controller actions:
	```csharp
	IEnumerable<Beer> beers = new List<Beer>
	{
		new Beer { Name = "Heineken", Type = "Lager", AlcoholPercentage = 5, Brewery = "Heineken International", Country = "Netherlands" },
		new Beer { Name = "Guinness", Type = "Stout", AlcoholPercentage = 4.2, Brewery = "Guinness & Co.", Country = "Ireland" },
		new Beer { Name = "Corona", Type = "Lager", AlcoholPercentage = 4.5, Brewery = "Grupo Modelo", Country = "Mexico" },
		new Beer { Name = "Budweiser", Type = "Lager", AlcoholPercentage = 5, Brewery = "Anheuser-Busch InBev", Country = "United States" },
		new Beer { Name = "Stella Artois", Type = "Pilsner", AlcoholPercentage = 5, Brewery = "Anheuser-Busch InBev", Country = "Belgium" },
		new Beer { Name = "Sapporo", Type = "Lager", AlcoholPercentage = 5, Brewery = "Sapporo Breweries Ltd.", Country = "Japan" },
		new Beer { Name = "Peroni", Type = "Lager", AlcoholPercentage = 5.1, Brewery = "Peroni Brewery", Country = "Italy" },
		new Beer { Name = "Asahi", Type = "Lager", AlcoholPercentage = 5, Brewery = "Asahi Breweries Ltd.", Country = "Japan" },
		new Beer { Name = "Hoegaarden", Type = "Witbier", AlcoholPercentage = 4.9, Brewery = "InBev Belgium", Country = "Belgium" },
		new Beer { Name = "Tsingtao", Type = "Lager", AlcoholPercentage = 4.7, Brewery = "Tsingtao Brewery Co. Ltd.", Country = "China" }
	};
	```
4. Create a new "BeerController" controller class with actions "Index", "FilterByPercentage", "GroupByCountry", "FilterByName", and "GroupByType".
5. In the "Index" action, retrieve a list of all beers from a data source and pass it to the corresponding view to display.
6. In the "FilterByPercentage" action, retrieve a list of all beers with a higher percentage of alcohol than 5% from a data source and pass it to the corresponding view to display.
7. In the "GroupByCountry" action, retrieve a list of all beers from a data source, group them by country and pass it to the corresponding view to display.
8. In the "FilterByName" action, retrieve a list of all beers from a data source, filter names by letter "S" and pass it to the corresponding view to display.
9. In the "GroupByType" action, retrieve a list of all beers from a data source, group them by type and pass it to the corresponding view to display.