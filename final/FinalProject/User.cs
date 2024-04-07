using System;
using System.Security.Cryptography;

public class User
{
    private string _userName;
    private string _workout;
    private int _age;
    private string _gender;
    private int _userWeight;
    private int _height;
    public User(string userName, string workout, int age, string gender,int userWeight, int height)
    {
        _userName = userName;
        _workout = workout;
        _age = age;
        _gender = gender;
        _userWeight = userWeight;
        _height = height;
    }



    public string DisplayUserInfo()
    {
        return $"Name:{_userName}, Workout: {_workout}, Age: {_age} years, Gender: {_gender}, Weight:{_userWeight}kg and Height:{_height}cm.";
    }

    public string AddUser()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.Write("What is your age?: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("What is your weight?: ");
        int weight = int.Parse(Console.ReadLine());
        Console.Write("What is your height?: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("What is your gender: ");
        string gender = Console.ReadLine();
        Console.Write("What is the workout that you want?: ");
        string workout = Console.ReadLine();
        return $"Name:{name}, Workout: {workout}, Age: {age} years, Gender: {gender}, Weight:{weight}kg and Height:{height}cm.";
    
    }
}