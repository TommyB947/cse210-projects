using System;
using System.Runtime.CompilerServices;


//I did not use AI for this assignment
//For a bit of creaticvity I added a screen after the Listing Activity that reads back what you wrote before it moves you back to the Menu.
//I also added a screen before the menu that welcomes you to the application. 
class Program
{
    static async Task Main(string[] args)
    {
        int input = 0;
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Activity App!");
        Thread.Sleep(3000);
        Console.Clear();

        while (input != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                BreathingActivity BA = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                BA.Run();
                input = 0;
            }

            if (input == 2)
            {
                ReflectingActivity RA = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                RA.Run();
                input = 0;
            }

            if (input == 3)
            {
                ListingActivity LA = new ListingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                LA.Run();
                input = 0;
            }
        }
        Console.Clear();
    }
}