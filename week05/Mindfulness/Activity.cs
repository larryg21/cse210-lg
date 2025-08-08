abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected Random _random;

    public abstract void Run();

    public Activity(Random random)
    {
        _random = random;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(5);
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}