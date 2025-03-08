abstract class Vehicle
{
    public abstract void Move();
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car moves on road.");
    }
}

class Airplane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Airplane flies in the sky.");
    }
}
/*
class Program
{
    static void Main()
    {
        Vehicle v1 = new Car();
        v1.Move();

        Vehicle v2 = new Airplane();
        v2.Move();

        Console.ReadLine();
    }
}
*/
