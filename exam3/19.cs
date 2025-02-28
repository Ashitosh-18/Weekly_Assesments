using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface INotificationObserver
{
    void Update(string message);
}

class EmailNotifier : INotificationObserver
{
    public void Update(string message) => Console.WriteLine($"Email Notification: {message}");
}

class SMSNotifier : INotificationObserver
{
    public void Update(string message) => Console.WriteLine($"SMS Notification: {message}");
}

class NotificationService
{
    private readonly List<INotificationObserver> observers = new List<INotificationObserver>();

    public void AddObserver(INotificationObserver observer) => observers.Add(observer);
    public void NotifyAll(string message) => observers.ForEach(o => o.Update(message));
}
/*
class Program
{
    static void Main()
    {
        NotificationService service = new NotificationService();
        service.AddObserver(new EmailNotifier());
        service.AddObserver(new SMSNotifier());

        service.NotifyAll("New promotion available!");

        Console.ReadLine();
    }
}
*/
