// See https://aka.ms/new-console-template for more information
using System;

class Person
{
    private string name;  // Field

    public string Name    // Property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}

