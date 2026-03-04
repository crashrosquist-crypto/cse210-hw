using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        
        int guess = -1;

        Console.WriteLine("Enter A list of Numbers, type 0 when finished.");

        while (guess != 0)
        {
            Console.WriteLine("Enter A number ");
            string response = Console.ReadLine();
            guess = int.Parse(response);

            if (guess != 0)
            {
                numbers.Add(guess);

            }
            
        }
        
        Console.WriteLine($"You entered {numbers.Count} numbers.");

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}