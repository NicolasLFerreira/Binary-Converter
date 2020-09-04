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
            long output = 0;

            while (!long.TryParse(input, out output))
            {
                if (input == "switch")
                {
                    Program.Ask = true;
                    return 1;
                }
                Console.WriteLine("Enter an integer number: ");
                input = Console.ReadLine();
            }
            return output;
        }
    }
}
