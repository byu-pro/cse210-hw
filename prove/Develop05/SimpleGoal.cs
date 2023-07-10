// SimpleGoal class represents a goal that can be marked complete and the user gains some value
public class SimpleGoal : Goal
{
    // Constructor
    public SimpleGoal(string name, int value)
    {
        Name = name;
        Value = value;
    }

    // Implementation of abstract method to calculate the points earned for completing the goal
    public override int CalculatePointsEarned()
    {
        if (IsCompleted)
        {
            return Value;
        }
        else
        {
            return 0;
        }
    }
}
