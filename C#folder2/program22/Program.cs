// See https://aka.ms/new-console-template for more information

//2D array
using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize a 2D array
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Original 2D Array:");
        for (int row = 0; row < matrix.GetLength(0); row++)       // GetLength(0) -> number of rows
        {
            for (int col = 0; col < matrix.GetLength(1); col++)   // GetLength(1) -> number of columns
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        // Access a specific element
        Console.WriteLine("\nElement at [1,2]: " + matrix[1, 2]);  // 6

        // Change a specific element
        matrix[2, 1] = 88;

        Console.WriteLine("\nModified 2D Array (after changing element at [2,1] to 88):");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

