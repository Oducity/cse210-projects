public class ListingActivity : BreathingActivity
{
    private List<string> _message = new List<string>() { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

    public ListingActivity(string activityName, string description, string preparationMessage, string endMessage) : base(activityName, description, preparationMessage, endMessage)
    {

    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        
    }
}