public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1; //Initialized the _top attribute to 1.
        _bottom = 1; // Initialized the class attribute _bottom of the Fraction1 object to 1.
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber; // Store the wholeNumber value in the _top attribute.
        _bottom = 1; // Initialized the class attribute _bottom of the Fraction2 object to 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top; // Stores the value of the top parameter of the Fraction3 & Fraction4 objects in the class attribute _top.
        _bottom = bottom; // Stores the value of the bottom parameter of the Fraction3 & Fraction4 objects in the class attribute _bottom.
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionToString()
    {
        string top = GetTop().ToString(); // Convert to string.
        string bottom = GetBottom().ToString(); // Convert to string.
        return top + "/" + bottom; // Return the string representation.
    }

    public Decimal GetDecimalValue()
    {
        Decimal topValue = _top; // Convert the class attribute _top to decimal value and store as topValue
        Decimal bottomValue = _bottom; // Convert the class attribute _bottom to decimal value and store as bottomValue
        Decimal result = Decimal.Divide(topValue, bottomValue);
        return result;
    }


}