<div align="center">

<!-- title -->

# Introductory exercises for xUnit testing tool in Web App ASP.NET MVC

<!-- description -->

The exercise set cover the most basic ways of writing tests (without parameterized test and Mock examples).

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
	* Index_ReturnsView_NotNull() - result object **can't be null**.
	* Index_ReturnsView_WithBookList() - model object is assignable from **List<Book> or IEnumerable<Book> collections**.
	* Index_ReturnsView_WithoutEmptyElements() - model object **must have one or more elements inside collection**.

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
4. Create new xUnit project using Visual Studio or the Visual Studio Code.
5. Add project reference to newly created xUnit project and create class called "CarControllerTest".
6. Inside "CarControllerTest" class, create the following methods that will test your actions for:
	* Index_Returns_ViewResult() - result object **must be ViewResult type**.
	* Create_Returns_ViewResult() - result object **must be ViewResult type**.
	* Details_Returns_ViewResult() - result object **must be ViewResult type**.
	* Delete_Returns_ViewResult() - result object **must be ViewResult type**.


## Exercise 3

1. Create a new ASP.NET Core MVC project in Visual Studio.
2. Add a new "Football" model class to the Models folder with the following properties:
	* Id (int)
	* TeamName (string)
	* Country (string)
	* Stadium (string)
	* Founded (int)
3. Create a new controller called "FootballController" with actions such as "Index" and "Details".
4. Create new xUnit project using Visual Studio or the Visual Studio Code.
5. Add project reference to newly created xUnit project and create class called "FootballControllerTest".
6. Inside "FootballControllerTest" class, create the following methods that will test your actions for:
	* Index_ReturnsAViewResult_WithListOfFootballTeams()
		> checks that the "Index" action returns a view result **with a list of football teams**
	* Details_ReturnsAViewResult_WithFootballTeam()
		> checks that the "Details" action returns a view result with a single football team that matches the **ID passed in as a parameter (id = 2)**.
	* Index_ReturnsViewWithFootballList()
		> checks whether the "Index" action returns a view with a list of football teams. The test checks whether the returned result **is not null**, whether it **is of type ViewResult**, and whether the model returned by the view **is a list of Football objects with a count of 5**.
	* Details_ReturnsViewWithFootball()
		> checks whether the "Details" action returns a view with a specific football team. The test checks whether the returned result **is not null**, whether it **is of type ViewResult**, and whether the model returned by the view **is a Football object with an id of 2**.


## Exercise 4

1. Create a new ASP.NET Core MVC application using Visual Studio.
2. Create a Beer class with properties like:
	* Id (int)
	* Name (string)
	* Type (string)
	* AlcoholPercentage (double)
	* Brewery (string)
	* Country (string)
3. Create a new controller called "BeerController" with actions such as "Index", "Create", "Edit", and "Delete".
4. Create new xUnit project using Visual Studio or the Visual Studio Code.
5. Add project reference to newly created xUnit project and create class called "BeerControllerTest".
6. Inside "BeerControllerTest" class, create the following methods that will test your actions for:
	* Index_ReturnsViewResult_WithListOfBeers()
		> ensure that the result is a ViewResult, and then check that the model passed to the view **is a list of Beer objects** with the expected count.
	* Create_ValidBeer_AddedSuccessfully()
		> tests when **valid Beer is added successfully**. 
	* Create_InvalidBeer_ReturnsCreateView()
	 	> tests when **invalid Beer is added and redirected to Create view**.
	* Edit_ReturnsRedirectToActionResult_WhenBeerIsEditedSuccessfully()
		> testing successful beer data editing.
	* Edit_ReturnsViewResult_WhenBeerEditFails()
		> testing failed beer data editing.