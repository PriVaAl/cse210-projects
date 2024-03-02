using System;
using Sytem.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List <int> numbers = new List<int>();
        int number = -1

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

           
        
    }
}