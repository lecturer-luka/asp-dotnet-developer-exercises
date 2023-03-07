<div align="center">

<!-- title -->

# Basic exercises for xUnit testing tool in Web App ASP.NET MVC

<!-- description -->

The exercise set cover the most basic ways of writing tests with parameterized test and Mock.

</div>

## Exercise 1

1. Create a new ASP.NET Core MVC application using Visual Studio or the command line.
2. Suppose you have a "BookController" class that has the following method:
```csharp
public class BookController : Controller
{
    private readonly IDataRepository<Book> _bookRepository;

    public BookController(IDataRepository<Book> bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public IActionResult GetBook(int id)
    {
        var book = _bookRepository.GetById(id);

        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }
}
```
3. Create new xUnit project using Visual Studio or the Visual Studio Code.
4. Add project reference to newly created xUnit project and create class called "BookControllerTest".
5. Inside "BookControllerTest" class, create the following methods that will test your "Index" action for:
    * GetBook_ReturnsOkResult_WhenBookExists()

        > To test this method, you can use "xUnit and Moq package" to create a mock object for the "IDataRepository<Book> interface" and pass it to the "BookController" constructor.

        > We need to create a mock object for the "IDataRepository<Book> interface" using "Moq" and set it up to "return a Book object" with an "Id of 1" and a "Title" of "Test Book" when the "GetById" method is called with any integer argument.

        > Then create an instance of the "BookController" class with the mock object and call the "GetBook" method with an argument of 1.

        > Assert that the result is type of "ViewResult" and assert that the object model is type of "Book"


## Exercise 2


1. Create a new ASP.NET Core MVC application using Visual Studio or the command line.
2. Suppose you have a "BeerController" class that has the following methods:
```csharp
public class BeerController : Controller
{
    private readonly IDataRepository<Beer> _demoData;

    public BeerController(IDataRepository<Beer> demoData)
    {
        _demoData = demoData;
    }

    public IActionResult Index()
    {
        List<Beer> allBeers = _demoData.GetBeers().OrderBy(x => x.Id).ToList();
        return View(allBeers);
    }

    public IActionResult Details(int id)
    {
        Beer beer = _demoData.GetBeerById(id);

        if (beer == null)
        {
            return NotFound();
        }

        return View(beer);
    }

    [HttpPost]
    public IActionResult Edit(Beer editBeer)
    {
        try
        {
            _demoData.UpdateBeer(editBeer);
            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }
}
```
3. Create new xUnit project using Visual Studio or the Visual Studio Code.
4. Add project reference to newly created xUnit project and create class called "BeerControllerTest".
5. Inside "BeerControllerTest" class, create the following methods:
    * Index_ReturnsAViewResult_WithAListOfBeers()
    * Details_ReturnsAViewResult_WithAListOfBeers()
    * Edit_ReturnsARedirectToIndex_WhenModelStateIsValid()
6. Don't forget to create a "Mock" object of the "IDemoData" interface, which is the data source used by the "BeerController". We then instantiate a new "BeerController" object using the "Mock" object as a parameter.
7. In each test, we arrange the necessary data by setting up the "Mock" object to return the expected data or behavior. We then act by calling the action method, and finally assert the expected result by checking the returned object and its properties.
