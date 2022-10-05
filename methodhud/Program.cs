using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodhud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Varible set up
            //Player stats
            int health = 100;
            int score = 0;
            int lives = 3;
            int attackPower = 25;
            int enemykilled = 0;

            string playerName = "sam";
            //monster stats
            int monsterKillPoints = 50;
            int monsterPower = 10;
            int monsterHealth = 50;
            int monsterExperiance = 50;

            //HudTop(playerName,score,health,lives,enemykilled);
           
        }
        //player stats
        static void HudTop(string playerNameA, int scoreA,int healthA, int livesA, int enemykilledA)
        {
            Console.WriteLine(playerNameA + " Score: " + scoreA +" health: " + healthA + " Lives: " + livesA + " Enemys killed: " + enemykilledA);
        }
        //"Game screens"
        // Man no monster
        static void manNoMonster()
        {
            Console.WriteLine("");
            Console.WriteLine(@" 0 |");
            Console.WriteLine(@"/|\T");
            Console.WriteLine(@"/7");
        }
        // Man with monster
        static void manWithMonster()
        {
            Console.WriteLine(@"     " + @" ^{_}");
            Console.WriteLine(@" 0 | " + @" T[ ]");
            Console.WriteLine(@"/|\T " + @" || |");
            Console.WriteLine(@"/7   " + @" |d d");
        }
        // No man no monster
        static void noManNoMonster()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        //noManWithMonster
        static void noManWithMonster()
        {
            Console.WriteLine(@"     " + @" ^{_}");
            Console.WriteLine(@"     " + @" T[ ]");
            Console.WriteLine(@"     " + @" || |");
            Console.WriteLine(@"     " + @" |d d");
        }
    }
}
