// See https://aka.ms/new-console-template for more information

//Data types to specify the size and type of variable values.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Integer types
        byte age = 25;               // 1 byte: 0 to 255
        short year = 2025;           // 2 bytes: -32,768 to 32,767
        int salary = 50000;          // 4 bytes: -2,147,483,648 to 2,147,483,647
        long population = 1400000000L; // 8 bytes: append 'L' for long literals

        // Floating-point types
        float height = 5.8f;         // 4 bytes: append 'f' for float
        double weight = 72.5;        // 8 bytes
        decimal price = 999.99m;     // 16 bytes: high precision, use 'm'

        // Character and boolean
        char grade = 'A';            // 2 bytes: single Unicode character
        bool isPassed = true;        // 1 byte: true or false

        // String (sequence of characters)
        string fullName = "Anjali Mehta";

        // Displaying the values
        Console.WriteLine("Age (byte): " + age);
        Console.WriteLine("Year (short): " + year);
        Console.WriteLine("Salary (int): " + salary);
        Console.WriteLine("Population (long): " + population);
        Console.WriteLine("Height (float): " + height);
        Console.WriteLine("Weight (double): " + weight);
        Console.WriteLine("Price (decimal): " + price);
        Console.WriteLine("Grade (char): " + grade);
        Console.WriteLine("Passed (bool): " + isPassed);
        Console.WriteLine("Full Name (string): " + fullName);
    }
}

