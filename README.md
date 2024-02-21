# Notes that I took from this learning path
_This repo plans to serve as a cheatsheet or a notebook with practical examples that explain the use of design patterns in software development._

I'm using C# console applications with __.NET 8.0__

## What's a Design pattern
In software engineering, a design pattern is a general repeatable solution to a commonly occurring problem in software design. It represents best practices evolved over time by experienced software developers. Design patterns can speed up the development process by providing tested, proven development paradigms. Reusing design patterns helps to prevent subtle issues that can cause major problems and improves code readability for developers who are familiar with the patterns.

Design patterns can be categorized into three main types:

1. __Creational Patterns__: These patterns deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. Examples include the Singleton, Factory Method, and Abstract Factory patterns.

2. __Structural Patterns__: These patterns focus on the composition of classes or objects to form larger structures. Examples include the Adapter, Composite, and Decorator patterns.

3. __Behavioral Patterns__: These patterns are concerned with the interaction and responsibility of objects. They define patterns of communication between classes and objects. Examples include the Observer, Strategy, and Command patterns.

## Creational Patterns

### Builder pattern
> There is an example in the Creational project

Some objects are simple and can be created in a single constructor call. This pattern makes easy and productive the construction of any object, specially when you need a lot of arguments to create that object.

