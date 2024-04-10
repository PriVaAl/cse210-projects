using System;
using System.Collections.Generic;
public abstract class Exercise
{
    protected string _name;

    protected int _calories;
    protected int _duration;

    public Exercise(string name,  int calories, int duration)
    {
        _name = name;
        _calories = calories;
       _duration = duration; 

    }

    public abstract int  CaloriesBurnedPerMinute();
    
    public virtual string GetDetailString()
    {
        return $"Name:{_name}, Calories burned per minute: {CaloriesBurnedPerMinute()}";
    }
}