using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Reflection : Relaxation
    {
        private int _secondAux;
         private string _rulesDescriptionText;
        private string _welcomeReflectiongMsg;
        private string _endReflectionMsg;
        Random _random = new Random();
        List<string> _reflectionPromp = new List<string>() {

            "Think of a time when you stood up for someone else.", 
            "Have you ever done anything like this before?",
            "How did you get started?", 
            "Think of a time when you did something truly selfless." 
        };
        List<string> _reflectionList = new List<string>() {

            "Why was this experience meaningful to you?", 
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.", 
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        private string _introduction;
        public Reflection(){
            _rulesDescriptionText = @"
            This activity will help you reflect on times in your life when you have shown strength and resilience.
            This will help you recognize the power you have and how you can use it in other aspects of your life.";
            
            _introduction = @"
            Consider the following prompt:
            
            --- Think of a time when you did something really difficult. ---
            
            When you have something in mind, press enter to continue.";

            _welcomeReflectiongMsg = "Welcome to the Reflection Activity. Enjoy it!";
            _endReflectionMsg = "\nVery Nice... Well Done!!";
        }
        private string SendPrompt() {
            // variables 
            List<string> _checkRepeated = new List<string>();
            string randomPrompt;


            do{    
                randomPrompt = _reflectionPromp[_random.Next(0,_reflectionPromp.Count)];
                
                if (!_checkRepeated.Contains(randomPrompt)){

                    _checkRepeated.Add(randomPrompt);
                    return randomPrompt;
                }

            } while (_checkRepeated.Count < 4);

            return randomPrompt;
        }

        private string SendReflection(){
            // variables 
            List<string> _checkRepeated = new List<string>();
            string randomReflection;

            do{    
                randomReflection = _reflectionPromp[_random.Next(0,_reflectionPromp.Count)];
                
                if (!_checkRepeated.Contains(randomReflection)){

                    _checkRepeated.Add(randomReflection);
                    return randomReflection;
                }

            } while (_checkRepeated.Count < 9);

            return randomReflection;        
        }
        public void ShowReflectionTask(){
            // nested method for user entry from keyboard
            int Ingres(){
                Console.Write("How long, in seconds, would you like for your session: ");

                int timeInSecond = Int32.Parse(Console.ReadLine());
                SetUserInputTime(timeInSecond);
                int second = GetUserInputTime();
                return second;
            }

            // showing welcome and rules message
            ShowMsg(_welcomeReflectiongMsg);
            ShowMsg(_rulesDescriptionText);

            // setting up DateTime and members
            _secondAux = Ingres();

            // main core of the method
            Console.Clear();
            Console.WriteLine("Get Ready...");

            ShowAnimation();
            // showing more instruction
            Console.WriteLine(_introduction);
            Console.ReadKey();

            ReflectionTask();
            
            // showing end message and final animation --> go to Main Menu
            ShowMsg(_endReflectionMsg);
            ShowAnimation();

            Console.WriteLine($"You have completed {GetUserInputTime()} seconds of the Reflection Activity");
            ShowAnimation();
        }
        public void ReflectionTask(){
            string prompt = SendPrompt();
            string reflection = SendReflection();

            Console.Write("\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
            ShowCountdown(5);
            Console.Clear();
            
            _startTime = DateTime.Now;
            _futureTime = _startTime.AddSeconds(_secondAux / 2);

            while(DateTime.Now < _futureTime){
                Console.SetCursorPosition(0, 0);
                Console.Write($"{prompt} ");
                ShowAnimation();
                
                Console.SetCursorPosition(0, 1);
                Console.Write($"{reflection} ");
                ShowAnimation();            
            }
            Console.WriteLine(_secondAux / 2);
        }
    }
}












