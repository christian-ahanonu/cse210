using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() {}

    public void Run()
    {
        DisplayStartingMessage("1");

        Console.Clear();

        Console.WriteLine("Get ready....");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {

            Console.WriteLine();
            Console.Write("Breathe in....");
            ShowCountDown(3);

            Console.WriteLine();
            Console.Write("Now Breadth out....");
            ShowCountDown(3);     

            Console.WriteLine();
        }

        Console.Clear();

        DisplayEndingMessage();
        ShowSpinner(7);

        Console.Clear();
    }
}
