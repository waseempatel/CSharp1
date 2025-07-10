// See https://aka.ms/new-console-template for more information
using System;

// Abstract class
abstract class Animal
{
    // Abstract method (no body)
    public abstract void MakeSound();

    // Regular method
    public void Sleep()
    {
        Console.WriteLine("Zzz...");
    }
}

// Derived class (must implement the abstract method)
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.MakeSound();  // Output: The dog barks
        myDog.Sleep();      // Output: Zzz...
    }
}

