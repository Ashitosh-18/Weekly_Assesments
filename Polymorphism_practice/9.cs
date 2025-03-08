class Aniimal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Doog : Aniimal
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
        Aniimal a = new Doog();
        a.Speak(); // Output: "Dog barks"

        Console.ReadLine();
    }
}
*/
