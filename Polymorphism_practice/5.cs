interface IAnimal
{
    void Speak();
}

abstract class Animall
{
    public abstract void Speak();
}

class Dogg : Animall, IAnimal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
/*
class Program
{
    static void Main()
    {
        Animall animal = new Dogg();
        animal.Speak();

        Console.ReadLine();
    }
}
*/