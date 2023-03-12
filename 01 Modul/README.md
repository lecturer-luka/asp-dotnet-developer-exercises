<div align="center">

<!-- title -->

# Modul 1 - Exercises

<!-- description -->

Exercises for basics of writing C# code and using .NET 6 in Console application project templates.

</div>


<!-- TOC -->

## Contents

- [Variables](#variables)
- [Conditional statements](#conditional-statements)
- [Loops](#loops)
- [Methods](#methods)
- [Classes and Objects](#classes-and-objects)
- [Inheritance](#inheritance)
- [Interfaces](#interfaces)

<!-- CONTENT -->

## Variables

Variables are containers for storing data values.
Every variable has a type that determines what values can be stored in the variable.
C# is a type-safe language and the C# compiler guarantees that values stored in variables are always of the appropriate type. 


## Conditional statements

C# conditional statements are used when we want to execute a certain action depending upon an available condition.
C# conditional statements can be divided on `if-else` and `switch-case`.


## Loops

Loops in C# are used for iterating over collections of items or for executing a block of code repeatedly until a certain condition is met. 

There are four main types of loops in C#:

### `for` loop

 This type of loop is used when we know the exact number of times we want to execute a block of code. It has three parts: initialization, condition, and increment.

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```


### `foreach`

This type od loop allows you to iterate over a collection of items such as an array, list, or other enumerable object. It simplifies the process of looping through a collection by automatically handling the iteration and providing access to each item in the collection.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```


### `while` loop

This type of loop is used when we want to execute a block of code while a certain condition is true.

```csharp
int i = 0;

while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
```


### `do-while` loop

This type of loop is similar to the while loop, except that the block of code is executed at least once before the condition is checked.

```csharp
int i = 0;

do
{
    Console.WriteLine(i);
    i++;
}
while (i < 10);
```

## Methods

Method is a block of code that performs a specific task. 
Methods are used to perform actions or calculations and can be called multiple times from different parts of the program.

A method can have a name, parameters, and a return type. The name of the method should reflect what the method does. Parameters are values that are passed to the method when it is called, and they can be used as input to the method's logic. The return type specifies the type of value that the method returns to the calling code.


```csharp
public int Add(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}

// How to call above method
int result = Add(2, 3);
```

## Classes and Objects

A class is like a blueprint or a template for creating objects. 
It defines the properties and behaviors of an object. 

For example, a class called "Person" might have properties like "name", "age", and "address", and behaviors like "walk" or "talk".


An object, on the other hand, is an instance of a class. It's like a real-world object created from a blueprint. 
Using the example above, if we create an object from the "Person" class, we might create an object called "John" with properties like "name=John", "age=30", and "address=123 Main St", and behaviors like "walk()" or "talk()".

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public void Walk()
    {
        Console.WriteLine("Walking...");
    }
    
    public void Talk()
    {
        Console.WriteLine("Talking...");
    }
}


// How you can create an object from the Person class
Person john = new Person();
john.Name = "John";
john.Age = 30;
john.Walk();
```

## Inheritance

Inheritance is a mechanism in C# that allows a class to inherit properties, methods, and fields from another class. 
The class that inherits is called the derived class, while the class that is being inherited from is called the base class.

When a derived class inherits from a base class, it automatically receives all of the properties, methods, and fields defined in the base class. The derived class can also add additional properties, methods, and fields that are specific to its needs.

## Interfaces

An interface is a blueprint for a class. 
It defines a set of properties and methods that a class must implement. 
An interface can contain only the signature of methods, properties, events or indexers. It does not contain any implementation of the methods or properties.

A class that implements an interface must provide an implementation for all the members of that interface. This ensures that the class behaves consistently with other classes that implement the same interface.

<!-- END CONTENT -->