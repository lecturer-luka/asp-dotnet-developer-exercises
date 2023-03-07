<div align="center">

<!-- title -->

# Modul 7 - Exercises

<!-- description -->

Exercises for Repository pattern with C# code using .NET 6 in Web App ASP.NET MVC application project templates.

</div>


<!-- TOC -->

## Content

- [Repository pattern](#repository-pattern)
- [View & partial View](view-partial-view)
- [HTML form and Razor syntax](html-and-razor)
- [Domain Driven Design](#ddd)

<!-- CONTENT -->

## Repository pattern

Repository pattern in C# is a design pattern that separates the logic that accesses data from the business logic in an application.

The basic idea behind the Repository pattern is to provide a layer of abstraction between the data storage (such as a database) and the rest of the application. Instead of accessing the data storage directly, the application interacts with the repository, which handles the details of data storage and retrieval.


## View & partial View

In C# web development, a View is a template that defines the HTML markup and presentation logic for rendering a web page.

A View can be thought of as a way to separate the presentation logic of a web page from the rest of the application's code. It typically contains HTML markup and placeholders for data that will be provided by the application.

A partial View, on the other hand, is a reusable portion of a View that can be included in other Views. It's essentially a smaller, self-contained View that can be used to render a specific portion of a web page.


## View Component

A View Component is a way to separate functionality and presentation logic into a self-contained component that can be easily reused across multiple views in a web application. It is essentially a combination of a controller action and a partial view, which can be used to render a specific part of a web page.

View Components can also be used for more complex functionality, such as retrieving data from a database or making API calls. By encapsulating this functionality into a self-contained component, you can make your code more modular and maintainable.


## HTML form and Razor syntax

HTML form is a way for a user to enter data and submit it to a web server for processing.

HTML forms are created using the <form> tag in HTML, and can contain various input fields such as text boxes, checkboxes, radio buttons, and drop-down lists. When a user submits a form, the data they entered is sent to the web server as a HTTP request, which can then be processed by server-side code.

In C# web development, the Razor syntax is a way to embed server-side code (such as C# code) into an HTML document. Razor syntax is used to generate dynamic content in a web page, such as retrieving data from a database and displaying it on the page, or processing data submitted through an HTML form.

Overall, HTML forms and C# Razor syntax are important tools for building dynamic, interactive web applications in C#. They allow you to create web pages that can accept user input, process data on the server, and generate dynamic content for display on the page.


## Domain Driven Design

Domain Driven Design (DDD) is an approach to software development that focuses on building software that closely models the real-world problem domain it is intended to solve.

This means that developers need to have a deep understanding of the domain they are building software for, and that the software they build should closely align with the concepts and terminology used in that domain.

Overall, Domain Driven Design is a powerful approach to software development that emphasizes the importance of building software that closely reflects the real-world problem domain it is intended to solve. By building software that accurately models the domain, developers can create software that is easier to understand, maintain, and evolve over time.


<!-- END CONTENT -->