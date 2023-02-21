using System;

namespace Learning04
{
        class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment("Nehuen", "Historia");
            //Console.WriteLine(assignment.GetSummary());

            MathAssignment mathAssignment = new MathAssignment("Nehuen", "Fracciones", "Sumas", "Seccion 12 a 20");
            WritingAssignment writingAssignment = new WritingAssignment("Nehuen", "Fracciones", "el libro gordo de petete");
        
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkLIst());
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingAssignment());          
        }
    }
}