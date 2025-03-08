using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Manager : Employee
{
    public double Bonus { get; set; }

    public Manager(string name, double salary, double bonus) : base(name, salary)
    {
        Bonus = bonus;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Manager: {Name}, Salary: {Salary}, Bonus: {Bonus}");
    }
}
/*
class Program
{
    static void Main()
    {
        Manager mgr = new Manager("Alice", 50000, 10000);
        mgr.DisplayInfo();

        Console.ReadLine();
    }
}
*/