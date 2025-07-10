// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void ShowDetails(string name, int age, string city)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }

    static void Main()
    {
        // Using named arguments (order doesn't matter)
        ShowDetails(age: 25, city: "New York", name: "Alice");

        // You can also mix named and positional arguments (named ones must come after positional)
        ShowDetails("Bob", city: "Chicago", age: 30);
    }
}

