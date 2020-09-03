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
            char choice = '-';
            Ask = true;

            while (true)
            {
                if (Ask)
                {
                    Console.Write("1 for Binary -> Decimal\n" +
                                  "2 for Decimal -> Binary\n");

                    choice = Console.ReadKey().KeyChar;
                    Ask = false;
                }

                if (choice == '1')
                {
                    Console.Write("\nEnter a binary number: ");
                    string binary = Capturer.LongIn().ToString();
                    Console.WriteLine(Converter.BinaryToDecimal(binary).ToString());
                }
                if (choice != '1')
                {
                    Console.Write("\nEnter a decimal number: ");
                    long decimal_ = Capturer.LongIn();
                    Console.WriteLine(Converter.DecimalToBinary(decimal_));
                }
            }
        }
    }
}
