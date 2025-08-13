using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 8, 13), 30, 3.0),
            new Cycling(new DateTime(2025, 8, 10), 45, 15.0),
            new Swimming(new DateTime(2025, 8, 12), 40, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}