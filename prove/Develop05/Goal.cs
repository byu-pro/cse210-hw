// Goal class represents a base class for all kinds of goals
public abstract class Goal
{
    // Properties
    public string Name { get; set; }
    public int Value { get; set; }
    public bool IsCompleted { get; set; }

    // Methods
    // Abstract method to calculate the points earned for completing the goal
    public abstract int CalculatePointsEarned();

    // Method to mark the goal as completed
    public virtual void MarkCompleted()
    {
        IsCompleted = true;
    }
}
