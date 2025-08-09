using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetBonus()
    {
        int bonus = 0;
        if (IsComplete())
        {
            bonus += _bonus;
        }
        return bonus;
    }
    public new string GetDetailsString()
    {
        return "";
    }
    public override void RecordEvent()
    {
        Console.Write("How many did you accomplish of this goal? ");
        int amountAccomplished = Int32.Parse(Console.ReadLine());
        _amountCompleted += amountAccomplished;
        

    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}