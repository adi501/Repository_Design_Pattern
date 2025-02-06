# Repository Design Pattern

Ref: https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/#whats-a-repository-pattern

Git Code: https://github.com/adi501/Repository_Design_Pattern

![image](https://github.com/user-attachments/assets/c67a6c95-5539-4476-a4d4-8bdf12b3feb8)

# What is the Repository Design Pattern in C#?
The Repository Pattern is a design pattern commonly used in software development, including C# and .NET applications, to abstract and encapsulate the data access layer. It provides a structured way to interact with data storage, such as databases, without directly coupling the application’s business logic to the specific data access technology or implementation details. This separation of concerns improves your codebase’s maintainability, testability, and flexibility.
The Repository Design Pattern Mediates between the domain and the data mapping layers using a collection-like interface for accessing the domain objects.

# Why do we need the Repository Design Pattern in C#?
As we already discussed, nowadays, most data-driven applications need to access the data residing in one or more other data sources. Most of the time, data sources will be a database. Again, these data-driven applications need a good and secure strategy for data access to perform the CRUD operations against the underlying database. One of the most important aspects of this strategy is the separation between the actual database, queries, and other data access logic from the rest of the application. In our example, we must separate the data access logic from the Employee Controller. The Repository Design Pattern is one of the most popular design patterns to achieve such separation between the actual database, queries, and other data access logic from the rest of the application.

# What’s a Repository Pattern?
A Repository pattern is a design pattern that mediates data from and to the Domain and Data Access Layers ( like Entity Framework Core / Dapper). Repositories are classes that hide the logics required to store or retreive data. Thus, our application will not care about what kind of ORM we are using, as everything related to the ORM is handled within a repository layer. This allows you to have a cleaner seperation of concerns. Repository pattern is one of the heavily used Design Patterns to build cleaner solutions.

# Benefits of Repository Pattern ?
1) Reduces Duplicate Queries : Imagine having to write lines of code to just fetch some data from your datastore. Now what if this set of queries are going to be used in multiple places in the application. Not very ideal to write this code over and over again, right? Here is the added advantage of Repository Classes. You could write your data access code within the Repository and call it from multiple Controllers / Libraries. Get the point?

2) De-couples the application from the Data Access Layer : There are quite a lot of ORMs available for ASP.NET Core. Currently the most popular one is Entity Framework Core. But that change in the upcoming years. To keep in pace with the evolving technologies and to keep our Solutions upto date, it is highly crucial to build applications that can switch over to a new DataAccessTechnology with minimal impact on our application’s code base.
There can be also cases where you need to use multiple ORMs in a single solution. Probably Dapper to fetch the data and EFCore to write the data. This is solely for performance optimizations.Repository pattern helps us to achieve this by creating an Abstration over the DataAccess Layer. Now, you no longer have to depend on EFCore or any other ORM for your application. EFCore becomes one of your options rather than your only option to access data.
# Practical Use-Case of Repositories
While Performing CRUD Operations with Entity Framework Core, you might have noticed that the basic essence of the code keeps the same. Yet we write it multiple times over and over. The CRUD Operations include Create, Read, Update, and Delete. So, why not have a class / interface setup where you can generalize each of these operations.
