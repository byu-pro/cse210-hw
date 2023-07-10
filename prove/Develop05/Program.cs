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

        // Allow the user to create goals
        bool createMoreGoals = true;
        while (createMoreGoals)
        {
            Console.WriteLine("Do you want to create a new goal? (yes/no)");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                Console.WriteLine("Enter the name of the goal:");
                string goalName = Console.ReadLine();

                Console.WriteLine("Enter the value of the goal:");
                int goalValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select the type of goal: (1) Simple Goal, (2) Eternal Goal, (3) Checklist Goal");
                int goalType = Convert.ToInt32(Console.ReadLine());

                Goal newGoal;
                switch (goalType)
                {
                    case 1:
                        newGoal = new SimpleGoal(goalName, goalValue);
                        break;
                    case 2:
                        newGoal = new EternalGoal(goalName, goalValue);
                        break;
                    case 3:
                        Console.WriteLine("Enter the required times for the checklist goal:");
                        int requiredTimes = Convert.ToInt32(Console.ReadLine());
                        newGoal = new ChecklistGoal(goalName, goalValue, requiredTimes);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type. Creating a simple goal by default.");
                        newGoal = new SimpleGoal(goalName, goalValue);
                        break;
                }

                goals.Add(newGoal);
                Console.WriteLine("New goal created!");
            }
            else if (response == "no")
            {
                createMoreGoals = false;
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
            }
        }

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
