using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        string response = "yes";


        while (response == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = -1;
            int guessCount = 1;
            while (magicNumber != guess)
            {
                Console.Write("What is your guess (1-100, whole numbers?) ");

                guess = int.Parse(Console.ReadLine());


                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses!");
                }

                guessCount++;


            }
            Console.Write("Do you want to play again? (yes/no) ");
            response = Console.ReadLine();
        }
       
    }
   
}