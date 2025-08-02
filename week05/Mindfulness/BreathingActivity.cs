public class BreathingActivity
{
    private string _activityName;
    private string _description;
    private string _activityMessage1 = "Breath in..";
    private string _activityMessage2 = "Breath out..";
    private string _preparationMessage;
    private string _endMessage;
    private int _duration;


    public BreathingActivity(string activityName, string description, int duration, string preparationMessage, string endMessage)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
        _preparationMessage = preparationMessage;
        _endMessage = endMessage;
    }

    public void DisplayIntro()
    {
        Console.WriteLine("You are welcomed to " + _activityName + Environment.NewLine + "Activity Description: " + _description);
        Thread.Sleep(15000);
        Console.Clear();
        Console.WriteLine(_preparationMessage);
        Thread.Sleep(10000);
        Console.Clear();
    }

    public void PauseTimer()
    {
        int time = 5;
        for (int i = time; i >= 0; i--)
        {
            Console.WriteLine(i + " Seconds");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }

    public void DisplayActivityMessage()
    {
        PauseTimer();
        Console.WriteLine(_activityMessage1);
        PauseTimer();
        Console.WriteLine(_activityMessage2);
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine(_endMessage);
        Thread.Sleep(3000);
        Console.WriteLine($"You just completed the {_activityName} in {_duration - 28} seconds.");
        Thread.Sleep(10000);
    }
}