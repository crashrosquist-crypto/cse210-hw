using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

        MathAssignment a1 = new MathAssignment("Crash Rosquist", "Calculus", "Calc-R3", "10-15");
        Console.WriteLine(a1.GetHomeworkList());
        // Just some extra practice
    }
}