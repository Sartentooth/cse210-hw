using System;
using System.Threading.Tasks;

namespace final
{
    public class Character
    {           
        Random dice = new Random();

        // for all character and enemies
        protected string _characterName;
        protected int _health;
        protected int _conSkill;
        protected int _strSkill;
        protected int _desSkill;
        protected int _intSkill;

        //Constructor
        public Character(string characterName, int health, int consSkill, int strSkill, int desSkill, int intSkill)
        {
            _characterName = characterName;
            _health = health;
            _conSkill = consSkill;
            _strSkill = strSkill;
            _desSkill = desSkill;
            _intSkill = intSkill;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Welcome {_characterName}");
            Console.WriteLine($"Your Stats:\n");
            Console.WriteLine($"     HEALT: {_health}");
            Console.WriteLine($"       STR: {_strSkill}");
            Console.WriteLine($"       CON: {_conSkill}");
            Console.WriteLine($"       DES: {_desSkill}");
            Console.WriteLine($"       INT: {_intSkill}");
        }
        public virtual int Attack(int skillBase)
        {
            int SkillModifier()
            {
                int modifier = -1;
                switch(skillBase)
                {
                    case int M when(M >= 10 && M <=11):
                        modifier = 0;
                        break;
                    case int M when(M >= 12 && M <=13):
                        modifier = 1;
                        break;
                    case int M when(M >= 14 && M <=15):
                        modifier = 2;                                            
                        break;
                    case int M when(M >= 16 && M <=17):
                        modifier = 3;                        
                        break;
                    case int M when(M >= 18 && M <=19):
                        modifier = 4;                        
                        break;
                    case int M when(M >= 20):
                        modifier = 5;                        
                        break;                        
                }
                return modifier;
            }
            int D20 = dice.Next(1, 20);
            if (D20 == 1)
            {
                Console.WriteLine("you have bungling!");
                return 1;
            }
            else if (D20 == 20)
            {
                Console.WriteLine("you have Critic!");
                return 20;
            }
            else{ 
                int attack = SkillModifier() + D20; // """_strSkill""" will be override in the sub class according the character selected.
                Console.WriteLine(SkillModifier() + " " + D20);
                return attack;
            }
        }
        public virtual bool Defend(int attack, int diceConCharacter)
        {
            int armorClass = _conSkill + diceConCharacter;

            Console.WriteLine($"{_conSkill} {diceConCharacter} {attack}");

            if(attack >= armorClass ){
                return true;
            }   
            else{
                return false;
            }
        }
    }
}