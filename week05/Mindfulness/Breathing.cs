public class Breathing : Activity
{
    public Breathing()
        :base("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Well done on completing your breathing exercise!", "breathing")
    {

    }

    public void Run()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(5000);
        Console.WriteLine("Breathe in...");
    }
}