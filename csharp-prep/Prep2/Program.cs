using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage?: ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        
        string letter = " ";

        if (percentage >= 90)
        {
            letter = "A";
        }
        
        else if (percentage >= 80)
        {
            letter = "B";
        }
        
        else if (percentage >= 70)
        {
            letter = "C";
        }
        
        else if (percentage >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your percentage {percentage} corresponds to {letter}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations you have passed the class!");
        }
        else
        {
            Console.WriteLine("You haven't passed the class, Don't give up and keep trying, you got it.");
        }
    }
}