using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IDiscountStrategy
{
    double ApplyDiscount(double amount);
}

class NoDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double amount) => amount;
}

class PercentageDiscount : IDiscountStrategy
{
    private readonly double percentage;
    public PercentageDiscount(double percentage) => this.percentage = percentage;

    public double ApplyDiscount(double amount) => amount - (amount * percentage / 100);
}

class FixedAmountDiscount : IDiscountStrategy
{
    private readonly double discount;
    public FixedAmountDiscount(double discount) => this.discount = discount;

    public double ApplyDiscount(double amount) => amount - discount;
}

class ShoppingCart
{
    private readonly IDiscountStrategy discountStrategy;

    public ShoppingCart(IDiscountStrategy strategy) => discountStrategy = strategy;

    public double Checkout(double amount) => discountStrategy.ApplyDiscount(amount);
}
/*
class Program
{
    static void Main()
    {
        ShoppingCart cart1 = new ShoppingCart(new NoDiscount());
        ShoppingCart cart2 = new ShoppingCart(new PercentageDiscount(10));
        ShoppingCart cart3 = new ShoppingCart(new FixedAmountDiscount(50));

        Console.WriteLine($"No Discount: {cart1.Checkout(500)}");
        Console.WriteLine($"10% Discount: {cart2.Checkout(500)}");
        Console.WriteLine($"Fixed Discount: {cart3.Checkout(500)}");

        Console.ReadLine();
    }
}
*/
