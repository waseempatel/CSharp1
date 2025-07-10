// See https://aka.ms/new-console-template for more information

using System;

class Car
{
    // Field
    public string color = "Red";
}

class Program
{
    static void Main()
    {
        // Create object
        Car myobj = new Car();

        // Access and print the value of color
        Console.WriteLine("The color of the car is: " + myobj.color);
    }
}
