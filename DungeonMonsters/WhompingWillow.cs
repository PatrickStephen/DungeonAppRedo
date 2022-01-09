using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dungeon_Library;//added

namespace DungeonMonsters
{
    public class WhompingWillow : Monster
    {
        public bool WasSleeping { get; set; }

        public WhompingWillow()
        {
            //SET MAX VALUES FIRST
            MaxHP = 25;
            MaxDamage = 12;
            Name = "Whomping Willow";
            HP = 25;
            HitChance = 15;
            Dodge = 5;
            MinDamage = 3;
            Description = "It was awake so it's not as aggressive.";
            WasSleeping = false;

        }//end default ctor

        public WhompingWillow(string name, int hp, int maxHP, int hitChance,
            int dodge, int minDamage, int maxDamage, string description, bool wasSleeping)
            : base(name, hp, maxHP, hitChance, dodge, minDamage, maxDamage, description)

        {
            WasSleeping = WasSleeping;
        }//end FQ CTOR

        public override string ToString()
        {
            return base.ToString() + (WasSleeping ? "Was it sleeping?" : "It's swinging all over the place!");
        }//end ToString()

        //Override life : if it is Giant, the get an extra 20 health value
        public override int CalcHitChance()
        {
            int calculatedHitChance = HitChance;

            if (WasSleeping)
            {
                calculatedHitChance += calculatedHitChance + 20;
            }

            return calculatedHitChance;
        }//end CalcHitChance

    }//end class
}//end namespace