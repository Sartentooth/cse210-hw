using System;
using System.IO;
using System.Threading.Tasks;

namespace Develop05
{
    public class ChecklistGoals : Goals
    {
        private string gName;
        private string gDescription;        
        private List<string> formatTextToFile = new List<string>();
        public ChecklistGoals(string bracket, string gName, string gDescription, int nTimesDoIt, string gRepetition)
        {
            Bracket = bracket;
            GName = gName;
            GDescription = gDescription;
            NTimesDoIt = nTimesDoIt;
            GRepetition = gRepetition;
        }

        public ChecklistGoals()
        {
            
        }

        public ChecklistGoals(string goalName, string goalDescription, int nTimesDoIt)
        {
            NTimesDoIt = nTimesDoIt;
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

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nHow many times do you want to do it? ");
            Console.ForegroundColor = ConsoleColor.White;
            GRepetition = Console.ReadLine();           

            if (!list.Contains($"{Bracket} {GName} ({GDescription} -- {NTimesDoIt}/{GRepetition}"))
            {
                list.Add($"{Bracket} {GName} ({GDescription}) -- {NTimesDoIt}/{GRepetition}");              
            }

        }
        public override void SaveFile(string fileName, List<Goals> list)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (Goals g in list)
                {
                    sw.WriteLine($"{g.Bracket},{g.GName},{g.GDescription},{g.NTimesDoIt},{g.GRepetition}");
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
                    string[] parts = line.Split(',');
                    ChecklistGoals b = new ChecklistGoals();
                    b.Bracket = parts[0].Trim();
                    b.GName = parts[1].Trim();
                    b.GDescription = parts[2].Trim();
                    b.NTimesDoIt = int.Parse(parts[3]);
                    b.GRepetition = parts[4].Trim();
                    list.Add(b);
                }
            }
        }
    
        public override void RecordEvent()
        {
            if (int.Parse(GRepetition) > NTimesDoIt)
            {
                NTimesDoIt += 1;
            }
            else if (int.Parse(GRepetition) <= NTimesDoIt)
            {
                Bracket = "[x]";
            }
        }
    }
}
