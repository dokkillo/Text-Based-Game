using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Text_Based_Game
{
    class Program
    {
        private static int storyCounter = 0;

        static void Main(string[] args)
        {
            //the string that will hold all user commands in our adventure game
            String command = string.Empty;

            PlayerCharacter player = new PlayerCharacter();

            Console.WriteLine("Welcome to the Unnamed Game.");

            do
            {
                Console.WriteLine("Please enter a character name.");
                command = Console.ReadLine();

            } while (!(Regex.IsMatch(command, @"^[a-zA-Z]+$")));
            
           
            

            player.set_Name(command);

            CombatHandler.start_Combat(player, 0, 0, 0);

            Console.ReadLine();
        }

        public static void set_StoryCounter(int val)
        {
            storyCounter = val;
        }

    }
}
