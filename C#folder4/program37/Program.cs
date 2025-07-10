// See https://aka.ms/new-console-template for more information
using System;

// First interface
interface IAnimal
{
    void Eat();
}

// Second interface
interface IBird
{
    void Fly();
}

// Class implements both interfaces
class Parrot : IAnimal, IBird
{
    public void Eat()
    {
        Console.WriteLine("The parrot eats seeds.");
    }

    public void Fly()
    {
        Console.WriteLine("The parrot flies high in the sky.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parrot myParrot = new Parrot();

        myParrot.Eat();  // Output: The parrot eats seeds.
        myParrot.Fly();  // Output: The parrot flies high in the sky.
    }
}

