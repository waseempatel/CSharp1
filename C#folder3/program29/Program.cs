// See https://aka.ms/new-console-template for more information
using System;

class Car
{
    // Fields
    public string color = "Black";
    public int maxSpeed = 180;
}

class Program
{
    static void Main()
    {
        // Create an object of the Car class
        Car myObj = new Car();

        // Print field values
        Console.WriteLine("Car color: " + myObj.color);
        Console.WriteLine("Max speed: " + myObj.maxSpeed);
    }
}

