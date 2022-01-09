using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Monster : Character
    {
        //frugal / fields
        //we will have a business rule on MinDamage, we need a full prop and a full field

        private int _minDamage;

        //people / properties
        //Auto props go first (no business rules)
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            //Can't be more than MaxDamage and can't be less than 1
            set
            {
                if (value > 0 && value < MaxDamage)
                {
                    //you're good
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
                //or this way when you learn more
                //OR
                //_minDamage = (value > 0 && value <= MaxDamage) ? value : 1;
            }//end set
        }//end MinDamage

        //collect / constructors (ctors)
        public Monster() { }
        public Monster(string name, int hp, int maxHP, int hitChance,
            int dodge, int minDamage, int maxDamage, string description)
        {
            MaxHP = maxHP;
            MaxDamage = maxDamage;
            Name = name;
            HP = hp;
            HitChance = HitChance;
            Dodge = dodge;
            Description = description;
            MinDamage = minDamage;
            //8 total!!!
        }// FQ CTOR

        //money / methods
        public override string ToString()
        {
            return $"\n***** MONSTER *****\n" +
                $"{Name}\n" +
                $"Life: {HP} / {MaxHP}\n" +
                $"Damage: {MinDamage} / {MaxDamage}\n" +
                $"Block: {Dodge}\n" +
                $"Description: {Description}\n";
        }//end ToString()

        //We are overriding the CalcDamage() to use the props MinDamage and MaxDamage
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
            //If we had a monster that had a mindamage of 2 and max of 8...
            //and passed just MinDamage and MaxDamage to the .Next(), it would
            //only return a random number between 2 and 7 (with out the + 1)
        }//end ClacDamage
    }//end class
}//end namespace
