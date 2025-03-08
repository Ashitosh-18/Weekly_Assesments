using System;

class vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class car : vehicle
{
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("This is a car.");
    }
}

class bike : vehicle
{
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("This is a bike.");
    }
}
/*
class Program
{
    static void Main()
    {
        Car car = new Car { Brand = "Tesla", Speed = 150 };
        Bike bike = new Bike { Brand = "Honda", Speed = 90 };

        car.DisplayInfo();
        bike.DisplayInfo();

        Console.ReadLine();
    }
}*/

