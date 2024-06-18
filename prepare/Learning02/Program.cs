using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();


        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2015;
        job1._endYear = 2018;
        // job1.DisplayJob();       

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // job2.DisplayJob();       

        Resume resume = new Resume();
        resume._name = "Christian Ahanonu";

        resume._userJobs.Add(job1);
        resume._userJobs.Add(job2);

        resume.DisplayName();

        


        // string printJob = resume._userJobs[1];
        // Console.WriteLine(printJob);

    

















        Console.WriteLine();
    }

}