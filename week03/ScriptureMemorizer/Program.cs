using System;

class Program
{
    static void Main(string[] args)
    {




        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        //Console.Write("Press 1 for random scripture or 2 for 1 Nephi 1:9 and hit ENTER.");
        //string reply = Console.ReadLine();

        //if (reply == "2")
        //{

        Reference reference = new Reference("1 Nephi", 1, 9);
        string passage = "And it came to pass that he saw One descending out of the midst of heaven, and he beheld that his luster was above that of the sun at noon-day.";


        //Console.WriteLine(reference.GetReference());
        Scripture scripture = new Scripture(reference, passage);
        while (!scripture.IsCompletelyHidden())
        {
            scripture.GetDisplayText();

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
            //break;
        }
        //}
        //else
        //{

        //Reference ref1 = new Reference();
        //ref1.GetRandomReference();
        //Scripture scrip1 = new Scripture();
        //string refe = ref1.GetGeneratedReference();
        //string message = scrip1.GetGeneratedScripture();
        // 

        //Commented these codes out for testing purposes.
        // while (!scrip1.IsCompletelyHidden())
        //{
        //scrip1.GetDisplayText();
        //
        //Console.Write("Press ENTER key to continue or type 'quit' to finish ");
        //string response = Console.ReadLine();
        //if (response.ToLower() == "quit")
        //{
        //    break;
        //}
        //else
        //{
        //    scrip1.HideRandomWords();
        //}
        //
        //
        //}
        //if (scrip1.IsCompletelyHidden())
        //{
        //    scrip1.GetDisplayText();
        //    Console.Clear();
        //    //break;
        //}

        //}
    }
}