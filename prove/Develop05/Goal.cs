public class Goal
{
    private int _points;
    protected string _description;
    protected string _name;
    private bool _completed;
    public Goal(string name, string description)
    {
        _description = description;
        _name = name;
        _completed = false;
        _points = 0;
    }
    public Goal(string name, string description, bool completed, int points)
    {
        _description = description;
        _name = name;
        _completed = completed;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    virtual public int GetPoints()
    {
        return _points;
    }
    virtual public bool IsComplete()
    {
        return _completed;
    }
    virtual public int RecordEvent()
    {
        _completed = true;
        _points += 100;
        return _points;
    }
    public override string ToString()
    {
        return $"Goal,{_name},{_description},{_completed},{_points}"; 
    }

}