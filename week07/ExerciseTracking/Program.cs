using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> _activityList = new List<Activity>();

        CyclingActivity cycling1 = new CyclingActivity();
        CyclingActivity cycling2 = new CyclingActivity();
        CyclingActivity cycling3 = new CyclingActivity();
        cycling1.SetLength(30);
        cycling2.SetLength(30);
        cycling3.SetLength(30);
        _activityList.Add(cycling1);
        _activityList.Add(cycling2);
        _activityList.Add(cycling3);


        RunningActivity running1 = new RunningActivity();
        RunningActivity running2 = new RunningActivity();
        RunningActivity running3 = new RunningActivity();
        running1.SetLength(500);
        running2.SetLength(600);
        running3.SetLength(800);
        _activityList.Add(running1);
        _activityList.Add(running2);
        _activityList.Add(running3);


        SwimmingActivity swimming1 = new SwimmingActivity();
        SwimmingActivity swimming2 = new SwimmingActivity();
        SwimmingActivity swimming3 = new SwimmingActivity();
        swimming1.SetLength(200);
        swimming2.SetLength(250);
        swimming3.SetLength(300);
        _activityList.Add(swimming1);
        _activityList.Add(swimming2);
        _activityList.Add(swimming3);

        foreach (Activity activity in _activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}