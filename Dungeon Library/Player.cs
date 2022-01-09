using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public sealed class Player : Character
    {

        //frugal / fields

        //people / properties
        public Race PlayerRace { get; set; }
        public Weapons PlayerWeapon { get; set; }

        public Player(string name, int hitChance, int dodge, int hp, int maxHP,
            Race playerRace, Weapons playerWeapon)
        {

            MaxHP = maxHP;
            Name = name;
            HitChance = hitChance;
            HP = hp;
            PlayerRace = playerRace;
            PlayerWeapon = playerWeapon;
            Dodge = Dodge;

            switch (playerRace)
            {
                case Race.Centaur:
                    MaxHP += 25;
                    break;

                case Race.Werewolf:
                    HitChance += 15;
                    break;

                case Race.HouseElf:
                    Dodge += 20;
                    break;

                case Race.Muggle:
                    MaxHP -= 10;
                    break;

               
            }

        }//end FQ CTOR

        //money / methods
        public override string ToString()
        {
            string description = "";

            switch (PlayerRace) //WitchWizard,Centaur,Werewolf,HouseElf,Muggle
            {
                case Race.WitchWizard:
                    description = "A Witch/ Wizard are the base Race, they have all around balanced stats.";
                    break;
            }
            switch (PlayerRace)
            {
                case Race.Centaur:
                    description = "Centaurs are half-human, half-horse creatures. They have the body of a horse, and the torso, head, and arms of a man. They have a strong connection with nature which provides them 25 extra HP";
                    break;
            }

            switch (PlayerRace)
            {
                case Race.Werewolf:
                    description = "Werewolfs are humanbeings that can transform into a wolf like creature. Naturally this gives them a boost to speed and strength. ( + 15 HitChance)";
                    break;
            }

            switch (PlayerRace)
            {
                case Race.HouseElf:
                    description = "Due to their small size, House Elfs have a higher dodge percentage.( + 20 to dodge)";
                    break;
            }

            switch (PlayerRace)
            {
                case Race.Muggle:
                    description = "You failed to choose a valid race. You are now a muggle. Have fun...(-10 HP)";
                    break;
            }



            return $"-={PlayerRace}=-\n" +
                $"HP: {HP} / {MaxHP}\n" +
                $"Accuracy: {CalcHitChance()}%\n" +
                $"Equiped Weapn: {PlayerWeapon}\n" +
                $"Dodge: {Dodge}%\n" +
                $"Description: {description}";
        }//end Override ToString()

        public override int CalcDamage()
        {
            //return base.CalcDamage();
            //create a random object
            Random rand = new Random();

            //determine damage
            int damage = rand.Next(PlayerWeapon.MinDamage, PlayerWeapon.MaxDamage + 1);

            //return the damage
            return damage;
        }//end CalcDamamge

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + PlayerWeapon.BonusHitChance;
        }//end CalcHitChance()



    }

    


    
}

