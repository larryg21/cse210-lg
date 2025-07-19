using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {


        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "Did you discover anything new or learn something interesting today? ",
        "Did someone make you feel special or make you smile today?",
        "What was the most meaningful spiritual experience you had today?",
        "Did you do anything today that took you out of your comfort zone?",
        "what do you most wish for tomorrow?",

    };
    private Random _random = new Random();
    public string GetRandomPrompt()

    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
    
    
