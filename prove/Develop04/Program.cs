// I kept track of the number of activities the user did.

using System;

class Program
{
    static void Main(string[] args) 
    {
        Activity active = new Activity();
        int activityCount = 0; // Keep count of the number of activities taken.

        while (true)
        {
            active.StartProgram();
            
            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity breathe = new BreathingActivity();
                breathe.Run();
                activityCount++;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.Run();
                activityCount++;
            }
            else if (choice == "3")
            {
                ListingActivity list = new ListingActivity();
                list.Run();
                activityCount++;
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                break;
            }

        }

        Console.WriteLine($"You have completed {activityCount} activities.");

        Console.WriteLine();
    }
}