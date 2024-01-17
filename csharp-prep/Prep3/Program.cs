using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;

        while (number != guess)
            {
                Console.WriteLine("Guess a number from 1-100. What is your guess?");
                string user_guess = Console.ReadLine();
                guess = int.Parse(user_guess);

                if (number > guess)
                    {
                        Console.WriteLine("Higher");
                    }
                else if (number < guess)
                    {
                        Console.WriteLine("Lower");
                    }
                else
                    {
                        Console.WriteLine("You guessed it!");
                    }
            }


        


    }
}