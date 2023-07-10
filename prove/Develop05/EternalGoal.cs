// EternalGoal class represents an eternal goal that is never complete, but each time the user records them, they gain some value
public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, int value)
    {
        Name = name;
        Value = value;
    }

    // Implementation of abstract method to calculate the points earned for completing the goal
    public override int CalculatePointsEarned()
    {
        return Value;
    }

    // Override MarkCompleted method to prevent marking eternal goals as completed
    public override void MarkCompleted()
    {
        // Do nothing
    }
}
