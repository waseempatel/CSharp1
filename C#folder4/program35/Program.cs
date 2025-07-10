// See https://aka.ms/new-console-template for more information
using System;

// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Derived class
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

// Another derived class
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Base class object
        Animal myDog = new Dog();        // Polymorphism: base class reference, derived object
        Animal myCat = new Cat();        // Polymorphism

        myAnimal.MakeSound();  // Output: The animal makes a sound
        myDog.MakeSound();     // Output: The dog barks
        myCat.MakeSound();     // Output: The cat meows
    }
}

