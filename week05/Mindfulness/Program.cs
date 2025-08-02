using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.Write("How long do you want to spend on this activity in seconds? ");
        int duration = int.Parse(Console.ReadLine());
        duration += 28;
        BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration, "Prepare to start the activity.", "Well done, great job!");
        activity1.DisplayIntro();
        for (int i = duration; i >= 0; i -= 12)
        {
            activity1.DisplayActivityMessage();
        }
        activity1.DisplayEndMessage();
        
    }
}