using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dungeon_Library;//added

namespace DungeonMonsters
{
    public class Basilisk : Monster
    {


        public Basilisk()
        {
            //SET MAX VALUES FIRST
            MaxHP = 50;
            MaxDamage = 20;
            Name = "Basilisk";
            HP = 50;
            HitChance = 15;
            Dodge = 20;
            MinDamage = 8;
            Description = "Legendary seprtant, largely called the 'Serpant King' who causes death with a single glance. But it was blinded by a Pheonix!";

        }//end default ctor

    }
}
