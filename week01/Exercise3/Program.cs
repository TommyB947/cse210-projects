using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        string userInput;
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        do
        {
            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (number != guess);
    }
}