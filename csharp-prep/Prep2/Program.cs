using System;

class Program
{
    static string LetterSign(int userInput)
    {
        string sign = "";

         if ( userInput >= 90)
         {
            if (userInput %10 < 3) 
            {
                sign = "-";
            }
         }
         else if (userInput %10 >=7)
         {
            sign = "+";
         }
         else if (userInput %10 < 3 )
         {
            sign= "-";
         }
         else sign = "";
        
        return sign;
        }
    
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Welcome, please enter your Grade Percentage (0-100): ");
        string grade = Console.ReadLine();
        int userInput = int.Parse(grade);   

        string letter = "";
        string sign = "";

        if (userInput >= 90) 
        {
            letter = "A";
            sign = LetterSign(userInput);
        }
        else if (userInput >= 80)
        {
            letter = "B";
            sign = LetterSign(userInput);
        }
        else if (userInput >= 70)
        {
            letter = "C";
            sign = LetterSign(userInput);
        }
        else if (userInput >= 60)
        {
            letter = "D";
            sign = LetterSign(userInput);
        }
        else 
        {
            letter = "F";
        }

        if (userInput >= 70)
        {
            Console.WriteLine("Congratulation! You passed");
            Console.WriteLine("");
            Console.WriteLine($"Your Letter Grade is: {letter}{sign}");
        }
        else 
        {
            Console.WriteLine("You need to do better");            
        }
        
    }
}