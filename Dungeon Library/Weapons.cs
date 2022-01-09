using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Weapons
    {
        //fields
        private int _minDamage;

        //props
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
       

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value < MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }//end prop

        //ctors
        public Weapons(string name, int minDamage, int maxDamage, int bonusHitChance)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
        }//end FQ CTOR

        //methods
        public override string ToString()
        {

            return string.Format("{0}\t{1} to {2} Damage\n" +
                "BonusHitChance: {3}%\n", 
                Name, MinDamage, MaxDamage, BonusHitChance);
        }//end Override ToString()


        //used the auto add feature to fix red squiggle on line 88 in Program.cs
        public static explicit operator Weapons(int v)
        {
            throw new NotImplementedException();
        }
    }
}
