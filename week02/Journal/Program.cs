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
            string fileName;


            // Comparison statement to check the menu value.
            if (menu == 1)
            {
                PromptGenerator generator = new PromptGenerator();  // Created the PromptGenerator class object.
                Entry entry1 = new Entry(); // Created the Entry class object.


                entry1._promptText = generator.GetRandomPrompt();  //Get random question from the GetRandomPrompt method and store it in the _promptText attribute in the Entry class.
                entry1._entryText = Console.ReadLine();  // Store the user response into the _entryText attribute in the Entry class.
                DateTime currentDate = DateTime.Now; // Get the current date from the computer and store it in the currentDate variable.
                entry1._date = currentDate.ToShortDateString(); // Re-assign the date to the _date attribute in the Entry class.
                journal.AddEntry(entry1); // Calling the AddEntry method from the Journal class and adding all entries to the Entry list including the date.
            }

            else if (menu == 2)
            {
                Console.WriteLine("List in journal is:");
                journal.DisplayAll();
            }

            else if (menu == 3)
            {
                Console.Write("Enter file name: ");
                fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }

            else if (menu == 4)
            {
                Console.Write("Enter the file name you want to load: ");
                fileName = Console.ReadLine();
                {
                    journal.LoadFromFile(fileName);
                }
            }

            else if (menu == 5)
            {
                break;
            }
        }
    }
}