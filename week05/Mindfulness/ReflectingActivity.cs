using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.CompilerServices;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    


    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }



    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder the follwing questions as they relate to this experience. ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        int num = _duration / 2;
        DisplayQuestions(GetRandomQuestion());
        ShowSpinner(num);
        DisplayQuestions(GetRandomQuestion());
        ShowSpinner(num);
        DisplayEndingMessage();
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        int num = Random.Shared.Next(1, _prompts.Count() + 1);
        string prompt = _prompts[num - 1];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        int num = Random.Shared.Next(1, _questions.Count() + 1);
        string prompt = _questions[num - 1];
        return prompt;
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"----- {prompt} -----");
    }

    public void DisplayQuestions(string question)
    {
        Console.WriteLine(question);
    }
}