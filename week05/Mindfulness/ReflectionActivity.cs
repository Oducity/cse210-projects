public class ReflectionActivity : BreathingActivity
{
    private List<string> _promptText = new List<string>();
    private List<string> _promptQuestions = new List<string>();
    private List<int> _randNumber = new List<int>();
    public ReflectionActivity(string activityName, string description, int duration, string preparationMessage, string endMessage) : base(activityName, description, duration, preparationMessage, endMessage)
    {
        _promptText.Add("Think of a time when you stood up for someone else.");
        _promptText.Add("Think of a time when you did something really difficult.");
        _promptText.Add("Think of a time when you helped someone in need.");
        _promptText.Add("Think of a time when you did something truly selfless.");

        _promptQuestions.Add("Why was this experience meaningful to you?");
        _promptQuestions.Add("Have you ever done anything like this before?");
        _promptQuestions.Add("How did you get started?");
        _promptQuestions.Add("How did you feel when it was complete?");
        _promptQuestions.Add("What made this time different than other times when you were not as successful?");
        _promptQuestions.Add("What is your favorite thing about this experience?");
        _promptQuestions.Add("What could you learn from this experience that applies to other situations?");
        _promptQuestions.Add("What did you learn about yourself through this experience?");
        _promptQuestions.Add("How can you keep this experience in mind in the future?");
        _promptQuestions.Add("How did the glory of the Lord reflect in this experience");
    }

    public void GetRandomReflection()
    {

        Random rand = new Random();
        //pick text index value
        int randIndex = rand.Next(_promptText.Count);
        //return the text at the picked index
        Console.WriteLine(_promptText[randIndex]);

        int randomNumber = rand.Next(_promptQuestions.Count);
        if (!_randNumber.Contains(randomNumber))
        {
            Console.WriteLine(_promptQuestions[randomNumber]);
        }
        _randNumber.Add(randomNumber);
    }
}