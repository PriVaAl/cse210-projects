using System
public class Job
{
    private string _company;
    private string _jobTitle;
    private int _enterYear;
    private int _endYear;
    
    public Job( string company, string jobTitle, int enterYear, int endYear) 

    {
        _company = company;
        _jobTitle = jobTitle;
        _enterYear = enterYear;
        _endYear = endYear;
    }

    public void DisplayJobInformation()
    {
        Console.WriteLine($"{_company}, {_jobTitle}, {_enterYear} {_endYear}")
    }
}