// See https://aka.ms/new-console-template for more information

//break and continue statements
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Using break in a loop:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                Console.WriteLine("Breaking the loop at i = " + i);
                break; // Exit the loop when i is 6
            }
            Console.WriteLine("i = " + i);
        }

        Console.WriteLine("\nUsing continue in a loop:");

        for (int j = 1; j <= 10; j++)
        {
            if (j % 2 == 0)
            {
                continue; // Skip even numbers
            }
            Console.WriteLine("j = " + j); // Only odd numbers will be printed
        }
    }
}

