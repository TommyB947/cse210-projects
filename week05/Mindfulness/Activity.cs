using System;
using System.Configuration.Assemblies;
using System.Diagnostics;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;



    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }



    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity. ");
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Well Done! ");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity. ");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        while (seconds >= 0)
        {
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            seconds -= 1;
        }
        Console.Write("\b \b");
    }

    public void ShowCountDown(int seconds)
    {
        int count = 0;
        while (seconds != count)
        {
            Console.Write($"{seconds - count}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            count += 1;
        }
    }
}