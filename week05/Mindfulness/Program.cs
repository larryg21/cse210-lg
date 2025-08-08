using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string choice = "";
        
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            
            Activity activity = null;
            
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(random);
                    break;
                case "2":
                    activity = new ReflectingActivity(random);
                    break;
                case "3":
                    activity = new ListingActivity(random);
                    break;
                case "4":
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
            
            if (activity != null)
            {
                activity.Run();
            }
        }
    }
}