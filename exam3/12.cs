using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Manager
{
    public string Name { get; set; }
}

class Department
{
    public string Name { get; set; }
    public Manager Manager { get; set; }

    public Department ShallowCopy()
    {
        return (Department)this.MemberwiseClone();
    }

    public Department DeepCopy()
    {
        return new Department { Name = this.Name, Manager = new Manager { Name = this.Manager.Name } };
    }
}
/*
class Program
{
    static void Main()
    {
        Department dept1 = new Department { Name = "HR", Manager = new Manager { Name = "Ramesh" } };
        Department dept2 = dept1.ShallowCopy();
        Department dept3 = dept1.DeepCopy();

        dept1.Manager.Name = "Suresh"; 

        Console.WriteLine($"Shallow Copy Manager: {dept2.Manager.Name}"); 
        Console.WriteLine($"Deep Copy Manager: {dept3.Manager.Name}"); 

        Console.ReadLine();
    }
}
*/