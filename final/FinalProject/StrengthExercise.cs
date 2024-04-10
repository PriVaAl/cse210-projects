using System;

public class StrengthExercise : Exercise
{
    protected int _weight;
    public StrengthExercise(string name,  int calories, int duration, int weight): base (name, calories, duration)
    {
        _weight = weight;
    }

    public override int CaloriesBurnedPerMinute()
    {
        return _calories * _duration * _weight;

    }

    public override string GetDetailString()
    {
        return $"Name: {_name}, Calories Burned:{CaloriesBurnedPerMinute()} calories per minute and weight from dumbbells worked with:{_weight} pounds."; 
    }


}