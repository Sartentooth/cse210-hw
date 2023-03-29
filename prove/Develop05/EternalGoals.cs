using System;
using System.IO;
using System.Threading.Tasks;

namespace Develop05
{
    public class EternalGoals : Goals
    {
        private string gName;
        private string gDescription;
        private List<string> formatTextToFile = new List<string>();
        public EternalGoals(string gBracket, string gName, string gDescription)
        {
            Bracket = gBracket;
            GName = gName;
            GDescription = gDescription;
        }

        public EternalGoals()
        {
        }

        public EternalGoals(string goalName, string goalDescription)
        {
        }

        public override void EntryUser(List<string> list)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nWhat is the name of the Goal? ");
            Console.ForegroundColor = ConsoleColor.White;
            GName = Console.ReadLine();

            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nWrite a brief description of the Goal? ");
            Console.ForegroundColor = ConsoleColor.White;
            GDescription = Console.ReadLine();
            
            if (!list.Contains($"{Bracket} {GName} ({GDescription}"))
            {
                list.Add($"{Bracket} {GName} ({GDescription})");             
            }
        }
        public override void SaveFile(string fileName, List<Goals> list)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (Goals g in list)
                {
                    sw.WriteLine($"{g.Bracket},{g.GName},{g.GDescription}");
                }
            }
        }

        public override void LoadFile(string fileName, List<Goals> list)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('-');
                    EternalGoals b = new EternalGoals();
                    b.Bracket = parts[0].Trim();
                    b.GName = parts[1].Trim();
                    b.GDescription = parts[2].Trim();
                    list.Add(b);
                }
            }
        }
    
        public override void RecordEvent()
        {
            Bracket = "[E]";
        }
    }
}