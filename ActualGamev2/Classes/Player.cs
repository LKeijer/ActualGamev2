using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualGamev2.Classes
{
    //Abstract class that all playable classes inherit from.
    public abstract class Player
    {
        //Character indentification
        public abstract string characterName { get; set; }
        public abstract int characterID { get; set; }

        //Character stats
        public abstract double currentHealth { get; set; }
        public abstract double maxHealth { get; set; }
        public abstract double currentWeight { get; set; }
        public abstract double maxWeight { get; set; }
        public abstract double currentStamina { get; set; }
        public abstract double maxStamina { get; set; }

        public abstract int strenght { get; set; }
        public abstract int intelligence { get; set; }
        public abstract int endurance { get; set; }
        public abstract int dexterity { get; set; }

        public Items equippedWeapon;
        public Dictionary<int, Items> equippedArmor;

    }

    //Playable class.
    public class Mechanic : Player
    {
        //Character indentification
        public override string characterName { get; set; }
        public override int characterID { get; set; }

        //Character stats
        public override double currentHealth
        {
            get { return currentHealth; }
            set
            {
                currentHealth = value;
                    //Raise the HealthChanged event if player health changes.
                if (HealthChanged != null)
                {
                    HealthChanged(currentHealth, maxHealth);
                }
            }
        }
        



        public override double maxHealth { get; set; }
        public override double currentWeight { get; set; }
        public override double maxWeight { get; set; }
        public override double currentStamina { get; set; }
        public override double maxStamina { get; set; }

        public override int strenght { get; set; }
        public override int intelligence { get; set; }
        public override int endurance { get; set; }
        public override int dexterity { get; set; }
        //On character creation
        public Mechanic(string _name)
        {
            this.characterName = _name;
            this.currentHealth = 100;
            this.maxHealth = 100;
            this.currentWeight = 0;
            this.maxWeight = 50;
            this.strenght = 5;
            this.dexterity = 3;
            this.endurance = 4;
            this.intelligence = 7;
            this.currentStamina = 60;
            this.maxStamina = 60;
        }
        
        

        //Events that handle statchanges

        //Declare a delegate
        public delegate void HealthChangedHandler(double _currrentHealth, double _maxHealth);
        //Declare the event.
        public event HealthChangedHandler HealthChanged;


    }


}
