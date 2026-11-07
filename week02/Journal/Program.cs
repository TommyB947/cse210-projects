//In my program I added a reminder when you load from a file that will check to see if the user wrote in their journal the day before. If they have'nt it will send a reminder to write in the journal daily. If they have ti will congratulate them for remembering the day before. 

using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;
        Console.WriteLine("Welcome to the Journal Program!");

        while (menu != 5) //Menu
        {
            if (menu == 0)
            {
                //Display menu
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                
                //User input
                string userChoice = Console.ReadLine();
                int.TryParse(userChoice, out menu);
            }

            if (menu == 1) //Write Entry
            {
                //Update
                Journal.AddEntry();
                menu = 0;
            }

            if (menu == 2) //Display Entries
            {
                Journal.DisplayAll();
                menu = 0;
            }

            if (menu == 3) //Load Entries
            {
                Console.WriteLine("");
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                Journal.LoadFromFile(file);

                menu = 0;
            }

            if (menu == 4) //Save Entries
            {
                Console.WriteLine("");
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                Journal.SaveToFile(file);

                menu = 0;
            }

            if (menu == 5) //Exit Program
            {
            }
        }
    }
}