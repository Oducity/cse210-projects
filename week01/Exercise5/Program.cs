using System;
using System.Globalization;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        float favoriteNumber = PromptUserNumber();
        float SNumber = favoriteNumber;
        float squareResult = SquareNumber(SNumber);
        DisplayResult(name, squareResult);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }




        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string userName = Console.ReadLine();
            return userName;
        }


        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }


        static float SquareNumber(float SNumber)
        {
            float result = SNumber * SNumber;
            return result;
        }


        static void DisplayResult(string userName, float squareResult)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareResult}");
        }
    }
}