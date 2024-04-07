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

    public string AddGoal()
    {
        Console.Write("What is your goal's name?: ");
        string name = Console.ReadLine();
        Console.Write("What is your goal about?: ");
        string  description = Console.ReadLine();
        Console.Write("What is your burn calorie targe?: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the date you want to acomplish your goal?: ");
        int date = int.Parse(Console.ReadLine());
        return $"Name:{name}, description {description}, your burn calories target{target} and the date you want to accomplish {date}";
    }

    public string DisplayGoal()
    {
        return $"The name:{_name}, description: {_description}, target {_target} and date{_date}";
    }

}