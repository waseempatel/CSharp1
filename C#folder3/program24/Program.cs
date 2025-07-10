// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Method with single parameter
    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    // Method with multiple parameters
    static void AddNumbers(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, sum);
    }

    // Method with default parameter
    static void DisplayInfo(string name, int age = 18)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main(string[] args)
    {
        // Calling method with one parameter
        Greet("Alice");

        // Calling method with multiple parameters
        AddNumbers(10, 20);

        // Calling method with and without default parameter
        DisplayInfo("Bob", 25);   // Both parameters given
        DisplayInfo("Charlie");   // Only name given, age uses default (18)
    }
}

