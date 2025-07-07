// See https://aka.ms/new-console-template for more information

//Array declaration and initialization
using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Declare and initialize an array directly
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Accessing elements of numbers array:");
        Console.WriteLine("First element: " + numbers[0]);   // Access first element
        Console.WriteLine("Third element: " + numbers[2]);   // Access third element

        Console.WriteLine("\nIterating through numbers array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"numbers[{i}] = {numbers[i]}");
        }

        // 2. Create an array using the 'new' keyword and initialize later
        string[] fruits = new string[3];  // Array of size 3

        // Assign values to the array elements
        fruits[0] = "Apple";
        fruits[1] = "Banana";
        fruits[2] = "Mango";

        Console.WriteLine("\nAccessing elements of fruits array created using new:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }

        // 3. Declare and initialize with new keyword in one line
        double[] prices = new double[] { 9.99, 19.99, 29.99 };

        Console.WriteLine("\nPrices array:");
        foreach (double price in prices)
        {
            Console.WriteLine("Price: $" + price);
        }
    }
}
