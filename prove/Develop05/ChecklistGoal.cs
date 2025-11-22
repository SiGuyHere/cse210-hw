public class ChecklistGoal : Goal
{
    private bool _completed;
    private int _timesCompleted;
    private int _totalGoalAmount;
    private int _bonus;
    private int _points;
    public ChecklistGoal(string name, string description, int totalGoalAmount) : base(name, description)
    {
        _completed = false;
        _timesCompleted = 0;
        _totalGoalAmount = totalGoalAmount;
        _bonus = 1000;
        _points = 0;
    }
    public ChecklistGoal(string name, string description, bool completed, int points, int timesCompleted, int totalGoalAmount, int bonus) : base(name, description)
    {
        _completed = completed;
        _timesCompleted = timesCompleted;
        _totalGoalAmount = totalGoalAmount;
        _bonus = bonus;
        _points = points;
    }
    override public bool IsComplete()
    {
        return _completed;
    }
    public int GoalProgress()
    {
        return _timesCompleted;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _points+_bonus;
        }
        else
        {
            return _points;
        }
    }
    override public int RecordEvent()
    {
        _timesCompleted++;
        _points += 100;
        if(_timesCompleted == _totalGoalAmount)
        {
            _completed = true;
            return _points+_bonus;
        }
        else
        {
            return _points;   
        }
    }
    public override string ToString()
    {
        return $"ChecklistGoal,{_name},{_description},{_completed},{_points},{_timesCompleted},{_totalGoalAmount},{_bonus}"; 
    }
    public static ChecklistGoal FromString(string line)
    {
        var parts = line.Split(',');
        return new ChecklistGoal(parts[1],parts[2],bool.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]),int.Parse(parts[7]));
    }
        
}