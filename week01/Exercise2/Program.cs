using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Percentage Calculator.");
        Console.Write("What is your grade percentage? ");
        float grade = float.Parse(Console.ReadLine());
        string letter = "";
        if (grade >= 90.0)
        {
            letter = "A";
        }
        else if (grade >= 80.0)
        {
             letter = "B";
        }
        else if (grade >= 70.0)
        {
             letter = "C";
        }
        else if (grade >= 60.0)
        {
            letter = "D";
        }
        else 
        {
             letter = "F";
        }

        float lastDigit = grade % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");
        
        if (grade >= 70.0)
        {
            Console.WriteLine("Congratulations, you passed the class.");
        }
        else
        {
            Console.WriteLine("Better Luck Next Time Buddeh!");
        }
        
        
    }
}