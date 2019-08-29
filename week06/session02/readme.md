---
course: COMP6215
week: 06
lesson: 02
topic: setting-up-mvc-project
---

[![Print](https://img.shields.io/badge/DOWNLOAD_PDF-CLICK_HERE-blue.svg)](https://github.com/ToiOhomaiBCS/COMP6215-Course-Material/raw/master/week06/session02/readme.pdf)

# Setting up Controllers

Within an asp.net core project, generally each model has its own controller.

In this project we are going to have a look at updating a fake rest api and see what the processes are for each of the route types.

Every controller has the following parts:

**Defining the controller**

```
namespace jsonpg01.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JsonController : ControllerBase
```

**Setting up the Context**

_In this case, we mocking the context by making a static list_

```
private  static List<Post> _context = null;
private static string MyData = "";
```

**A Constructor**

This loads the context with the initial data

```
public JsonController()
{
  
}
```

**Routing Attributes**

```
[HttpGet]
[HttpGet("{id}")]
[HttpPost]
[HttpPut("{id}")]
[HttpDelete("{id}")]
```

## Other Things....

**Setting up your Model**

This should be done before you create the controller and if you have an existing JSON string, it is very easy to do with the help of [http://json2csharp.com/](http://json2csharp.com/)

**Using Linq**

Although it is possible to get the data you want in other ways, using Linq can make things a lot easier:

```
//Select a post by a matching ID
Post post = _context.First(x => x.id == id);

// Get all posts that match the same id
List<Post> posts = _context.Where(all => all.id == id).ToList();
```

**Use the debugger**

VSCode has a great debugger build in, and you can (and should) make use of it.

```
System.Diagnostics.Debug.WriteLine($"COUNTING => {_context.Count}");
```

## Creating our first api

API usually connect to a database and therefore the data is persistent, but let's have a look using a mock api before we go there.

For this task, the following extensions will come in handy:

* ASP.NET Core Snippets by rahulsahay.csharp-aspnetcore
* C# by ms-vscode.csharp
* C# Extensions by jchannon.csharpextensions
* C# Snippets by jorgeserrano.vscode-csharp-snippets

You can look them up, or create an extension.json file with the following code and find them in the recommendations:

```
{
	"recommendations": [
		"rahulsahay.csharp-aspnetcore",
    "ms-vscode.csharp",
    "jchannon.csharpextensions",
    "jorgeserrano.vscode-csharp-snippets"
		]
}
```

We will use the following api for our example:

```
https://jsonplaceholder.typicode.com/posts
```

