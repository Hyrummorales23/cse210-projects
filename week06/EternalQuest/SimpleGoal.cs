class SimpleGoal : Goal
{
    public bool Completed { get; set; }  // ✅ Renamed to avoid conflict with IsComplete()

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        Completed = false;
    }

    public override int RecordEvent()
    {
        Completed = true;
        return _points;
    }

    public override bool IsComplete() => Completed;  // ✅ Now calls Completed

    public override string GetStringRepresentation() => $"SimpleGoal,{_shortName},{_description},{_points},{Completed}";
}