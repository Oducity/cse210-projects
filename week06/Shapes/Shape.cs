using System.Security.Cryptography.X509Certificates;

public abstract class Shape
{
    private string _shape;
    private string _color;

    public Shape()
    {

    }

    public void SetShape(string shape)
    {
        _shape = shape;
    }

    public string GetShape()
    {
        return _shape;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}