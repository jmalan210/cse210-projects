public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        
    }

    public void DisplayAll()
    {   
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)

    {   
        Console.WriteLine($"Saving to file {file} ...");
        
        using (StreamWriter outputFile = new StreamWriter(file, true))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}, {e._promptText}, {e._entryText}");
            }
        
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine($"Retrieving {file} ...");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nDate: {date}\nPrompt: {prompt}\nEntry:{entry}\n");
            Console.ResetColor();

        }

    }


}
