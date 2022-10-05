using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodhud
{
    internal class Program
    {
        //Varible set up

        //Player stats
        static int health;
        static int score;
        static int lives;
        static int attackPower;
        static int enemykilled;
        static int playerExperience;
        static int playerLevel;
        static int neededExperience;
        static int scoreModifier;

        static string playerName;

        //monster stats
        static int monsterKillPoints;
        static int monsterPower;
        static int monsterHealth;
        static int monsterExperience;
        static void Main(string[] args)
        {

            //Initialization

            //Player stats
            health = 100;
            score = 0;
            lives = 5;
            attackPower = 10;
            enemykilled = 0;
            playerExperience = 0;
            playerLevel = 1;
            neededExperience = 100;
            scoreModifier = 1;
            enemykilled = 0;

            //Monster stats
            monsterKillPoints = 50;
            monsterPower = 10;
            monsterHealth = 50;
            monsterExperience = 50;

            //Name your guy
            Console.WriteLine("What's your name");
            playerName = Console.ReadLine();
            Console.Clear();

            ManFindsMonster();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManKillMonster();
            Console.ReadKey();
            Console.Clear();

            ManFindsMonster();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManAndMonsterFight();
            Console.ReadKey();
            Console.Clear();

            ManKillMonster();
            Console.ReadKey();
            Console.Clear();

            TheEnd();
            Console.ReadKey();
        }
        //Top HUD
        static void HudTop()
        {
            Console.WriteLine(playerName + ": " + "Score: "+ score +" health: " + health + " Lives: " + lives + " Level: " + playerLevel + " Exp: " + playerExperience + "/" + neededExperience + " Enemys killed: " + enemykilled);
        }

        //"Game screens"

        // Man no monster
        static void ManNoMonster()
            {
                Console.WriteLine("");
                Console.WriteLine(@" 0 |");
                Console.WriteLine(@"/|\T");
                Console.WriteLine(@"/ 7");
            }
        // Man with monster
        static void ManWithMonster()
            {
                Console.WriteLine(@"     " + @" ^{_}");
                Console.WriteLine(@" 0 | " + @" T[ ]");
                Console.WriteLine(@"/|\T " + @" || |");
                Console.WriteLine(@"/ 7  " + @" |d d");
            }
        // No man no monster
        static void NoManNoMonster()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        //noManWithMonster
        static void NoManWithMonster()
            {
                Console.WriteLine(@"     " + @" ^{_}");
                Console.WriteLine(@"     " + @" T[ ]");
                Console.WriteLine(@"     " + @" || |");
                Console.WriteLine(@"     " + @" |d d");
            }
        //The end
        static void TheEnd()
        {
            Console.WriteLine(@" _____ _   _  _____   _____ _   _______ ");
            Console.WriteLine(@"|_   _| | | ||  ___| |  ___| \ | |  _  \");
            Console.WriteLine(@"  | | | |_| || |__   | |__ |  \| | | | |");
            Console.WriteLine(@"  | | |  _  ||  __|  |  __|| . ` | | | |");
            Console.WriteLine(@"  | | | | | || |___  | |___| |\  | |/ / ");
            Console.WriteLine(@"  \_/ \_| |_/\____/  \____/\_| \_/___/  ");
        }
        //scenarios
        static void ManFindsMonster()
        {
            HudTop();
            ManWithMonster();
            Console.WriteLine(playerName + " finds a monster");
        }
        static void ManAndMonsterFight()

        {
            HudTop();
            ManWithMonster();
            PlayerDamageCal();
            MonsterDamageCal();
        }
        static void ManKillMonster()
        {
            ExperianceCal();
            HudTop();
            ManNoMonster();
            Console.WriteLine("The monster is dead");
        }
        //Calculators
        //Experiance
        static void ExperianceCal()
        {
            playerExperience += monsterExperience;
            if (playerExperience >= neededExperience)
            {
                //resets EXP count
                playerExperience -= 100;
                //Increases player lvl
                playerLevel += 1;

            }
        }
        //Player takes damage
        static void PlayerDamageCal()
        {
            Console.WriteLine("The monster Attacks " + playerName + "!");
            health -= monsterPower;
            //Monster kills player
            if (health <= 0)
            {
                //takes away a life resets health
                lives -= 1;
                health = 100;
            }
        }
        //Monster takes damage
        static void MonsterDamageCal()
        {
            Console.WriteLine(playerName + " attacks the monster!");
            monsterHealth -= attackPower;
            //player kills the monster
            if (monsterHealth <= 0)
            {
                monsterHealth = 50;
                Scorecal();
                enemykilled += 1;
                scoreModifier += 1;
            }
        }
        // Player gets points
        static void Scorecal()
        {
            score += monsterKillPoints * scoreModifier;
        }
        
    }
}
