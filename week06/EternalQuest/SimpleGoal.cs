using System.Drawing;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    //private int _pointsObtained;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }


    public override void RecordEvent()
    {
        int record = 0;
        int record2 = 1;
        record += 1;
        
        if (record >= record2)
        {
            _isComplete = true;
            
        }
        else
        {
            _isComplete = false;
        }
    }

    public override bool IsComplete()
    {

        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return $"Description: {GetDescription()}. Points: {_points}. Completed: {_isComplete}";
    }

}