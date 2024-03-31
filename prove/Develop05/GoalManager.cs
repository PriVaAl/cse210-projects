using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }    
    
    public void Start()
    {
        bool exit = false;
        while(!exit)
        {

            //Console.WriteLine(" ");
            DisplayPlayerInfo();
            Console.WriteLine("\nWelcome to Menu.");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Remove goal.");
            Console.WriteLine("7. Exit");
            
            Console.Write("\nChose an option from menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
                Console.Clear();
                
            }
            else if(choice == "2")
            {
                ListGoalDetails();
            }
            else if(choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                RemoveGoal();
            }
            else 
            {
                Console.WriteLine("Thank you for your time");
                exit =true;
                
            }
            
        }    

    }

    //Exceeding requirements--- Created a new method to remove the goal from list.

    public void RemoveGoal()
    {
        Console.WriteLine("Remove a goal");
        ListGoalDetails(); 

        Console.Write("Enter the index of the goal to remove: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goalToRemove = _goals[index];
            _goals.Remove(goalToRemove); 
            Console.WriteLine("Goal removed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.Write($"You have:{_score} points.");
    }

    public void ListGoalNames()
    {
        
        Console.WriteLine($"The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            string detailString = _goals[i].GetDetailString();

            int startIndex = detailString.IndexOf(']');
            int endIndex = detailString.IndexOf('(' );
            
            string shortName = detailString.Substring(startIndex + 1, endIndex - startIndex - 1).Trim();
            Console.WriteLine($"{i + 1}, {shortName}");
        }
    }

    public void ListGoalDetails()
    {
        Console.Write("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1 }. {_goals[i].GetDetailString()}");

        }
    }

    public void CreateGoal()
    {
        
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal.");
        Console.WriteLine("2. Eternal Goal.");
        Console.WriteLine("3. Check List Goal.");

        Console.Write("\nWhich type of goal woudl you like to create?: ");
        string goalChoice = Console.ReadLine();


        if(goalChoice == "1")
        {
            Console.WriteLine("What is the name of your goal?: ");
            string shortName = Console.ReadLine();

            Console.WriteLine("What is the short description of your goal?: ");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with your goal?: ");
            int points = int.Parse(Console.ReadLine());


            SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points, false);
            _goals.Add(simpleGoal);
            
        }
        else if (goalChoice == "2")
        {
            Console.WriteLine("What is the name of your goal?: ");
            string shortName = Console.ReadLine();

            Console.WriteLine("What is the short description of your goal?: ");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with your goal?: ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalChoice == "3")

        {
            Console.WriteLine("What is the name of your goal?: ");
            string shortName = Console.ReadLine();

            Console.WriteLine("What is the short description of your goal?: ");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with your goal?: ");
            int points = int.Parse(Console.ReadLine());

            Console.Write("Enter the total number of times this goal must be accomplish for a bonus: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter the total of the bonus for this goal accomplishment: ");
            int bonus = int.Parse(Console.ReadLine());
            
            CheckListGoal checkListGoal = new CheckListGoal(shortName, description, points, target, bonus); 
            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("Select a type of goal from menu.");

        }
        Console.WriteLine("Goal created successfully.");
    }    
    
    
    public void RecordEvent()
    {
        Console.WriteLine("Record an event");
        ListGoalNames();
        Console.Write("Enter the index of the goal to record the event for: ");
        int goalI = int.Parse(Console.ReadLine()) -1;

        if (goalI >= 0 && goalI < _goals.Count)
        {
            
            Goal goalT = _goals[goalI];
            if(goalT is SimpleGoal simpleGoal)
            {
                if(!simpleGoal.IsComplete())
                {
                    simpleGoal.RecordEvent();
                    if (simpleGoal.IsComplete())
                    {
                        string representation = simpleGoal.GetStringRepresentation();
                        string [] parts = representation.Split(',');
                        int points = int.Parse(parts[2]);
                        _score += points;
                        Console.WriteLine($"Good Job! You have earned {points} points!");
                    }

                }
                else 
                {
                    Console.WriteLine("Please add a new SimpleGoal, you have already completed it.");
                }    
            }
            else if (goalT is EternalGoal eternalGoal)
            {
                eternalGoal.RecordEvent();
                string representation = eternalGoal.GetStringRepresentation();
                string [] parts = representation.Split(',');
                int points = int.Parse(parts[2]);
                _score += points; 
                Console.WriteLine($"Good Job! You have earned {points} points!");
            }
            else if (goalT is CheckListGoal checkListGoal)
            {
                if (checkListGoal.IsComplete())
                {
                 Console.WriteLine("Please add a new Checklist goal, you have already completed it.");   
                }
                else
                {
                    checkListGoal.RecordEvent();
                    string representation = checkListGoal.GetStringRepresentation();
                    string [] parts = representation.Split(',');
                    int points = int.Parse(parts[2]);
                    _score += points; 

                    if(checkListGoal.IsComplete())
                    {
                        int bonus = int.Parse(parts[3]);
                        _score+= bonus;
                        Console.WriteLine($"Great Job! You have earned {points} point!");
                    }
                    
                }
            }
            
            Console.WriteLine($"Good Job! You have now {_score} points!");
        }
        else
        {
            Console.WriteLine("Invalid index.");

        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of file for the goal?: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
               writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved succesfully.");

    }
    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("Enter the name of the file that contains the goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            
            using(StreamReader  reader = new StreamReader(filename))
            {
        
                string scoreLine = reader.ReadLine();
                _score = int.Parse(scoreLine);

                string line;
                while ((line = reader.ReadLine()) !=null )
                {
                    string [] parts = line.Split(':');
                    if(parts.Length >= 2)
                    {
                        string type = parts[0];
                        string details = parts[1];
                        {
                            if (type == "SimpleGoal")
                            {
                                string [] goalDetails = details.Split(',');
                                if(goalDetails.Length >= 4)
                                {
                                    string shortName = goalDetails[0];
                                    string description = goalDetails[1];
                                    int points = int.Parse(goalDetails[2]);
                                    bool isComplete = bool.Parse(goalDetails[3]);
                                    _goals.Add(new SimpleGoal(shortName, description, points, isComplete));
                                }
                            }
                        

                            else if (type == "EternalGoal")
                            {
                                string [] goalDetails = details.Split(',');
                                if(goalDetails.Length >= 3)
                                {
                                    string shortName = goalDetails[0];
                                    string description = goalDetails[1];
                                    int points = int.Parse(goalDetails[2]);
                                    _goals.Add(new EternalGoal(shortName, description, points));
                                } 
                                
                            }
                             else if (type == "CheckListGoal")
                            {
                                string [] goalDetails = details.Split(',');
                                if(goalDetails.Length >= 5)
                                {
                                    string shortName = goalDetails[0];
                                    string description = goalDetails[1];
                                    int points = int.Parse(goalDetails[2]);
                                    int bonus = int.Parse(goalDetails[3]);
                                    int target = int.Parse(goalDetails[4]);

                                    _goals.Add(new CheckListGoal(shortName, description, points, target, bonus));
                                }
                            }

                        } 
                        
                    }
                                
                }
            }
            
        }
    }
}     