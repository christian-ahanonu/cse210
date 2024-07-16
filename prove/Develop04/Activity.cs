using System;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;


    public Activity() {}

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public Activity(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }

    public void DisplayStartingMessage(string response)
    {
        if (response == "1")
        {
            _name = "Breathing";
            Console.WriteLine($"Welcome to the {_name} Activity\n");

            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");

            Console.Write("How long in seconds would you like your session: ");
            _duration = int.Parse(Console.ReadLine());

        }
        else if (response == "2")
        {
            _name = "Reflection";
            Console.WriteLine($"Welcome to the {_name} Activity\n");

            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life.\n");

            Console.Write("How long in seconds would you like your session: ");
            _duration = int.Parse(Console.ReadLine());

        }
        else if (response == "3")
        {   
            _name = "Listing";
            Console.WriteLine($"Welcome to the {_name} Activity\n");

            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");

            Console.Write("How long in seconds would you like your session: ");
            _duration = int.Parse(Console.ReadLine());
        }   
    }



    public void DisplayEndingMessage()
    {
        Console.Clear();

        Console.WriteLine("Well done\n");

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");   
    }



    public void ShowSpinner(int seconds)
    {
        List<string> spinners = new List<string>();
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("|");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinners[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinners.Count)
            {
                i = 0;
            }
        }
    }



    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(2000);
            Console.Write("\b \b");
        }
    }


    public void StartProgram()
    {
        Console.WriteLine("\nMindfulness Program\n");
        Console.WriteLine("""
            1. Start breathing activity
            2. Start reflection activity
            3. Start listing activity
            4. Quit
            """ + "\n");

        Console.Write("Select a choice from the menu: ");
    }


}