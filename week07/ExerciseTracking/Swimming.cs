using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        float distance = _laps * 50 / 1000 * 0.62f;
        return distance;
    }

    public override float GetSpeed()
{
    return (GetDistance() / GetMinutes()) * 60;
}

    public override float GetPace()
    {
        return (float)GetMinutes() / GetDistance();
    }
}