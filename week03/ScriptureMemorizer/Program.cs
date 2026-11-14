using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

//Exceeding the Requirements:
//I added functionality so that at the beginning of the program the usre can pick which scripture they want to memorize. 

class Program
{
    static void Main(string[] args)
    {
        string scripture = "0";
        string stop = "";
        Reference reference1 = new Reference("James", 1, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed. ");

        Reference reference2 = new Reference("1 Nephi", 3, 7);
        Scripture scripture2 = new Scripture(reference1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ");

        Console.Clear();
        Console.WriteLine("What scripture would you like to memorize? ");
        Console.WriteLine($"1: {reference1.GetDisplayText()}");
        Console.WriteLine($"2: {reference2.GetDisplayText()}");
        scripture = Console.ReadLine();

        if (scripture == "1")
        {
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
        if (scripture == "2")
        {
            while(stop != "quit")
            {
                
                Console.Clear();
                Console.WriteLine(reference2.GetDisplayText() + " " + scripture2.GetDisplayText());
                Console.WriteLine("");
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

                stop = Console.ReadLine();
                Console.Clear();
                
                scripture2.HideRandomWords(3);
            }
        }
    }
}