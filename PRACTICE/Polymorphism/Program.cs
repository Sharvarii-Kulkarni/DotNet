using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes sound");
    }
    public void Greet()
    {
        Console.WriteLine("Hello");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }

    public new void Greet()
    {
        Console.WriteLine("Dog waves");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Dog-:");
        Dog dog = new Dog();
        dog.MakeSound();
        dog.Greet();

        Console.WriteLine("Animal object");
        Animal aniref = new Animal();
        aniref.MakeSound();
        aniref.Greet();
    }
}