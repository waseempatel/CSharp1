// See https://aka.ms/new-console-template for more information

//Identifiers with small as well as descriptive names
using System;

class Program
{
    static void Main(string[] args)
    {
        string studentName = "Rahul Sharma";
        int studentAge = 20;
        double studentGPA = 8.6;
        char grade = 'A';
        bool isGraduated = false;

        // Displaying student information
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Age: " + studentAge);
        Console.WriteLine("GPA: " + studentGPA);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Graduated: " + isGraduated);
    }
}

