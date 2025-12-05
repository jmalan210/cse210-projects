using System.Collections.Concurrent;

public class MilestoneGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _completionBonus;
    public MilestoneGoal(string name, string description, int points, int target, int completionBonus)
        : base(name, description, points)
    {
        _target = target;
        _completionBonus = completionBonus;
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
                pointsEarned += _completionBonus;
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
        double percentage = _amountCompleted * 100 / _target;
        return $"--You've met {_amountCompleted} of {_target} milestones. You are {percentage}% done with this goal!";
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
        return $"MilestoneGoal|{name}|{description}|{points}|{completed}|{_target}|{_amountCompleted}|{_completionBonus}";
    }
}