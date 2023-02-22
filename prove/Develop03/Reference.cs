using System;

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
        _verse = "12";
        _textVerse = "Y sucedió que mientras leía, fue lleno del Espíritu del Señor.";
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
