using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dungeon_Library;//added;
using DungeonMonsters;//added;

namespace Dungeon
{
    public class Program
    {
        static void Main(string[] args)
        {
            string harryPotter = @"
                                                                 _ __
                                ___                             | '  \
                           ___  \ /  ___         ,'\_           | .-. \        /|
                           \ /  | |,'__ \  ,'\_  |   \          | | | |      ,' |_   /|
                         _ | |  | |\/  \ \ |   \ | |\_|    _    | |_| |   _ '-. .-',' |_   _
                        // | |  | |____| | | |\_|| |__    //    |     | ,'_`. | | '-. .-',' `. ,'\_
                        \\_| |_,' .-, _  | | |   | |\ \  //    .| |\_/ | / \ || |   | | / |\  \|   \
                         `-. .-'| |/ / | | | |   | | \ \//     |  |    | | | || |   | | | |_\ || |\_|
                           | |  | || \_| | | |   /_\  \ /      | |`    | | | || |   | | | .---'| |
                           | |  | |\___,_\ /_\ _      //       | |     | \_/ || |   | | | |  /\| |
                           /_\  | |           //_____//       .||`      `._,' | |   | | \ `-' /| |
                                /_\           `------'        \ |              `.\  | |  `._,' /_\
                                                               \|                    `.\
                                   
    ";
            Console.WriteLine(harryPotter);
            string txt = "The Traveler that lived!\n";
            Console.Title = txt;


            Console.WriteLine("{0," +
                    ((Console.WindowWidth / 2) + txt.Length / 2) + "}", txt);

            Console.WriteLine("Your future begins here...\n");

            int score = 0;

            Weapons playerWeapon = new Weapons("Rock", 1, 1, -5);

            //1. Create a Player
            Console.WriteLine(@"Please choose a race:
1)Witch/Wizard
2)Centaur
3)Werewolf
4)House Elf
");

            int raceInt = 0;
            bool playerChoice = int.TryParse(Console.ReadLine(), out raceInt);

            Race playerRace;

            if (playerChoice && raceInt > 0 && raceInt < 5)
            {
                playerRace = (Race)(raceInt - 1);
            }
            else
            {
                Console.WriteLine("Invalid Choice you are a Muggle");
                playerRace = Race.Muggle;
            }
            Console.WriteLine($"You are now a {playerRace}");

            Weapons Wand = new Weapons("Wand", 2, 13, 8);
            Weapons Bow = new Weapons("Bow", 3, 12, 15);
            Weapons Claws = new Weapons("Claws", 2, 15, 10);
            Weapons Magic_Elf_Finger = new Weapons("You're an elf, use your finger as a wand!", 2, 12, 20);
            
            //Weapons[] weapons = { Wand, Bow, Claws, Magic_Elf_Finger };

            Console.WriteLine(@"Please choose your weapon:
1)Wand
2)Bow
3)Claws
4)Magic Elf Finger
");
            ConsoleKey userWeapon = Console.ReadKey(true).Key;
            switch (userWeapon)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    playerWeapon = Wand;
                    break;

                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    playerWeapon = Bow;
                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    playerWeapon = Claws;
                    break;

                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    playerWeapon = Magic_Elf_Finger;
                    break;

                default: Console.WriteLine("You failed to choose a weapon, here is a rock. Good luck...");
                    break;
            }

            Console.WriteLine($"Your weapon of choice is {playerWeapon}");

            Player player = new Player("Harry Potter", 35, 50, 100, 100, playerRace, playerWeapon);
            //2. Create a Weapon

            //3. Add Customization based on player race

            //4. Create a loop for the room and monster

            bool exit = false;

            do
            {
                //5.Get a room description from a custom method that generates them
                Console.WriteLine(GetRoom());

                //6. Create a monster in the room for the Player to battle.
                //Learn about creating objects and randomly selecting them
                Spider s1 = new Spider();

                Spider s2 = new Spider("Giant Spider!", 25, 25, 40, 25, 3, 10,
                    "That's not a normal spider thats an Acromantula!!", true);

                BlastEndedSkrewt bs = new BlastEndedSkrewt();

                BlastEndedSkrewt bs2 = new BlastEndedSkrewt("Fully Grown Blast Ended Skrewt!", 25, 25, 35, 15, 8, 18, "It is fully grown so it can sting and shoot fire!", true);

                WhompingWillow w = new WhompingWillow();

                WhompingWillow w2 = new WhompingWillow("It was sleeping", 25,25,35,5,3,15,"You woke a sleeping Willow, it is extremly aggressive!",true);

                CornishPixie c = new CornishPixie();

                Dementor d = new Dementor();

                Basilisk b = new Basilisk();
                //7. Create a loop for the user choice menu (inner loop)

                Monster[] monsters = {s1, s1, s2, bs, bs, bs2, w, w2, c, c, d, d};

                int randomIndex = new Random().Next(monsters.Length);
                Monster monster = monsters[randomIndex];//Polymorphism, we don't know what kind
                //we will get, so we'll just save it as a Monster.

                //Show that monster in the room
                Console.WriteLine("\nIn this room: " + monster.Name);

                bool reload = false;
                do
                {
                    //8. Create a menu of options
                    Console.WriteLine(@"
Please choose and action:
A) Attack
R) Run Away
P) Player Info
M) Monster Info
X) Exit
");
                    //9 Capture the user choice.
                    string userChoice = Console.ReadKey(true).Key.ToString();

                    Console.Clear();
                    //10. Build switch to perform an action based on the users input
                    switch (userChoice)
                    {
                        case "A":
                            //11. Create attack/ battle functionality
                            Combat.DoBattle(player, monster);

                            //12. Handle if the user wins
                            if (monster.HP <= 0)
                            {
                                //it's dead!!
                                //You could put logic here to have the
                                //player get some items, heal a bit, or exp
                                //due to defeating the monster.
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                Console.ResetColor();
                                reload = true;// new room and monster
                            }//end if monster if dead

                            //Console.WriteLine("Attack Method Goes Here...");
                            break;

                        case "R":
                            //13. Give the monster a free attack since you ran away
                            Console.WriteLine("Run Away!!");
                            Console.WriteLine($"{monster.Name} attacks as you flee!");
                            Combat.DoAttack(monster, player);//free attack
                            Console.WriteLine();
                            reload = true;//"re"load a new room
                            break;

                        case "P":
                            Console.WriteLine("Player Info:");
                            //14. Display Player info
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters slain: " + score);
                            break;

                        case "M":
                            Console.WriteLine("Monster Info:");
                            //15. Display Monster info
                            Console.WriteLine(monster);//this will use
                            //polymorphism to get the correct ToString
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an invalid option.");
                            break;

                    }//end switch

                    //16. Check Player Info
                    if (player.HP <= 0)
                    {
                        Console.WriteLine("Dude... you died!\a");
                        exit = true;
                    }//end if player is dead!

                } while (!reload && !exit);

            } while (!exit);//While exit is NOT TRUE, keep looping

            Console.WriteLine($"" +
                $"You defeated {score:n0} monster{(score == 1 ? "." : "s")}");

        }//end main

        #region Custom Methods
        private static string GetRoom()
        {
            string[] rooms =
            {
                "You fell down a pit filled with devil's snare...",
                "You entered a room filled with bones",
                "You are in the forbidin forest",
                "You are by the lake",
                "You are in the observation tower",
                "You are in the dungeon under the stairs"
            };

            return rooms[new Random().Next(rooms.Length)];


        }//end GetRoom
        #endregion
    }//end class
}//end namespace
