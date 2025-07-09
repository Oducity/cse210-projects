public class PromptGenerator
{


    

    public PromptGenerator()
    {

    }

    // Create GetRandomPrompt() method.
    public string GetRandomPrompt()
    {
        string _rand; //Initialize _rand to nothing.

        Random randomGenerator = new Random(); // Create the Random object and assign it randomGenerator.
        int randomNumber = randomGenerator.Next(1, 6); //Declared the range to randomly pick from and store in a variable.

        if (randomNumber == 1) //Compare randomNumber to pick a prompt question.
        {
            Console.WriteLine(_rand = "What was your best experience today?");
        }
        else if (randomNumber == 2)
        {
            Console.WriteLine(_rand = "What one thing did you learn best today?");
        }
        else if (randomNumber == 3)
        {
            Console.WriteLine(_rand = "How best were you to your family today?");
        }
        else if (randomNumber == 4)
        {
            Console.WriteLine(_rand = "What do you love most about your pet?");
        }
        else
        {
            Console.WriteLine(_rand = "What was your most important task achieved today?");
        }
        return _rand;
    }
}