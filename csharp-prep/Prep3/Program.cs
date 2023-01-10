using System;

class Program
{
    static bool gameOver()
    {
        while (true)
        {
            Console.Write("Play Again (yes/no? ");
            string userInput = Console.ReadLine();

            if ((userInput != "yes" && userInput != "no") || (userInput == ""))
            {
                Console.WriteLine("Please enter a valid option... Press enter to continue");
                Console.ReadKey();
            }
            else if (userInput == "yes")
            {
                return true;
            }
            else return false;
        }
    }
    static void Main(string[] args)
    {
        Console.Clear();
    
        Random magicNumber = new Random();
        int magicNum = magicNumber.Next(1, 100);

        // Core Rules
        string userInput = "";
        int userNumber = 0;

        // Stretch Challenge
        int trackGuesses = 0;
        bool playing = true;

        do
        {
            Console.Write("What is the Magic Number?: ");

            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            
            trackGuesses += 1;

            if (userNumber == magicNum)
            {
                Console.WriteLine("You Guessed it!!!");
                Console.WriteLine($"you guess {trackGuesses} times");

                trackGuesses = 0;

                playing = gameOver();

                if (playing == true)
                {
                    magicNum = magicNumber.Next(1, 10);
                    Console.Clear();
                }
            }
            else if (userNumber > magicNum)
            {
                Console.WriteLine("Go Lower");
            }
            else 
                Console.WriteLine("Go Higher");

        }while (playing == true );

        Console.WriteLine("GAME OVER");
    }
}