using System;
using System.Runtime.CompilerServices;

class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        DisplayWelcome();
        Console.WriteLine();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        Console.WriteLine();
        DisplayResult(userName, userNumber);

        Console.WriteLine();
    }

    // displays welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Ask the user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");

        string userName = Console.ReadLine();
        return userName;
    }

    // Ask the user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");

        int userNumber = Convert.ToInt16(Console.ReadLine());
        return userNumber * userNumber;
    }

    // Display both the name and square of their fav number.
    static void DisplayResult(string userName, int userNumber)
    {
        Console.WriteLine($"Brother {userName}, the square of your number is {userNumber}");
    }


}