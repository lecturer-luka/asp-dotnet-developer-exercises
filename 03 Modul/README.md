<div align="center">

<!-- title -->

# Modul 3 - Exercises

<!-- description -->

Exercises for some of the advanced writing for C# code and using .NET 6 in Console application project templates.

</div>


<!-- TOC -->

## Contents

- [Try-Catch statements](#try-catch-statements)
- [Nullable value types](#nullable-value-types)
- [Anonymous types & Anonymous Methods](#anonymous-types-methods)
- [Delegates](#delegates)
- [Events](#events)

<!-- CONTENT -->

## Try-Catch statement

Try-catch statement is used to handle exceptions or errors that may occur during program execution.

The "try" block contains the code that might throw an exception, while the "catch" block is used to handle the exception and provide a way to recover from it. If an exception is thrown in the "try" block, the program will immediately jump to the corresponding "catch" block.

```csharp
try
{
    // Code that might throw an exception
}
catch(Exception e)
{
    // Handle the exception here
}
```


## Nullable value types

Value types are types that hold values directly, as opposed to reference types which hold a reference to the memory location where the value is stored. Value types include integers, floating-point numbers, and boolean values, among others.

A nullable value type allows you to assign null to a value type variable, which is not normally possible. 
For example, an integer value cannot be null by default, but a nullable integer can be null. This is useful when you need to represent an absence of a value, such as in cases where a value is optional or unknown.

To declare a nullable value type in C#, you use the `?` symbol after the value type. For example, `int? myNullableInt = null;` declares a nullable integer variable called `myNullableInt` that is assigned a null value.

You can check if a nullable value type is null using the `HasValue` property. For example, `if(myNullableInt.HasValue)` checks if `myNullableInt` has a value assigned to it.

To retrieve the value of a nullable value type, you use the `Value` property, but you need to check if it has a value first, otherwise you will get a `InvalidOperationException`. 
For example, `int myInt = myNullableInt.Value;` retrieves the value of `myNullableInt`, but only if it has a value assigned to it.


## Delegates

Delegate is a type that represents a reference to a method with a specific parameter list and return type. In simpler terms, a delegate is like a pointer to a method that can be passed as a parameter or stored as a variable.

Delegates are useful when you want to pass a method as an argument to another method or when you want to assign a method to a variable. They are commonly used for event handling, where you can define a delegate type for an event and then register methods to be called when the event occurs.

Here is an example of a delegate declaration:

```csharp
delegate int MyDelegate(int x, int y);
```

Here is an example of using a delegate:

```csharp
int Add(int x, int y) {
    return x + y;
}

int Multiply(int x, int y) {
    return x * y;
}

MyDelegate myDelegate = Add;
int result = myDelegate(3, 4); // result is 7

myDelegate = Multiply;
result = myDelegate(3, 4); // result is 12
```


## Anonymous types & Anonymous Methods

Anonymous types allow you to define a new type on the fly, without having to explicitly define the type. Instead, you can use a type inference mechanism to determine the type automatically. You can create an anonymous type by using the new keyword followed by an object initializer. The type of the object is determined by the compiler based on the properties you set.

```csharp
var person = new { Name = "John", Age = 25 };
```

We can access the values of these properties using dot notation:

```csharp
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);
```


Anonymous methods are similar to lambda expressions in that they allow you to define a block of code without having to create a separate method. They are useful when you need to pass a delegate as a parameter but don't want to create a separate method for it.

```csharp
delegate int MyDelegate(int x, int y);

MyDelegate del = delegate(int x, int y) {
    return x + y;
};
```

We can invoke the delegate like this:

```csharp
int result = del(3, 5);
Console.WriteLine(result); // Output: 8
```


## Events

Event is a notification sent by an object to signal the occurrence of an action. Events allow you to respond to actions taken by the user or by the system, such as mouse clicks or data being added to a database.

To use events in C#, you need to define a delegate type that specifies the signature of the event handlers. The delegate type defines the method signature of the event handler method, which is the method that is called when the event is raised.

To raise an event, you use the `event` keyword to define the event as a member of a class, and then you call the event handler method through the event. When the event is raised, all registered event handler methods are executed in order.

<!-- END CONTENT -->