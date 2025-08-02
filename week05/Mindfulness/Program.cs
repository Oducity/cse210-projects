using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.Write($"To navigate the menu:{Environment.NewLine}Breathing Activity: Type 1 and hit Enter key!{Environment.NewLine}Reflection Activity: Type 2 and hit Enter key!{Environment.NewLine}Listing Activity: Type 3 and hit Enter key! ");
        int menu = int.Parse(Console.ReadLine());
        int duration = 0;

        if (menu == 1)
        {
            Console.Write("How long do you want to spend on this activity in seconds? ");
            duration = int.Parse(Console.ReadLine());
            duration += 28;
            BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration, "Prepare to start the activity.", "Well done, great job!");
            activity1.DisplayIntro();
            for (int i = duration; i >= 0; i -= 12)
            {
                activity1.DisplayActivityMessage();
            }
            activity1.DisplayEndMessage();
        }
        else if (menu == 2)
        {

            ReflectionActivity activity2 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \n This will help you recognize the power you have and how you can use it in other aspect of life.", duration, "Prepare to start the activity.", "Well done! You have done great in this activity.");
            activity2.DisplayIntro();
            for (int i = duration; i >= 0; i -= 12)
            {
                activity2.GetRandomReflection();

            }
            activity2.DisplayEndMessage();
        }
        else if (menu == 3)
        {
            
        }
        
    }
}