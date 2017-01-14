/*
A palindromic number reads the same both ways.
The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 * 99.
Find the largest palindrome made from the product of two 3-digit numbers.
*/

using System;
using System.Linq;

namespace Palindrom
{
    class Program
    {
        private static int createPalindrome(int half)
        {
            char[] reversed = half.ToString().Reverse().ToArray();
            return Convert.ToInt32(half + new string(reversed));
        }

        static void Main(string[] args)
        {
            bool done = false;
            int start = 1000, palindrom = 0; // for optimazation you can start from 998

            while (!done)
            {
                start--;
                palindrom = createPalindrome(start);
                for (int i = 999; i > 99; i--)
                {
                    if ((palindrom / i) > 999 || Math.Pow(i,2) < palindrom)
                    {
                        break;
                    }

                    if ((palindrom % i == 0))
                    {
                        done = true;
                        break;
                    }
                }
            }
            Console.WriteLine(palindrom);
        }
    }
}
