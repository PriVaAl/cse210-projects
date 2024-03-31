using System;
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    

    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    
    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";

    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}