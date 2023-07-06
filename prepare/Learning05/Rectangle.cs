// Rectangle class representing a rectangle shape
public class Rectangle : Shape
{
    private double length; // Private member variable for length
    private double width; // Private member variable for width

    // Constructor accepting color, length, and width, calling base constructor with color
    public Rectangle(string color, double length, double width) : base(color)
    {
        this.length = length;
        this.width = width;
    }

    // Override GetArea method to calculate area for rectangle
    public override double GetArea()
    {
        return length * width; // Area of a rectangle is length multiplied by width
    }
}
