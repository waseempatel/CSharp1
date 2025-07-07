// See https://aka.ms/new-console-template for more information

//for and for-each loop
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] colors = { "Red", "Green", "Blue", "Yellow", "Orange" };

        // Looping using a for loop
        Console.WriteLine("Using for loop:");
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine($"colors[{i}] = {colors[i]}");
        }

        // Looping using a foreach loop
        Console.WriteLine("\nUsing foreach loop:");
        foreach (string color in colors)
        {
            Console.WriteLine("Color: " + color);
        }
    }
}
