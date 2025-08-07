using System;
//Completed the Shape program applying the principles of abstraction,
// encapsulation, inheritance and polymorphism.

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
        Console.WriteLine(Environment.NewLine);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        foreach (Shape sh in shapes)
        {
            Console.WriteLine($"The area {sh.GetArea()} square centimeters is gotten from the {sh.GetColor()} {sh.GetShape()}.");
        }
        


    }

    static void DisplayShapesInformation(Shape shape)
    {
        Console.WriteLine($"The area of the {shape.GetColor()} {shape.GetShape()} is {shape.GetArea()} square centimeters.");
    }
}