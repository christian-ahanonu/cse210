using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("342 Adam St", "Springfield", "IL", "62701");
        Address address2 = new Address("456 Elm St", "Shelbyville", "UT", "62702");
        Address address3 = new Address("789 Oak St", "Capital City", "IL", "62703");

        // Create events
        Lecture lecture = new Lecture("Photography", "Exposure Triangle", new DateTime(2024, 8, 5), "09:00 AM", address1, "Steve Gerald", 150);
        Reception reception = new Reception("Music/Art Festival", "A display of art and music.", new DateTime(2024, 8, 6), "04:00 PM", address2, "rsvp@example.com");
        OutdoorGathering     outdoorGathering = new OutdoorGathering("Love Hikers", "A hiking activity for Love Hikers community.", new DateTime(2024, 8, 7), "07:00 AM", address3, "Mostly Sunny");

        // Display marketing messages
        Console.Clear(); 
        Console.WriteLine("Event Details: \n");
        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine();
        }
    }
}
