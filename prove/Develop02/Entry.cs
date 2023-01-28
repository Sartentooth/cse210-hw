using System;
/*
Progress Log -Class Entry- v0.1 - Friday 26/1/2023
Progress Log -Class Entry- v0.2 - Friday 27/1/2023
Progress Log -Class Entry- v0.3 - Saturday 28/1/2023

Members:
    _entryList          : Declared (added in v0.2)
    _entryUser          : Declared in 0.1
    _prompts            : Declared in 0.1
    _date               : Declared in 0.1

Methods:
    DisplayEntry        : Declared in 0.1 (Modified in v0.3) added validation and more functionality: now can read files

*/
class Entry
{
public List<string> _entryList = new List<string>();
    public string _entryUser = "";
    public string _entryPrompts = "";
    public string _entryDate = "";
    
    public void DisplayEntry(string _loadFromFile) {

        if (String.IsNullOrEmpty(_loadFromFile)) {

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nThe File is empty. Please load a File before");
            Console.ForegroundColor = ConsoleColor.White;

        }   
        else {

        string[] lines = System.IO.File.ReadAllLines(_loadFromFile);

            foreach (string line in lines)
            {
                string[] parts = line.Split("-");
                
                string date = parts[0].Trim();
                string prompt = parts[1].Trim();
                string entry = parts[2].Trim();
                Console.WriteLine($"Date: {date} - Prompt: {prompt} -\n{entry}\n");
            }
        }
    }
}

