using System;
using System.Collections.Generic;

//For exceeding requirements created a menu for the user to choose what scripture to memorize.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Prompt the user to choose a scripture
        Console.WriteLine("Choose a Scripture:");
        Console.WriteLine("1. Proverbs 3:5-6");
        Console.WriteLine("2. Moses 3:19");
        Console.Write("Enter your choice (1 or 2): ");

        //Read the User Input
        string choice = Console.ReadLine().Trim();
        
        Reference reference;
        string verseText;
        
        if (choice == "1")
        {
            Console.Clear();
            reference = new Reference("Proverbs", 3, 5, 6);
            verseText =  "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }

        else if (choice == "2")
        {
            Console.Clear();
            reference = new Reference("Moses", 3, 19);
            verseText =  "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.";
        }

        else
        {
            Console.Clear();
            Console.WriteLine("Invalid choice");
            return;
        }

        Scripture scriptures = new Scripture(reference, verseText);

        Console.WriteLine($"{reference.GetDisplayText()} {scriptures.GetDisplayText()}");
        Console.WriteLine("Press Enter to continue or type 'quit' to exit");
        Console.ReadLine();
        
        while (!scriptures.IsCompletelyHidden())
        {
            Console.Clear();

            scriptures.HideRandomWords(3);
            
            Console.WriteLine($"{reference.GetDisplayText()} {scriptures.GetDisplayText()}");
            Console.WriteLine("Press Enter to continue or type 'quit' to exit");
            string input = Console.ReadLine().Trim();
            
            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
        }

    }
}