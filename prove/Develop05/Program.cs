using System;

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
            ShowGoals showGoals = new ShowGoals();

            // variables
            List<string> currentList = new List<string>();
            bool exit = false;

            // Title and Color
            Console.Title = "Eternal Goal v.01";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // call Method
            
            do {
                switch (mainMenu.MenuOptions()) {
                
                case 1:
                    switch (mainMenu.SubMenu())
                    {
                        case 1:
                            basicGoals.AddEntry();
                            break;
                        case 2:
                            eternalGoals.AddEntry();
                            break;
                        case 3:
                            checklistGoals.AddEntry();
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
                    showGoals.show();
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
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
            } while(!exit);            


        }
    }
}