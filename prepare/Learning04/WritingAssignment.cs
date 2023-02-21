using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning04
{
    public class WritingAssignment : Assignment
    {
        private string _title = "";

        public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic){
            _title = title;
        }
        public string GetWritingAssignment(){
            string studentName = GetStudentName();
            return $"Title: {_title} by {studentName}";
        }
    }
}