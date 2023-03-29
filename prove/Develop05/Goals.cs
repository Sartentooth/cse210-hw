using System;
using System.Threading.Tasks;

namespace Develop05
{
    public abstract class Goals
    {
        public string FileName { get; set; }
        public string Bracket { get; set; }
        public string GName { get; set; }
        public string GDescription { get; set; }
        public string GRepetition { get; set; }
        public int NTimesDoIt { get; set; }

        public Goals()
        {
            Bracket = "[ ]";
            NTimesDoIt = 0;
        }
        public Goals(string _Bracket, string _GName, string _GDescription, string _GRepetition, int _NTimesDoIt){
            Bracket = _Bracket;
            GName = _GName;
            GDescription = _GDescription;
            GRepetition = _GRepetition;
            NTimesDoIt = _NTimesDoIt;
        }
        public abstract void SaveFile(string fileName, List<Goals> list);
        public abstract void LoadFile(string fileName, List<Goals> list);
        public abstract void EntryUser(List<string> list);
        public abstract void RecordEvent();
    }
}