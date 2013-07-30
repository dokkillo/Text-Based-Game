using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Based_Game
{
    //Class that is in charge of saving an loading the charData and Place in the story.
    static class DataHandler
    {
        /// <summary>
        /// Saves the game.
        /// </summary>
        /// <param name="player">the player's stats and stuff</param>
        /// <param name="storyPlace">the current place in the story, passed in by the main's storycounter</param>
        public static void save_Game(PlayerCharacter player, int storyPlace)
        {
            /*String filename = "SaveData.txt";
            String filePath = System.IO.Path.Combine(@"C:\Users\Jack\Desktop\Text-Based Game\Text-Based Game", filename);
            System.IO.File.Create(filePath);*/

            int mHP = player.get_Max_HP();
            int mMana = player.get_Max_Mana();
            int cHP = player.get_Curr_HP();
            int cMana = player.get_Curr_Mana();
            int clevel = player.get_Level();
            int cExp = player.get_Exp();
            int cAtk = player.get_Attack();
            int cDef = player.get_Defense();
            int cSpl = player.get_Special();
            String cName = player.get_Name();
            String[] cInv = player.get_Inventory();

            int arrayLength = 11;
            if (cInv.Length == 0)
            {
                arrayLength++;
            }
            else
            {
                arrayLength += cInv.Length;
            }

            // Convert each data entry above to a string and store them in the correct order in this array, then save the array
            // using the IO.File.WriteAllLines method
            String[] saveData = new String[arrayLength];
            saveData[0] = Convert.ToString(mHP);
            saveData[1] = Convert.ToString(cHP);
            saveData[2] = Convert.ToString(mMana);
            saveData[3] = Convert.ToString(cMana);
            saveData[4] = Convert.ToString(clevel);
            saveData[5] = Convert.ToString(cExp);
            saveData[6] = Convert.ToString(cAtk);
            saveData[7] = Convert.ToString(cDef);
            saveData[8] = Convert.ToString(cSpl);
            saveData[9] = cName;
            saveData[10] = Convert.ToString(storyPlace);
            if (cInv.Length > 0)
            {
                for (int i = 0; i < cInv.Length; i++)
                {
                    saveData[i + 11] = cInv[i];
                }
            }
            else
            {
                saveData[11] = "No inventory items";
            }

            System.IO.File.WriteAllLines(@"C:\Users\Jack\Desktop\Text-Based Game\Text-Based Game\SaveData.txt", saveData);

            //String fileData = "MaxHP:" + mHP "$CurrHP:" + cHP + "$MaxMana:" + mMana + "$CurrMana:" + cMana + "$level
        }


        /// <summary>
        /// Loads the game from the file generated in the save_Game method
        /// </summary>
        /// <param name="player"></param>
        public static void load_Game(PlayerCharacter player)
        {
            String[] saveData = System.IO.File.ReadAllLines(@"C:\Users\Jack\Desktop\Text-Based Game\Text-Based Game\SaveData.txt");
            player.load_Character(saveData);
            Program.set_StoryCounter(Convert.ToInt32(saveData[10]));
        }
    }
}
