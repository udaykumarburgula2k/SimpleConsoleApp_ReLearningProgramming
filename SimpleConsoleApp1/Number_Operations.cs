using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{

    /// <summary>
    /// Number operations
    /// </summary>
    internal class Number_Operations
    {

        /// <summary>
        /// ReverseNumber Reverse a Number with Examples
        /// https://dotnettutorials.net/lesson/reverse-number-in-csharp/
        /// </summary>
        /// <param name="givenString"></param>
        /// <returns></returns>
        public static int ReverseNumber(int number)
        {
            int remainder = 0, reverse = 0;

            while (number > 0)
            {

                //Get the remainder by dividing the number with 10
                remainder = number % 10;

                reverse = (reverse * 10) + remainder;

                number = number / 10;
            }

            return reverse;
        }
    }
}
