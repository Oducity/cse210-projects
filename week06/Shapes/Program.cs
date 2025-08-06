using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Rectangle rectangle = new Rectangle();
        rectangle.SetShape("Rectangle");
        rectangle.SetColor("green");
        rectangle.SetLength(20);
        rectangle.SetWidth(10);

        Square square = new Square();
        square.SetShape("Square");
        square.SetColor("blue");
        square.SetSide(15);


        Circle circle = new Circle();
        circle.SetShape("Circle");
        circle.SetColor("Brown");
        circle.SetRadius(25);


        DisplayShapesInformation(rectangle);
        DisplayShapesInformation(square);
        DisplayShapesInformation(circle);


    }

    static void DisplayShapesInformation(Shape shape)
    {
        Console.WriteLine($"The area of the{shape.GetColor()} {shape.GetShape()} is {shape.GetArea()} square centimeters.");
    }
}