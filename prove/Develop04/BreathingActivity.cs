using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name,description, duration) {}
     public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your sesion?: ");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("\n\nBreath in...");
            ShowCountDown(4);

            if (DateTime.Now >= endTime)
               break; 

            Console.Write("\nBreath out ...");
            ShowCountDown(6);
        }
        Console.WriteLine(" ");
        DisplayEndingMessage(duration);
    }
}
   