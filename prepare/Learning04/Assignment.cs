using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning04
{
    public class Assignment
    {
        private string _studentName = "";
        private string _topic ="";
        public Assignment(string studentName, string topic){
            _studentName = studentName;
            _topic = topic;
        }

        public string GetStudentName(){
            return _studentName;
        }
        public string GetSummary(){
            return $"Student: {_studentName} - Topic: {_topic}";
        }

    }
}