using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello student! Please enter your class percentage: ");
        string percentageReported = Console.ReadLine();
        float percentageFloat = float.Parse(percentageReported);
        string letter = "X";
        string sign = "";
        if (percentageFloat % 10 >= 7)
        {
            sign = "+";
        }
        else if (percentageFloat % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }


        if (percentageFloat >= 90)
        {
            letter = "A";
        }

        else if (percentageFloat < 90 && percentageFloat >= 80)
        {
            letter = "B";
        }
        else if (percentageFloat < 80 && percentageFloat >= 70)
        {
            letter = "C";
        }
        else if (percentageFloat < 70 && percentageFloat >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentageFloat >= 97 || percentageFloat < 60)
        {
            Console.WriteLine($"Your grade is {letter}.");
        }

        else
        {
            Console.WriteLine($"Your grade is {letter}{sign}.");
        }


        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.Write("Congratulations, you have passed the course!");
        }
        else
        {
            Console.Write("Sorry, you have not passed the class this time. You'll do better next time!");
        }
    }
}