using System;
using System.Collections.Generic;
using System.Linq;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = goals.FirstOrDefault(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            totalScore += goal.Points;
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
            {
                totalScore += checklistGoal.BonusPoints;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.Name}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals(string filePath)
    {
        // Implement saving logic
    }

    public void LoadGoals(string filePath)
    {
        // Implement loading logic
    }
}