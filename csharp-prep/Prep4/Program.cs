using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List <int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write( "Enter a number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            numbers.Add(number);
            
        }    

        int total_sum = 0;

        foreach (int n in numbers)
        {
            total_sum += n; 
        }
        Console.WriteLine($"The sum of numbers is:{total_sum}.");

        float average = ((float)total_sum)/ numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}.");

        int largest = numbers[0];
        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }
        
        Console.WriteLine($"The largest number is: {largest}.");
                
    
    }
}