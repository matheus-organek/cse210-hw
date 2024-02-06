using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("White", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Black", 4, 3);
        shapes.Add(rectangle);

        Circle circle = new Circle("Grenn", 4);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.Color;

            double computedArea = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {computedArea}.");
        }
    }
}