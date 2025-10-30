using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            else
            {
                numbers.Add(number);
            }
        }

        int sum = numbers.Sum();
        int length = numbers.Count;
        float avg = ((float)sum) / length;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");

        int largestNumber = int.MinValue;
        foreach (int item in numbers)
        {
            if (item > largestNumber)
            {
                largestNumber = item;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");

        int smallestPositive = int.MaxValue;
        foreach (int item in numbers)
        {
            if (item > 0 && item < smallestPositive)
            {
                smallestPositive = item;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        
    }

}