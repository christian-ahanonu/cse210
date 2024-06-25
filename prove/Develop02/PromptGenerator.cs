using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        string promptQuestion1 = "What was the best part of my day?"; 
        string promptQuestion2 = "What was the strongest emotion I felt today?"; 
        string promptQuestion3 = "Who was the most interesting person I interacted with today and why?"; 
        string promptQuestion4 = "What am I grateful for today and why?"; 
        string promptQuestion5 = "If I had one thing I could do over today what would it be?"; 
        string promptQuestion6 = "How did I see the hand of the Lord in my life today?"; 
        string promptQuestion7 = "What is something interesting I learnt today?"; 
        string promptQuestion8 = "What could I have done better today?"; 

        // Add all prompts questions to the _prompt list
        _prompts.Add(promptQuestion1);
        _prompts.Add(promptQuestion2);
        _prompts.Add(promptQuestion3);
        _prompts.Add(promptQuestion4);
        _prompts.Add(promptQuestion5);
        _prompts.Add(promptQuestion6);
        _prompts.Add(promptQuestion7);
        _prompts.Add(promptQuestion8);


        // Use the random class to generate a random prompt from the list
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string promptRandom = _prompts[promptIndex];

        return promptRandom;
    }

    
}
