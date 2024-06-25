// I added more prompts in the PromptGenerator class
// I added the ability for users to save file into what format they choose by using "."
   // after the name of the file. Eg Wonderland.txt

using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        PromptGenerator prompts  = new PromptGenerator();
        Journal journal = new Journal();
        Entry entryInst = new Entry();

        Console.WriteLine("Welcome to the Journal Program!\n");


        while (true)
        {
            
            Console.WriteLine("Please select one of the following choice:");
        
            Console.WriteLine("""
            1. Write a new entry
            2. Display all entries
            3. Save entries
            4. Load entries
            5. Exit 
            """);

            Console.Write("What would you like to do? ");
            string response = Console.ReadLine();

            Console.WriteLine();

            if (response == "1")
            {
                string prompt = prompts.GetRandomPrompt();
                Console.WriteLine($"Your prompt is: {prompt}");
                Console.Write("Enter your response: ");
                string response1 = Console.ReadLine();
                entryInst.Entrys(DateTime.Now.ToShortDateString(), prompt, response1); //= new Entry(DateTime.Now.ToString(), prompt, response1);
                journal.AddEntry(entryInst);

                Console.WriteLine();

            }

            else if (response == "2")
            {
                journal.DisplayAll();

                Console.WriteLine();
            }
            
            else if (response == "3")
            {
                Console.Write("""
                Enter filename to save (add ''.'' after filename 
                to save in a specific format such as txt, docx, JSON, etc. 
                eg. Summer-Holiday.txt): 
                """);
                
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);

                Console.WriteLine();

            }

            else if (response == "4")
            {
                Console.Write("Enter the filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);

                Console.WriteLine();
            }

            
            else if (response == "5")
            {
                break;
            }

            else if (response == null)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            
            else
            {
                Console.WriteLine("Invalid Choice!");

                Console.WriteLine();
            }

        }

    }
}