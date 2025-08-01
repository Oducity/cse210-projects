using System;

// To exceed requirement, I added code to keep track and display to
// the user the numbers of hidden words until the user presses quit or
// until the program ends.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("1 Nephi", 1, 9);
        string passage = "And it came to pass that he saw One descending out of the midst of heaven, and he beheld that his luster was above that of the sun at noon-day.";


        Scripture scripture = new Scripture(reference, passage);
        while (!scripture.IsCompletelyHidden())
        {
            scripture.GetDisplayText();
            Console.WriteLine($"Numbers of hidden words: {scripture.GetHiddenCount()}");

            Console.Write("Press ENTER key to continue or type 'quit' to finish ");
            string response = Console.ReadLine();
            if (response.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords();
            }
        }
        if (scripture.IsCompletelyHidden())
        {
            scripture.GetDisplayText();
            Console.Clear();
            Console.WriteLine($"Numbers of hidden words: {scripture.GetHiddenCount()}");
            //break;
        }
    }
}