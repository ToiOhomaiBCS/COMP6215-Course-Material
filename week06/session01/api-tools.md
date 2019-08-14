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

