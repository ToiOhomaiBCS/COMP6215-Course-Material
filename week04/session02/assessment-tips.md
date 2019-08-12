---
course: COMP6215
week: 04
lesson: 02
topic: assessment-tips
---

[![Print](https://img.shields.io/badge/DOWNLOAD_PDF-CLICK_HERE-blue.svg)](https://github.com/ToiOhomaiBCS/COMP6215-Course-Material/raw/master/week04/session02/assessment_tips.pdf)

# Nesting multiple projects for your assignment

// Need screenshots for these

# Pulling in JSON Data from remote API

Importing data into a project from a JSON string requires a few steps. There are a number of tools that can help with this, but they all require the same basis once you have the data. Here I will outline the steps that you will need when you are using the `NewtonSoft.JSON` package.

## 1. Install the Newtonsoft Package

Go to the nuget package manager under the tools menu and select the cli tool

```
Install-Package Newtonsoft.Json -Version 12.0.2
```

## 2. Setup your models and loop through the data

Next you will need to create a model that mirrors all of the properties of the data you are pulling in:

You can find the Models and some demo code that you require here:

[demo.cs](demo.cs)

When you run that code, you will see that is pulls down the data from the API.