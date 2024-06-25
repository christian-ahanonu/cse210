using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;



public class Journal
{
    public List<Entry> _entries = new List<Entry>(); // Hold all responses from the user



    public void AddEntry(Entry newEntry) // receive and store the user response into the _entries list
    {
        _entries.Add(newEntry);
    }



    public void DisplayAll() // Display all entries
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }



    public void SaveToFile(string file) // save all entries to a file
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}, {entry._promptText}, '{entry._entryText}'");
            }
        }
    }

    public void LoadFromFile(string file) // load all entries
    {
        _entries.Clear(); // Clear the current entries before loading new ones

        using (StreamReader reader = new StreamReader(file))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split(',');

                Entry entry = new Entry();
                {
                    entry._date = line[0];
                    entry._promptText = line[1];
                    entry._entryText = line[2];
                }
                _entries.Add(entry);
            }
        }
    }
}