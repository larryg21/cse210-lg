public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

 
    public static EternalGoal Load(string[] parts)
    {
      
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        return new EternalGoal(name, description, points);
    }

    public override int RecordEvent()
{
    return Points; 
}
    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetStatus()
    {
        return $"[∞] {Name} ({Description})";
    }

    public override string SaveString() => $"EternalGoal|{Name}|{Description}|{Points}";
}
