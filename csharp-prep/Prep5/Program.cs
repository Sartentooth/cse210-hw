using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("what is your name? ");
        string userInput = Console.ReadLine();
        return userInput;
    }
    static int PromptUserNumber()
    {
        Console.Write("what is your favorite number? ");
        string userInput = Console.ReadLine();
        int favoriteNum = int.Parse(userInput);
        return favoriteNum;
    }
    static int SquareNumber(int number)
    {
        double sqrNum = Math.Pow(number, 2);
        int aux = (int) sqrNum;
        return aux;        
    }
    static void DisplayResult(string name, int sqrNum)
    {
        Console.WriteLine($"{name}, the square of your number is: {sqrNum}");
    }


    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int power = SquareNumber(userNumber);
        DisplayResult(userName, power);
    }

}


/* 
DisplayResult - Accepts the user's name and the squared number and displays them.*/