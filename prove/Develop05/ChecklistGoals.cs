using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class ChecklistGoals : Goals
    {
         private string _rulesText;
        private List<string> _checkedPrompts = new List<string>(){
            "What is the name of the goal? ",
            "Write a brief description of the goal",
            "How many times do you want to do this?"
        };
        public ChecklistGoals(){
            _rulesText = "";
        }
        public override List<string> SendPrompt()
        {
            return _checkedPrompts;
        }
    }
}