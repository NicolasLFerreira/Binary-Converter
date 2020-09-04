using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_converter
{
    public class Converter
    {
        public static string Reverse(string binary)
        {
            char[] array = binary.ToCharArray();
            string reverse = string.Empty;

            for (int i = array.Length - 1; i > -1; i--)
            {
                reverse = string.Concat(reverse, array[i]);
            }
            return reverse;
        }
    
        public static long BinaryToDecimal(string binary)
        {
            long factor = 1;
            long decimal_ = 0;



            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1' || binary[i] == '0')
                {
                    if (binary[i].ToString() == "1") decimal_ += factor;
                    factor *= 2;
                }
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
