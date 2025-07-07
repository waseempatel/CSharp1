// See https://aka.ms/new-console-template for more information

//operators to perform operations on variables and values for Arithmetic Operators,  Assignment Operators, Comparison Operators, Logical Operators
using System;

class Program
{
    static void Main(string[] args)
    {
        // Arithmetic Operators
        int num1 = 20, num2 = 6;
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("Addition: " + (num1 + num2));
        Console.WriteLine("Subtraction: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));
        Console.WriteLine("Division: " + (num1 / num2));
        Console.WriteLine("Modulus: " + (num1 % num2));

        // Assignment Operators
        int a = 10;
        a += 5;     // a = a + 5
        a *= 2;     // a = a * 2
        Console.WriteLine("\nAssignment Operators:");
        Console.WriteLine("Value of a after += and *= : " + a);

        // Comparison Operators
        int x = 15, y = 20;
        Console.WriteLine("\nComparison Operators:");
        Console.WriteLine("x == y: " + (x == y));
        Console.WriteLine("x != y: " + (x != y));
        Console.WriteLine("x > y: " + (x > y));
        Console.WriteLine("x < y: " + (x < y));
        Console.WriteLine("x >= y: " + (x >= y));
        Console.WriteLine("x <= y: " + (x <= y));

        // Logical Operators
        bool isLoggedIn = true;
        bool isAdmin = false;
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("isLoggedIn AND isAdmin: " + (isLoggedIn && isAdmin));
        Console.WriteLine("isLoggedIn OR isAdmin: " + (isLoggedIn || isAdmin));
        Console.WriteLine("NOT isAdmin: " + (!isAdmin));
    }
}
