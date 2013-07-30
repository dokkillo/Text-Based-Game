using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Based_Game
{
    /*This is the class that will be used to spawn enemies.  All enemies will inherit this class.*/
    class BlankEnemy
    {
        private int maxHP = 0;
        private int currHP = 0;
        private int maxMana = 0;
        private int currMana = 0;
        private String name = "";
        private int attack = 0;
        private int defense = 0;
        private int special = 0;
        private int expVal = 0;
        private String[] weaknesses = new String[0];
        private String[] attackList = new String[0];

        //constructor for the enemy
        public BlankEnemy(String filepath)
        {
            this.parse_Data(filepath);
        }

        //Parses the data from one line of the enemy data .txt file
        public void parse_Data(String filepath)
        {
            //call the parse functions from the parser class
            maxHP = CreatureParser.parse_HP(filepath);
            currHP = maxHP;
            maxMana = CreatureParser.parse_Mana(filepath);
            currMana = maxMana;
            name = CreatureParser.parse_Name(filepath);
            attack = CreatureParser.parse_Attack(filepath);
            defense = CreatureParser.parse_Defense(filepath);
            special = CreatureParser.parse_Special(filepath);
            expVal = CreatureParser.parse_Exp(filepath);
        }


        public String get_Name()
        {
            return this.name;
        }


        /// <summary>
        /// Prints all the data from an enemy.
        /// </summary>
        public void print_Enemy_Data()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Max HP: " + maxHP);
            Console.WriteLine("Max MP: " + maxMana);
            Console.WriteLine("Atk: " + attack);
            Console.WriteLine("Def: " + defense);
            Console.WriteLine("Spec: " + special);
            Console.WriteLine("Experience Value: " + expVal);
            Console.WriteLine("Attack List:");
            if (attackList.Length == 0)
            {
                Console.WriteLine("No Attacks");
            }
            else
            {
                for (int i = 0; i < attackList.Length; i++)
                {
                    Console.WriteLine(attackList[i]);
                }
            }
        }
    }
}
