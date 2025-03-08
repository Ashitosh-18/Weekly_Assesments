class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent class");
    }
}

class Child : Parent
{
    public override void Show()
    {
        Console.WriteLine("Child class");
    }
}
/*
class Program
{
    static void Main()
    {
        Parent obj = new Child();
        obj.Show();

        Console.ReadLine();
    }
}
*/
