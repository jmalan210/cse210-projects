using System.Diagnostics.Contracts;

public class Activity
{
    private string _startMsg;
    private string _endMsg;
    private int _duration;

    public Activity()
    {
        

    }

    public void DisplayStartMsg()
    {

        if (this is Breathing)
        {
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }
        else if (this is Reflection)
        {
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }
        else if (this is Listing)
        {
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }        

        Console.WriteLine("How many seconds would you like to practice mindfulness today?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndMsg()
    {
        Console.WriteLine(_endMsg);
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown (int seconds)
    {
        
    }

}