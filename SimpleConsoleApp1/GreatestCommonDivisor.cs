using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class GreatestCommonDivisor
    {
        /// <summary>
        /// Calculate_GCD : (10, 15) --> 10 < 15.. --> 10-1, 10-2, 10-3 .. go on checking. 
        /// </summary>
        /// <param name="givenNumber1"></param>
        /// <param name="givenNumber2"></param>
        /// <returns></returns>
        public static int Calculate_GCD(int givenNumber1, int givenNumber2)
        {
            int res = Math.Min(givenNumber1, givenNumber2);
            while (res > 0)
            {
                if (givenNumber1 % res == 0 && givenNumber2 % res == 0) {
                    break;
                }
                res--;
            }
            return res;
        }


        /// <summary>
        /// Method 2 : Euclidean algorithm
        ///  a = 12 b = 15 -->> b > a -->> b = b - a
        ///  a = 12 b = 3 
        ///  a = 9  b = 3
        ///  a = 6  b = 3
        ///  a = 3  b = 3
        /// </summary>
        /// <param name="givenNumber1"></param>
        /// <param name="givenNumber2"></param>
        /// <returns></returns>
        public static int Calculate_GCD2(int givenNumber1, int givenNumber2)
        {
            while (givenNumber1 != givenNumber2)
            {
                if (givenNumber1 > givenNumber2) { givenNumber1 = givenNumber1 - givenNumber2; }
                else { givenNumber2 = givenNumber2 - givenNumber1; }
            }
            return givenNumber1;
        }


        /// <summary>
        /// Optimal solution
        /// gcd (12,15)
        /// gcd (15,12)
        /// gcd (12, 3)
        /// gcd (3, 0)
        /// </summary>
        /// <param name="givenNumber1"></param>
        /// <param name="givenNumber2"></param>
        /// <returns></returns>
        public static int Calculate_GCD3(int givenNumber1, int givenNumber2)
        {
            if (givenNumber2 == 0) { return givenNumber1; }
            else { return Calculate_GCD3(givenNumber2, givenNumber1 % givenNumber2); }
            
        }
    }
}
