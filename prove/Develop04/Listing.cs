using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Listing : Relaxation
    {
        Random _random = new Random();
        private int _secondAux;
        private string _rulesDescriptionText;
        private string _welcomeListingMsg;
        private string _endListingMsg;
        List<string> _listingPromp = new List<string>() {

            "Who are people that you appreciate?", 
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?", 
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?" 
        };
        List<string> _listingUserList = new List<string>();

        
        private string _introduction;
        public Listing(){
            _rulesDescriptionText = @"
            This activity will help you reflect on the good things in your life by 
            having you list as many things as you can in a certain area.";

            _introduction = @"
            LIst as many responses you can to the following prompt: ";
            
            _welcomeListingMsg = "Welcome to the Listing Activity. Enjoy it!";
            _endListingMsg = "\nVery Nice... Well Done!!";
        }
        private string SendPrompt() {
            // variables 
            List<string> _checkRepeated = new List<string>();
            string randomPrompt;

            do{    
                randomPrompt = _listingPromp[_random.Next(0,_listingPromp.Count)];
                
                if (!_checkRepeated.Contains(randomPrompt)){

                    _checkRepeated.Add(randomPrompt);
                    return randomPrompt;
                }

            } while (_checkRepeated.Count < 5);

            return randomPrompt;
        }
        public void ShowListingTask(){
            // variables 
            string userEntry = "";

            // nested method for user entry from keyboard
            int Ingres(){
                Console.Write("How long, in seconds, would you like for your session: ");

                int timeInSecond = Int32.Parse(Console.ReadLine());
                SetUserInputTime(timeInSecond);
                int second = GetUserInputTime();
                return second;
            }

            // showing welcome and rules message
            ShowMsg(_welcomeListingMsg);
            ShowMsg(_rulesDescriptionText);

            // setting up DateTime and members
            _secondAux = Ingres();

            // main core of the method
            Console.Clear();
            Console.WriteLine("Get Ready...");
            ShowAnimation();

            Console.WriteLine(_introduction);
            Console.Write($"\n--- {SendPrompt()} ---\nYou may begin in: ");
            ShowCountdown(3);
            
            // main core
            _startTime = DateTime.Now;
            _futureTime = _startTime.AddSeconds(_secondAux);

            while(DateTime.Now < _futureTime){
                
                Console.Write(">> ");
                userEntry = Console.ReadLine();
                _listingUserList.Add(userEntry);
            }
            Console.WriteLine($"\nYou listed {_listingUserList.Count} items!!\n");

             // showing end message and final animation --> go to Main Menu
            ShowMsg(_endListingMsg);
            ShowAnimation();

            Console.WriteLine($"You have completed {GetUserInputTime()} seconds of the Reflection Activity");
            ShowAnimation();

        }
    }
}





