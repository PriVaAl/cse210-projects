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
        return $"Name:{_userName}, \nWorkout: {_workout}, \nAge: {_age} years, \nGender: {_gender}, \nWeight:{_userWeight}kg, \nHeight:{_height}cm.";
    }


}