public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    //public string GetDetailsString()
    //{
    //    return "";
    //}
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoint()
    {
        return _points;
    }

    public void SetPoints(int point)
    {
        _points = point;
    }
}