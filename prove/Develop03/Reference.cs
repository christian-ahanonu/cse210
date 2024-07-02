using System;

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

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // split the reference scipture 
    public Reference(string refer) //James 5:2 or James 5:2-3
    {
        string[] parts = refer.Split(' ');
        _book = parts[0];

        string[] chapter = parts[1].Split(':');
        _chapter = int.Parse(chapter[0]);

        string[] verse = chapter[1].Split('-');
        _verse = int.Parse(verse[0]);

        if (verse.Length > 1)
            _endVerse = int.Parse(verse[1]);
        else
            _endVerse = 0;


    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}