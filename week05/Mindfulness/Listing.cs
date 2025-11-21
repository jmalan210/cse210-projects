using System.Runtime.CompilerServices;

public class Listing : Activity

{
    private int _count;
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are the people that you  have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _availablePrompts; //working copy so randomizer does not alter original list
    Random _randomPrompt = new Random();
    public Listing()
    : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Well done on completing your listing exercise!", "listing")
    {
        _availablePrompts = new List<string>(_prompts);
    }

    public string GetRandomPrompt()
    {
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
        }

        int index = _randomPrompt.Next(_availablePrompts.Count);
        string prompt = _availablePrompts[index];
        _availablePrompts.RemoveAt(index);
        return prompt;
    }


    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int i = 1;
        while (DateTime.Now < endTime)
        {
            Console.Write($"{i}.");
            string input = Console.ReadLine();
            userList.Add(input);
            i++;
        }
        return userList;
    }
    
    public void Run()
    {
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(5);
        List<string> displayList = GetListFromUser();
        Console.WriteLine("Done");
        ShowSpinner(3);
       _count = displayList.Count();
        Console.Write($"You listed {_count} items.");
    }
    
}