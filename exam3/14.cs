using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

sealed class SecuritySystem
{
    public void Authenticate()
    {
        Console.WriteLine("Authenticating...");
    }
}
/*
class Program
{
    static void Main()
    {
        SecuritySystem security = new SecuritySystem();
        security.Authenticate();

        Console.ReadLine();
    }
}
*/