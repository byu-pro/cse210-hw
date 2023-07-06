// Square class representing a square shape
public class Square : Shape
{
    private double side; // Private member variable for side length

    // Constructor accepting color and side length, calling base constructor with color
    public Square(string color, double side) : base(color)
    {
        this.side = side;
    }

    // Override GetArea method to calculate area for square
    public override double GetArea()
    {
        return side * side; // Area of a square is side squared
    }
}
