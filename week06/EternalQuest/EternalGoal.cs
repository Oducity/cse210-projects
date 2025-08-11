public class EternalGoal : Goal
{
    private int _initialPoint;

    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {

    }
    public override void RecordEvent()
    {
        _initialPoint += GetPoint();
        //Console.WriteLine($"Congratulations! You have earned {_points++} points!");
    }

    public override bool IsComplete()
    {
        return 1 == 2;
    }
    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}