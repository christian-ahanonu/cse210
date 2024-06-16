using System;

class Program
{
    static void Main(string[] args)
    {

        string playAgain;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            // Console.Write("What is the Magic number? ");
            // string input = Console.ReadLine();
            // int magicNo = int.Parse(input);

            int guess = -1;
            int numberOfGuess = 0;


            while (guess != number)
            {
                Console.Write("What is your guess? ");
                // string input2 = Console.ReadLine();
                // int guessNo = int.Parse(input2);

                guess = int.Parse(Console.ReadLine());

                numberOfGuess += 1; 


                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    // break;
                }
            }

            Console.WriteLine($"You guessed right in {numberOfGuess} attempts.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        }
        
        while (playAgain == "yes");
        {
            Console.Write("Thanks you for playing!");
        }

       


















    }   
}