using System.Reflection;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {

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
        return $"{name}, {description}, {points}, {completed}";

    }    
        
}
