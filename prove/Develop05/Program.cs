using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nType in the number you want to do.");
            Console.WriteLine("1.Create Goal\n2.Record Progress\n3.Show Points\n4.Display Goals\n5.Save\n6.Load\n7.Quit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Goal name?");
                string name = Console.ReadLine();
                Console.WriteLine("Goal description?");
                string description = Console.ReadLine();
                Console.WriteLine("What type of goal?\n1.Simple Goal\n2.Eternal Goal\n3.Checklist Goal");
                string goaltype = Console.ReadLine();
                if (goaltype == "1")
                {
                    SimpleGoal goal = new SimpleGoal(name, description);
                    OverallFile.AddToList(goal);
                } else if (goaltype == "2")
                {
                    EternalGoal goal = new EternalGoal(name, description);
                    OverallFile.AddToList(goal);
                } else if (goaltype == "3")
                {
                    Console.WriteLine("\nHow many times do you want to do it before it's complete?");
                    int times = int.Parse(Console.ReadLine());
                    ChecklistGoal goal = new ChecklistGoal(name, description, times);
                    OverallFile.AddToList(goal);
                }
            } else if (choice == "2")
            {
                bool keepGoing = true;
                while (keepGoing)
                {
                    OverallFile.DisplayGoals();
                    Console.WriteLine("Would you like to record a goal?('no' to exit)");
                    if (Console.ReadLine() == "no")
                    {
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine("Which goal would you like to record?");
                        int goal = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{OverallFile.goals[goal-1].GetName()}\n{OverallFile.goals[goal-1].GetDescription()}");
                        Console.WriteLine("Would you like to mark as complete/ mark one completion?");
                        string completion = Console.ReadLine();
                        if (completion == "yes")
                        {
                            Console.WriteLine($"\nYou earned {OverallFile.goals[goal-1].RecordEvent()} points");
                            if (OverallFile.goals[goal - 1].IsComplete())
                            {
                                Console.WriteLine("You completed the goal!!");
                            }
                            keepGoing = false;
                            Thread.Sleep(2000);
                        } else
                        {
                            keepGoing = true;
                        }
                            
                    }
                }
            } else if (choice == "3")
            {
                OverallFile.DisplayPoints();
            } else if (choice == "4")
            {
                OverallFile.DisplayGoals();
            } else if (choice == "5")
            {
                Console.WriteLine("What is the file name?");
                string savename = Console.ReadLine();
                OverallFile.SaveFile(savename);
            } else if (choice == "6")
            {
                Console.WriteLine("What is the file name?");
                string savename = Console.ReadLine();
                OverallFile.LoadFile(savename);
            } else if (choice == "7")
            {
                running = false;
            } 
        }
        
    } 
}