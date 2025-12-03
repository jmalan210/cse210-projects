using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("red", 2);
        shapes.Add(square1);
        // Console.WriteLine(square1.GetColor());
        // Console.WriteLine(square1.GetArea());

        Rectangle rec1 = new Rectangle("blue", 2, 4);
        shapes.Add(rec1);
        // Console.WriteLine(rec1.GetColor());
        // Console.WriteLine(rec1.GetArea());

        Circle circ1 = new Circle("green", 3);
        shapes.Add(circ1);
        // Console.WriteLine(circ1.GetColor());
        // Console.WriteLine(circ1.GetArea());

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}