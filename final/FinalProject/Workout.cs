using System;

public class Workout
{
    protected List <Exercise> _exercises;
    
    public Workout()
    {
        _exercises = new List<Exercise>();


    }
    

    public void AddExcercise(Exercise exercise)
    {
        _exercises.Add(exercise);
    }

    public int CalculateCaloriesBurned(int duration)

    {
        int totalCalories = 0;
        {
            foreach(var exercise in _exercises)
            {
                totalCalories += exercise.CaloriesBurnedPerMinute() * duration;

            }

            return totalCalories;

        }
    
    }

    public void AddExercise(Exercise exercise)
    {
        _exercises.Add(exercise);
    }
    public string WorkoutDetails()
    {
        string details = "Workout Details:\n ";
        foreach (var exercise in _exercises)
        {
            details+= exercise.GetDetailString();
        }
        return details;

    }
}