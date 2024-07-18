using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();

        Rectangle rectangle = new Rectangle(20, 49, "red");
        shapes.Add(rectangle);

        Circle circle = new Circle(5, "yellow");
        shapes.Add(circle);

        Square square = new Square(23, "blue");
        shapes.Add(square);

        foreach (Shape item in shapes)
        {
            double area = item.GetArea();

            string color = item.GetColor();

            Console.WriteLine($"The area of the shape is {area} and the color is {color}.");
        }














        Console.WriteLine();
    }
}