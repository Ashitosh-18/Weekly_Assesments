using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public virtual void GetDetails()
    {
        Console.WriteLine("This is a person.");
    }
}

class Stu : Person
{
    public string Name { get; set; }
    public int RollNo { get; set; }

    public override void GetDetails()
    {
        Console.WriteLine($"This is a student. Name: {Name}, Roll No: {RollNo}");
    }
}

class Teacher : Person
{
    public override void GetDetails()
    {
        Console.WriteLine("This is a teacher.");
    }
}
/*
class Program
{
    static void Main()
    {
        Person person = new Person();
        Person student = new Stu { Name = "Alice", RollNo = 101 };
        Person teacher = new Teacher();

        person.GetDetails();
        student.GetDetails();
        teacher.GetDetails();

        Console.ReadLine();
    }
}
*/