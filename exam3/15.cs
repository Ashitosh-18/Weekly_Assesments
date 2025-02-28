using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void ClickHandler();

class Button
{
    public event ClickHandler OnClick;

    public void Click()
    {
        Console.WriteLine("Button clicked!");
        OnClick?.Invoke();
    }
}
/*
class Program
{
    static void Main()
    {
        Button button = new Button();
        button.OnClick += () => Console.WriteLine("Event triggered: Button was clicked.");
        button.Click();

        Console.ReadLine();
    }
}
*/
