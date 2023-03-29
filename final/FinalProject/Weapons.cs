using System;
using System.Threading.Tasks;

namespace final
{
    public static class Weapons
    {
        private static List<string> _meleeWeapons = new List<string>()
        {
            "sword", // sword damage = D6
            "longsword", // Long sowrd damage = D8
            "mornigstar" // Morning Star damage = D8
        };
        private static List<string> _rangeWeapons = new List<string>()
        {
            "bow", // bown damage = D6
            "longbow", // Long bown damage = D8
            "crossbow" // Morning Star damage = D10
        };
        private static List<string> _spellMagic = new List<string>()
        {
            "magicMissiles", // magic missiles damage = 3D4 + 3
            "firebolt", // firebolt damage = D10
        };

        public static string SendWeapon(string characterClass, string weaponSelect)
        {
            string selectedWeapon = "";

            switch (characterClass)
            {
                case "warrior":
                    switch (weaponSelect)
                    {
                        case "sword":
                            Console.WriteLine("you have seleted a Sword");
                            selectedWeapon = _meleeWeapons[0];
                            break;
                        case "longSword":
                            Console.WriteLine("you have seleted a Long Sword");
                            selectedWeapon = _meleeWeapons[1];
                            break;
                        case "mornigStar":
                            Console.WriteLine("you have seleted a MornigStar");
                            selectedWeapon = _meleeWeapons[2];
                            break;
                        default:
                            break;
                    }
                    break;
                case "ranger":
                    switch (weaponSelect)
                    {
                        case "bow":
                            Console.WriteLine("you have seleted a bow");
                            selectedWeapon = _rangeWeapons[0];
                            break;
                        case "longbow":
                            Console.WriteLine("you have seleted a Long Bow");
                            selectedWeapon = _rangeWeapons[1];
                            break;
                        case "crossbow":
                            Console.WriteLine("you have seleted a Crossbow");
                            selectedWeapon = _rangeWeapons[2];
                            break;
                        default:
                            break;
                    }
                    break;
                case "mage":
                    switch (weaponSelect)
                    {
                        case "magicMissiles":
                            Console.WriteLine("you have seleted a Magic Missiles");
                            selectedWeapon = _spellMagic[0];
                            break;
                        case "firebolt":
                            Console.WriteLine("you have seleted a Fire Bolt");
                            selectedWeapon = _spellMagic[1];
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            return selectedWeapon;                        
        }
    }
}