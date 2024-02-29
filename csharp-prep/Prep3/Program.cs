using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number =randomGenerator.Next(1, 100);

        Console.Write("What is your guess?:");
        string response = Console.ReadLine();
        int guess = int.Parse(response);
        int max = 100;

        while (guess>= max)
        {
            if (guess == number)
            {
                Console.WriteLine("Congratulations! You have guessed the number.");
            }
            else if (guess > number )
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }

    }
}