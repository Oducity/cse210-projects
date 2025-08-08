public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
        
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