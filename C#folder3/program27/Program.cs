// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    // Method with one int parameter
    static void Display(int num)
    {
        Console.WriteLine("Integer value: " + num);
    }

    // Method with one double parameter
    static void Display(double num)
    {
        Console.WriteLine("Double value: " + num);
    }

    // Method with two parameters
    static void Display(string text, int count)
    {
        Console.WriteLine("Text: " + text + ", Count: " + count);
    }

    static void Main()
    {
        Display(10);              // Calls int version
        Display(3.14);            // Calls double version
        Display("Hello", 5);      // Calls string + int version
    }
}
