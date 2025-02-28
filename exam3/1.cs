using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public double GetBalance()
    {
        return balance;
    }
}
/*
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(500);
        account.Withdraw(200);
        account.Withdraw(400);

        Console.ReadLine();
    }
}

*/

