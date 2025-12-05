using System.Reflection;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
    {
       
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        int points = GetPoints();
        return points;
        
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool completed = IsComplete();
        return $"SimpleGoal|{name}|{description}|{points}|{completed}";

    }    
        
}
