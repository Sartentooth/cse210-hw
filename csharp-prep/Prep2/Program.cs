using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Welcome, please enter your Grade Percentage (0-100): ");
        string grade = Console.ReadLine();
        int userInput = int.Parse(grade);   

        string letter = "";

        if (userInput >= 90) 
        {
            letter = "A";
        }
        else if (userInput >= 80)
        {
            letter = "B";
        }
        else if (userInput >= 70)
        {
            letter = "C";
        }
        else if (userInput >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine("");
        Console.WriteLine($"Your Letter Grade is: {letter}");

        if (userInput >= 70)
        {
            Console.WriteLine("Congratulation! You passed");
        }
        else 
        {
            Console.WriteLine("You need to do better");            
        }
        
    }
}