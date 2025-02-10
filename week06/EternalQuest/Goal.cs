class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    
    public virtual int RecordEvent() => _points;
    public virtual bool IsComplete() => false;
    public virtual string GetDetailsString() => $"{_shortName}: {_description} ({_points} points)";
    public virtual string GetStringRepresentation() => "";
    public string ShortName { get { return _shortName; } }
}