public class Activity
{
    private string _activityName;
    private string _description;
    private string _preparationMessage;
    private string _endMessage;
    private int _duration;
    private int _timeSpent;
    private int _pauseTimer;


    public Activity(string activityName, string description, string preparationMessage, string endMessage)
    {
        _activityName = activityName;
        _description = description;
        _preparationMessage = preparationMessage;
        _endMessage = endMessage;
    }

    public void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine("You are welcomed to " + _activityName + Environment.NewLine + Environment.NewLine + "Activity Description: " + _description + Environment.NewLine);
        Console.Write("How long do you want to spend on this activity in second? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready");
        DisplaySpinner();
        Thread.Sleep(2000);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public int GetTimeSpent()
    {
        return _timeSpent;
    }

    public void GetPreparationMessage()
    {
        Console.WriteLine(_preparationMessage);
    }

    public void PauseTimer()
    {
        int time = 5;
        for (int i = time; i > 0; i--)
        {
            _pauseTimer += 1;
            Console.Write(i);
            Thread.Sleep(1000);
            _timeSpent += 1;
            Console.Write("\b \b");
        }
    }

    public void PauseTimer2()
    {
        int time = 5;
        for (int i = time; i >= 0; i--)
        {
            _pauseTimer += 1;
            Console.Write(i);
            Thread.Sleep(1000);
            _timeSpent += 1;
            Console.Write("\b \b");
        }
    }

    public void DisplaySpinner()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            _timeSpent += 1;
        }
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine(_endMessage);
        Thread.Sleep(3000);
        Console.WriteLine($"You just completed the {_activityName} in {_duration} seconds.");
        Thread.Sleep(10000);
    }
}

