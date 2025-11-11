//Author: Jennifer Malan
//Creativity Added: Designed program to select a random scripture from a JSON data file. Added a loop to offer the user the opportunity to memorize another scripture.
using System;
using System.Security.AccessControl;
using System.Linq;
using System.Text.Json;


class Program
{

    static void Main(string[] args)
    {
    while (true) {
        Library lib = new Library();
        lib.Load();

        Scripture scripture = lib.GetRandomScripture();

        if (scripture == null)
        {
            Console.WriteLine("No scriptures loaded.");
            return;
        }

        Console.Clear();
        Console.WriteLine(scripture.GetScriptureDisplayText());

        while (true) {
                Console.WriteLine("\nPress enter to hide words or type 'quit' to finish:");
                string entry = Console.ReadLine();

            if (entry.ToLower() == "quit")
            {
                return;
            }

            if (entry == "")
                {
                    scripture.HideRandomWords(5);
                    Console.Clear();
                    Console.WriteLine(scripture.GetScriptureDisplayText());

                if (scripture.EveryWordHidden())
                {

                    string reference = scripture.GetScriptureReference().GetReferenceDisplayText();
                    Console.WriteLine($"\nCongratulations! You've memorized {reference}!");
                    Console.WriteLine("\nWould you like to memorize another scripture? (type yes, or press enter to quit)");
                    string answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            break;
                        }

                        else
                        {
                            return;
                        }
                           
                        
                }

            }
            else
            {
                Console.WriteLine("Invalid entry.");
            }


        }




    }
}

}
