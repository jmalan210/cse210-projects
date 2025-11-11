//Author: Jennifer Malan
//Creativity Added: Handled invalid input. Add a congratulations message that uses the scripture reference. 
using System;
using System.Security.AccessControl;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        Reference r1 = new Reference("Isaiah", 9, 6); 

        Word word = new Word("For unto us a child is born, unto us a son is given: and the government shall be upon his shoulder: and his name shall be called Wonderful, Counsellor, The mighty God, The everlasting Father, The Prince of Peace.");

        Scripture scripture = new Scripture(r1, word.GetWordsDisplayText());
        string displayText = scripture.GetScriptureDisplayText();
        Console.WriteLine(displayText);


        while (true){
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

        string entry = Console.ReadLine();

        if (entry.ToLower() == "quit")
        {
            return;
        }

            if (entry == "")
            {
                scripture.HideRandomWords(8);
                Console.Clear();
                Console.WriteLine(scripture.GetScriptureDisplayText());

                if (scripture.EveryWordHidden())
                {
                    string scripRef = r1.GetReferenceDisplayText();
                    Console.WriteLine($"Congratulations! You've memorized {scripRef}!");
                    return;
                }

            }
            else
            {
                Console.WriteLine("Invalid entry.");
            }


        }




    }
}
