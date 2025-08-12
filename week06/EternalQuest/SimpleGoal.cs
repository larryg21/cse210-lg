public class SimpleGoal : Goal
{
    private bool complete;
    public SimpleGoal(string name, string description, int points, bool complete = false) : base(name, description, points)
    {
        this.complete = complete;
    }

    public override int RecordEvent() { if (complete) return 0; complete = true; return Points; }
    public override bool IsComplete() => complete;
    public override string GetStatus() => $"[{(complete ? "X" : " ")}] {Name}";
    public override string SaveString() => $"SimpleGoal|{Name}|{Description}|{Points}|{complete}";
    public static SimpleGoal Load(string[] p) => new SimpleGoal(p[1], p[2], int.Parse(p[3]), bool.Parse(p[4]));
}