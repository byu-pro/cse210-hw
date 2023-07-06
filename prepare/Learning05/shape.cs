// Shape class representing a base shape
public class Shape
{
    // Color member variable
    private string color;

    // Constructor accepting color and setting it
    public Shape(string color)
    {
        this.color = color;
    }

    // Getter and setter for color
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Virtual method for calculating area (to be overridden in derived classes)
    public virtual double GetArea()
    {
        return 0; // Base implementation returns 0
    }
}
