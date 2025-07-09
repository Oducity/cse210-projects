using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();//Created Journal class object and assigned it, journal.
        int menu = 0; //Initialize menu to 0.

        while (menu != 5) // Create menu comparison loop.
        {

            Console.WriteLine("Enter a MENU number and hit Enter button:");
            Console.WriteLine("To Write: Press 1");
            Console.WriteLine("To Display: Press 2");
            Console.WriteLine("To Save: Press 3");
            Console.WriteLine("To Load: Press 4");
            Console.WriteLine("To Quit: Press 5");
            Console.Write("What do you want to do? ");//Take menu input from the user.
            menu = Convert.ToInt32(Console.ReadLine());//Re-assign the user input to the menu variable.
            
        }
    }
}