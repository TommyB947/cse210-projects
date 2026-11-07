using System;

public class PromptGenerator
{
    public static List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was your favorite food that you ate today?", 
        "What was the biggest miracle that you saw in your life today?"
    };

    public static string GetRandomPrompt()
    {
        int number = Random.Shared.Next(_prompts.Count);

        string _prompt;
        _prompt = _prompts[number];

        return _prompt;
    }
    
}