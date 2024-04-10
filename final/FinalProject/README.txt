Final Project : Open-Ended Fitness Goal Tracker by Priscilla Valverde Alvarez.

Description: 
This project is a Fitness Tracker Goal that allows a user to set goals regarding the calories the user wants to burn through
workouts. The workout is created through different exercises, it can display the goal for the user save it on text, and load it later.

Design:
This project was designed in different classes that have specific functions on the program, such as:
Exercise: It provides the base and common functions and attributes for different exercises.
Cardio Exercise: Following the functions and attributes of the base class, calculate the calories burned per minute, displaying the information with the Heart frequency.
StretchExercise: With the function to display the burned calories per minute with a specific number of repetitions follows the base 
function and attributes.
StrengthExercise: Also uses the base functions and attributes with the variable of dumbbell's weight to calculate the burned calories
per minute.
Workout: Represents a workout session created from different exercises, allows users to mix exercises and calculate as 
well, the total calories burned per minute.
User: It has the user's data on the Tracker Fitness Goal: name, weight, height, gender, age, and preferred workout.
FitnesGoal: It compiles the fitness goals for the user for specific situations or events, such as burning calories for a beach trip, a wedding,
or graduation, allowing the user to name it for the special occasion, describe the expectation, mention a specific target of calories to burn,
and also a date to reach that goal.
FitnesTrackerManager: This class manages the functionality of the tracker, including adding users, displaying the user information, adding
goals, display goals, add workouts, display the last workout, save on a file, and load from the file as a menu for the user.
Program: Has the function to run all the classes and methods from the FitnesTrackerManager. 
Goals.txt: It's a file that works as an example for saving, loading, and displaying the user, workout, and goals information.
README: Shows the user the design purpose.

Usage:
The user has the option to choose from a menu as follows:
Adding User and Display the user information: requests and then display the user information (name, age, gender, weight, height, and workout)
Adding Goals and Display the goals: Displays a menu for the goals according to the different exercises and lets the user add the goals 
information and then display that (name, description, target calories burned, and date to accomplish that goal).
Adding and Displaying Workouts: Allows the user to create workouts from one or more exercises (Cardio, Stretch, and Strength) and then display 
the last workout information is exercise name, calories burned, duration, repetitions, dumbbell weight, and heart frequency. 
Saving and Loading Goals: A file allows the user to save and load the goals, user, and workout information. 
