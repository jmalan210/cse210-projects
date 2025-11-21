//Author: Jennifer Malan
//Creativity Shown: Added a User class that handles the user name and the number of activities they completed. Their name is used throughout and they get a count of activities reported to them when they quit. Optimized randomizers so that prompts aren't repeated (did so by removing items from a working list so the original list isn't altered).
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Project");
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        User user = new User(userName);
        Console.WriteLine($"Welcome {userName}!");

        while (true) {
           
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Breathing breathing = new Breathing(user);
                breathing.DisplayStartMsg();
                breathing.Run();
                breathing.DisplayEndMsg();
                user.AddActivity();
                
            }

            else if (menuChoice == "2")
            {
                Reflection reflection = new Reflection(user);
                reflection.DisplayStartMsg();
                reflection.Run();
                reflection.DisplayEndMsg();
                user.AddActivity();
            }

            else if (menuChoice == "3")
            {
                Listing listing = new Listing(user);
                listing.DisplayStartMsg();
                listing.Run();
                listing.DisplayEndMsg();
                user.AddActivity();
            }

            else if (menuChoice == "4")
            {
                Console.WriteLine($"Thanks for taking time for mindfulness today, {userName}!");
                if (user.GetActivityCount() == 1)
                {
                    Console.WriteLine($"You did {user.GetActivityCount()} activity today.");
                }
                else
                {
                    Console.WriteLine($"You did {user.GetActivityCount()} activities today.");
                }
                break;
            }

            else
            {
                Console.WriteLine("Invalid input. Please choose a number from 1-4.\n");
            }
        }
    }
}