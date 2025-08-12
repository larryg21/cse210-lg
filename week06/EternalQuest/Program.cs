using System;

class Program
{
    static void Main()
    {
        var manager = new GoalManager();
        while (true)
        {
            Console.WriteLine($"Score: {manager.Score}");
            Console.WriteLine("1. Create Goal\n2. List Goals\n3. Save\n4. Load\n5. Record Event\n6. Quit");
            switch (Console.ReadLine())
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoals(); break;
                case "3":
                Console.Write("What is the filename for the goal file? ");
                string saveFilename = Console.ReadLine();
                manager.Save(saveFilename);
                Console.WriteLine($"Goals saved to {saveFilename}.");
                break;
                case "4":
                Console.Write("What is the filename of the goal file? ");
                string loadFilename = Console.ReadLine();
                manager.Load(loadFilename);
                Console.WriteLine($"Goals loaded from {loadFilename}.");
                break;
                case "5": manager.RecordEvent(); break;
                case "6": return;
            }
        }
    }
}
