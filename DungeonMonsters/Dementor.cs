using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dungeon_Library;//added

namespace DungeonMonsters
{
    public class Dementor : Monster
    {
        public Dementor()
        {
            //SET MAX VALUES FIRST
            MaxHP = 15;
            MaxDamage = 10;
            Name = "Dementor";
            HP = 15;
            HitChance = 20;
            Dodge = 20;
            MinDamage = 4;
            Description = "Faceless and flying, wraith like creatures that feed on happiness leaving only despare.";

        }//end default ctor

    }
}
