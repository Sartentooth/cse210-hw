using System.IO; 
using System;
/*
Progress Log -Class Journal- v0.1 - Thursday 26/1/2023
Progress Log -Class Journal- v0.2 - Friday 27/1/2023
Progress Log -Class Journal- v0.3 - Saturday 28/1/2023
Progress Log -Class Journal- v0.4 - Saturday 28/1/2023

Members:
    _entryList      : Declared (eliminated in v0.2) 
    _prompts        : Declared in v0.1
    _dateTime       : Declared in v0.1
    _loadFromFile   : Declared in v0.1
    _saveToFIle     : Declared in v0.1

Methods:
    MenuOptions()         : Declared in v0.1 
    AddEntry()            : Declared in v0.1 (modified in v0.2) change: return a string
    DisplayAllEntries()   : Declared in v0.1 (modified in v0.3) pass as a parameters _loadFromFile to Entry Class
    DisplayCurrentEntry() : Declared in v0.1 (modified in v0.4) added more options to Display Entries and validations  
    LoadFile()            : Declared in v0.1 (modified in v0.3)
    SaveFile()            : Declared in v0.1 (modified in v0.3)
*/
class Journal
{
    public RandomList _prompts = new RandomList();
    public DateTime _dateTime = DateTime.Now;
    public string _loadFromFile = "";
    public string _saveToFile = "";

    public int MenuOptions(){
        // Variables for validation
        int outValue;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Please select one of the following: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1. Write new entry" +
            "\n2. Display All Entries"+
            "\n3. Display Current Entry"+
            "\n4. Load File"+
            "\n5. Save File"+
            "\n0. Exit");

        while(true) {

            Console.Write("\nEnter One Action: ");
            string userOption = Console.ReadLine();
        
            if (int.TryParse(userOption, out outValue)) {

                break;
            } 
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEnter a Valid Option. Press Enter To Continue...");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadKey();
            }
        }

        return outValue;
    }
    public void AddEntry(Entry entry) {
        
        entry._entryDate = _dateTime.ToString("dd/MM/yyyy");
        entry._entryPrompts = _prompts.SendPrompt();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"{entry._entryPrompts}\n>> ");
        Console.ForegroundColor = ConsoleColor.White;

        entry._entryUser = Console.ReadLine();

        entry._entryList.Add($"Date: {entry._entryDate} - Prompt: {entry._entryPrompts} - {entry._entryUser}");
    }

    public void DisplayCurrentEntry(Entry entry) {

        if (entry._entryList.Count == 0) {

            Console.ForegroundColor = ConsoleColor.DarkGray;        
            Console.WriteLine($"\nEntry no found. Please enter a new entry before"+
            "\nRemember to save the changes to a file to be able to see them in all entries");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else {
                
            foreach (string element in entry._entryList) {

                Console.WriteLine($"Date: {entry._entryDate} - Prompt: {entry._entryPrompts}\n{entry._entryUser}\n");
            }
        }
    }
    public void DisplayAllEntries(Entry entry) {

        if (String.IsNullOrEmpty(_loadFromFile)) {
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\nNothing to show...\nPlease load a file before");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else {

            entry.DisplayEntry(_loadFromFile);
        }
        
    }
    public void LoadFile() {

        
        Console.Write("Please, enter the name of the file (.txt): ");
        _loadFromFile = Console.ReadLine();

        if (String.IsNullOrEmpty(_loadFromFile)) {
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("The File is empty");
            Console.ForegroundColor = ConsoleColor.White;   
        }
        else {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\nFile {_loadFromFile} loaded");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public void SaveFile(List<string> _entryList) {

        
        Console.Write("Please, enter the name of the file (.txt): ");
        _loadFromFile = _saveToFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_saveToFile, append: true))
        {
            foreach (string line in _entryList) {

                outputFile.WriteLine($"{line}");
            }
        }
    }
}