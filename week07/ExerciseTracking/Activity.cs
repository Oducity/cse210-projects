using System.Reflection.Metadata.Ecma335;

public abstract class Activity
{
    private double _length;

    public Activity()
    {

    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public abstract string GetDate();
    public abstract string GetSummary();
}