public class ReflectionActivity : Activity
{ 
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions; 
    }  

    public void RunReflect()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your sesion?:");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready....");
        ShowSpinner(3);
        Console.Clear();
        DisplayPrompt();
        Console.WriteLine(" ");
        Console.WriteLine("When you have something in mind, please enter to continue.");
        ShowCountDown(5);
        Console.Write("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine(" ");
        Console.WriteLine("Please begin: ");
        Console.WriteLine("");
        DisplayQuestion(duration);
        Console.WriteLine(" ");
        ShowSpinner(5);
        Console.WriteLine(" ");
        DisplayEndingMessage(duration);
        Console.WriteLine(" ");

    }
    public string GetRandomPrompt()
    {

        Random random = new Random();
        int promptI = random.Next(_prompts.Count);
        string prompt = _prompts[promptI];
        Console.WriteLine($"Consider the following Prompt:");
        return prompt;
       
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int questionI =random.Next(_questions.Count);
        string question = _questions[questionI];
        return question;
        
       
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(" ");
        Console.WriteLine(prompt);
    }
    public void DisplayQuestion(int duration)
    {
        string question = GetRandomQuestion(); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        foreach(var q in _questions)
        {
            Console.WriteLine($">{q}");
            ShowSpinner(5);
            TimeSpan remainingT = endTime - DateTime.Now;
            if (DateTime.Now >= endTime || remainingT.TotalSeconds <3)
            {
                break;
            }
        }
    }
       
}

