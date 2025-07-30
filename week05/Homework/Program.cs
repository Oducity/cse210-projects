using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Oducity", "Inheritance");
        Console.WriteLine(assignment.GetSummary());
    }
}