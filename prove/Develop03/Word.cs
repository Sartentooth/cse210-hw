using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Progress Log -Class RandomList- v0.1 - Thursday 26/1/2023

Members:
    _listOfPrompt       : Declared
    _randomPrompt       : Declared

Methods:
    SendPrompt          : Declared
*/

class Word
{
    private List<string> _trackWord = new List<string>();
    private Random ran = new Random();

    public void DisplayWords(string scriptureRef, List<string> textVerse){

        Console.Clear(); 
        Console.WriteLine(string.Join(" ", textVerse));
        Console.WriteLine("\n\nPRESS ENTER TO CONTINUE OR 'TYPE' QUIT TO FINISH");
       
    }
    public void HideWords(List<string> asd){

        int rn = ran.Next(0, asd.Count);
        
        int aux = asd[rn].Length;               
        string str = new string('_', aux);                             
        asd[rn] = str;
        
    }
}
