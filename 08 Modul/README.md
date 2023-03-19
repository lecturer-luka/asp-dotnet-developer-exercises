<div align="center">

<!-- title -->

# Modul 8 - Exercises

<!-- description -->

Exercises for Entity Framework (Code First) approach with C# code using .NET 6 in Web App ASP.NET MVC application project templates.

</div>

<!-- TOC -->

## Content

- [Entity Framework](#entity-framework)
- [Entity Framework (Code First)](entity-framework-code-first)
- [Entity Framework migrations](#entity-framework-migrations)
- [Entity Framework seeding](#entity-framework-seeding)
- [Entity Framework (Database first)](entity-framework-database-first)

<!-- CONTENT -->
## Entity Framework

Entity Framework is a popular Object-Relational Mapping (ORM) framework that allows developers to work with databases using object-oriented code.

With Entity Framework, developers can define a model for their database, which consists of classes and properties that map to tables and columns in the database. They can also define relationships between entities, which represent the relationships between tables in the database.

Entity Framework makes it easy to interact with databases using LINQ (Language Integrated Query) syntax, which allows developers to write queries in a more intuitive and readable way. It also provides tools for creating, updating, and deleting data in the database.


## Entity Framework (Code First)

In Entity Framework, the **code first** approach is a way to create a database from C# classes. Instead of designing a database first and then creating classes that map to the tables, you create the classes first and EF generates the database schema for you.

To use the Code First approach, you define your classes with properties that represent the fields in your tables. 
You can also define relationships between your classes, which will be mapped to foreign keys in your database. Then, you use EF to create or update the database based on your classes.


## Entity Framework migrations

Entity Framework migrations are a way to manage changes to your database schema over time. When you make changes to your entity classes, you can use migrations to update your database schema to match those changes. Migrations allow you to keep track of the changes you make to your schema over time, and easily apply those changes to other environments.


## Entity Framework seeding

Entity Framework seeding is a process where you can populate a database with initial data using code, rather than manually entering data into the database. This can be useful if you want to ensure that your application always has the same initial data when it is run, or if you want to automate the process of adding data to your database.


## Entity Framework (Database first)

In Entity Framework, the **database first** approach refers to creating a data model based on an existing database. In other words, the database schema is used to generate the Entity Framework model.


<!-- END CONTENT -->