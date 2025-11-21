public class Breathing : Activity
{
    public Breathing()
        :base("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Well done on completing your breathing exercise!", "breathing")
    {

    }

    public void Run()
    {
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);

        }


        Console.WriteLine("Done");
        ShowSpinner(3);
    }
}