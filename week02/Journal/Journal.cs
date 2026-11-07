using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Mime;

public class Journal
{
    public static List<Entry> _entries = new List<Entry>();

    public static void AddEntry()
    {
        Console.WriteLine("");
        Entry _newEntry = new Entry();
        PromptGenerator _promptText = new PromptGenerator();
        _newEntry._promptText = PromptGenerator.GetRandomPrompt();
        Console.WriteLine($"{_newEntry._promptText}");
        _newEntry._entryText = Console.ReadLine();
        _newEntry._date = DateTime.Today.ToString("d");

        _entries.Add(_newEntry);
        Console.WriteLine("");
    }

    public static void DisplayAll()
    {
        Console.WriteLine("");
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

    public static void SaveToFile(string file)
    {
        Console.WriteLine("");
        if (File.Exists(file))
        {
            File.WriteAllText(file, string.Empty);
        }
        foreach (Entry entry in _entries)
        {
            string date = entry._date;
            string prompt = entry._promptText;
            string userEntry = entry._entryText;
            string[] content = {$"{date}", $"{prompt}", $"{userEntry}"};
            File.AppendAllLines(file, content);
        }
        Console.WriteLine("");
    }

    public static void LoadFromFile(string file)
    {       
        _entries.Clear();

        int number = 1;
        string date = "a";
        string promptText = "a";
        string entryText = "a";

        foreach (string line in File.ReadLines(file))
        {
            
            if (number == 3)
            {
                entryText = line;

                Entry _newEntry = new Entry();
                _newEntry._date = date;
                _newEntry._promptText = promptText;
                _newEntry._entryText = entryText;

                _entries.Add(_newEntry);

                number = 0;
            }
            
            if (number == 2)
            {
                promptText = line;
                number = number + 1;
            }

            if (number == 1)
            {
                date = line;
                number = number + 1;
            }

            if (number == 0)
            {
                number += 1;
            }
        }
        
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        DateOnly yestermorrow = today.AddDays(-1);
        string yesterday = yestermorrow.ToString();

        Console.WriteLine($"{_entries[^1]._date}");
        Console.WriteLine(yesterday);
        
        if (yesterday != _entries[^1]._date)
        {
            Console.Write("Looks like you did'nt Journal yesterday! Be sure to Journal every single day!");
        }
        else
        {
            Console.Write("You remember to write in your journal yesterday! Keep up the good journaling practices!");
        }
        Console.WriteLine("");
    }
}