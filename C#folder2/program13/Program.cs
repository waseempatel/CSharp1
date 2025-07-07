// See https://aka.ms/new-console-template for more information

//Access Strings
using System;

class Program
{
    static void Main(string[] args)
    {
        string message = "Hello, World!";

        // Accessing characters by index
        Console.WriteLine("First character: " + message[0]);      // 'H'
        Console.WriteLine("Last character: " + message[message.Length - 1]);  // '!'

        // Iterating through all characters in the string
        Console.WriteLine("\nAll characters:");
        foreach (char ch in message)
        {
            Console.Write(ch + " ");
        }

        // Substring: extract part of the string
        string part = message.Substring(7, 5);  // Starts at index 7, length 5
        Console.WriteLine("\n\nSubstring (7,5): " + part);  // "World"

        // IndexOf: find the position of a character or substring
        int index = message.IndexOf('W');
        Console.WriteLine("Index of 'W': " + index);

        // LastIndexOf: find the last occurrence
        int lastIndex = message.LastIndexOf('l');
        Console.WriteLine("Last index of 'l': " + lastIndex);
    }
}

