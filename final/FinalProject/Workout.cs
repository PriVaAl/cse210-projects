using System;

public class Workout
{
    protected List <Exercise> _exercises;
    protected string _newExercise;
   
    
    public Workout()
    {
        _exercises = new List<Exercise>();


    }
    

    public void AddExcercise(Exercise newExercise)
    {
        _exercises.Add(newExercise);
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