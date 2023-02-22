using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> textVerseToList;
        Random ran = new Random();

        string text = "Adán cayó para que los hombres existiesen; y existen los hombres para que tengan gozo.";
        string[] scriptureList = text.Split(" ");

        textVerseToList = new List<string>(scriptureList);
        List<int> newList = new List<int>();

        int count = textVerseToList.Count;
        string value = "";

        do {       
            Console.Clear(); 
            Console.WriteLine($"{string.Join(" ", textVerseToList)}");
            Console.WriteLine("\n\nPRESS ENTER TO CONTINUE OR 'TYPE' QUIT TO FINISH");
            Console.WriteLine(newList.Count +" - "+  count);

            value = Console.ReadLine();

            if ((value == "" || value == null) && newList.Count < count) {
                
                for (int i = 0; i < 5; i++) {
                    int rn = ran.Next(0, textVerseToList.Count);
                    
                    if (!newList.Contains(rn)){

                        newList.Add(rn);
                        
                        int aux = textVerseToList[rn].Length;               
                        string str = new string('_', aux);                             
                        textVerseToList[rn] = str;
                    }
                }
            }
            else break;
        } while(value != "quit");
    }
}
