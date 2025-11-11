using System.Collections.Concurrent;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

        string[] splitWords = _text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }

    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (numberToHide > visibleWords.Count)
            numberToHide = visibleWords.Count;  //limits removal to available words

        for (int i = 0; i<numberToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); //prevents same word from being hidden twice
        }
    }

    public string GetScriptureDisplayText()
    {
        string displayText = _reference.GetReferenceDisplayText() + ' ';
        foreach (Word word in _words)
        {
            displayText += word.GetWordsDisplayText() + ' ';
        }
        return displayText.Trim();

    }

    public bool EveryWordHidden()
    {
        return _words.All(w => w.IsHidden());
    }



}