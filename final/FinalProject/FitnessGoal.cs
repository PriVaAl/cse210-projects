using System;
using System.ComponentModel;
using System.Runtime;


public class FitnessGoal
{
    protected string _name;
    protected string _description;
    protected int _target;
    protected DateTime _date;

    public FitnessGoal(string name, string description, int target, DateTime date)
    {
        _name = name;
        _description = description;
        _target = target;
        _date = date;
    }


    public string DisplayGoal()
    {
        return $"Name:{_name}, \nDescription: {_description}, \nTarget {_target} \n Date{_date}";
    }

    public string GetStringRepresentation()
    {
        return $"{_name},{_description},{_target},{_date}";
    }

    public static FitnessGoal FromString(string line)
    {
        string[] parts = line.Split(',');
        if (parts.Length >= 4)
        {
            string name = parts[0];
            string description = parts[1];
            int target = int.Parse(parts[2]);
            DateTime date = DateTime.Parse(parts[3]);
            return new FitnessGoal(name, description, target, date);
        }
        return null; 
    }
}
