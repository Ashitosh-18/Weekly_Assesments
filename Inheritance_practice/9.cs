using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public virtual double GetDiscountedPrice()
    {
        return Price;
    }
}

class ElectronicProduct : Product
{
    public override double GetDiscountedPrice()
    {
        return Price * 0.90; // 10% discount
    }
}

class ClothingProduct : Product
{
    public override double GetDiscountedPrice()
    {
        return Price * 0.80; // 20% discount
    }
}
/*
class Program
{
    static void Main()
    {
        Product laptop = new ElectronicProduct { Name = "Laptop", Price = 1000 };
        Product shirt = new ClothingProduct { Name = "Shirt", Price = 50 };

        Console.WriteLine($"Laptop discounted price: {laptop.GetDiscountedPrice()}");
        Console.WriteLine($"Shirt discounted price: {shirt.GetDiscountedPrice()}");

        Console.ReadLine();
    }
}
*/
