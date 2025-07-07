// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // This is a single-line comment: declaring and initializing variables

        int age = 25;                   // integer variable
        double height = 5.9;            // double (floating point)
        char grade = 'A';               // character
        string name = "John Doe";       // string
        bool isStudent = true;          // boolean

        /*
         * Multi-line comment:
         * Below we are printing all the variables
         * to show their values on the console.
         */

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Is Student: " + isStudent);
    }
}

