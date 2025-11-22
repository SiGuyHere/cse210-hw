public class SimpleGoal : Goal
{
    private bool _completed;
    private int _points;
    public SimpleGoal(string name, string description) : base(name, description)
    {
        _completed = false;
        _points = 0;
    }
    public SimpleGoal(string name, string description, bool completed, int points) : base(name, description)
    {
        _completed = completed;
        _points = points;
    }
    public override string ToString()
    {
        return $"SimpleGoal,{_name},{_description},{_completed},{_points}"; 
    }
    public static SimpleGoal FromString(string line)
    {
        var parts = line.Split(',');
        return new SimpleGoal(parts[1],parts[2],bool.Parse(parts[3]),int.Parse(parts[4]));
    }
        
}