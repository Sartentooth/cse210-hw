using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Develop04
{
    public class Relaxation
    {
        protected DateTime _startTime = new DateTime();
        protected DateTime _currentTime = new DateTime();
        protected DateTime _futureTime = new DateTime();
        private Random randomList = new Random();
        private string _welcomeMsg;
        private string _endMsg;
        private int _userInputTime;
        private List<string> _animation = new List<string>(){

        "|", "/", "─", "\\", "|", "/", "─", "\\"

        };

        public Relaxation(){
            _welcomeMsg = "unknow";
            _endMsg = "unknow";
            _userInputTime = 0;
        }
        public Relaxation(string welcomeMsg, string endMsg, int userInputTime){
            _welcomeMsg = welcomeMsg;
            _endMsg = endMsg;
            _userInputTime = userInputTime;
        }
        public string GetWelcomeMsg(){
            return _welcomeMsg;
        }
        public string GetEndMsg(){
            return _endMsg;
        }
        public void SetUserInputTime(int userInputTime) {
            _userInputTime = userInputTime;
        }
        public int GetUserInputTime() {
            return _userInputTime;
        }
        public int MenuOptions(){
        // Variables for validation
        int outValue;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Please select one of the following: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1. Breathing Activity" +
            "\n2. Reflecting Activity"+
            "\n3. Listing Activity"+
            "\n4. future feature"+
            "\n5. future feature"+
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
        public void ShowMsg(string message){
            Console.WriteLine($"{message}\n");
        }
        public void ShowTitle(){
            Console.Clear();
            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(_welcomeMsg);
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(2000);
            Console.Clear();
        }
        public void ShowEndTitle(){
            Console.Clear();
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_endMsg);
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(100);
        }
        public void ShowAnimation(){

            Console.CursorVisible = false;

                foreach (string ani in _animation)
                {
                    Console.Write(ani);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                }
            
            Console.CursorVisible = true;
            Console.Write("\b \b");
            Console.WriteLine();
        }
        public void ShowCountdown(int value = 2){
            
            for (int i = value; i >= 0; i--)
            {   
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    } 
}

