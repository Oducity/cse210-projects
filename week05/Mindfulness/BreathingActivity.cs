public class BreathingActivity
{
    private string _activityName;
    private string _description;
    private DateTime _duration;
    private DateTime _pauseTimer;

    public Activity(string activityName, string description, DateTime duration, DateTime pauseTimer)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
        _pauseTimer = pauseTimer;
    }

    public void DisplayIntro()
    {

    }

    public void DisplayEndMessage()
    {

    }
}