// Author: Jennifer Malan
//Creativity Added: Addressed invalid input. Highlighted displayed journal entries in green to make console viewing easier. Added a message about having no entries to display if list-length=0. Configured Streamwriter parameters so that new journal entries are appended to the journal instead of overwriting it. Used a .csv file instead of a .txt file and handled the delimiters appropriately. 

using System;
using System.ComponentModel.DataAnnotations;
using System.Timers;
using System.Xml.Serialization;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args) {

        Journal myJournal = new Journal();

        while (true)
        {
           
            Console.Write("\nPlease select one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit\nWhat would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {

                Prompt generatedPrompt = new Prompt();
                string savedPrompt = generatedPrompt.GetRandomPrompt();
                Console.Write($"{savedPrompt}\n>");
                string userInput = Console.ReadLine();
                DateTime today = DateTime.Today;
                string currentDate = today.ToString("MM-dd-yyyy");

                Entry entry1 = new Entry();
                entry1._date = $"{currentDate}";
                entry1._promptText = $"{savedPrompt}";
                entry1._entryText = $"{userInput}";

                myJournal.AddEntry(entry1);
            }
            else if (choice == "2")
            {
                int entriesLength = myJournal._entries.Count;
                if (entriesLength == 0)
                {
                    Console.Write("\nYou have no entries to display.\n");
                }
                else if (entriesLength >= 1)
                {
                    myJournal.DisplayAll();
                }
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }

            else if (choice == "5")
            {
                return;
            }

            else
            {
                Console.Write("Invalid input.  Please try again.");
            }
        }
    }
}