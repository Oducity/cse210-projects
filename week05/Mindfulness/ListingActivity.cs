public class ListingActivity : BreathingActivity
{
    private List<string> _message = new List<string>() { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    private List<string> _responses = new List<string>();
    private int _timeSpent;
    private int _duration;

    public ListingActivity(string activityName, string description, string preparationMessage, string endMessage) : base(activityName, description, preparationMessage, endMessage)
    {

    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(_message.Count);

        _duration = GetDuration();



        string promptText = _message[promptIndex];
        while (_duration > _timeSpent)
        {
            Console.WriteLine("List as many responses you can to the following prompt:" + Environment.NewLine);
            Console.WriteLine($"--- {promptText} __");
            Console.Write("You may begin in:" + Environment.NewLine);
            PauseTimer();
            _timeSpent = GetTimeSpent();
            while (_duration > _timeSpent)
            {
                _timeSpent += 1;
                Console.Write("> ");
                string response = Console.ReadLine();
                _responses.Add(response);

            }
        }
        

    }

    public int GetFinalTimeSpent()
    {
        return _timeSpent;
    }

    public void GetItemsInList()
    {
        int j = 0;
        Console.WriteLine($"You listed {_responses.Count()} items:");
        foreach (string i in _responses)
        {
            j += 1;
            Console.WriteLine( j+"." + "  " + i );
            
        }
    }

}
