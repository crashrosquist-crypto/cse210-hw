namespace EternalQuest;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        List<Goal> goals = new List<Goal>()
        {
            new SimpleGoal("Crashtopher", "Finish Homework", 1000)

        };
    }
}