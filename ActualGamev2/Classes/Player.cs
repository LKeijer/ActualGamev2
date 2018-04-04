using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualGamev2.Classes
{
    public abstract class Player
    {
        //Character indentification
        public string characterName { get; set; }
        public int characterID { get; set; }

        //Character stats
        public double currentHealth { get; set; }
        public double maxHealth { get; set; }
        public double currentWeight { get; set; }
        public double maxWeight { get; set; }

        public int strenght { get; set; }
        public int intelligence { get; set; }
        public int endurance { get; set; }
        public int dexterity { get; set; }

        public Items equippedWeapon;
        public Dictionary<string, Items> equippedArmor;


    }

    public static class CurrentPlayer
    {
        //Character indentification
        public static string characterName { get; set; }
        public static int characterID { get; set; }

        //Character stats
        public static double currentHealth { get; set; }
        public static double maxHealth { get; set; }
        public static double currentWeight { get; set; }
        public static double maxWeight { get; set; }

        public static int strenght { get; set; }
        public static int intelligence { get; set; }
        public static int endurance { get; set; }
        public static int dexterity { get; set; }

    }

    public class Inventory
    {

    }

    public static class CurrentInventory
    {

    }

    public class Warrior : Player
    {
        public Warrior()
        {
            
        }
    }
}
