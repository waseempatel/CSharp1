// See https://aka.ms/new-console-template for more information

//Looping Statements
using System;

class Program
{
    static void Main(string[] args)
    {
        // FOR loop: print numbers from 1 to 5
        Console.WriteLine("For Loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        // WHILE loop: print numbers from 1 to 5
        Console.WriteLine("\nWhile Loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine("j = " + j);
            j++;
        }

        // DO-WHILE loop: print numbers from 1 to 5
        Console.WriteLine("\nDo-While Loop:");
        int k = 1;
        do
        {
            Console.WriteLine("k = " + k);
            k++;
        } while (k <= 5);

        // FOREACH loop: print elements of an array
        Console.WriteLine("\nForeach Loop:");
        string[] fruits = { "Apple", "Banana", "Mango", "Orange" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }
    }
}
