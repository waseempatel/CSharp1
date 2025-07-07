// See https://aka.ms/new-console-template for more information

//String Interpolation
using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "Waseem";
        string lastName = "Ahmed";
        string course = "C# Programming";

        // Using string interpolation to form full name
        string fullName = $"{firstName} {lastName}";
        Console.WriteLine("Full Name using interpolation: " + fullName);

        // Creating a welcome message using interpolation
        string message = $"Welcome {fullName} to {course}!";
        Console.WriteLine("Message: " + message);

        // Interpolating expressions directly
        int completedLessons = 5;
        int totalLessons = 10;
        string progress = $"You have completed {completedLessons} out of {totalLessons} lessons.";
        Console.WriteLine(progress);
    }
}

