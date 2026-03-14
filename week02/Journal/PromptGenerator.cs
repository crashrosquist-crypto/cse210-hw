using System;
using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Did you have any positive interactions with someone today?",
        "What was your favorite part of the day?",
        "Did you see God's hand in your life today?",
        "Do you have any regrets from today?",
        "What are you grateful for today?",
        "Did you express gratitude for anyone today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}