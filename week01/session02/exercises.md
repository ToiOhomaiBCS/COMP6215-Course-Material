# Exercise 01

Looking at the code below, refactor this code to comply with the Single Responsibility Principle.  

Answer the following questions as a class or as the tutor comes around:

* How many things is this method doing?
* What is a key element that is missing for the program output

## Your Task:

* Refactor the code. 
* You are to create a new `Class` that holds all of the logic code.
* The Program is **only** allowed to hold the input and output of the program.
* Note that anything that is not UI related needs to be put into methods, no matter how small it is - so that it potentially can be used somewhere else.

```
private static void Main(string[] args)
{
    List<string> names = new List<string> { "Lisa", "Bob", "Stephen", "Ricky", "Christine" };

    Console.WriteLine("The number of people in this array is:");
    Console.WriteLine(names.Count);

    Console.WriteLine("Please add another name:");
    string name = Console.ReadLine();

    names.Add(name);

    Console.WriteLine("The names in the array list are:");
    
    foreach(string x in names)
    {
        Console.WriteLine(x);
    }

    Console.WriteLine("The number of people in this array is:");
    Console.WriteLine(names.Count);
}
```