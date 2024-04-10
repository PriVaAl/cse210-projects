using System;

public class CardioExercise : Exercise
{
    protected int _frequency;
    public CardioExercise(string name, int calories, int duration, int frequency): base (name, calories, duration)
    {
        _frequency = frequency;

    }

    public override int CaloriesBurnedPerMinute()
    {
        return _calories * _duration * _frequency;

    }

    public  override string GetDetailString()
    {
        return $"Name:{_name}, Calories Burned: {CaloriesBurnedPerMinute()} calories per minute and Heart Frequency : {_frequency} HZ."; 
    }


}