using System.Diagnostics.Contracts;
using System.Dynamic;

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
        ShowSpinner(3);
        Console.WriteLine($"You spent {_duration} seconds on {_activity}.");
        ShowSpinner(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
            
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i>=animationStrings.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown (int seconds)
    {
        for(int i = seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}