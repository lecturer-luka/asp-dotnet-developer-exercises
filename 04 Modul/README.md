<div align="center">

<!-- title -->

# Modul 4 - Exercises

<!-- description -->

Exercises for Language Integrated Query (LINQ) writing for C# code and using .NET 6 in Console application project templates.

</div>


<!-- TOC -->

## Content

- [LINQ](#linq)
- [LINQ and Entity Framework](#linq-and-ef)

<!-- CONTENT -->

## LINQ

LINQ (Language Integrated Query) is a feature of C# that allows you to perform data queries directly in your code using a syntax similar to SQL. It allows you to work with collections of data, such as arrays or lists, in a way that is more efficient and expressive than traditional looping and iterating.

With LINQ, you can filter, sort, group, and transform data in various ways. You can use LINQ to query data from different sources, such as databases, XML files, or other objects. The results of a LINQ query are returned as a new collection of objects that you can then manipulate or display.

LINQ have two styles: `query syntax` or `method syntax`.

Simple example:

```csharp
int[] numbers = { 3, 7, 12, 15, 18, 21 };
var result = from num in numbers
             where num > 10 && num % 2 == 0
             select num;
```


## LINQ and Entity Framework

In Entity Framework, developers can use LINQ to query the database and retrieve data in a more intuitive way than writing SQL queries. LINQ queries are written using C# syntax and are translated into SQL queries by Entity Framework.

Simple example:

```csharp
var context = new MyDbContext();
var students = from s in context.Students
               where s.Grade > 80
               orderby s.LastName
               select s;
```

<!-- END CONTENT -->