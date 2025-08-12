public abstract class Activity
{
    private double _speed;
    private double _distance;
    private double _pace;
    private DateTime _date;
    private double _length;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}