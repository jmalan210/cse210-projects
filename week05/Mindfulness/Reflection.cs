public class Reflection : Activity
{

    private List<string> _prompts = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};

    private List<string> _availablePrompts; //working copy so randomizer doesn't permanently alter original list.
    private List<string> _questions = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _availableQuestions; //working copy so randomizer doesn't permanently alter original list.
    Random _randomPrompt = new Random();
    Random _randomQuestion = new Random();
    public Reflection()
        : base("This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.", "Well done on completing your reflection exercise!", "reflection")
    {
        _availablePrompts = new List<string>(_prompts);
        _availableQuestions = new List<string>(_questions);
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

    public string GetRandomQuestion()
    {
        if (_availableQuestions.Count == 0)
        {
            _availableQuestions = new List<string>(_questions);
        }

        int index = _randomQuestion.Next(_availableQuestions.Count);
        string question = _availableQuestions[index];
        _availableQuestions.RemoveAt(index);
        return question;
    }

    public void Run()
    {
        int duration =GetDuration();
        Console.WriteLine(GetRandomPrompt());
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(10);
        }
        Console.WriteLine("Done");
        ShowSpinner(3);
    
}

}