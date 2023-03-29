using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final
{
    public class Game
    {
        private Warrior warriorOne;
        string NAME;
        private int HEALTH;
        private int CON;
        private int STR;
        private int DES;
        private int INT;
        public Game()
        {
            Console.Write("Please select a Name: ");
            NAME = Console.ReadLine();

            Console.WriteLine("You have 10 points to assign in your skills\n");
            Console.WriteLine("Health: ");
            HEALTH = 10 + int.Parse(Console.ReadLine());

            Console.WriteLine("Constitution: ");
            CON = 10 + int.Parse(Console.ReadLine());

            Console.WriteLine("Strength: ");
            STR = 10 + int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dexterity: ");
            DES = 10 + int.Parse(Console.ReadLine());

            Console.WriteLine("Intelligence: ");
            INT = 10 + int.Parse(Console.ReadLine());

            warriorOne = new Warrior(NAME, HEALTH, CON, STR, DES, INT);
           
        }
        public void Run()
        {
            warriorOne.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine(warriorOne.Defend(warriorOne.Attack(STR), 8));
        }
    }
}