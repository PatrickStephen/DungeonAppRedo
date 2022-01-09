using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dungeon_Library;//added

namespace DungeonMonsters
{
    public class CornishPixie : Monster
    {


        public CornishPixie()
        {
            //SET MAX VALUES FIRST
            MaxHP = 20;
            MaxDamage = 12;
            Name = "Cornish Pixie";
            HP = 20;
            HitChance = 20;
            Dodge = 20;
            MinDamage = 2;
            Description = "Little blue flying pixie's. Do not underestimate them.";

        }//end default ctor

        //public CornishPixie(string name, int hp, int maxHP, int hitChance,
        //    int dodge, int minDamage, int maxDamage, string description)
        //    : base(name, hp, maxHP, hitChance, dodge, minDamage, maxDamage, description) { }


    }//end class
}//end namespace
