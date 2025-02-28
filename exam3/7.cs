using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
    public double Add(double a, double b) => a + b;
}
/*
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();  
        Console.WriteLine($"Add(2, 3): {calc.Add(2, 3)}");
        Console.WriteLine($"Add(2, 3, 4): {calc.Add(2, 3, 4)}");
        Console.WriteLine($"Add(2.5, 3.7): {calc.Add(2.5, 3.7)}");

        Console.ReadLine();
    }
}
*/
