using System;
using System.ComponentModel.Design;
using System.Transactions;

// In order to exceed core requirement, I stored the user responses in a list
//asked the user to see the list and at the user's authorization, the list is
// displayed to the screen.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        int menu = 0;
        while (menu != 4)
        {
            Console.Write($"To navigate the menu:{Environment.NewLine}  1: Breathing Activity{Environment.NewLine}  2: Reflection Activity{Environment.NewLine}  3: Listing Activity{Environment.NewLine}  4: Quit {Environment.NewLine}Type a menu number and hit 'ENTER KEY'.   ");
            menu = Int32.Parse(Console.ReadLine());
            int duration = 0;
            if (menu == 1)
            {
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Prepare to start the activity.", "Well done, great job!");
                activity1.DisplayIntro();
                duration = activity1.GetDuration();

                activity1.GetPreparationMessage();

                for (int i = duration; i > 0; i -= 13)
                {
                    activity1.DisplayBreathingMessage();

                }
                activity1.DisplayEndMessage();

            }
            else if (menu == 2)
            {
                ReflectionActivity activity2 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspect of life.", "Prepare to start the activity.", "Well done! You have done great in this activity.");
                activity2.DisplayIntro();
                activity2.GetPreparationMessage();

                for (int i = 1; i >= 0; i++)
                {
                    activity2.GetRandomReflection();
                    i -= activity2.GetTimeSpent();

                }
                activity2.DisplayEndMessage();
            }
            else if (menu == 3)
            {
                ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Prepare to start this activity", "That was wonderful, You have done well!");
                activity3.DisplayIntro();
                activity3.GetPreparationMessage();

                int duration3 = activity3.GetDuration();
                int timeSpent = activity3.GetTimeSpent();
                while (duration3 > timeSpent)
                {
                    activity3.GetRandomPrompt();
                    timeSpent = activity3.GetFinalTimeSpent();
                }
                activity3.DisplayEndMessage();
                Thread.Sleep(7000);
                Console.WriteLine("Enter 'YES' to check your list or 'QUIT' to quit. ");
                string ans = Console.ReadLine().ToLower();
                if (ans == "yes")
                {
                    Console.Clear();
                    activity3.GetItemsInList();
                }
                else break;

            }
        }

    }
}