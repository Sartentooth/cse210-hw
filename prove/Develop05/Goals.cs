using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public abstract class Goals 
    {
        private string _userEntry;
        private string _day;
        private DateTime _dateTime = new DateTime();
        private List<string> _listAux = new List<string>();
        private List<string> _currentGoals = new List<string>();
        private List<string> _prompts = new List<string>(){
            "What is the name of the goal? ",
            "Write a brief description of the goal"
        };

        public List<string> GetListOfGoals(){
            return _currentGoals;
        } 
        public void SetListOfGoals(List<string> list){
            _currentGoals = list;
        } 
        public void AddEntry() {
            _day = _dateTime.ToString("dd/MM/yyyy");
            _listAux = SendPrompt();

            string sAux = "";

            foreach (var line in _listAux)
            {    
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{line}\n>> ");
                Console.ForegroundColor = ConsoleColor.White;

                _userEntry = Console.ReadLine();
                sAux += $"{_userEntry},";  
            }
            
            _currentGoals.Add($"{_day}: [ ] {sAux}");
        }
        public void ShowCurrentGoalsList(){

            foreach (var goal in _currentGoals)
            {
                Console.WriteLine("hola");
            }
            Console.ReadKey();
        }
        public virtual List<string> SendPrompt(){
            return _prompts; 
        }
    }
}