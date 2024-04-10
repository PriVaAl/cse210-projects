using System;

public class StretchingExercise : Exercise
{
    protected int _repetitions;
    public StretchingExercise(string name, int calories, int duration, int repetitions): base (name, calories, duration)
    {
        _repetitions = repetitions;

    }

    public override int  CaloriesBurnedPerMinute()
    {
        return _calories * _duration * _repetitions;

    }

    public override string GetDetailString()
    {
        return $"Name:{_name}, Calories Burned: {CaloriesBurnedPerMinute()} calories per minute and worked with {_repetitions} repetitions."; 
    
    }


}