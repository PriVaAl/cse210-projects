using System;
using System.Collections.Generic;
//For exceeding requirements I created a new subclass MeditationTimerActivity to use a timer for the meditation time.
class Program
{
    static void Main(string[] args)
    {
        string userChoice;

        do
        {
            
            Console.WriteLine("Menu Optios:");
            Console.WriteLine("Choose an activity: ");
            Console.WriteLine("1.Breathing Activity.");
            Console.WriteLine("2.Reflection Activity.");
            Console.WriteLine("3.Listing Activiy.");
            Console.WriteLine("4.Meditiation Timer Activity.");
            Console.WriteLine("5.Quit the program");
            
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if(int.TryParse(userChoice, out int choice))
            {
                if (choice == 1)
                {  
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", @"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    breathingActivity.Run();
                }

                else if (choice == 2)
                {
                    Console.Clear();  
                    List<string> prompts = new List<string>
                    {
                        "Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless."
                    };
                
                    List<string> questions = new List<string>
                    {
                        "Why was this experience meaningful to you?",
                        "Have you ever done anything like this before?",
                        "How did you get started?",
                        "How did you feel when it was complete?",
                        "What made this time different than other times when you were not as successful?",
                        "What is your favorite thing about this experience?",
                        "What could you learn from this experience that applies to other situations?",
                        "What did you learn about yourself through this experience?",
                        "How can you keep this experience in mind in the future?"
                    }; 
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", @"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 0, prompts, questions);
                    reflectionActivity.RunReflect();

                }

                else if (choice == 3)
                {
                    List<string> prompts = new List<string>
                    {
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"
                    };

                    ListingActivity listingActivity = new ListingActivity("Listing", "This Activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, 0,  prompts);
                    listingActivity.RunListing();
                }
                else if(choice == 4)
                {
                    string soundFilePath = "alarm.wav";
            
                    MeditationTimerActivity meditationTimerActivity = new MeditationTimerActivity("Meditation", "This Activity will help you will meditate, relaxing your body and mind and concentrate in your breathing",0, soundFilePath);
                    meditationTimerActivity.StartMeditation();

                }

                else if(choice == 5)
                {
                    Console.WriteLine("Thank you for participating.");
                    break;
                }
            
                else
                {
                    Console.Clear();
                }
            }
        } while (userChoice != "5");  
        
    }
}