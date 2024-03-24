public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }
    
    public void RunListing()
    {
        DisplayStartingMessage();
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your sesion?:");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("You will begin now with the list");
        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(3);
        Console.WriteLine(" ");
        Console.WriteLine("Think about the following prompt.");
        GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine(" ");

        Console.WriteLine("You have a few moments to start your list.");
        Console.WriteLine(" ");

        List<string> itemList = GetListFromUser(duration);
        Console.WriteLine(" ");
        DisplayEndingMessage(duration);
        Console.WriteLine(" ");
        ShowSpinner(3);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptI = random.Next(_prompts.Count);
        string prompt = _prompts[promptI];
        Console.WriteLine("List as many answers you can to the following prompt:");
        Console.WriteLine(" ");
        Console.WriteLine($"- - -{prompt}- - -");
        Console.Write("You may begin: ");
        return prompt;
    }

    public List<string> GetListFromUser(int duration)
    {
        string userInput;
        List<string> itemList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            userInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userInput))
            {
            itemList.Add(userInput);
            _count++;
            }
            if (DateTime.Now >= endTime)
            {
                break;
            }
            Console.WriteLine($"You listed {_count} items.");
            Console.WriteLine("");       
        }
        return itemList;
        
    }

}