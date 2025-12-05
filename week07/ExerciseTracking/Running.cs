public class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double minutes = GetLengthInMinutes();
        double speed = _distance / minutes * 60;
        return speed;

    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
}