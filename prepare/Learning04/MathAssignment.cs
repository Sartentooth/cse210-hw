using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning04
{
    public class MathAssignment : Assignment
    {
        private string _textBookSection = "";
        private string _problems = "";
        
        public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic){
            _textBookSection = textBookSection;
            _problems = problems;
        }

        public string GetHomeworkLIst(){
            return $"Book: {_textBookSection} - Problem: {_problems}";
        }
    }
}