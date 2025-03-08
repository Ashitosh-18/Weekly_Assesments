using System;

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows: Meow Meow!");
    }
}
/*
class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.MakeSound();
        cat.MakeSound();

        Console.ReadLine();
    }
}
*/