// See https://aka.ms/new-console-template for more information
using System;

// Base class (Parent)
class Vehicle
{
    public string brand = "Ford";  // Vehicle field

    public void honk()             // Vehicle method
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

// Derived class (Child)
class Car : Vehicle
{
    public string modelName = "Mustang";  // Car field
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (inherited from Vehicle)
        myCar.honk();

        // Display the value of brand and modelName
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}

