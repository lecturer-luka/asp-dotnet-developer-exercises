<div align="center">
	<h3 align="center">Introductory exercises for Web App ASP.NET MVC</h3>


	<p align="center">
		List of exercise for a introductory level of data manipulation i MVC architecture.
		The exercises teach you how to pass data from the controller to the view.
	<p>
	<p align="left">
		Basic ways of forwarding data:
		* Model object - refers to the model data that is passed from the controller to the view. This data can be of any type, but typically it is an instance of a class that represents the data that the view needs to display.
		* ViewBag - a dynamic object in C# that is used to pass data between a controller and a view in ASP.NET applications. It is a property of the Controller base class that allows you to store data and then access it from the view.
		* ViewData - object used to pass data from a controller action to a view. It is a dictionary that stores key-value pairs, where the key is a string and the value can be any object.
	</p>
</div>


## Excercise 1

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Add a new model class called "Book" with properties such as:
	* Title (string), 
	* Author (string), 
	* PublicationDate (int), 
	* Genre (string)
3. Create a new controller called "BookController" with action "Index"
4. Inside "BookController" create a private method "DemoBookCollection" which will return a collection of books that will contain 4 objects of the "Book" class filled with arbitrary data.
5. In the "Index" action, retrieve a list of all books from a data source and pass it to the corresponding view to display.

## Excercise 2

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Add a new model class called "Car" with properties such as:
	* Make (string), 
	* Model (string), 
	* Year (int), 
	* Color (string), 
	* Price (decimal)
3. Create a new controller called "CarController" with actions "Index", "FilterByYear" and "FilterByColor".
4. Use following demo data for your controller actions:
	 ```dotnet
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

## Excercise 3


## Excercise 4