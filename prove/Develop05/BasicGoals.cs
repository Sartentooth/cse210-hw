using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class BasicGoals : Goals, IGoals
    {
        private string _rulesText;
       
        List<string> _goalList = new List<string>();

        public BasicGoals(){
            _rulesText = "";
        }
        public void SaveFile(){
            
            Console.Write("Please, enter the name of the file (.txt): ");
            string _saveToFile = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(_saveToFile, append: true))
            {
                foreach (string line in _goalList) {

                    outputFile.WriteLine($"{line}");
                }
            }
        }
    }
}