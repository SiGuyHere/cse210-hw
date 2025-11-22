public class EternalGoal : Goal
{
    private int _timesCompleted;
    private int _points;
    public EternalGoal(string name, string description) : base(name, description)
    {
        _timesCompleted = 0;
        _points = 0;
    }
    public EternalGoal(string name, string description, int points, int timesCompleted) : base(name, description)
    {
        _timesCompleted = timesCompleted;
        _points = points;
    }
    override public bool IsComplete()
    {
        return false;
    }
    override public int RecordEvent()
    {
        _points += 100;
        _timesCompleted++;
        return _points;
    }
    public override string ToString()
    {
        return $"EternalGoal,{_name},{_description},{_points},{_timesCompleted}"; 
    }
    public static EternalGoal FromString(string line)
    {
        var parts = line.Split(',');
        return new EternalGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]));
    }
        
}