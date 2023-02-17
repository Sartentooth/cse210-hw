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

        public string GetSummary(){

            return $"Student: {_studentName} - Topic: {_topic}";
        }
        public string GetStudentName(string studentName){
            return _studentName = studentName;
        }

        public Assignment(string studentName, string topic){
            _studentName = studentName;
            _topic = topic;
        }
    }
}