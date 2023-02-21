using System.IO; 
using System;

/*
Progress Log -Class RandomList- v0.1 - Thursday 26/1/2023

Members:
    _listOfPrompt       : Declared
    _randomPrompt       : Declared

Methods:
    SendPrompt          : Declared
*/
class Scripture
{
    private Reference _scriptureRef = new Reference();
    private string _levels = "";

    // constructors


    public int MenuOptions(){
        // Variables for validation
        int outValue;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Please select one of the following: ");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("1. Play Game" +
            "\n2. "+
            "\n3. "+
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
    public string LevelSelected(){
        Console.WriteLine("SELECT DIFFICULTY LEVEL\n\n   EASY - MEDIUM - HARD");
        _levels = Console.ReadLine();

        string aux = "";

        if (_levels.ToLower() == "easy") {
            aux = _scriptureRef.SendScriptureRef();
    
        }
        else if (_levels.ToLower() == "medium"){
            _scriptureRef.SetBook("2 Nefi");
            _scriptureRef.SetChapter("2");
            _scriptureRef.SetVerse("25");
            aux = _scriptureRef.SendScriptureRef();
            
        }
        else if (_levels.ToLower() == "hard") {
            _scriptureRef.SetBook("Mosiah");
            _scriptureRef.SetChapter("2");
            _scriptureRef.SetVerse("17");
            aux = _scriptureRef.SendScriptureRef();
            
        }
        
        return aux;
    }
    public void GetTextRendered(){

        Console.WriteLine(_scriptureRef.SendScriptureRef());
        
    }

    private bool IsAllHidden(){
                
        return true;
    }
}