//Author: Jennifer Malan
//Creativity Shown: optimized randomizers so that prompts aren't repeated (did so by removing items from a working list so the original list isn't altered).
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Project");

        while (true) {
           
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Breathing breathing = new Breathing();
                breathing.DisplayStartMsg();
                breathing.Run();
                breathing.DisplayEndMsg();
            }

            else if (menuChoice == "2")
            {
                Reflection reflection = new Reflection();
                reflection.DisplayStartMsg();
                reflection.Run();
                reflection.DisplayEndMsg();
            }

            else if (menuChoice == "3")
            {
                Listing listing = new Listing();
                listing.DisplayStartMsg();
                listing.Run();
                listing.DisplayEndMsg();
            }

            else if (menuChoice == "4")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid input. Please choose a number from 1-4.\n");
            }
        }
    }
}