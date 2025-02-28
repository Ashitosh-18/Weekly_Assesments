using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}

class TimestampLogger : ILogger
{
    private readonly ILogger logger;
    public TimestampLogger(ILogger logger) => this.logger = logger;

    public void Log(string message)
    {
        logger.Log($"{DateTime.Now}: {message}");
    }
}
/*
class Program
{
    static void Main()
    {
        ILogger logger = new FileLogger();
        ILogger timestampLogger = new TimestampLogger(logger);

        logger.Log("System started.");
        timestampLogger.Log("System initialized.");

        Console.ReadLine();
    }
}
*/