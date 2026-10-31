using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int favNum = PromptUserNumber();

        int squareNum = SquareNumber(favNum);

        DisplayResult(name, squareNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string fav = Console.ReadLine();
        int favNum = int.Parse(fav);
        return favNum;
    }

    static int SquareNumber(int favNum)
    {
        int squareNum = favNum * favNum;
        return squareNum;
    }

    static void DisplayResult(string name, int squareNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNum}");
    }

}