using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dungeon_Library;//added

namespace DungeonMonsters
{
    public class BlastEndedSkrewt : Monster
    {
        public bool IsFullGrown { get; set; }

        public BlastEndedSkrewt()
        {
            //SET MAX VALUES FIRST
            MaxHP = 25;
            MaxDamage = 12;
            Name = "Blast Ended Skrewt";
            HP = 25;
            HitChance = 15;
            Dodge = 15;
            MinDamage = 4;
            Description = "It's ugly! Thankfully it isn't fully grown so it can only sting and not shoot fire!";
            IsFullGrown = false;

        }//end default ctor

        public BlastEndedSkrewt(string name, int hp, int maxHP, int hitChance,
            int dodge, int minDamage, int maxDamage, string description, bool isFullGrown)
            : base(name, hp, maxHP, hitChance, dodge, minDamage, maxDamage, description)

        {
            IsFullGrown = IsFullGrown;
        }//end FQ CTOR

    public override string ToString()
    {
        return base.ToString() + (IsFullGrown ? "Full Grown?" : "It can shoot fire!");
    }//end ToString()

    //Override life : if it is Giant, the get an extra 20 health value
    public override int CalcHitChance()
    {
        int calculatedHitChance = HitChance;

        if (IsFullGrown)
        {
            calculatedHitChance += calculatedHitChance + 20;
        }

        return calculatedHitChance;
    }//end CalcHitChance

}//end class
}//end namespace