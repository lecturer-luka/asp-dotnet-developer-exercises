# Proposal For C# Coding Standards And Naming Conventions

The suggestions below can be adapted to the group of participants, depending on the knowledge of the individual.
The idea is that after module 3, the rules below start to apply.

The proposals were adopted from [MS C# Coding Conventions](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)

---

| Term name                 | Notation   | Plural | Allowed characters | Underscores |
|:--------------------------|:-----------|:-------|:-------------------|:------------|
| Namespace name            | PascalCase | Yes    | [A-z][0-9]		   | No          |
| Class name                | PascalCase | No     | [A-z][0-9]         | No          |
| Constructor name          | PascalCase | No     | [A-z][0-9]         | No          |
| Method name               | PascalCase | Yes    | [A-z][0-9]         | No          |
| Method arguments          | camelCase  | Yes    | [A-z][0-9]         | No          |
| Local variables           | camelCase  | Yes    | [A-z][0-9]         | No          |
| Constants name            | PascalCase | No     | [A-z][0-9]         | No          |
| Field name                | camelCase  | Yes    | [A-z][0-9]         | Yes         |
| Properties name           | PascalCase | Yes    | [A-z][0-9]         | No          |
| Delegate name             | PascalCase | No     | [A-z]              | No          |
| Enum type name            | PascalCase | Yes    | [A-z]              | No          |


---

### What's the Difference Between Programming Type Casings?

Types of casings in programming are simply described in the following FreeCodeCamp [article](https://www.freecodecamp.org/news/snake-case-vs-camel-case-vs-pascal-case-vs-kebab-case-whats-the-difference/).


Below are some examples of using coding standards for each term.

---


#### 1. Class names and method names

```csharp

public class OrderProcessing
{
	public void ClearCart()
	{
		//...
	}
	public void CalculateTotal()
	{
		//...
	}
}

```


#### 2. Method arguments and local variables

```csharp

public class CartItem
{
	public void Add(Product product)
	{
		int itemCount = cart.Items.Count;
		// ...
	}
}

```


#### 3. Meaningful names for variables

```csharp

var filterUsers = from user in users
	where user.City == "Zagreb"
	select user.Name;

```


#### 4. Predefined type names (C# aliases) like `int`, `float`, `string` for local, parameter and member declarations.

```csharp

// Correct
	string firstName;
	int id;
	bool isSaved;
	string commaSeparatedNames = String.Join(", ", names);
	int index = Int32.Parse(input);

// Avoid
	String firstName;
	Int32 id;
	Boolean isSaved;
	string commaSeparatedNames = string.Join(", ", names);
	int index = int.Parse(input);

```

*** Use .NET names like `Int32`, `Single`, `String` when accessing the type's static members like `Int32.TryParse` or `String.Join` ***


#### 5. Constants or readonly variables can also use PascalCasing

```csharp

// Correct
	public const string ShippingType = "International";
// Avoid
	public const string SHIPPING_TYPE = "International";

```


#### 6. Prefix private fields with an underscore

```csharp 

// Correct
	private DateTime _dateOfBirth;
	private TimeSpan _offssetTime;

// Avoid
	private DateTime client_Appointment;
	private TimeSpan time_Left; 

```


#### 7. Declare all class properties and variables at the top of a class

```csharp

public class UserAccount
{
	public static string BankName;
	public static decimal Reserves;      
	public string Number { get; set; }
	public DateTime DateOpened { get; set; }
	public DateTime DateClosed { get; set; }
	public decimal Balance { get; set; }     

	// Constructor
	public UserAccount()
	{
		// ...
	}
}

```


#### 8. Singular names for simple enums and plural for bit field / flags enums)

```csharp

// Correct
	public enum Currency
	{
		GBP,
		AUD,
		HRK,
		CHF,
		EUR,
		USD
	} 

	[Flags]
	public enum CurrencyCodes
	{
		GBP = 826,
		HRK = 191,
		AUD = 36, 
		CHF = 756,
		EUR = 978,
		USD = 840
	}

// Avoid
	public enum CurrencyEnum
	{
		GBP,
		EUR,
		AUD,
		CHF,
		USD
	}

	[Flags]
	public enum CurrencyCodesEnumFlags
	{
		GBP = 826,
		HRK = 191,
		AUD = 36, 
		CHF = 756,
		EUR = 978,
		USD = 840
	}

```


#### Information on events can use suffix in name

```csharp

// Declaring events with generic EventHandler<>
public event EventHandler<UserAccountEventArgs> UserAccountEvent;

// Declaring events with delagates
public delegate void UserAccountEventHandler(object sender, UserAccountEventArgs e);

public class UserAccountEventArgs
{
	// ...
}

// OR

public class UserAccountEventArgs : System.EventArgs
{
	// ...
}

```


#### In method calls you can use named arguments

```csharp

// Method
public void MethodName(string text, int number) 
{
	// ...
}

MethodName("Random text string", 100);
// OR
MethodName(text: "Random text string", number: 100);

```


### More soon...