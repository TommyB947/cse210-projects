using System;
using System.Threading;
using System.Threading.Tasks;

class ListingActivity : Activity
{
    private  int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the follwing prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        List<string> entries = GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        Console.Clear();
        
        Console.WriteLine("You entered...");
        for (int i = 0; i < entries.Count(); i++)
        {
            Console.WriteLine(entries[i]);
        }
        ShowSpinner(5);
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        int num = Random.Shared.Next(1, _prompts.Count() + 1);
        string prompt = _prompts[num - 1];
        Console.WriteLine($"----- {prompt} -----");
    }

    public List<string> GetListFromUser()
    {
        List<string> entries = new List<string>();
        using var timer = new CancellationTokenSource(TimeSpan.FromSeconds(_duration));
        while (!timer.Token.IsCancellationRequested)
        {
            string item = Console.ReadLine();
            entries.Add(item);
            _count += 1;
        }

        return entries;
    }
}