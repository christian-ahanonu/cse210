using System;

public class Resume
{
    public string _name = "";
    public List<Job> _userJobs = new List<Job>();

    public void DisplayName()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job x in _userJobs)
        {
            x.DisplayJob();
        }
    }
}