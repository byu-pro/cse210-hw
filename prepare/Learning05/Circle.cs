// Circle class representing a circle shape
public class Circle : Shape
{
    private double radius; // Private member variable for radius

    // Constructor accepting color and radius, calling base constructor with color
    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    // Override GetArea method to calculate area for circle
    public override double GetArea()
    {
        return Math.PI * radius * radius; // Area of a circle is pi multiplied by radius squared
    }
}
