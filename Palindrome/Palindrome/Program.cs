using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Enter a nubmer to test the Palindrome");
                long number = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPalindrome(number));
            }

        }
        /// <summary>
        /// Check if the number is a palindrime 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
            public static bool IsPalindrome(long number)
        {
            // since the input is a number, one very fast way way would be 
            // to reverse the number and compare to original
            long revNum = ReverseNumber(number);

            return (number == revNum);
        }
        /// <summary>
        /// //Reverse the Number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static long ReverseNumber(long number)
        {
            long retVal = 0;
            do
            {
                // get the last digit by using the modulo (remainder) operator
                retVal = (retVal * 10) + (number % 10);
                // drop the last digit from the number
                number = number / 10;
            }
            while (number != 0);
            return retVal;
        }
    }  
}
