using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square(5),
            new Rectangle(4, 6),
            new Circle(3)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea():F2}");
        }
    }
}