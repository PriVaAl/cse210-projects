using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number?: ");
        //int number = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number =randomGenerator.Next(1, 100);
        
        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine("Congratulations! You have guessed the number.");
            }
            else if (guess > number )
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }

    }
}