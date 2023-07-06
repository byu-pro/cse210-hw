using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Create instances of square, rectangle, and circle and add them to the list
        Shape square = new Square("Red", 5);
        Shape rectangle = new Rectangle("Blue", 4, 6);
        Shape circle = new Circle("Green", 3);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate through the list of shapes and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.Color);
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine();
        }
    }
}
