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

        try
        {
            Console.Clear();
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Unable to clear the console: {ex.Message}");
        }

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress enter to hide more words or type 'quite' to end the program.\n");

        Random random = new Random();

        while (!scripture.IsCompletelyHidden() && Console.ReadLine() != "quite")
        {
            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3, random);

                try
                {
                    Console.Clear();
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Unable to clear the console: {ex.Message}");
                }

                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to hide more words or type 'quite' to end the program.");
            }
        }
        
        Console.WriteLine();
    }
}