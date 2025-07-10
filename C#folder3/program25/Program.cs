// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static int Square(int num)
    {
        return num * num;
    }

    static void Main()
    {
        int result = Square(4);
        Console.WriteLine("Square of 4 is: " + result);
    }
}

