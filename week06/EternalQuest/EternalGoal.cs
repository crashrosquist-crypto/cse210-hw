namespace EternalQuest;

using System;

public class EternalGoal : Goal
{

    public override bool IsComplete()
    {
        return false;
    }
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
}