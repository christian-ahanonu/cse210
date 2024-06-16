using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>(); 

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (input == "0")
                {
                    break;
                } 
            int askUser = int.Parse(input);
            userNumbers.Add(askUser);
        }

        int addNumbers = 0;
        double countList = 0;
        int largeNumber = -1;
        int smallPositive = 10000;
        
        userNumbers.Sort();

        foreach (int number in userNumbers)
        {
            addNumbers += number;  // Compute sum 

            countList = userNumbers.Count; // Compute Average 

            if (number >= largeNumber)  // Find the largest number
            {
                largeNumber = number;
            }

            // Stretch Challenge
            if (number <= smallPositive && number > 0)
            {
                smallPositive = number; // Find the smallest positive number
            }

        }
        
        // Print sum 
        Console.WriteLine($"The sum is: {addNumbers}");

        // Print Average 
        double average = addNumbers / countList;
        Console.WriteLine($"The average is: {average}");

        // Print largest number
        Console.WriteLine($"The largest number is: {largeNumber}");

        // Print the smallest positive number
        Console.WriteLine($"The smallest positive number is: {smallPositive}");

        // Sorted list
        Console.WriteLine("The sorted list is:");
        foreach (int number in userNumbers)
        {
            Console.WriteLine(number);

        }





























    }
}