using System;

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
            Console.WriteLine("Welcome to the Fitness Tracker Manager.");
            Console.WriteLine("The purpose is to assist you on your goals to burn calories through different workouts.");
            Console.WriteLine("Here is the information that we have for you:");
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Add user: ");
            Console.WriteLine("2.Display user information:");
            Console.WriteLine("3.Add goals:");
            Console.WriteLine("4.Display goals: ");
            Console.WriteLine("5.Add workout:");
            Console.WriteLine("6.Display last workout:");
            Console.WriteLine("7.Exit:");
            Console.Write("\nChose an option from menu: ");
            string option = Console.ReadLine();
        
            if (option == "1")
            {
                AddUser();

            }
                

            else if (option == "2")
            {
                Console.WriteLine("Still working on it.");
                
              
            }
            else if (option == "3")

            {
                //AddGoal();
                Console.WriteLine("Still working on it");

            }
            else if (option == "4")
            {
                Console.WriteLine("Still working on it.");

            }
            else if (option == "5")
            {
                Console.WriteLine("Still working on it.");

            }
            
            else if (option == "6")
            {
                Console.WriteLine("Still working on it.");

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
        Console.Write("Enter (exercises for the workout): ");
        string workout = Console.ReadLine();

        User newUser = new User(userName, workout, age, gender, weight, height);
        _users.Add(newUser);
        Console.WriteLine("User added successfully.");
    }

    public string AddGoal()
    {
        return AddGoal();
    }

    

    public void DisplayUserInfo()
    {
        foreach (var user in _users)
        {
            Console.WriteLine(user.DisplayUserInfo());
        }
    }

    public void DisplayGoals()
    {
        foreach(var goal in _goals)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
    }

    public void AddGoal(FitnessGoal goal)
    {   
        Console.WriteLine("Adding a new fitness goal:");
        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description =Console.ReadLine();
        Console.Write("Burn calorie target: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Date to accomplish goal (YYYY-MM-DD): ");
        string dateString = Console.ReadLine();

        DateTime date;
        if (!DateTime.TryParse(dateString, out date))
        {
            Console.WriteLine("Invalid date format. Please enter date in the format YYYY-MM-DD.");
    
            return;
        }
        FitnessGoal newGoal = new FitnessGoal(name, description, target, date);
        _goals.Add(newGoal);
        Console.WriteLine("Fitness goal added successfully.");
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
    public void AddWorkout(Workout workout)
    {
        Console.WriteLine(workout.WorkoutDetails());

    }

}