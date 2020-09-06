using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_converter
{
    class Capturer
    {
        public static long LongIn()
        {
            string input = Console.ReadLine();
            long output;

            while (!long.TryParse(input, out output))
            {
                if (input == "switch" || input == "change" || input == "back")
                {
                    Program.Ask = true;
                    return 1;
                }
                Console.WriteLine("Enter an integer number: ");
                input = Console.ReadLine();
            }
            return output;
        }

        public static char ChoiceIn(char choiceOne, char choiceTwo)
        {
            char input = Console.ReadKey().KeyChar;

            while (input != choiceOne && input != choiceTwo)
            {
                Console.Write($"\nPlease enter either '{choiceOne}' or '{choiceTwo}': ");
                input = Console.ReadKey().KeyChar;
            }
            return input;
        }
    }
}
