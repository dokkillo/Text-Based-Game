using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Based_Game
{
    static class CombatHandler
    {
        /// <summary>
        /// Initializes combat.  0 = random, 1 = bounded, 2 = particular.  Low doubles as particular.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="type"></param>
        public static void start_Combat(PlayerCharacter player, int type, int low, int high)
        {
            BlankEnemy enemy;
            if (type == 0)
            {
                enemy = new BlankEnemy(get_Random_Enemy());
            }
            else if (type == 1)
            {
                enemy = new BlankEnemy(get_Bounded_Enemy(low, high));
            }
            else
            {
                enemy = new BlankEnemy(get_Particular_Enemy(low));
            }

            Console.WriteLine("A " + enemy.get_Name() + " has appeared!");
            enemy.print_Enemy_Data();

            CombatHandler.combat_Loop(player, enemy);
        }


        /// <summary>
        /// The main loop for combat, in which the player and enemy take turns fighting each other.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        public static void combat_Loop(PlayerCharacter player, BlankEnemy enemy)
        {

        }

        /// <summary>
        /// Returns the string to parse, which decides which enemy the player will fight
        /// </summary>
        /// <returns></returns>
        public static String get_Random_Enemy()
        {
            String[] enemyList = System.IO.File.ReadAllLines(@"C:\Users\Jack\Desktop\Text-Based Game\Text-Based Game\EnemyData.txt");

            Random enemyPick = new Random();
            return enemyList[enemyPick.Next(enemyList.Length)];
        }


        /// <summary>
        /// Returns a string to parse, as bounded by the difficulty of the enemies that should be fought
        /// </summary>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <returns></returns>
        public static String get_Bounded_Enemy(int lowerBound, int upperBound)
        {
            String[] enemyList = System.IO.File.ReadAllLines(@"C:\Users\Jack\Desktop\Text-Based Game\Text-Based Game\EnemyData.txt");

            Random enemyPick = new Random();
            return enemyList[enemyPick.Next(lowerBound, upperBound)];
        }


        /// <summary>
        /// For when you know which enemy you want to fight exactly
        /// </summary>
        /// <param name="enemyVal"></param>
        /// <returns></returns>
        public static String get_Particular_Enemy(int enemyVal)
        {
            String[] enemyList = System.IO.File.ReadAllLines(@"C:\Users\Jack\Desktop\Text-Based Game\Text-Based Game\EnemyData.txt");

            return enemyList[enemyVal];
        }
    }
}
