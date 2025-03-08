abstract class Payment
{
    public abstract void ProcessPayment();
}

class CreditCard : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing payment via Credit Card...");
    }
}

class PayPal : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing payment via PayPal..."); 
    }
}
/*
class Program
{
    static void Main()
    {
        Payment payment1 = new CreditCard();
        payment1.ProcessPayment();

        Payment payment2 = new PayPal();
        payment2.ProcessPayment();

        Console.ReadLine();
    }
}
*/