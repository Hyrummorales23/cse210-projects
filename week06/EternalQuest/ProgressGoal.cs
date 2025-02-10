// Exceeding Expectation Feature: Progress Goal
class ProgressGoal : Goal
{
    private int _currentProgress;
    private int _goalTarget;

    public ProgressGoal(string name, string description, int points, int goalTarget) : base(name, description, points)
    {
        _currentProgress = 0;
        _goalTarget = goalTarget;
    }

    public override int RecordEvent()
    {
        _currentProgress++;
        return _points;
    }

    public override bool IsComplete() => _currentProgress >= _goalTarget;
    public override string GetDetailsString() => $"{_shortName}: {_description} ({_currentProgress}/{_goalTarget} completed)";
    public override string GetStringRepresentation() => $"ProgressGoal,{_shortName},{_description},{_points},{_goalTarget},{_currentProgress}";
}