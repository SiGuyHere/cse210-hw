using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class OverallFile
{
    public static List<Goal> goals = new List<Goal>();
    public static void AddToList(Goal goal)
    {
        goals.Add(goal);
    }
    public static void DisplayGoals()
    {
        for (int i = 0; i < goals.Count(); i++)
        {
            if (goals[i].IsComplete())
            {
              Console.WriteLine($"\n{i+1}.{goals[i].GetName()}[x]");  
            } 
            else
            {
                Console.WriteLine($"\n{i+1}.{goals[i].GetName()}[ ]");
            }
        }
        Thread.Sleep(2000);
    }
    public static void DisplayPoints()
    {
        int points = 0;
        foreach(Goal goal in goals)
        {
            points += goal.GetPoints();
        }
        Console.WriteLine($"You have {points} points.");
    }
    public static void SaveFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.ToString());
            }
        }
    }
    public static void LoadFile(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("SimpleGoal,"))
                {
                    goals.Add(SimpleGoal.FromString(line));
                }
                else if (line.StartsWith("EternalGoal,"))
                {
                    goals.Add(EternalGoal.FromString(line));
                }
                else if (line.StartsWith("ChecklistGoal,"))
                {
                    goals.Add(ChecklistGoal.FromString(line));
                }
            }
        }
    }
}