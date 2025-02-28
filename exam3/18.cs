using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConfigurationManager
{
    private static ConfigurationManager instance;
    private static readonly object lockObj = new object();

    private ConfigurationManager() { }

    public static ConfigurationManager GetInstance()
    {
        lock (lockObj)
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }
    }
}
/*
class Program
{
    static void Main()
    {
        ConfigurationManager config1 = ConfigurationManager.GetInstance();
        ConfigurationManager config2 = ConfigurationManager.GetInstance();

        Console.WriteLine(ReferenceEquals(config1, config2) ? "Singleton works!" : "Singleton failed.");

        Console.ReadLine();
    }
}
*/
