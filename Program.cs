using System;
using System.Linq;
using System.Security.Cryptography;

namespace Binary_converter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 for Binary -> Decimal\n" +
                          "2 for Decimal -> Binary\n");

            char choice = Console.ReadKey().KeyChar;
            
            while (choice == '1')
            {
                Console.Write("\nEnter a binary number: ");
                string binary = Console.ReadLine();
                Console.WriteLine(Converter.BinaryToDecimal(binary).ToString());
            }
            while (choice == '2')
            {
                Console.Write("\nEnter a decimal number: ");
                long decimal_ = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(Converter.DecimalToBinary(decimal_));
            }
        }
    }
}
