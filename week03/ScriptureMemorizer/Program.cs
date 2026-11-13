using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

//Exceeding the Requirements:
//I added functionality so that the program will only close when you type quit. 
//As your learning the scripture sometimes it's possible to memorize the wrong words in the scripture. 
//This will allow the user to check themselves when they think they have it down. 
//It also allows the user to try memorizing it again the right way if they were wrong before. 
//I also added functionality so that you can press any keys you want and it will step you forward in the program, and only when you type quit specifically will it close the program. 
//There is a dual purpose as well for the numebr of time you need to click enter to underscore the entire verse. 
//I both don't need to add extra logic and it forces the user to repeat the scripture many more times than normal. 

class Program
{
    static void Main(string[] args)
    {
        string stop = "";
        Reference reference1 = new Reference("James", 1, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed. ");

        while(stop != "quit")
        {
            
            Console.Clear();
            Console.WriteLine(reference1.GetDisplayText() + " " + scripture1.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            stop = Console.ReadLine();
            Console.Clear();
            
            scripture1.HideRandomWords(3);
        }
    }
}