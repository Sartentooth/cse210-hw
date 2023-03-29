using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class MainMenu
    {
        public int MenuOptions(){
            // Variables for validation
            int outValue;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select one of the following: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Create a new goal" +
                "\n2. List Current Goals"+
                "\n3. List Loaded Goals"+
                "\n4. Save Goals"+
                "\n5. Load Goals"+
                "\n6. Record Event"+
                "\n0. Exit");

            while(true) {

                Console.Write("\nEnter One Action: ");
                string userOption = Console.ReadLine();
            
                if (int.TryParse(userOption, out outValue)) {

                    break;
                } 
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter a Valid Option. Press Enter To Continue...");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadKey();
                }
            }
            return outValue;
        }

        public int SubMenu(){
            int outValue;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select one of the following Goals: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Basic Goal" +
                "\n2. Eternal Goal"+
                "\n3. Checklist Goal"
                );

            while(true) {

                Console.Write("\nEnter One Action: ");
                string userOption = Console.ReadLine();
            
                if (int.TryParse(userOption, out outValue)) {

                    break;
                } 
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter a Valid Option. Press Enter To Continue...");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadKey();
                }
            }
            return outValue;
        }
    }
}