public abstract class Goal
{
    //public string GetDetailsString()
    //{
    //    return "";
    //}
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}