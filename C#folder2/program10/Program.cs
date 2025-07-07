// See https://aka.ms/new-console-template for more information

//Strings and their methods
using System;

class Program
{
    static void Main(string[] args)
    {
        // Storing text using string
        string fullName = "Waseem Ahmed";
        string course = "C# Programming";

        Console.WriteLine("Full Name: " + fullName);
        Console.WriteLine("Course: " + course);

        // String Properties
        Console.WriteLine("\n--- String Properties ---");
        Console.WriteLine("Length of fullName: " + fullName.Length);  // Number of characters
        Console.WriteLine("First character of course: " + course[0]); // Indexing starts at 0

        // String Methods
        Console.WriteLine("\n--- String Methods ---");
        Console.WriteLine("ToUpper: " + fullName.ToUpper());
        Console.WriteLine("ToLower: " + fullName.ToLower());
        Console.WriteLine("Contains 'Ahmed': " + fullName.Contains("Ahmed"));
        Console.WriteLine("StartsWith 'Was': " + fullName.StartsWith("Was"));
        Console.WriteLine("EndsWith 'med': " + fullName.EndsWith("med"));
        Console.WriteLine("Index of 'Programming': " + course.IndexOf("Programming"));

        // Substring and Replace
        string shortName = fullName.Substring(0, 6);  // Extracts "Waseem"
        Console.WriteLine("Substring (0, 6): " + shortName);

        string updatedCourse = course.Replace("C#", "Java");
        Console.WriteLine("Replaced course: " + updatedCourse);

        // String Concatenation
        string message = "Welcome " + fullName + " to " + course + "!";
        Console.WriteLine("\n" + message);
    }
}

