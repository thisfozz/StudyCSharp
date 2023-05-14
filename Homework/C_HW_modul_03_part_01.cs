using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Homework
{
    internal class C_HW_modul_03_part_01
    {
        public static void PrintSquare(int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static bool IsPalindrome(int number)
        {
            int reversed = 0;
            int original = number;

            while (original > 0)
            {
                int digit = original % 10;
                reversed = (reversed * 10) + digit;
                original /= 10;
            }

            return reversed == number;
        }
    }
}
