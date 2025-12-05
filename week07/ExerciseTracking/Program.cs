using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Dec 2025", 30, 3);
        activities.Add(running);

        Swimming swimming = new Swimming("04 Dec 2025", 25, 30);
        activities.Add(swimming);

        Cycling cycling = new Cycling("05 Dec 2025", 45, 10);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}