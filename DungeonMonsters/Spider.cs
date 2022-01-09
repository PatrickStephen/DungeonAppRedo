using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dungeon_Library;//added
namespace DungeonMonsters
{
    public class Spider : Monster
    {
        public bool IsGiant { get; set; }

        public Spider()
        {
            //SET MAX VALUES FIRST
            MaxHP = 10;
            MaxDamage = 8;
            Name = "Spider";
            HP = 10;
            HitChance = 20;
            Dodge = 25;
            MinDamage = 3;
            Description = "It is a spider! AAHHHHHHH!!!";
            IsGiant = false;
        }//end default ctor

        public Spider(string name, int hp, int maxHP, int hitChance,
            int dodge, int minDamage, int maxDamage, string description, bool isGiant)
            : base(name, hp, maxHP, hitChance, dodge, minDamage, maxDamage, description)

        {
            IsGiant = IsGiant;
        }//end FQ CTOR

        public override string ToString()
        {
            return base.ToString() + (IsGiant ? "Giant" : "Still scary!");
        }//end ToString()

        //Override life : if it is Giant, the get an extra 20 health value
        public override int CalcHitChance()
        {
            int calculatedHitChance = HitChance;

            if (IsGiant)
            {
                calculatedHitChance += calculatedHitChance + 20;
            }

            return calculatedHitChance;
        }//end CalcHitChance

    }//end class
}//end namespace
