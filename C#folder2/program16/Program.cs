﻿// See https://aka.ms/new-console-template for more information

//Switch Statement
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number (1 to 7) for a day of the week: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            case 4:
                Console.WriteLine("Thursday");
                break;

            case 5:
                Console.WriteLine("Friday");
                break;

            case 6:
                Console.WriteLine("Saturday");
                break;

            case 7:
                Console.WriteLine("Sunday");
                break;

            default:
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                break;
        }
    }
}

