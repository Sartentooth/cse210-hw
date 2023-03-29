using System;
using System.Threading.Tasks;

namespace final
{
    public class Warrior : Character
    {       
         public Warrior(string characterName, int health, int consSkill, int strSkill, int desSkill, int intSkill) 
                        : base(characterName, health, consSkill, strSkill, desSkill, intSkill)
        {
            
        }

        public int PowerAttack()
        {
            return 20;
        }
        public override int Attack(int skillBase)
        {
            return base.Attack(skillBase);
        }
        public override bool Defend(int attack, int diceConCharacter)
        {
            return base.Defend(attack, diceConCharacter);
        }
    }
}