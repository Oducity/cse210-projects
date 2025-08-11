using System;
using System.ComponentModel.Design;

// To exceed requirement, I created code that checks and display
// congratulatory message for completing any of the goal.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}