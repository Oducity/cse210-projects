using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? "); //Request the user first name
        string firstName = Console.ReadLine(); // Define string variable firstName, read and store user input into the string variable.

        Console.Write("What is your last name? "); //Requested for user last name.
        string lastName = Console.ReadLine(); // Define string variable lastName, read and store user input into the string variable.

        Console.WriteLine($"Your names is {lastName}, {firstName} {lastName}.");
    }
}