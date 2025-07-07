// See https://aka.ms/new-console-template for more information

//Type Casting (Implicit and Explicit Casting)
using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicit Casting (smaller to larger type) — done automatically
        int num = 100;
        double result = num;  // int to double
        Console.WriteLine("Implicit Casting (int to double): " + result);

        char letter = 'A';
        int asciiValue = letter;  // char to int
        Console.WriteLine("Implicit Casting (char to int): " + asciiValue);

        // Explicit Casting (larger to smaller type) — requires cast operator
        double salary = 12345.67;
        int roundedSalary = (int)salary;  // double to int
        Console.WriteLine("Explicit Casting (double to int): " + roundedSalary);

        float pi = 3.14159f;
        byte smallValue = (byte)pi;  // float to byte
        Console.WriteLine("Explicit Casting (float to byte): " + smallValue);
    }
}

