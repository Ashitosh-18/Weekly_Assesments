class BaseClass
{
    public void Display()
    {
        Console.WriteLine("Base class method");
    }
}

class DerivedClass : BaseClass
{
    public new void Display()
    {
        Console.WriteLine("Derived class method");
    }
}
/*
class Program
{
    static void Main()
    {
        BaseClass obj = new DerivedClass();
        obj.Display(); // Calls BaseClass method since it is not virtual

        Console.ReadLine();
    }
}
*/