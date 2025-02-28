using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting...");
    }
}

class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting...");
    }
}
/*
class Program
{
    static void Main()
    {
        Vehicle myCar = new Car();
        Vehicle myBike = new Bike();

        myCar.Start();
        myBike.Start();

        Console.ReadLine();
    }
}
*/
