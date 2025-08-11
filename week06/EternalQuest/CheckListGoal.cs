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
        if (IsComplete())
        {
            _points += _bonus;
        }
        return _points;
    }
    public override string GetDetailsString()
    {
        return $"---Currently completed: {_amountCompleted}" + "/" + $"{_target}";
    }
    public override void RecordEvent()
    {
        int amountAccomplished = 1;
        _amountCompleted += amountAccomplished;
        GetBonus();
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetStringRepresentation()
    {
        return $"Description: {GetDescription()}. Point: {_points}. Bonus: {_bonus}. Target: {_target}. Completed: {_amountCompleted}";
    }
}