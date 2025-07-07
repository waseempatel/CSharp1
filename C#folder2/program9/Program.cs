// See https://aka.ms/new-console-template for more information

//C# Program: Using Math Class Methods
using System;

class Program
{
    static void Main(string[] args)
    {
        double number = 16.75;
        int a = -10, b = 25;

        // Square root
        Console.WriteLine("Square root of " + number + " is " + Math.Sqrt(number));

        // Power
        Console.WriteLine("2 raised to the power 3 is " + Math.Pow(2, 3));

        // Round to nearest whole number
        Console.WriteLine("Rounded value of " + number + " is " + Math.Round(number));

        // Ceiling and Floor
        Console.WriteLine("Ceiling of " + number + " is " + Math.Ceiling(number)); // Round up
        Console.WriteLine("Floor of " + number + " is " + Math.Floor(number));     // Round down

        // Absolute value
        Console.WriteLine("Absolute value of a is " + Math.Abs(a));

        // Min and Max
        Console.WriteLine("Minimum of a and b is " + Math.Min(a, b));
        Console.WriteLine("Maximum of a and b is " + Math.Max(a, b));

        // Trigonometric functions (angle in radians)
        double angle = Math.PI / 4;  // 45 degrees
        Console.WriteLine("Sin(45°): " + Math.Sin(angle));
        Console.WriteLine("Cos(45°): " + Math.Cos(angle));
        Console.WriteLine("Tan(45°): " + Math.Tan(angle));
    }
}

