using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _count = 0;
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