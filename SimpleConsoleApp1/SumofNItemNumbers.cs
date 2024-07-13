using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class SumofNItemNumbers
    {
        public static int nNumber_SumOfNumbers(int givenNumber)
        {
            int sum = 0;
            for (int i = 1; i <= givenNumber; i++) { 
                sum = sum + i;
            }
            // 1 ,2, 3, 4,  5,  6,  7,   8, 9,  10
            // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55
            Console.WriteLine(sum);
            return sum;
        }

        /// <summary>
        /// Sum Of Numbers : n*(n+1)/2
        /// </summary>
        /// <param name="givenNumber"></param>
        /// <returns></returns>
        public static int nNumber_SumOfNumbers_1(int givenNumber)
        {
            // 10 : 10*11/2
            return givenNumber*(givenNumber+1)/2;
        }

        /// <summary>
        /// Sum Of Numbers : iterative method
        /// </summary>
        /// <param name="givenNumber"></param>
        /// <returns></returns>
        public static int nNumber_SumOfNumbers_2(int givenNumber)
        {
            int sum = 0;
            for (int i = 1; i <= givenNumber; i++)
            {
                sum = sum + i;
            }
            // 1 ,2, 3, 4,  5,  6,  7,   8, 9,  10
            // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55
            Console.WriteLine(sum);
            return sum;
        }

        /// <summary>
        /// /// Sum Of Numbers : iterative method 1, 1+1, 1+1+1...
        /// </summary>
        /// <param name="givenNumber"></param>
        /// <returns></returns>
        public static int nNumber_SumOfNumbers_3(int givenNumber)
        {
            int sum = 0;
            for (int i = 1; i <= givenNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    sum++;
                }
            }
            // 1 ,2,   3,       4,  5,  6,  7,   8, 9,  10
            // 1, 1+1, 1+1+1 ...
            Console.WriteLine(sum);
            return sum;
        }
    }
}
