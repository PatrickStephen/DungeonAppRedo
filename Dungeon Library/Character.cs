using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public abstract class Character
    {
        //frugal / fields
        private int _hp;

        //people / properties
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Dodge { get; set; }
        public int MaxHP { get; set; }
        public int HP
        {
            get { return _hp; }
            set
            {
                if (value <= MaxHP)
                {
                    _hp = value;
                }
                else
                {
                    _hp = MaxHP;
                }
            }//end set
        }//end Life

        //collect / constructors (ctors)

        //money / methods
        public virtual int CalcHP()
        {
            return HP;
        }//end CalcHP()

        public virtual int CalcDodge()
        {
            return Dodge;
        }//end CalcBlock()

        public virtual int CalcHitChance()
        {
            return HitChance;
        }//end CalcHitChance()

        public virtual int CalcDamage()
        {
            return 0;
        }//end CalcDamage()
    }//end class
}//end namespace
