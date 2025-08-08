class BreathingActivity : Activity
{
    public BreathingActivity(Random random) : base(random)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    
    public override void Run()
    {
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            
            Console.Write("\nBreathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}