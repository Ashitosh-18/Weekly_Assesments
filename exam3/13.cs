using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bank
{
    public static double InterestRate { get; private set; } = 3.0;

    public static void SetInterestRate(double rate)
    {
        InterestRate = rate;
        Console.WriteLine($"New Interest Rate set to: {InterestRate}%");
    }
}
/*
class Program
{
    static void Main()
    {
        Console.WriteLine($"Default Interest Rate: {Bank.InterestRate}%");
        Bank.SetInterestRate(4.5);

        Console.ReadLine();
    }
}
*/
