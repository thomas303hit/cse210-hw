using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What made me smile today?",
            "What was a small win I had today?",
            "How did I see the hand of the Lord in my life today?",
            "What’s one thing I learned today?",
            "What’s something I’m grateful for today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}