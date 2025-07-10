// See https://aka.ms/new-console-template for more information
using System;

class Car
{
    // Public field: accessible from outside the class
    public string brand = "Toyota";

    // Private field: only accessible within the class
    private int maxSpeed = 200;

    // Public method to access private field
    public void ShowDetails()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Max Speed: " + maxSpeed + " km/h");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();

        // Accessing public field directly
        Console.WriteLine("Car Brand: " + myCar.brand);

        // Cannot access private field directly (will give error if uncommented)
        // Console.WriteLine(myCar.maxSpeed);

        // Accessing private field via public method
        myCar.ShowDetails();
    }
}

