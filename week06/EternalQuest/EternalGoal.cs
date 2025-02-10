class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }
    public override string GetStringRepresentation() => $"EternalGoal,{_shortName},{_description},{_points}";
}