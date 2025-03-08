// See https://aka.ms/new-console-template for more information
using System;
class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class Car : Vehicle { }

class Bike : Vehicle { }
/*
class Program
{
    static void Main()
    {
        Car car = new Car { Brand = "Toyota", Speed = 120 };
        Bike bike = new Bike { Brand = "Yamaha", Speed = 80 };

        car.DisplayInfo();
        bike.DisplayInfo();

        Console.ReadLine();
    }
}*/

