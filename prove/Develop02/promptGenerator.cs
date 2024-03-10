using System.Collections.Generic;

public class PromptGenator
{
    
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What is one thing new that you learned today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is a goal I want to achieve this week?",
        "Describe a moment that made you laugh today.",
        "How did you show kindness to someone else?",
        "What is a skill you want to improve?",
        "Reflect on a small victory you had today.",
        "How did you manage your emotions today?",
        "What is your favorite moment that you've spent with a special person today?"
    };
    
    public string GetRandomPropmt()
    {
        Random r = new Random();
        int index = r.Next(0, _prompts.Count);
        return _prompts[index];
    }

}