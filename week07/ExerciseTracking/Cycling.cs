public class CyclingActivity : Activity
{

    public override double GetDistance()
    {
        return (GetSpeed() * GetLength()) / 60;
    }

    public override double GetSpeed()
    {
        return Math.Round(60 * (4.8 / GetLength()), 2);
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetDate()
    {
        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToString();
        return date;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min)- Distance {GetDistance()} km, Speed {GetSpeed()}kph, pace: {GetPace()} min per km.";
    }
}