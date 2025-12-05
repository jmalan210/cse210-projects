public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        int points = GetPoints();
        return points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
       
        return $"EternalGoal|{name}|{description}|{points}";
    }
}