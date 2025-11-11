using System;
using System.Collections.Concurrent;
using System.Data;
using System.Security.Cryptography.X509Certificates;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }



    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReferenceDisplayText()
    {
        string text = $"{_book} {_chapter}:{_verse}";
        return text;

    }

}