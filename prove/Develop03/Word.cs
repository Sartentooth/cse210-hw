using System;

class Word
{
    private List<int> _trackWord = new List<int>();
    private Random ran = new Random();

    public void DisplayWords(string scriptureRef, List<string> textList){

        Console.Clear(); 
        Console.WriteLine($"{scriptureRef} - {string.Join(" ", textList)}");
        Console.WriteLine("\n\nPRESS ENTER TO CONTINUE OR 'TYPE' QUIT TO FINISH");
        
    }
    public void HideWords(string scriptureRef, List<string> textList){
        string value;

        do{ 
            DisplayWords(scriptureRef, textList);
            value = Console.ReadLine();

            if ((value == "" || value == null) && _trackWord.Count < textList.Count) {

                for (int i = 0; i < 5; i++){

                    int rn = ran.Next(0, textList.Count);

                    if (!_trackWord.Contains(rn)){

                        _trackWord.Add(rn);
                            
                        int aux = textList[rn].Length;               
                        string str = new string('_', aux);                             
                        textList[rn] = str;
                    }
                }
            }
            else{
                _trackWord.Clear();
                textList.Clear();
                break;  
            } 
        } while(value != "quit");
    }
}