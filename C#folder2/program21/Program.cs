// See https://aka.ms/new-console-template for more information

//Array methods
using System;
using System.Linq;  // Required for Min, Max, Sum

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 25, 10, 5, 30, 15 };

        // Original array
        Console.WriteLine("Original array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        // Sort the array in ascending order
        Array.Sort(numbers);

        Console.WriteLine("\n\nSorted array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        // Find the minimum value
        int min = numbers.Min();
        Console.WriteLine($"\n\nMinimum value: {min}");

        // Find the maximum value
        int max = numbers.Max();
        Console.WriteLine("Maximum value: " + max);

        // Find the sum of all elements
        int total = numbers.Sum();
        Console.WriteLine("Sum of elements: " + total);
    }
}

