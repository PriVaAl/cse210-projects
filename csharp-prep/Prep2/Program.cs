using System;

class Program
{
    static void Main(string [] args)
    {
        
        Console.Write("What is your grade percentage?: ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        if (percentage >= 90)
        {
            Console.WriteLine($"Your grade {percentage} corresponds to an A.");
        }
        
        else if (percentage >= 80)
        {
            Console.WriteLine($"Your grade {percentage} corresponds to an B.");
        }
        
        else if (percentage >= 70)
        {
            Console.WriteLine($"Your grade {percentage} corresponds to an C.");
        }
        
        else if (percentage >= 60)
        {
            Console.WriteLine($"Your grade {percentage} corresponds to an D.");
        }

        else
        {
            Console.WriteLine($"Your grade {percentage} corresponds to an F.");
        }
        
        if (percentage >= 70)
        {
            Console.WriteLine($"Congratulations you have passed the class!");
        }
        else
        {
            Console.WriteLine($"You haven't passed the class, Don't give up and keep trying you got it.");
        }
    }
}