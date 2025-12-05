public class ChecklistGoal : Goal


{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonusPoints;
        
    }

    public override int RecordEvent()
    {
        int pointsEarned = 0;
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            pointsEarned = GetPoints();


            if (_amountCompleted == _target)
            {
                pointsEarned += _bonus;
            }
        }

        return pointsEarned;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"--Completed {_amountCompleted}/{_target}";
    }

    public void SetDetailString(int complete, int target)
    {
        _amountCompleted = complete;
        _target = target;
    }


    public override string GetStringRepresentation()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool completed = IsComplete();
        return $"ChecklistGoal|{name}|{description}|{points}|{completed}|{_target}|{_amountCompleted}|{_bonus}";
    }

}