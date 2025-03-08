abstract class Logger
{
    public abstract void Log(string message);
}

class FileLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine("Logging to file: " + message);
    }
}

class ConsoleLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine("Logging to console: " + message);
    }
}
/*
class Program
{
    static void Main()
    {
        Logger logger = new FileLogger();
        logger.Log("Error in system.");

        logger = new ConsoleLogger();
        logger.Log("System restarted.");

        Console.ReadLine();
    }
}
*/