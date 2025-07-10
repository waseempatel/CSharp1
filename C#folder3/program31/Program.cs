// See https://aka.ms/new-console-template for more information
using System;

class Car
{
    // Fields
    public string color;
    public int maxSpeed;

    // Constructor with parameters
    public Car(string carColor, int carSpeed)
    {
        color = carColor;
        maxSpeed = carSpeed;
    }

    // Method to display details
    public void DisplayInfo()
    {
        Console.WriteLine("Car color: " + color);
        Console.WriteLine("Max speed: " + maxSpeed + " km/h");
    }

    static void Main(string[] args)
    {
        // Create objects using the constructor
        Car myCar1 = new Car("Red", 200);
        Car myCar2 = new Car("Blue", 180);

        // Display info
        Console.WriteLine("Car 1:");
        myCar1.DisplayInfo();

        Console.WriteLine("\nCar 2:");
        myCar2.DisplayInfo();
    }
}

