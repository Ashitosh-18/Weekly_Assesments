using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    private string name;
    private int rollNo;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                Console.WriteLine("Name cannot be empty.");
        }
    }

    public int RollNo
    {
        get { return rollNo; }
        set
        {
            if (value > 0)
                rollNo = value;
            else
                Console.WriteLine("Roll number cannot be negative.");
        }
    }
}
/*
class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "Alice";
        student.RollNo = 10;
        Console.WriteLine($"Student Name: {student.Name}, Roll No: {student.RollNo}");

        Console.ReadLine();
    }
}
*/
