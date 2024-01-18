using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (user_number != 0)
            {
                Console.Write("Enter a number: ");
                string user_input = Console.ReadLine();
                user_number = int.Parse(user_input);

            if (user_number != 0)
                {
                    numbers.Add(user_number);
                }

            }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max_number = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max_number)
            {
                max_number = numbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {max_number}");
        

    }
}