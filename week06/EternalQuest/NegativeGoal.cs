// Exceeding Expectation Feature: Negative Goal
class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points) { }
    public override int RecordEvent() => -_points; // Deducts points
    public override string GetStringRepresentation() => $"NegativeGoal,{_shortName},{_description},{_points}";
}