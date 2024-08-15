using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    /// <summary>
    /// CommonLoop - Iterative code block
    /// </summary>
    internal class CommonLoop
    {
        /// <summary>
        /// executeFunction
        /// </summary>
        /// <param name="givenNumber"></param>
        /// <param name="functionNumber"></param>
        /// <returns></returns>
        public static string executeFunction(int givenNumber, int functionNumber)
        {
            string result = string.Empty;
            switch (functionNumber) { 
            case 1:
                result = SumOfDigitsFunc1(givenNumber).ToString();
                break;
            case 2:
                result = SumOfDigitsFunc2(givenNumber).ToString();
                break;
            case 3:
                result = SumOfDigitsFunc3(givenNumber).ToString();
                    break;
            case 4:
                result = SumOfDigitsFunc4(givenNumber).ToString();
                break;
            case 5:
                result = SumOfDigitsFunc5(givenNumber).ToString();
                break;
            case 6:
                result = SumOfDigitsFunc6(givenNumber).ToString();
                break;
            case 7:
                    result = SumOfDigitsFunc_NestedLoop_7(givenNumber).ToString();
                    break;
            case 8:
                result = SumOfDigitsFunc_NestedLoop_8(givenNumber).ToString();
                break;
             case 9:
                    result = SumOfDigitsFunc_NestedLoop_9(givenNumber, givenNumber).ToString();
                    break;
            default:
                result = String.Empty;
                Console.WriteLine("Invalid option");
                break;
            }
            Console.WriteLine("SumOfDigitsFunc"+ functionNumber +"="+ result);
            return result;
        }

        public static int SumOfDigitsFunc1(int n) 
        { 
            return n*((n+1)/2);
        }

        public static int SumOfDigitsFunc2(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++) 
            {
                sum = sum + i;
            }
            return sum;
        }

        public static int SumOfDigitsFunc3(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    sum++;
            }
            return sum;
        }


        /// <summary>
        /// Θ(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitsFunc4(int n)
        {
            // example: n = 10
            // 1,2,3,4,5,6,7,8,9 = 45
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }


        /// <summary>
        /// Θ(logn)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitsFunc5(int n)
        {
            // sample:
            // n = 10
            // 1 + 2 + 4+ 8 = 1 3 7 15 = 15
            //SumOfDigitsFunc5 #i1
            //SumOfDigitsFunc5 sum #i1
            //SumOfDigitsFunc5 #i2
            //SumOfDigitsFunc5 sum #i3
            //SumOfDigitsFunc5 #i4
            //SumOfDigitsFunc5 sum #i7
            //SumOfDigitsFunc5 #i8
            //SumOfDigitsFunc5 sum #i15
            //SumOfDigitsFunc5 = 15
            int sum = 0;
            for (int i = 1; i < n; i = i*2)
            {
                Console.WriteLine("SumOfDigitsFunc5 #i" + i);
                sum = sum + i;
                Console.WriteLine("SumOfDigitsFunc5 sum #i" + sum);
            }
            return sum;
        }


        /// <summary>
        /// Θ(n)  
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitsFunc6(int n)
        {
            // example: n = 10
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                sum = sum + i;
            }
            return sum;
        }


        /// <summary>
        /// SumOfDigitsFunc_NestedLoop_7 -- Θ(nlogn) 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitsFunc_NestedLoop_7(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++) // Θ(n)
            {
                Console.WriteLine("--SumOfDigitsFunc_NestedLoop_7 #i" + i);
                for (int j = 1; j < n; j = j*2) // Θ(logn)
                {
                    Console.WriteLine("------SumOfDigitsFunc5 #j" + j);
                    sum = sum + i;  // Θ(1)
                    Console.WriteLine("SumOfDigitsFunc_NestedLoop_7 #sum" + sum);
                }
            }
            return sum;
        }

        /// <summary>
        /// SumOfDigitsFunc_NestedLoop_8 -- Θ(n2) 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitsFunc_NestedLoop_8(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++) // Θ(n)
            {
                Console.WriteLine("--SumOfDigitsFunc_NestedLoop_8 #i" + i);
                for (int j = 1; j < n; j++) // Θ(logn)
                {
                    Console.WriteLine("------SumOfDigitsFunc_NestedLoop_8 #j" + j);
                    sum = sum + i;  // Θ(1)
                    Console.WriteLine("SumOfDigitsFunc_NestedLoop_8 #sum" + sum);
                }
            }
            return sum;
        }


        /// <summary>
        /// SumOfDigitsFunc_NestedLoop_9 -- Θ(m*n) 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitsFunc_NestedLoop_9(int m, int n)
        {
            int sum = 0;
            for (int i = 1; i < m; i++) // Θ(n)
            {
                Console.WriteLine("--SumOfDigitsFunc_NestedLoop_8 #i" + i);
                for (int j = 1; j < n; j++) // Θ(logn)
                {
                    Console.WriteLine("------SumOfDigitsFunc_NestedLoop_8 #j" + j);
                    sum = sum + i;  // Θ(1)
                    Console.WriteLine("SumOfDigitsFunc_NestedLoop_8 #sum" + sum);
                }
            }
            return sum;
        }


    }
}
