class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}
/*
class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Console.WriteLine(math.Add(5, 10));  // Calls int version
        Console.WriteLine(math.Add(5.5, 2.5));  // Calls double version

        Console.ReadLine();
    }
}
*/