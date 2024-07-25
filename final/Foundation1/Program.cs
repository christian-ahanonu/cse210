using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();


        Video video1 = new("Open a PayPal account", "TechGuy", 300);
        video1.AddComment(new Comment("Steven Randall", "Great video"));
        video1.AddComment(new Comment("James Daniels", "It's easier than I expected! Thank you."));
        video1.AddComment(new Comment("Grace Parker", "Your instructions are on point"));

        Video video2 = new("The New Anthem", "Brain Jotter", 1456);
        video2.AddComment(new Comment("Daddyawesome5001", "I so love this brain jotter so much... using content to pass valid message using comedy"));
        video2.AddComment(new Comment("Elizabeth Clinton", "What is the last singer name please?"));
        video2.AddComment(new Comment("Blessing Sunday", "I really enjoyed it ooooo"));

        Video video3 = new("Underwater Constructions | How do Engineers Make Them?", "Lesics", 555); 
        video3.AddComment(new Comment("MaxRemKing1", "I spent so many years as a child imagining how they did this! It's good to finally know how it's really done."));
        video3.AddComment(new Comment("MichalKing478", "Its crazy how much effort goes into building a single pier. Lovely explanation and summary of the whole process. Ive always wondered how this is done when looking at a bridge"));
        video3.AddComment(new Comment("Tranqulity8", "Thanks for educating us like this Lesics! this educational content is really valuable!"));

        List<Video> videos = new() {video1, video2, video3};

        foreach (var watch in videos)
        {
            Console.WriteLine($"Title: {watch._title}");
            Console.WriteLine($"Author: {watch._author}");
            Console.WriteLine($"Length: {watch._length} seconds");
            Console.WriteLine($"No of Comments: {watch.GetCommentCount()}");
            Console.WriteLine();

            foreach(var comment in watch.GetComments())
            {
                Console.WriteLine($"""
                Commenter's Name: {comment._name}
                Comment: {comment._text}
                """);
                Console.WriteLine();  
                
            }

        }

        
    }
}