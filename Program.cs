using System;
using System.Linq;
using System.Security.Cryptography;

namespace Binary_converter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter '0' for 'Binary -> Decimal'\n" +
                              "Enter '1' for 'Decimal -> Binary'");
            char choice = Console.ReadKey().
        }

        public static int BinaryToDecimal(string binary)
        {
            int factor = 1;
            int decimal_ = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i].ToString() == "1") decimal_ += factor;
                factor *= 2;
            }
            return decimal_;
        }

        public static string DecimalToBinary(int decimal_)
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

            return binary.Reverse().ToString();
        }
    }
}
