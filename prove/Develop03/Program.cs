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

        Console.WriteLine("Welcome To Scripture Memorizer");
        Thread.Sleep(2000);
    }
    static void ExitMsg(){

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nFarewell, my son, until I shall write unto you, or shall meet you again. Amen.");
        Console.ForegroundColor = ConsoleColor.White;
        
        Thread.Sleep(2000);
    }
    static void Main(string[] args)
    {
        // Classes
        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        Word word = new Word();

        // initialize variables
        bool exit = false;
        string value = "";
        //string scriptureRef = "";
        string level = "";
        List<string> listAux = new List<string>();

        // Title and Color
        Console.Title = "Scripture Memorizer v0.1";
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        // call funtion
        WelcomeMsg();

        do {
            switch (scripture.MenuOptions()) {
            
            case 1:
                level = scripture.LevelSelected();
                listAux = reference.SendTextRef();
                do {
                    word.DisplayWords(level, listAux);
                                        
                    value = Console.ReadLine();
                    
                    if (value == "" || value == null ) {

                       word.HideWords(listAux);
                    }            
                } while(value != "quit");

                goto case 0;
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