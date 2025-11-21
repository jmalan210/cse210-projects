using System.Diagnostics.Contracts;

public class Activity
{
    private string _startMsg;
    private string _endMsg;
    private int _duration;
    private string _activity;

    public Activity(string startMsg, string endMsg, string activity)
    {
        _startMsg = startMsg;
        _endMsg = endMsg;
        _activity = activity;
    }

    public void DisplayStartMsg()
    {
        Console.WriteLine(_startMsg);
        Console.WriteLine("How many seconds would you like to spend on this activity?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndMsg()
    {
        Console.WriteLine(_endMsg);
        Thread.Sleep(3000);
        Console.WriteLine($"You spent {_duration} seconds on {_activity}.");
        Thread.Sleep(3000);
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown (int seconds)
    {
        
    }

}