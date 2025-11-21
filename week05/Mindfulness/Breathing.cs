public class Breathing : Activity
{

    
    public Breathing(User user)
        :base("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Well done on completing your breathing exercise!", "breathing", user)
    {

    }

    public void Run()
    {
        Console.WriteLine($"Okay {GetUserName()}, prepare to begin...");
        ShowSpinner(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("\nBreathe out...");
            ShowCountDown(6);

        }


        Console.WriteLine("\nDone\n");
        ShowSpinner(3);
    }
}