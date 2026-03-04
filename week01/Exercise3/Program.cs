using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;

        Console.WriteLine("I'm thinking of a random number.");

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess boiiii??? ");
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
                Console.WriteLine("You got it");
            }
        }
    }
    
    
}