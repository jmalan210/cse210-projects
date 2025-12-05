using System.Security.Cryptography.X509Certificates;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000.0 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double minutes = GetLengthInMinutes();
        double speed = distance / minutes * 60;
        return speed;
    }

    public override double GetPace()
    {
        double minutes = GetLengthInMinutes();
        double distance = GetDistance();
        double pace = minutes / distance;
        return pace;
    }

}