// ChecklistGoal class represents a checklist goal that must be accomplished a certain number of times to be complete
public class ChecklistGoal : Goal
{
    // Private member variables
    private int _requiredTimes;
    private int _completedTimes;

    // Properties
    public int RequiredTimes
    {
        get { return _requiredTimes; }
        set { _requiredTimes = value; }
    }

    public int CompletedTimes
    {
        get { return _completedTimes; }
        private set { _completedTimes = value; }
    }

    // Constructor
    public ChecklistGoal(string name, int value, int requiredTimes)
    {
        Name = name;
        Value = value;
        RequiredTimes = requiredTimes;
        CompletedTimes = 0;
    }

    // Implementation of abstract method to calculate the points earned for completing the goal
    public override int CalculatePointsEarned()
    {
        if (IsCompleted)
        {
            return Value + (RequiredTimes * 50); // Bonus points when the goal is completed
        }
        else
        {
            return Value;
        }
    }

    // Method to record the goal as completed and update the completed times
    public override void MarkCompleted()
    {
        CompletedTimes++;
        if (CompletedTimes >= RequiredTimes)
        {
            IsCompleted = true;
        }
    }
}
