using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionToString()); //Print the string representation to the console.
        Console.WriteLine(fraction1.GetDecimalValue()); // Print the decimal value to the console.

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionToString()); //Print the string representation to the console.
        Console.WriteLine(fraction2.GetDecimalValue()); // Print the decimal value to the console.

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionToString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionToString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}