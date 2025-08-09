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
        int num1 = 0;
        int num2 = 2;
        return num1 == num2;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}