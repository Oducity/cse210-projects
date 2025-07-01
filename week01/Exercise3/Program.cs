using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Guess My Number Game Project.");

        Console.Write("What is the magic number? "); // request for input from the player.
        int magicNumber = int.Parse(Console.ReadLine()); //convert the user input to an int and store in a variable guessNumber.

        int guess = 0; // initialized guess to 0.

        while (magicNumber != guess) //Created a loop that keep looping till the comparison is correct.
        {
            Console.Write("What is your guess? "); //requested for guess input from user.
            guess = int.Parse(Console.ReadLine()); //converted user input and in int variable guess.


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
                Console.WriteLine($"You guessed it: {guess}");
            }
        }

        //Random randomGenerator = new Random(); //Create Random object.
        //int number = randomGenerator.Next(1, 20); //Pick random number between 1 to 20 and store in a int variable number.

            //while (number != 0)
            //{

            //}
            //Console.WriteLine(number)

    }
}