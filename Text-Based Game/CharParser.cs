using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Based_Game
{
    static class CharParser
    {
        //this is a class used to parse information that is exclusive to the player character, such as experience levels and the level up rewards.

        public static int get_Exp_By_Level(String filePath, int level)
        {
            String[] levels = System.IO.File.ReadAllLines(filePath);

            int start = 0;
            while (!levels[level - 1][start].Equals(':'))
            {
                start++;
            }
            start++;

            //parse the string starting at start, for 5 characters.  All experience values will be 5 characters, from 00001 to 99999
            String parsedData = levels[level - 1].Substring(start, 5);

            try
            {
                return Convert.ToInt32(parsedData);
            }
            catch
            {
                return -1;
            }
        }
    }
}
