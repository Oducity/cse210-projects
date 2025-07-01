using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Guess My Number Game Project.");

        Console.Write("What is the magic number? "); // request for input from the player.
        int guessNumber = int.Parse(Console.ReadLine()); //convert the user input to an int and store in a variable guessNumber.

        Random randomGenerator = new Random(); //Create Random object.
        int number = randomGenerator.Next(1, 20); //Pick random number between 1 to 20 and store in a int variable number.

        while (number != 0)
        {
            
        }
        Console.WriteLine(number);

    }
}