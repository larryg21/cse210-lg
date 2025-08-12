using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> Goals { get; private set; } = new List<Goal>();
    public int Score { get; private set; } = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Which type of goal do you want to create?");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("Short Description: ");
        string description = Console.ReadLine();
        Console.Write("Points for this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            Goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            Goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            Goals.Add(new ChecklistGoal(name, description, points, target, 0, bonus));
        }
    }
    public void ListGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
            Console.WriteLine($"{i + 1}. {Goals[i].GetStatus()}");
    }

    public void RecordEvent()
{
   
    ListGoals();
    
    
    Console.Write("Which goal did you accomplish? ");
    
    
    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= Goals.Count)
    {
        int index = choice - 1;
        
        
        int pointsEarned = Goals[index].RecordEvent();
        
        
        Score += pointsEarned;
        
       
        Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points.");
        Console.WriteLine($"You now have {Score} points.");
    }
    else
    {
        Console.WriteLine("\nInvalid choice. Please enter a valid goal number.");
    }
}

    public void Save(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(Score);
            foreach (var g in Goals)
            {
                sw.WriteLine(g.SaveString());
            }
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        
        string[] lines = File.ReadAllLines(filename);
        Score = int.Parse(lines[0]);
        Goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            if (parts[0] == "SimpleGoal") Goals.Add(SimpleGoal.Load(parts));
            else if (parts[0] == "EternalGoal") Goals.Add(EternalGoal.Load(parts));
            else if (parts[0] == "ChecklistGoal") Goals.Add(ChecklistGoal.Load(parts));
        }
    }
}