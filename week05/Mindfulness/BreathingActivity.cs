using System.Text;

public class BreathingActivity : Activity
{
    private string _activityMessage1 = "Breath in...";
    private string _activityMessage2 = "Now breath out...";

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