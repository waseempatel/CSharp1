// See https://aka.ms/new-console-template for more information

//String Concatenation
using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "Waseem";
        string lastName = "Ahmed";
        string course = "C# Programming";

        // Concatenation using + operator
        string fullName1 = firstName + " " + lastName;
        Console.WriteLine("Full Name using +: " + fullName1);

        // Concatenation using String.Concat method
        string fullName2 = String.Concat(firstName, " ", lastName);
        Console.WriteLine("Full Name using Concat: " + fullName2);

        // Concatenating more strings
        string message = "Welcome " + fullName1 + " to " + course + "!";
        Console.WriteLine("\nUsing + operator: " + message);

        string message2 = String.Concat("Welcome ", fullName2, " to ", course, "!");
        Console.WriteLine("Using Concat method: " + message2);
    }
}

