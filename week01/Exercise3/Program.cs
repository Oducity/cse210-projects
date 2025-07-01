using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Console.WriteLine("Hello World! This is the Exercise3 Guess Random Number Game Project.");

            Random randomGenerator = new Random(); //Create Random object.
            int magicNumber = randomGenerator.Next(1, 100); //Pick random number between 1 to 100 and store in an int variable magicNumber.

            int guess = 0; // initialized guess to 0.
            int guessCount = 0;

            while (magicNumber != guess) //Created a loop that keep looping till the comparison is correct.
            {
                Console.Write("What is your guess? "); //requested for guess input from user.
                guess = int.Parse(Console.ReadLine()); //converted user input and in int variable guess.
                guessCount += 1;


                // Compare guess with magicNumber.
                if (guess > magicNumber)
                {
                    Console.WriteLine("Guess Lower!");
                }

                else if (guess < magicNumber)
                {
                    Console.WriteLine("Guess higher!");
                }

                else
                {
                    Console.WriteLine($"You guessed it: you guessed {guessCount} times.");
                }
            }
            Console.Write("Do you want to repay? ");
            response = Console.ReadLine();

        } while (response == "yes");
    }
}