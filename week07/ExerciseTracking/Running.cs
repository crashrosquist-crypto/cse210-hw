using System;

public class Running : Activity
{
    private float _distance;

    public Running(string date, int minutes, float distance) : base(date, minutes)
    {
        _distance = distance;
    }
    
    
    public override float GetSpeed()
{
    return (GetDistance() / GetMinutes()) * 60;
}

    public override float GetPace()
    {
        return (float)GetMinutes() / GetDistance();
    }

    public override float GetDistance()
    {
        return _distance;
    }
}