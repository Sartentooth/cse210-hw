using System;
using System.Threading;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            // text file for welcome and end title
            string text = @"
             ________           ___                                                           
            `MMMMMMMb.         `MM                                    68b                    
             MM    `Mb          MM                              /     Y89                    
             MM     MM   ____   MM    ___   ____   ___   ___   /M     ___   _____  ___  __   
             MM     MM  6MMMMb  MM  6MMMMb  `MM(   )P' 6MMMMb /MMMMM  `MM  6MMMMMb `MM 6MMb  
             MM    .M9 6M'  `Mb MM 8M'  `Mb  `MM` ,P  8M'  `Mb MM      MM 6M'   `Mb MMM9 `Mb 
             MMMMMMM9' MM    MM MM     ,oMM   `MM,P       ,oMM MM      MM MM     MM MM'   MM 
             MM  \M\   MMMMMMMM MM ,6MM9'MM    `MM.   ,6MM9'MM MM      MM MM     MM MM    MM 
             MM   \M\  MM       MM MM'   MM    d`MM.  MM'   MM MM      MM MM     MM MM    MM 
             MM    \M\ YM    d9 MM MM.  ,MM   d' `MM. MM.  ,MM YM.  ,  MM YM.   ,M9 MM    MM 
            _MM_    \M\_YMMMM9 _MM_`YMMM9'Yb_d_  _)MM_`YMMM9'Yb.YMMM9 _MM_ YMMMMM9 _MM_  _MM_";

            string textEnd = @" 
            Relaxation App
               * * * *  
              * *     **
                  * *   
                  * *    
                    
              *   *   
                    
              *       *
                      * 
                  *     
                    
              *      *
                *
                
     copyright © 2023 SartenTooth ";
            // Classes 
            Relaxation relaxation = new Relaxation(text, textEnd, 20);
            Breathing breathing = new Breathing();
            Reflection reflection = new Reflection();
            Listing listing = new Listing();
            // initialize variables
            bool exit = false;

            // Title and Color
            Console.Title = "Relaxation v.01";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // call Method
            relaxation.ShowTitle();
            
            do {
                switch (relaxation.MenuOptions()) {
                
                case 1:
                    breathing.ShowBreathingTask();            
                    break;
                case 2:
                    reflection.ShowReflectionTask();
                    break;
                case 3:
                    listing.ShowListingTask();
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 0:
                    relaxation.ShowEndTitle();;
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