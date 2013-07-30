using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Based_Game
{
    static class CreatureParser
    {
        //parse the HP from an enemy.  The procedure will be the same for each parse, except for the value of i.
        /// <summary>
        /// parses the HP value from a .txt file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static int parse_HP(String text)
        {

            //find the points to split the string by to only grab the number for hp
            int start = 0;
            for (int i = 0; i < 2; i++)
            {
                while (!text[start].Equals(':'))
                {
                    start++;
                }
                start++;
            }
            
            //Convert the string to a number.  All HP values will be only 3 digits (from 001 to 999).
            String parsedData = text.Substring(start, 3);

            //Return the number if it works.  Else, return 0
            try
            {
                return Convert.ToInt32(parsedData);
            }
            catch
            {
                return 0;
            }
        }


        /// <summary>
        /// Parses the Mana value from a .txt file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static int parse_Mana(String text)
        {

            //find the points to split the string by to only grab the number for hp
            int start = 0;
            for (int i = 0; i < 3; i++)
            {
                while (!text[start].Equals(':'))
                {
                    start++;
                }
                start++;
            }

            //Convert the string to a number.  All HP values will be only 3 digits (from 001 to 999).
            String parsedData = text.Substring(start, 3);

            //Return the number if it works.  Else, return 0
            try
            {
                return Convert.ToInt32(parsedData);
            }
            catch
            {
                return 0;
            }
        }


        /// <summary>
        /// Parses the name from a .txt file
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static String parse_Name(String text)
        {

            //find the points to split the string by to only grab the name part
            int start = 0;

            while (!text[start].Equals(':'))
            {
                start++;
            }
            start++;

            int end = start + 1;
            while (!text[end].Equals('$'))
            {
                end++;
            }

            String parsedData = text.Substring(start, end-start);
            return parsedData;
        }


        /// <summary>
        /// returns the value of the enemies' attack
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static int parse_Attack(String text)
        {

            //find the points to split the string by to only grab the number for hp
            int start = 0;
            for (int i = 0; i < 4; i++)
            {
                while (!text[start].Equals(':'))
                {
                    start++;
                }
                start++;
            }

            //Convert the string to a number.  All values will be only 3 digits (from 001 to 999).
            String parsedData = text.Substring(start, 3);

            //Return the number if it works.  Else, return 0
            try
            {
                return Convert.ToInt32(parsedData);
            }
            catch
            {
                return 0;
            }
        }


        /// <summary>
        /// Gets the defense value from an enemy's .txt file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static int parse_Defense(String text)
        {

            //find the points to split the string by to only grab the number for hp
            int start = 0;
            for (int i = 0; i < 5; i++)
            {
                while (!text[start].Equals(':'))
                {
                    start++;
                }
                start++;
            }

            //Convert the string to a number.  All HP values will be only 3 digits (from 001 to 999).
            String parsedData = text.Substring(start, 3);

            //Return the number if it works.  Else, return 0
            try
            {
                return Convert.ToInt32(parsedData);
            }
            catch
            {
                return 0;
            }
        }



        public static int parse_Special(String text)
        {

            //find the points to split the string by to only grab the number for hp
            int start = 0;
            for (int i = 0; i < 6; i++)
            {
                while (!text[start].Equals(':'))
                {
                    start++;
                }
                start++;
            }

            //Convert the string to a number.  All HP values will be only 3 digits (from 001 to 999).
            String parsedData = text.Substring(start, 3);

            //Return the number if it works.  Else, return 0
            try
            {
                return Convert.ToInt32(parsedData);
            }
            catch
            {
                return 0;
            }
        }



        /// <summary>
        /// Parses the value of a creature's exp
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static int parse_Exp(String text)
        {

            //find the points to split the string by to only grab the number for hp
            int start = 0;
            for (int i = 0; i < 7; i++)
            {
                while (!text[start].Equals(':'))
                {
                    start++;
                }
                start++;
            }

            //Convert the string to a number.  All HP values will be only 3 digits (from 001 to 999).
            String parsedData = text.Substring(start, 5);

            //Return the number if it works.  Else, return 0
            try
            {
                return Convert.ToInt32(parsedData);
            }
            catch
            {
                return 0;
            }
        }


        //grabs the attacks that each enemy uses, and the ones that the character uses
        public static String parse_Attack_List()
        {
            return "ParseAttack, need to finish this";
        }
    }
}
