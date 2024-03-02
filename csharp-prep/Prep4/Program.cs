using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List <int> numbers = new List<int>();
        int number = -1;

        while (number!= 0)
        {
            Console.Write( "Enter a number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            
            if (number!=0)
            {
                numbers.Add(number);
            }
        }    

        int total_sum = 0;

        foreach (int n in numbers)
        {
            total_sum += number; 
        }
        Console.WriteLine($"The sum of numbers is:{total_sum}.");

        float average = ((float)total_sum)/ numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}.");

        int largest = numbers[0];
        foreach (int n in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        
        Console.WriteLine($"The largest number is: {largest}.");
                
    
    }
}