using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IPrintable
{
    void Print();
}

interface ISerializable
{
    void Save();
}

class Report : IPrintable, ISerializable
{
    public void Print()
    {
        Console.WriteLine("Printing report...");
    }

    public void Save()
    {
        Console.WriteLine("Saving report...");
    }
}
/*
class Program
{
    static void Main()
    {
        Report report = new Report();
        report.Print();
        report.Save();

        Console.ReadLine();
    }
}
*/
