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
                Console.WriteLine(BinaryToDecimal(binary).ToString());
            }
            while (choice == '2')
            {
                Console.Write("\nEnter a decimal number: ");
                long decimal_ = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(DecimalToBinary(decimal_));
            }
        }

        public static string Reverse(string binary)
        {
            char[] array = binary.ToCharArray();
            string reverse = string.Empty;
            for (long i = array.Length - 1; i > -1; i--)
            {
                reverse += array[i];
            }
            return reverse;
        }

        public static long BinaryToDecimal(string binary)
        {
            long factor = 1;
            long decimal_ = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i].ToString() == "1") decimal_ += factor;
                factor *= 2;
            }
            return decimal_;
        }

        public static string DecimalToBinary(long decimal_)
        {
            string binary = string.Empty;

            while (decimal_ > 0)
            {
                if (decimal_ % 2 == 1)
                {
                    decimal_ = (decimal_ - 1) / 2;
                    binary += "1";
                }
                else
                {
                    decimal_ /= 2;
                    binary += "0";
                }
            }         

            return Reverse(binary);
        }
    }
}
