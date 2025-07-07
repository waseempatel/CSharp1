// See https://aka.ms/new-console-template for more information

//User Input for diff typed of inputs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your gender (M/F): ");
        char gender = Convert.ToChar(Console.ReadLine());

        // Displaying the collected input
        Console.WriteLine("\n--- User Information ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height + " meters");
        Console.WriteLine("Gender: " + gender);
    }
}

