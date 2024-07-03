using System;

class Program
{
    static void Main(string[] args)
    {

        WritingAssignment assignment = new WritingAssignment("Christian Ahanonu", "History of Nigeria", 
        "The Amalgamation of Nigeria");

        Console.WriteLine("\n" + assignment.GetSummary());
        Console.WriteLine(assignment.GetWritingInformation() + "\n");


        MathAssignment assignment2 = new MathAssignment("Christian Ahanonu", "Algebra", "Section 17.3", 
        "Problems 1-10");
        
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeWorkList() + "\n");




    }
}