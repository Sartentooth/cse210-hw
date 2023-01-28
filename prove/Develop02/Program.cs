using System;
using System.Threading;
/*
Progress Log -Main Program - v0.1 - Friday 27/1/2023

Classes:
    journal             : instantiated
    randomPrompt        : instantiated
    entry               : instantiated

Functions:
    WelcomeMsg          : Declared
    ExitMsg             : Declared

Variables:
    exit                : Declared
    userEntry           : Declared

*/
class Program
{
    // functions
    static void WelcomeMsg(){

        Console.WriteLine("Welcome To Journal");
        Thread.Sleep(2000);
    }
    static void ExitMsg(){

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSo Long, and Thanks for All the Fish");
        Console.ForegroundColor = ConsoleColor.White;
        
        Thread.Sleep(2000);
    }
    static void Main(string[] args)
    {
        // Classes
        Journal journal = new Journal();
        RandomList randomList = new RandomList();
        Entry entry = new Entry();
        
        // initialize variables
        bool exit = false;
        
        // Title and Color
        Console.Title = "Journal v.04";
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        // call funtion
        WelcomeMsg();

        do {
            switch (journal.MenuOptions()) {
            
            case 1:
                journal.AddEntry(entry);                
                break;
            case 2:
                journal.DisplayAllEntries(entry);
                break;
            case 3:
                journal.DisplayCurrentEntry(entry);
                break;
            case 4:
                journal.LoadFile();
                break;
            case 5:
                journal.SaveFile(entry._entryList);
                break;
            case 0:
                ExitMsg();
                exit = true;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nInvalid Option");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadKey();
                break;        
            }
            Console.Write("\npress enter to continue...");
            Console.ReadKey();
        } while(!exit);   
    }    
}