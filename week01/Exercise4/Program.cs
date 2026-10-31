using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string userInput;
        int item;
        int sum = 0;
        float average;
        int largest = -1000000;

        Console.WriteLine("Enter a list of number, type 0 when finished. ");
        
        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            item = int.Parse(userInput);
            if (item != 0)
            {
                numbers.Add(item);
            }
        } while (item != 0);
        
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}