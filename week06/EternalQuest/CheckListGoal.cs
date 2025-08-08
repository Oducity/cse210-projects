using System.ComponentModel;
using System.Drawing;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        //_target = target;
        //_bonus = bonus;
    }
    public string GetDetailsString()
    {
        return "";
    }
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}