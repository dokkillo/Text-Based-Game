using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Text_Based_Game
{
    class PlayerCharacter
    {
        private int maxHP = 0;
        private int currHP = 0;
        private int maxMana = 0;
        private int currMana = 0;
        private int level = 1;
        private int attack = 0;
        private int defense = 0;
        private int special = 0;
        private int experience = 0;
        private String name = "";
        private String[] inventory = {"Handgun","Empty","Empty","Empty","Empty","Empty"};


        /// <summary>
        /// Constructor for the PlayerCharacter Class
        /// </summary>
        public PlayerCharacter()
        {

        }


        

        /// <summary>
        /// Checks the char file for the exp value of the next level, and if the char has more xp, returns true.
        /// The filepath is the path to the level up chart.
        /// </summary>
        /// <param name="filePath"></param>
        public bool did_Level_Up()
        {
            var path = Directory.GetCurrentDirectory();
            string filePath = path + @"\LevelData.txt";           
            int exp = CharParser.get_Exp_By_Level(filePath, this.level);
            return this.experience >= exp;
        }


        /// <summary>
        /// This is a series of getters and setters for the PlayerCharacter items
        /// </summary>
        /// <returns></returns>
        public int get_Max_HP() { return this.maxHP; }
        public void set_Max_HP(int newMax) { this.maxHP = newMax; }

        public int get_Curr_HP() { return this.currHP; }
        public void set_Curr_HP(int newCurr) { this.currHP = newCurr; }

        public int get_Max_Mana() { return this.maxMana; }
        public void set_Max_Mana(int newMax) { this.maxMana = newMax; }

        public int get_Curr_Mana() { return this.currMana; }
        public void set_Curr_Mana(int newCurr) { this.currMana = newCurr; }

        public int get_Level() { return this.level; }
        public void set_Level(int newLev) { this.level = newLev; }

        public int get_Exp() { return this.experience; }
        public void set_Exp(int newExp) { this.experience = newExp; }

        public int get_Attack() { return this.attack; }
        public void set_Attack(int newAtk) { this.attack = newAtk; }

        public int get_Defense() { return this.defense; }
        public void set_Defense(int newDef) { this.defense = newDef; }

        public int get_Special() { return this.special; }
        public void set_Special(int newSpl) { this.special = newSpl; }

        public String[] get_Inventory() { return this.inventory; }
        public void set_Inventory(String[] newInv) { this.inventory = newInv; }

        public String get_Name() { return this.name; }
        public void set_Name(String charName) { this.name = charName; }



        //in charge of loading the character's stats, given an array of the data pulled from the SaveData.txt
        public void load_Character(String[] charData)
        {
            this.maxHP = Convert.ToInt32(charData[0]);
            this.currHP = Convert.ToInt32(charData[1]);
            this.maxMana = Convert.ToInt32(charData[2]);
            this.currMana = Convert.ToInt32(charData[3]);
            this.level = Convert.ToInt32(charData[4]);
            this.experience = Convert.ToInt32(charData[5]);
            this.attack = Convert.ToInt32(charData[6]);
            this.defense = Convert.ToInt32(charData[7]);
            this.special = Convert.ToInt32(charData[8]);
            this.name = charData[9];
            if(!charData[11].Equals("No inventory items"))
            {
                for (int i = 11; i < charData.Length; i++)
                {
                    inventory[i - 11] = charData[i];
                }
            }
        }

        public void print_Character_Data()
        {
            Console.WriteLine("Max HP:" + maxHP);
            Console.WriteLine("Current HP:" + currHP);
            Console.WriteLine("Max Mana:" + maxMana);
            Console.WriteLine("Current Mana:" + currMana);
            Console.WriteLine("Current Level:" + level);
            Console.WriteLine("Experience:" + experience);
            Console.WriteLine("Attack:" + attack);
            Console.WriteLine("Defense:" + defense);
            Console.WriteLine("Special:" + special);
            Console.WriteLine("Name:" + name);
            if (inventory.Length != 0)
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    Console.WriteLine("Inventory Slot " + (i + 1) + ":" + inventory[i]);
                }
            }
            else
            {
                Console.WriteLine("No inventory items");
            }
        }
    }

}
