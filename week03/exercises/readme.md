---
course: COMP6215
week: 03
lesson: 02
topic: Exercises
---

[![Print](https://img.shields.io/badge/DOWNLOAD_PDF-CLICK_HERE-blue.svg)](https://github.com/ToiOhomaiBCS/COMP6215-Course-Material/raw/master/week03/exercises/readme.pdf)

# Exercise 1 - LisKov

Create a new application and create a single class of a person. This person can have a job, but some jobs have different requirements. The person needs to have an name and an age (keep things simple).

For example a Police Officer can make an arrest, but a person who is not an officer cannot do this.

The jobs this application has to cover are:

* Teacher - can mark assignments
* Student - can submit assignments
* Officer - can issue a ticket

You are to write to code in such a way that a **type** of person can be implemented as an **instance** of one of the 3 three classes above.

You are then required to create a list of type person that can view one of each person with their respective methods.

# Exercise 2 - LisKov

Create an application that does some basic caluclations. You are to create a base class that that has a method in there called `Answer` that takes a list of numbers and then returns a number based on the type of calculation. 

Create a series of subclasses that execute the method of `Answer` but workout the application differently.
The list of numbers need to be either added, multiplied, divided or subtracted in each of their respective classes.

The classes are:

* Addition
* Multiplication
* Substraction
* Division

Remember to focus on what your method requires as an input and what it returns to the user.

# Exercise 3 - Interface Segregation

Refactor Exercise 1 to use interfaces instead of subclasses

# Exercise 4 - Interface Segregation

Refactor Exercise 2 to use interfaces instead of subclasses

# Exercise 5 - Class Discussion

Have a dicussion on the following question:

Is your programming style in your head changing a bit, now that you are going through these principles? How? Why?