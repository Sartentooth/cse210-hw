using System;
/*
Progress Log -Class RandomList- v0.1 - Thursday 26/1/2023

Members:
    _listOfPrompt       : Declared
    _randomPrompt       : Declared

Methods:
    SendPrompt          : Declared
*/
class RandomList
{
    private List<string> _listOfPrompt = new List<string>(){
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What brings you joy?",
        "Describe a place where you felt happiest",
        "What was your greatest fear, and how did you conquer it?"
    };

    public Random _randomPrompt = new Random();

    public string SendPrompt() {

        string randomPrompt = _listOfPrompt[_randomPrompt.Next(0,_listOfPrompt.Count())];
        return randomPrompt;
    }
}