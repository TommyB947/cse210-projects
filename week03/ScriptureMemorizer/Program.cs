using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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
            
            int num = scripture1._words.Count() + 1;
            
            int randomNumber = Random.Shared.Next(1, num);
            
            if (scripture1.IsCompletlyHidden() == false)
            {
                scripture1.HideRandomWords(randomNumber - 1);
            }

            randomNumber = Random.Shared.Next(1, num);
            if (scripture1.IsCompletlyHidden() == false)
            {
                scripture1.HideRandomWords(randomNumber - 1);
            }

            randomNumber = Random.Shared.Next(1, num);
            if (scripture1.IsCompletlyHidden() == false)
            {
                scripture1.HideRandomWords(randomNumber - 1); 
            }
            
            if (scripture1.IsCompletlyHidden() == true)
            {
                for (int i = 0; i < scripture1._words.Count; i++)
                {
                    scripture1._words[i].Show();
                }
            }
        }
    }
}