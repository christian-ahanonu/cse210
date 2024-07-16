using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() {}

    public ListingActivity(List<string> prompt)
    {
        _count = 0;
        _prompts = prompt;
    }

    public void Run()
    {
        DisplayStartingMessage("3");

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:" + "\n");

        string prompt = GetRandomPrompt();
        Console.WriteLine("---- " + prompt + " ----");

        Console.Write("\nYou may begin in ");
        ShowCountDown(4);

        Console.WriteLine();

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"\nYou have entered {_count} items");

        DisplayEndingMessage();
        ShowSpinner(7);

        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>  
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];

        return prompt;
    }

    public List<string> GetListFromUser()
    {        
        List<string> userList = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrEmpty(entry))
            {
                userList.Add(entry);            
            }
        }
        
        return userList;
    }
} 