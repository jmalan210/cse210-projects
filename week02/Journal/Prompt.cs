public class Prompt
{
    public List<string> _prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today what would it be?", "What am I grateful for today?", "How did I serve someone today?", "Something I would like to do tomorrow is:", "Something that I hope will happen soon is:", "Where would you live if you could live anywhere in the world and why?", "What is a spiritual attribute you would like to develop?", "Who or what makes you smile and why?", "What is a goal you are working toward?"};

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomPromptIndex = randomPrompt.Next(_prompts.Count);
        string generatedPrompt = _prompts[randomPromptIndex];
        
        return generatedPrompt;
    }
}