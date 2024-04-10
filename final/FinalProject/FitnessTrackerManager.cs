using System;
using System.Collections.Generic;
using System.IO;

public class FitnessTrackerManager
{
    protected List<FitnessGoal> _goals;
    protected Workout _lastWorkout;
    protected List<User> _users;

    public FitnessTrackerManager()
    {
        _goals = new List<FitnessGoal>();
        _users = new List<User>();
    
    }

    public void StartTracker()
    {
        bool exit = false;
        while(!exit)
        {
            Console.WriteLine("\n*****Welcome to the Fitness Tracker Manager*****");
            Console.WriteLine("The purpose is to assist you on your goals to burn calories through different workouts.");
            Console.WriteLine("Thank you for taking care of your mind and body, please review the Menu.");
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Add user");
            Console.WriteLine("2.Display user information");
            Console.WriteLine("3.Add goals");
            Console.WriteLine("4.Display goals");
            Console.WriteLine("5.Add workout");
            Console.WriteLine("6.Display last workout");
            Console.WriteLine("7.Save Goals");
            Console.WriteLine("8.Load Goals");
            Console.WriteLine("9.Exit");
            Console.Write("Choose an option from menu: ");
            string option = Console.ReadLine();
        
            if (option == "1")
            {
                AddUser();

            }
                
            else if (option == "2")
            {
                DisplayUserInfo();
                
            }
            else if (option == "3")

            {
                AddGoal();
                

            }
            else if (option == "4")
            {
                DisplayGoals();

            }
            else if (option == "5")
            {
                AddWorkout();

            }
            
            else if (option == "6")
            {
                DisplayLastWorkout();

            }
            else if (option == "7")
            {
                SaveGoals();

            }
            else if (option == "8")
            {
                LoadGoals();

            }
            else 
            {
                Console.WriteLine("Thank you for your time. Have a fitday!");
                exit = true;
            }
        }
        
    }
    public void AddUser()
    {
        Console.Write("Enter user name: ");
        string userName = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter weight in kg: ");
        int weight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height in cm: ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter gender: ");
        string gender = Console.ReadLine();
        Console.Write("Enter (exercises for the workout: Cardio, Stretch or Strength): ");
        string workout = Console.ReadLine();

        User newUser = new User(userName, workout, age, gender, weight, height);
        _users.Add(newUser);
        Console.WriteLine("User added successfully.");
    }


    public void DisplayUserInfo()
   {
        if (_users.Count == 0)
        {
            Console.WriteLine("No users found. Please add a user.");
            AddUser(); 
        }
        else
        {
            Console.WriteLine("***User information***");
            foreach (var user in _users)
            {
                Console.WriteLine(user.DisplayUserInfo());
            }
        }
   }    
    public void AddGoal()
    {   
        Console.WriteLine("Adding a new fitness goal:");
        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description =Console.ReadLine();
        Console.Write("Burn calorie target: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Date to accomplish goal (YYYY-MM-DD): ");
        DateTime date;

        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Invalid date format. Please enter date in the format YYYY-MM-DD.");
    
        }
        FitnessGoal newGoal = new FitnessGoal(name, description, target, date);
        _goals.Add(newGoal);
        Console.WriteLine("Fitness goal added successfully.");
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No fitness goals found. Please add a goal.");
            AddGoal(); // Call the AddGoal method to add a new goal
        }
        else
        {
            Console.WriteLine("***Fitness goals***");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.DisplayGoal());
            }
        }
    } 

    public void AddWorkout()
    {
        Workout workout = new Workout();
        Console.WriteLine("Select the type of exercise you want to create the workout for:");
        Console.WriteLine("1. Cardio Exercise.");
        Console.WriteLine("2. Stretching Exercise.");
        Console.WriteLine("3. Strenght Exercise.");

        Console.Write("\nWhich type of exercise would you like to create?: ");
        string exerciseChoice = Console.ReadLine();


        Exercise exercise = null;
        if(exerciseChoice == "1")
        {
            Console.Write("Enter the name to save the cardio exercise: ");
            string name = Console.ReadLine();
            Console.Write("Enter the calories associated with the cardio exercise: ");
            int calories = int.Parse(Console.ReadLine());
            Console.Write("Enter the duration of the cardio exercise (in minutes): ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter the heart frequency: ");
            int frequency = int.Parse(Console.ReadLine());

            exercise = new CardioExercise(name, calories, duration, frequency);
              
        }
        else if (exerciseChoice == "2")
        {
            Console.Write("Enter the name to save the stretching exercise: ");
            string name = Console.ReadLine();
            Console.Write("Enter the calories associated with the stretching exercise: ");
            int calories = int.Parse(Console.ReadLine());
            Console.Write("Enter the duration of the stretching exercise (in minutes): ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of repetitions: ");
            int repetitions = int.Parse(Console.ReadLine());

            exercise = new StretchingExercise(name, calories, duration, repetitions);
         }
            
        
        else if (exerciseChoice == "3")

        {
            Console.Write("Enter the name to save the strength exercise: ");
            string name = Console.ReadLine();
            Console.Write("Enter the calories associated with the strength exercise: ");
            int calories = int.Parse(Console.ReadLine());
            Console.Write("Enter the duration of the strength exercise (in minutes): ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter the weight used (in kg): ");
            int weight = int.Parse(Console.ReadLine());

            exercise = new StrengthExercise(name, calories, duration, weight);
        }
        else
        {
            Console.WriteLine("Select a type of goal from menu.");

        }
        workout.AddExercise(exercise);
        _lastWorkout = workout;
        Console.WriteLine("Workout created successfully.");
    }


    public void DisplayLastWorkout()
    {
        if(_lastWorkout != null)
        {
            Console.WriteLine("Last Workout details:");
            Console.WriteLine(_lastWorkout.WorkoutDetails());
        }
        else
        {
            Console.WriteLine("No workout recorded yet.");

        }

    }

    public void SaveGoals()
    {
        Console.Write("Enter the name of the file to save the goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (FitnessGoal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals()
    {
        _goals.Clear();

        Console.Write("Enter the name of the file that contains the goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    FitnessGoal goal = FitnessGoal.FromString(line);
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}   