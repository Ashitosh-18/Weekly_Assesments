class CompileTimePolymorphism
{
    public void Display()
    {
        Console.WriteLine("No parameters");
    }

    public void Display(int a)
    {
        Console.WriteLine("Parameter: " + a);
    }
}

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
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
        // Compile-Time Polymorphism 
        CompileTimePolymorphism obj = new CompileTimePolymorphism();
        obj.Display();
        obj.Display(10);

        // Run-Time Polymorphism 
        Animal a = new Dog();
        a.Speak();

        Console.ReadLine();
    }
}
*/