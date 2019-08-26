---
course: COMP6215
week: 06
lesson: 01
topic: intro-aspnetcore
---

[![Print](https://img.shields.io/badge/DOWNLOAD_PDF-CLICK_HERE-blue.svg)](https://github.com/ToiOhomaiBCS/COMP6215-Course-Material/raw/master/week06/session01/readme.pdf)


# What is an API

An api (Application Programming Interface) in its most simplest form is how 2 parts of software communicate together, this could be anything from creating a button to combining multiple pieces of software together.

The type of API we are going to look at is a web api. Specifically on how we can connect a Database to a piece of client software.

It is possible to connect a Database directly to an application and as long as the application is on the same network or if the database is exposed directly to the internet then we do not need a web api. However both of these cases are limited in how they can be used and very vunerable to attacks.

By creating a web api we can ask for certain data to be returned from a database or for a user to submit data to a database without the appllication having a direct connection to it.

# API Tools

To be able to check our api we need to have some extra tools in our developer toolbox.

A very popular one is called [postman](https://www.getpostman.com/downloads/) and we will use that for most of the time.

There are plenty of ReST clients availabl and we use some directly inside of Visual Studio Code.

* [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) by humao.rest-client
* [Simple REST Client](https://marketplace.visualstudio.com/items?itemName=Tino.simple-rest-client) by Tino.simple-rest-client

To install Postman, you will need admin rights for your machine. You will not need that if you are using the VSCode extensions.

With these tools we are able to test the apis we are going to create.

# How does it all work

When we run the web api server, we do not see a traditional webpage that might expect when going to a normal URL.
What we see is a string with data. That string is a format called JSON and that string is made of Key Value pair sets of data.

Why JSON?

Well when we loop over a set of data it will be done so as a collection (Array, Lists, Dictionaries). These coillections are objects that are made up of several parts and are therefore difficult to transprt as a single object.

JSON is a string that holds the data structure of your collection.

JSON = JavaScript Object Notation and if you look at some JSON data you will see a pattern of these Key Value pairs.

Although there are other types of API's that we can create, ASP.net Core is design from the ground up to support JSON and MVC based ReST API



