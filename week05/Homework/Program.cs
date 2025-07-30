using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Oducity", "Inheritance");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine("--------------------------------------------------------------------------------");

        MathAssignment mathAssignment = new MathAssignment("Odumamwen Henry", "Addition", "6.3", "5 + 2");
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        Console.WriteLine("--------------------------------------------------------------------------------");

        WritingAssignment writingAssignment = new WritingAssignment("Evans Aisiokuebor", "The Obaship History", "The Origin of The Dynasty of Oba");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}