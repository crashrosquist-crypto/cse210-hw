namespace EternalQuest;
using System;

public class ChecklistGoal : global
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override string GetDetailsString()
{
    string statusSymbol = IsComplete() ? "X" : " ";
    
    return $"[{statusSymbol}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
}
}