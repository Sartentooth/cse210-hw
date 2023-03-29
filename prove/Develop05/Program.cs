using System;
using System.IO;
using System.Threading.Tasks;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            // classes 
            MainMenu mainMenu = new MainMenu();
            Rewards rewards = new Rewards();
            BasicGoals basicGoals = new BasicGoals();
            EternalGoals eternalGoals = new EternalGoals();
            ChecklistGoals checklistGoals = new ChecklistGoals();

            // variables
            List<Goals> listOfGoals = new List<Goals>();
            List<string> listGoals = new List<string>();
            string fileName = "";
            bool exit = false;
            int counter = 0;
            bool isNotNull = false;
            int userInput = 0;

            // Title and Color
            Console.Title = "Eternal Goal v.01";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

      
            do
            {
                switch (mainMenu.MenuOptions())
                {
                    case 1:
                        switch (mainMenu.SubMenu())
                        {
                            case 1:
                                basicGoals.EntryUser(listGoals);
                                break;
                            case 2:
                                eternalGoals.EntryUser(listGoals);
                                break;
                            case 3:
                                checklistGoals.EntryUser(listGoals);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\nInvalid Option");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 2:
                        foreach (string line in listGoals)
                        {
                            Console.WriteLine($"{line}");
                        }
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Please, enter the file name to save (in .txt):\n>> ");
                        Console.ForegroundColor = ConsoleColor.White;

                        fileName = Console.ReadLine();

                        foreach (Goals goal in listOfGoals)
                        {
                            goal.SaveFile(fileName, listOfGoals); 
                        }
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Please, enter the file name to load:\n>> ");
                        Console.ForegroundColor = ConsoleColor.White;

                        fileName = Console.ReadLine();

                        bool fileExist = File.Exists(fileName);

                        if (fileExist)
                        {
                            foreach (Goals goal in listOfGoals)
                            {
                                goal.LoadFile(fileName, listOfGoals);
                            }
                        }
                        else
                        {
                            Console.WriteLine("File does not exist.");
                        }
                        break;
                    case 6:

                        foreach (Goals goal in listOfGoals)
                        {
                            Console.WriteLine(goal.GName);
    
                            // if (goal.GetType() == basicGoals.GetType() && !string.IsNullOrEmpty(goal.GName))
                            // {
                            //     Console.ForegroundColor = ConsoleColor.Magenta;
                            //     Console.WriteLine($"{counter += 1}. [BasicGoal] {goal.GName}");
                            //     Console.ForegroundColor = ConsoleColor.White;
                            //     isNotNull = true;
                            // }
                            // else if (goal.GetType() == eternalGoals.GetType() && !string.IsNullOrEmpty(goal.GName))
                            // {
                            //     Console.ForegroundColor = ConsoleColor.Magenta;
                            //     Console.WriteLine($"{counter += 1}. [EternalGoal] {goal.GName}");
                            //     Console.ForegroundColor = ConsoleColor.White;
                            //     isNotNull = true;
                            // }
                            // else if (goal.GetType() == checklistGoals.GetType() && !string.IsNullOrEmpty(goal.GName))
                            // {
                            //     Console.ForegroundColor = ConsoleColor.Magenta;
                            //     Console.WriteLine($"{counter += 1}. [CheckListGoal] {goal.GName}");
                            //     Console.ForegroundColor = ConsoleColor.White;
                            //     isNotNull = true;
                            // }
                        }

                        if (isNotNull)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("What goal do you want to record?:\n(1 Basic) - (2 Eternal) - (3 Checked)\n>> ");
                            Console.ForegroundColor = ConsoleColor.White;

                            userInput = int.Parse(Console.ReadLine());

                            if (userInput == 1)
                            {
                                basicGoals.RecordEvent();
                            }
                            else if (userInput == 2)
                            {
                                eternalGoals.RecordEvent();
                            }
                            else if (userInput == 3)
                            {
                                checklistGoals.RecordEvent();
                            }
                        }
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nInvalid Option");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.ReadKey();
                        break;
                }
                Console.Write("\npress enter to continue...");
                Console.ReadKey();
            } while (!exit);
        }
    }
}