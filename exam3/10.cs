using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class User
{
    public string Username { get; set; }
    public virtual void AccessControl()
    {
        Console.WriteLine("Access control for user.");
    }
}

class Admin : User
{
    public override void AccessControl()
    {
        Console.WriteLine("Admin has full access.");
    }
}

class Customer : User
{
    public override void AccessControl()
    {
        Console.WriteLine("Customer has limited access.");
    }
}
/*
class Program
{
    static void Main()
    {
        User admin = new Admin();
        User customer = new Customer();

        admin.AccessControl();
        customer.AccessControl();

        Console.ReadLine();
    }
}
*/
