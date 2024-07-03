using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        List<string> scriptReferences = new List<string>();
        List<string> verseText = new List<string>();

        Console.WriteLine("Scripture Memorizer");

        Console.Write("\nEnter the scripture reference: ");
        string text = Console.ReadLine();
        scriptReferences.Add(text);

        Console.WriteLine("\nEnter the scripture text: ");
        string text2 = Console.ReadLine();
        verseText.Add(text2);

        Scripture scripture = new Scripture(scriptReferences[0], verseText[0]);

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress enter to hide more words or type 'quite' to end the program.\n");



        while (!scripture.IsCompletelyHidden() && Console.ReadLine() != "quite")
        {
            scripture.HideRandomWords(2);

            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide more words or type 'quite' to end the program.");
        }
        
        Console.WriteLine();
    }
}

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    // scripture constructor
    public Scripture(string refer, string text)
    {
        _reference = new Reference(refer);

        _words = new List<Word>();

        string[] textArray = text.Split(',');
        foreach (string w in textArray)
        {
            _words.Add(new Word(w)); // add the splitted scripture text to the _words list
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = rand.Next(_words.Count);
            _words[randomIndex].Hide(); // randomly selects a word and hide it
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n"; // display the scripture reference

        foreach (Word w in _words)
        {
            displayText += w.GetDisplayText();
        }
        
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}


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


public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }


    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}