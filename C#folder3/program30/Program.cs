// See https://aka.ms/new-console-template for more information
using System;

class Car
{
    string color;     // Field
    int maxSpeed;     // Field

    public void fullThrottle()  // Method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
        Car myObj = new Car();  // Create an object of Car
        myObj.fullThrottle();   // Call the method
    }
}

