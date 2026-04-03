using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"{GetRandomPrompt()}");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Press enter after each item. The activity will stop after your next entry once time is up!");
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>
        {
            "Who is someone you could show appreciation for today?",
            "What is something good you did today?",
            "Have you felt the Savior's love in your life today?",
            "Was there anyone you did a service for today?",
            "What are some of your favorite songs to listen to?"
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }
}