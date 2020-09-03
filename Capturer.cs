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
                Console.WriteLine("Enter an integer number: ");
            }
            return output;
        }
    }
}
