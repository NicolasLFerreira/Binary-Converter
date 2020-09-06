using System;
using System.Linq;
using System.Security.Cryptography;

namespace Binary_converter
{
    public class Program
    {
        public static bool Ask { get; set; }

        public static void Main()
        {
            char choice = ' ';
            Ask = true;

            while (true)
            {
                if (Ask)
                {
                    Console.Write("Enter '0' for a 'binary -> decimal' conversion\n" +
                                  "Enter '1' for a 'decimal -> binary' conversion\n");

                    choice = Capturer.ChoiceIn('0', '1');
                    Ask = false;
                }

                if (choice == '0')
                {
                    Console.Write("\nEnter a binary number: ");
                    string binary = Capturer.LongIn().ToString();
                    Console.WriteLine(Converter.BinaryToDecimal(binary).ToString());
                }
                if (choice == '1')
                {
                    Console.Write("\nEnter a decimal number: ");
                    long decimal_ = Capturer.LongIn();
                    Console.WriteLine(Converter.DecimalToBinary(decimal_));
                }
            }
        }
    }
}