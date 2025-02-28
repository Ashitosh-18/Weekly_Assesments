using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }
}
/*
class Program
{
    static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(2, 4);
        ComplexNumber c2 = new ComplexNumber(1, 8);
        ComplexNumber result = c1 + c2;

        Console.WriteLine($"Result: {result.Real} + {result.Imaginary}i");

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
*/