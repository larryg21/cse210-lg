public class ChecklistGoal : Goal
{
    private int current, target, bonus;
    public ChecklistGoal(string name, string description, int points, int target, int current, int bonus) : base(name, description, points)
    {
        this.target = target; this.current = current; this.bonus = bonus;
    }

    public override int RecordEvent() { if (current >= target) return 0; current++; return Points + (current == target ? bonus : 0); }
    public override bool IsComplete() => current >= target;
    public override string GetStatus() => $"[{(IsComplete() ? "X" : " ")}] {Name} {current}/{target}";
    public override string SaveString() => $"ChecklistGoal|{Name}|{Description}|{Points}|{target}|{current}|{bonus}";
    public static ChecklistGoal Load(string[] p) => new ChecklistGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[4]), int.Parse(p[5]), int.Parse(p[6]));
}
