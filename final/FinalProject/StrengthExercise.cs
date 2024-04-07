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
        return base.CaloriesBurnedPerMinute() * _weight;

    }

    public override string GetDetailString()
    {
        return $"Name: {_name} Calories Burned: {CaloriesBurnedPerMinute()} and weight from dumbbells worked with: {_weight} "; 
    }


}