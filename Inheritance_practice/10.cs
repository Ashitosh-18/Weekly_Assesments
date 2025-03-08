using System;

sealed class SecuritySystem
{
    public void AuthenticateUser()
    {
        Console.WriteLine("User authenticated.");
    }
}

// Uncommenting below will cause an error
// class AdvancedSecuritySystem : SecuritySystem { }

class Program
{
    static void Main()
    {
        SecuritySystem secSys = new SecuritySystem();
        secSys.AuthenticateUser();

        Console.ReadLine();
    }
}

