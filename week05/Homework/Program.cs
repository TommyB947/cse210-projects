using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.7", "8-19");
        Console.WriteLine($"{math1.GetSummary()}");
        Console.WriteLine($"{math1.GetHomeworkList()}");

        Console.WriteLine("");

        WritingAssignment write1 = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II");
        Console.WriteLine($"{write1.GetSummary()}");
        Console.WriteLine($"{write1.GetWritingInfo()}");
    }
}