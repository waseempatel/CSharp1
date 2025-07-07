// See https://aka.ms/new-console-template for more information

//using Ternary Operator
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ternary operator syntax: condition ? trueValue : falseValue
        string result = (age >= 18) ? "You are eligible to vote." : "You are not eligible to vote.";
        Console.WriteLine(result);

        // Another example: checking if a number is even or odd
        Console.Write("\nEnter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string type = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine("The number is " + type);
    }
}

