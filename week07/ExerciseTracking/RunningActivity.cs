using System.Diagnostics.CodeAnalysis;

public class RunningActivity : Activity
{

    public override string GetDate()
    {
        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToString();
        return date;
    }
    public override double GetSpeed()
    {
        return Math.Round(60 * (5 / GetLength()), 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 1);
    }
    public override double GetDistance()
    {
        return Math.Round(((GetSpeed() * GetLength()) / 60), 2);
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min), Distance: {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km.";
    }
    
}