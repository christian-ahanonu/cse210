using System;
using System.ComponentModel.DataAnnotations;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Entrys(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        
    }

    public void Display()
    {
        Console.WriteLine($"""
        {_date} 
        {_promptText} 
        > {_entryText}
        """);
    }
    
}

