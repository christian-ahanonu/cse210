using System;
using System.Net;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() {}

    public ReflectionActivity(List<string> prompts, List<string> questions)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {

        DisplayStartingMessage("2");

        Console.Clear();

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"---- {GetRandomPrompt()} ----\n");

        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.Clear();

        Console.Write("Now ponder on each of the following questions as they related to this experience. You may begin in: ");
        ShowCountDown(4);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("> ");
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(7);
        }

        Console.Clear();

        DisplayEndingMessage();
        ShowSpinner(4);

        Console.Clear();

    }


    public string GetRandomPrompt()
    {
        _prompts = new List<string>();

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);
        string selectedItem = _prompts[randomIndex];

        return selectedItem;
    }

    public string GetRandomQuestion()
    {
        _questions = new List<string>();

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();

        int randomIndex2 = random.Next(_questions.Count);
        string selectedItem2 = _questions[randomIndex2];

        return selectedItem2;
    }
}