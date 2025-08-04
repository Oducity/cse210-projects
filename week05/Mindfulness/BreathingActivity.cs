using System.Text;

public class BreathingActivity : Activity
{
    private string _activityName;
    private string _description;
    private string _activityMessage1 = "Breath in...";
    private string _activityMessage2 = "Now breath out...";
    private string _preparationMessage;
    private string _endMessage;
    private int _duration;
    private int _timeSpent;
    private int _pauseTimer;


    public BreathingActivity(string activityName, string description, string preparationMessage, string endMessage) : base(activityName, description, preparationMessage, endMessage)
    {

    }
    

    public void DisplayBreathingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write(_activityMessage1);
        PauseTimer();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write(_activityMessage2);
        PauseTimer();
    }
    
    
}