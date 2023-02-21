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

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _textVerse;
    List<string> textVerseToList;
    private DateTime _dateTime = new DateTime();
    
    public Reference() {
        _book = "1 Nefi";
        _chapter = "1";
        _verse = "1";
        _textVerse = "y he aqui os dog estas cosas para que aprendais sabiduria; para que sepais que cuando os hallais al servicio de vuestros semejantes solo estais al servicio de vuestro dios";
    }
    public Reference(string book, string chapter, string verse, string textVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _textVerse = textVerse;
    }
    public string GetBook() {
        return _book;
    }
    public string GetChapter(){
        return _chapter;
    }
    public string GetVerse(){
        return _verse;
    }
    public string GetTextVerse(){
        return _textVerse;
    }
    public void SetBook(string book){
        _book = book;
    }
    public void SetChapter(string chapter){
        _chapter = chapter;
    }
    public void SetVerse(string verse){
        _verse = verse;
    }
    public void SetTextVerse(string textVerse){
        _textVerse = textVerse;
    }
    public string SendScriptureRef() {
    
        string scripturePassage= $"{_book} {_chapter}:{_verse}";
        return scripturePassage;
    }
    public List<string> SendTextRef() {

        string[] scriptureList = _textVerse.Split(" ");
        textVerseToList = new List<string>(scriptureList);
        return textVerseToList;
    }

    public string Score() {
        string time = _dateTime.TimeOfDay.ToString();
        return time;
    }
}
