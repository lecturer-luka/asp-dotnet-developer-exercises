<div align="center">

<!-- title -->

# Introductory exercises for xUnit testing tool in Web App ASP.NET MVC

<!-- description -->

The exercise set and the rest cover the most basic ways of writing tests (without parameterized test and Mock examples).

</div>

## Exercise 1

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Add a new model class called "Book" with properties such as:
	* Title (string), 
	* Author (string), 
	* PublicationDate (int), 
	* Genre (string)
3. Create a new controller called "BookController" with action "Index"
4. In the "Index" action, retrieve a list of all books from a data source and pass it to the corresponding view to display.
5. Create new xUnit project using Visual Studio or the Visual Studio Code.
6. Add project reference to newly created xUnit project and create class called "BookControllerTest".
7. Inside "BookControllerTest" class, create the following methods that will test your "Index" action for:
	* Index_ReturnsView_NotNull() - result object can't be null
	* Index_ReturnsView_WithBookList() - model object is assignable from List<Book> or IEnumerable<Book> collections
	* Index_ReturnsView_WithoutEmptyElements() - model object must have one or more elements inside collection

## Exercise 2


## Exercise 3


## Exercise 4