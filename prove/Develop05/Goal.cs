using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;

    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
   
    public virtual string GetDetailString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
    
}