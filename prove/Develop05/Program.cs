using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store goals
        List<Goal> goals = new List<Goal>();

        // Create and add goals to the list
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 100));
        goals.Add(new ChecklistGoal("Attend the temple", 50, 10));

        // Display the list of goals
        Console.WriteLine("List of Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.Name);
        }

        // Record an event (accomplished goal) and update the goal's completion status
        goals[0].MarkCompleted();
        goals[2].MarkCompleted();

        // Display the user's score
        int totalScore = 0;
        foreach (var goal in goals)
        {
            totalScore += goal.CalculatePointsEarned();
        }
        Console.WriteLine("Total Score: " + totalScore);
    }
}
