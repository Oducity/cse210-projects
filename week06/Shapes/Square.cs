public class Square : Shape
{
    private double _side;

    public Square()
    {

    }

    public override double GetArea()
    {
        return _side * _side;
    }
}