using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Library
{
   
    private List<Scripture> _scriptures = new();

    public void Load()
    {
        string jsonData = File.ReadAllText("Library.json");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        List<ScriptureData> data = JsonSerializer.Deserialize<List<ScriptureData>>(jsonData, options);

        foreach (var d in data)
        {
            Reference r = new Reference(d.Book, d.Chapter, d.StartVerse, d.EndVerse);
            Scripture s = new Scripture(r, d.Text);
            _scriptures.Add(s);
        }
    }

    public void DisplayAll()
    {
        foreach (var s in _scriptures)
        {
            Console.WriteLine(s.GetScriptureDisplayText());
            Console.WriteLine();
        }
    }
// nested class allows data to be deserialized and reconstructed 
    private class ScriptureData
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int? _endVerse;
        private string _text;

        public ScriptureData(string book, int chapter, int startVerse, int? endVerse, string text)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
            _text = text;
        }

        public string Book => _book;
        public int Chapter => _chapter;
        public int StartVerse => _startVerse;
        public int? EndVerse => _endVerse;
        public string Text => _text;

    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
            return null;

        Random randomScrip = new Random();
        int index = randomScrip.Next(_scriptures.Count);
        return _scriptures[index];
    }
}