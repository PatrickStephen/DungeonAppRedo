using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            //Get a random number from 1-100 as a dice roll
            int diceRoll = new Random().Next(1, 101);
            System.Threading.Thread.Sleep(250);
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcDodge()))
            {
                
                int damageDealt = attacker.CalcDamage();

                //assign the damage
                defender.HP -= damageDealt;

                //Write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                //the attack missed
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            //player attacks first
            DoAttack(player, monster);

            //monster attacks second, if they live
            if (monster.HP > 0)
            {
                DoAttack(monster, player);
            }//end if
        }//end PSV
    }
}
