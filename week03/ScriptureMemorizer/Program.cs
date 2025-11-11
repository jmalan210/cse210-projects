//Author: Jennifer Malan
//Creativity Added: Designed program to select a random scripture from a JSON data file. Added a loop to offer the user the opportunity to memorize another scripture. Organized it so that the user would not get duplicate scriptures during a session, and added a message indicating the user had memorized all scriptures if they go through the entire library.
using System;
using System.Security.AccessControl;
using System.Linq;
using System.Text.Json;


class Program
{

    static void Main(string[] args)
    {
        Library lib = new Library();
        lib.Load();

        while (true) {

        Scripture scripture = lib.GetRandomScripture();

        if (scripture == null)
        {
            Console.WriteLine("All scriptures memorized!");
            break;
        }

        Console.Clear();

        while (true) {
                Console.WriteLine(scripture.GetScriptureDisplayText());
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
