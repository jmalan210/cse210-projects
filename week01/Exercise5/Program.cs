using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqNumber = SquareNumber(userNumber);
        Console.WriteLine(DisplayResult(userName, sqNumber));

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

        }
        
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int  PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        static int SquareNumber(int number)
        {
            
            int sqNum = number * number;
            return sqNum;
        }

        static string DisplayResult(string name, int square)
        {
           
            string msg = $"{name}, the square of your favorite number is {square}";
            return msg;
        }

       
    }
}