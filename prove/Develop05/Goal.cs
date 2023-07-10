// Goal class represents a base class for all kinds of goals
public abstract class Goal
{
    // Private member variables
    private string _name;
    private int _value;
    private bool _isCompleted;

    // Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public bool IsCompleted
    {
        get { return _isCompleted; }
        protected set { _isCompleted = value; }
    }

    // Abstract method to calculate the points earned for completing the goal
    public abstract int CalculatePointsEarned();

    // Method to mark the goal as completed
    public virtual void MarkCompleted()
    {
        _isCompleted = true;
    }
}
