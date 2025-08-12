public class SwimmingActivity : Activity
{
    private double _laps;


    public override string GetDate()
    {
        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToString();
        return date;
    }
    public override double GetDistance()
    {
        return (GetSpeed() * GetLength()) / 60;
    }
    public override double GetSpeed()
    {
        return Math.Round(60 * (2 / GetLength()), 2);
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();

        return pace;
    }
    public double GetLaps()
    {
        SetLaps();
        return _laps;
    }
    public void SetLaps()
    {
        _laps = (GetDistance() * 1000) / 50;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min): Distance {GetDistance()} km, Laps: {GetLaps()}, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km.";
    }
}