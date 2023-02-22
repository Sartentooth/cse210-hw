using System.IO; 
using System;

class Scripture
{
    private Reference _scriptureRef = new Reference();
    private Word word = new Word();
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
        Console.WriteLine("SELECT DIFFICULTY LEVEL\n\nEASY - MEDIUM - HARD\n");
        Console.Write(">> ");
        _levels = Console.ReadLine();

        string aux = "";

        if (_levels.ToLower() == "easy") {
            _scriptureRef.SetBook("1 Nefi");
            _scriptureRef.SetChapter("1");
            _scriptureRef.SetVerse("12");
            _scriptureRef.SetTextVerse("Y sucedió que mientras leía, fue lleno del Espíritu del Señor.");

            aux = _scriptureRef.SendScriptureRef();
        }
        else if (_levels.ToLower() == "medium"){
            _scriptureRef.SetBook("2 Nefi");
            _scriptureRef.SetChapter("2");
            _scriptureRef.SetVerse("25");
            _scriptureRef.SetTextVerse("Adán cayó para que los hombres existiesen; y existen los hombres para que tengan gozo.");

            aux = _scriptureRef.SendScriptureRef();
        }
        else if (_levels.ToLower() == "hard") {
            _scriptureRef.SetBook("Mosiah");
            _scriptureRef.SetChapter("2");
            _scriptureRef.SetVerse("17");
            _scriptureRef.SetTextVerse("Y he aquí, os digo estas cosas para que aprendáis sabiduría; para que sepáis que cuando os halláis al servicio de vuestros semejantes, solo estáis al servicio de vuestro Dios.");

            aux = _scriptureRef.SendScriptureRef();
        }
        
        return aux;
    }
    public List<string> GetTextRendered(){

        return _scriptureRef.SendTextRef();
    }
}