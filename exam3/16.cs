using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class VehicleBase 
{
    public abstract void Drive();
}

class CarVehicle : VehicleBase  
{
    public override void Drive() => Console.WriteLine("Driving a car...");
}

class BikeVehicle : VehicleBase  
{
    public override void Drive() => Console.WriteLine("Riding a bike...");
}

class VehicleFactory
{
    public static VehicleBase GetVehicle(string type)
    {
        switch (type)
        {
            case "Car":
                return new CarVehicle();
            case "Bike":
                return new BikeVehicle();
            default:
                throw new ArgumentException("Invalid vehicle type");
        }
    }
}
/*
class Program
{
    static void Main()
    {
        VehicleBase myCar = VehicleFactory.GetVehicle("Car");
        VehicleBase myBike = VehicleFactory.GetVehicle("Bike");

        myCar.Drive();
        myBike.Drive();

        Console.ReadLine();
    }
}
*/