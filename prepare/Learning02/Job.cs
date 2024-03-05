using System;
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _enterYear;
    public int _endYear;

    public void Display()   
    {
        Console.WriteLine($" {_jobTitle}, {_company}, {_enterYear}-{_endYear}");
    }
}