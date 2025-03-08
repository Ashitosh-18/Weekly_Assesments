using System;

class Account
{
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Calculating interest in base account...");
    }
}

class SavingsAccount : Account
{
    public sealed override void CalculateInterest()
    {
        Console.WriteLine("Calculating interest in savings account...");
    }
}
/*
class Program
{
    static void Main()
    {
        SavingsAccount acc = new SavingsAccount();
        acc.CalculateInterest();

        Console.ReadLine();
    }
}
*/
