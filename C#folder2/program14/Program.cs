// See https://aka.ms/new-console-template for more information

//if else
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your marks (0 - 100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 90)
        {
            Console.WriteLine("Grade: A+");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 40)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: Fail");
        }
    }
}
