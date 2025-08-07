public class SimpleGoal : Goal
{
    private bool _isComplete;
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