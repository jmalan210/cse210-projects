public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"\n\nDate: {_date}\nPrompt: {_promptText}\nEntry: {_entryText}\n");
        Console.ResetColor();
    }

}