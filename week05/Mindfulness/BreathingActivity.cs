using System;
using System.Data;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }



    public void Run()
    {
        int seconds = 9;
        int loops = 0;
        DisplayStartingMessage();
        int count = _duration / (seconds * 2);
        if (count <= 0)
        {
            count = 1;
        }
        while (loops != count)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe in... ");
            ShowCountDown(seconds);
            Console.WriteLine("");
            Console.Write("Breathe out... ");
            ShowCountDown(seconds);
            loops += 1;
        }
        DisplayEndingMessage();
        Console.Clear();
    }
}