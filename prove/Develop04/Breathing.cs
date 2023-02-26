using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Breathing : Relaxation
    {
        private string _rulesDescriptionText;
        private string _welcomeBreathingMsg;
        private string _endBreathingMsg;

        public Breathing(){
            _rulesDescriptionText = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            _welcomeBreathingMsg = "Welcome to the Breathing Activity. Enjoy it!";
            _endBreathingMsg = "\nVery Nice... Well Done!!";
        }
        public void ShowBreathingTask() {

            // showing welcome and rules message
            ShowMsg(_welcomeBreathingMsg);
            ShowMsg(_rulesDescriptionText);

            // main core of the method
            Console.Clear();
            Console.WriteLine("Get Ready...");

            ShowAnimation();

            BreathingTask();
            
            // showing end message and final animation --> go to Main Menu
            ShowMsg(_endBreathingMsg);
            ShowAnimation();
            Console.WriteLine($"You have completed {GetUserInputTime()} seconds of the Breathing Activity");
            ShowAnimation();
        }
        private void BreathingTask(){

            int increment = 2;

            // nested method for user entry from keyboard
            int Ingres(){
                Console.Write("How long, in seconds, would you like for your session: ");

                int timeInSecond = Int32.Parse(Console.ReadLine());
                SetUserInputTime(timeInSecond);
                int second = GetUserInputTime();
                return second;
            }

            // setting up DateTime and members
            _startTime = DateTime.Now;
            _futureTime = _startTime.AddSeconds(Ingres());

            Console.WriteLine();
            
            while(DateTime.Now < _futureTime){
                
                Console.CursorVisible = false;
                Console.Write("Breath in... ");
                ShowCountdown(increment);

                increment += 2;

                Console.Write("Breath out... ");
                ShowCountdown(increment);

                Console.CursorVisible = false;
                Console.WriteLine();
            }
        }
    }
}