public class GoalManager {
    private List<Goal> _goals;
    private int _score;

    public GoalManager() {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start() {
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames() {
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails() {
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal() {

    }

    public void RecordEvent() {
    }

    public void SaveGoals() {
    }

    public void LoadGoals() {
    }
}
