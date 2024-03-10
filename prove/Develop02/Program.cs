using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        string choice;

        PromptGenator promptGenator = new PromptGenator();
        List<Entry> entries = new List<Entry>();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete last entry.");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do?: ");
            choice = Console.ReadLine();

            int userInput = int.Parse(choice);

           
            if (userInput == 1)
            {
                string randomPrompt = promptGenator.GetRandomPropmt();
                Console.WriteLine(randomPrompt);

                string journalEntry = Console.ReadLine();
                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToString("MM-dd-yyyy"),
                    _promptText = randomPrompt,
                    _entryText = journalEntry
                };
                entries.Add(newEntry);
            }

            else if (userInput == 2)
            {
                DisplayAll(entries);
            }

            else if (userInput == 3)
            {
                Console.Write("What is the file's name that you want to load?: ");
                string file = Console.ReadLine();
                entries = ReadFromFile(file);
            }
            
            else if (userInput == 4)
            {
                Console.Write("What is the name of the file to save entry?: ");
                string file = Console.ReadLine();
                SavetoFile(file, entries);
            }
            
            else if (userInput == 5)
            {
               
                
                if (entries.Count > 0)
                {
                    Entry lastEntry = entries[entries.Count -1];
                    entries.Remove(lastEntry);
                    Console.WriteLine("Last entry deleted succesfully.");    
                } 
                else
                {
                    Console.WriteLine("No entries deleted.");

                }
                
            }    
            
            else if (userInput == 6)
            {
                Console.WriteLine("Thank you for recording your experience, have a great day.");
            }

            else
            {
                Console.WriteLine("Select a valid choice.");
            }
        }while (choice != "6");
    }            
    public static void DisplayAll(List<Entry> entries)
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("This journal is empty.");
            return;
        }
        foreach (var entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }  
    }    
    public static void SavetoFile(string file, List<Entry> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry ent in entries)
            {
                outputFile.WriteLine($"Date: {ent._date} - Prompt: {ent._promptText}");
                outputFile.WriteLine($"{ent._entryText}");
            }
        }
        Console.WriteLine("All the entries saved to the file.");              
    }

    public static List<Entry> ReadFromFile(string file)
    {
        List<Entry> entries = new List<Entry>();

        string[] lines = File.ReadAllLines(file);
        for (int i = 0; i < lines.Length; i += 2)
        {
            
            string[] parts = lines[i].Split(" - Prompt: ", StringSplitOptions.RemoveEmptyEntries);
               
            string date = parts[0].Substring(6);
            string promptText = parts[1];
            string entryText = lines[i + 1];

            Entry entry = new Entry
            {
                _date = date,
                _promptText = promptText,
                _entryText = entryText
            };
            entries.Add(entry);
        }         
    

    return entries;
 
    }
   
  
}