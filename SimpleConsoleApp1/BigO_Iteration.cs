using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class BigO_Iteration
    {
       
        /// <summary>
        /// O(N) Time complexity - Even if Array traversed twice
        /// </summary>
        /// <param name="givenNumberArray"></param>
        /// <returns></returns>
        public static string timeComplexitySumProduct(int[] givenNumberArray)
        {
            int sum = 0;
            int product = 1;

            for (int i = 0; i < givenNumberArray.Length; i++) { 
                sum += givenNumberArray[i];
            }
            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                product *= givenNumberArray[i];
            }
            Console.WriteLine("timeComplexitySumProduct-sum#" + sum + "-product#"+ product);
            return "sum#" + sum + "-product#"+ product;
        }

        /// <summary>
        /// O(n2) 
        /// </summary>
        /// <param name="givenNumberArray"></param>
        /// <returns></returns>
        public static string timeComplexityPrintPairs(int[] givenNumberArray)
        {
            int sum = 0;
            int product = 1;
            int[,] result = new int[givenNumberArray.Length,givenNumberArray.Length];

            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = 0; j < givenNumberArray.Length; j++)
                {
                    result[i, j] = i+j;
                    Console.WriteLine("timeComplexitySumProduct-traverse i#"+ givenNumberArray[i] + "j#"+givenNumberArray[j]);
                }
                
            }

            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = 0; j < givenNumberArray.Length; j++)
                {
                    if (j == givenNumberArray.Length - 1) 
                    {
                        Console.WriteLine(result[i, j].ToString());
                    }
                    else { 
                        Console.Write(result[i, j].ToString()+ " ");
                    }
                }
            }
            Console.WriteLine("timeComplexityFullMatrix Ends!!");
            return "timeComplexityFullMatrix";
        }

        /// <summary>
        /// O(n2) 
        /// </summary>
        /// <param name="givenNumberArray"></param>
        /// <returns></returns>
        public static string timeComplexityPrintUnorderedPairs(int[] givenNumberArray)
        {
            int sum = 0;
            int product = 1;
            string[,] result = new string[givenNumberArray.Length, givenNumberArray.Length];

            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = i+1; j < givenNumberArray.Length; j++)
                {
                    result[i, j] = i.ToString() + j.ToString();
                    Console.WriteLine("timeComplexitySumProduct-traverse i#" + givenNumberArray[i] + "j#" + givenNumberArray[j]);
                }

            }

            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = 0; j < givenNumberArray.Length; j++)
                {
                    if (j == givenNumberArray.Length - 1)
                    {
                        Console.WriteLine(Convert.ToString(result[i, j]));
                    }
                    else
                    {
                        Console.Write(Convert.ToString(result[i, j]) +" ");
                    }
                }
            }
            Console.WriteLine("timeComplexityFullMatrix Ends!!");
            return "timeComplexityFullMatrix";
        }

        /// <summary>
        /// O(m*n) 
        /// </summary>
        /// <param name="givenNumberArray"></param>
        /// <returns></returns>
        public static string timeComplexityPrintUnorderedPairs2Array(int[] givenNumberArray)
        {
            int sum = 0;
            int product = 1;
            string[,] result1 = new string[givenNumberArray.Length, givenNumberArray.Length];
            string[,] result2 = new string[givenNumberArray.Length, givenNumberArray.Length];

            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = i + 1; j < givenNumberArray.Length; j++)
                {
                    result1[i, j] = i.ToString() + j.ToString();
                    result2[i, j] = i.ToString() + j.ToString();
                    Console.WriteLine("timeComplexitySumProduct-traverse i#" + givenNumberArray[i] + "j#" + givenNumberArray[j]);
                }
            }
            Console.WriteLine("timeComplexityFullMatrix Matrix#1!!");
            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = 0; j < givenNumberArray.Length; j++)
                {
                    if (j == givenNumberArray.Length - 1)
                    {
                        Console.WriteLine(Convert.ToString(result1[i, j]));
                    }
                    else
                    {
                        Console.Write(Convert.ToString(result1[i, j]) + " ");
                    }
                }
            }
            Console.WriteLine("timeComplexityFullMatrix Matrix#2!!");
            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = 0; j < givenNumberArray.Length; j++)
                {
                    if (j == givenNumberArray.Length - 1)
                    {
                        Console.WriteLine(Convert.ToString(result2[i, j]));
                    }
                    else
                    {
                        Console.Write(Convert.ToString(result2[i, j]) + " ");
                    }
                }
            }
            Console.WriteLine("timeComplexityFullMatrix Ends!!");
            return "timeComplexityFullMatrix";
        }

        /// <summary>
        /// O(m*n) 
        /// </summary>
        /// <param name="givenNumberArray"></param>
        /// <returns></returns>
        public static string timeComplexityPrintUnorderedPairs2Array1kUnitOfWork (int[] givenNumberArray)
        {
            int sum = 0;
            int product = 1;
            string[,] result1 = new string[givenNumberArray.Length, givenNumberArray.Length];
            string[,] result2 = new string[givenNumberArray.Length, givenNumberArray.Length];

            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = i + 1; j < givenNumberArray.Length; j++)
                {
                    for (int k = i + 1; k < 1000; k++)
                    {
                        result1[i, j] = i.ToString() + j.ToString();
                        result2[i, j] = i.ToString() + j.ToString();
                        Console.WriteLine("timeComplexitySumProduct-traverse i#" + givenNumberArray[i] + "j#" + givenNumberArray[j]);
                    }
                }
            }
            Console.WriteLine("timeComplexityFullMatrix Matrix#1!!");
            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = 0; j < givenNumberArray.Length; j++)
                {
                    if (j == givenNumberArray.Length - 1)
                    {
                        Console.WriteLine(Convert.ToString(result1[i, j]));
                    }
                    else
                    {
                        Console.Write(Convert.ToString(result1[i, j]) + " ");
                    }
                }
            }
            Console.WriteLine("timeComplexityFullMatrix Matrix#2!!");
            for (int i = 0; i < givenNumberArray.Length; i++)
            {
                for (int j = 0; j < givenNumberArray.Length; j++)
                {
                    if (j == givenNumberArray.Length - 1)
                    {
                        Console.WriteLine(Convert.ToString(result2[i, j]));
                    }
                    else
                    {
                        Console.Write(Convert.ToString(result2[i, j]) + " ");
                    }
                }
            }
            Console.WriteLine("timeComplexityFullMatrix Ends!!");
            return "timeComplexityFullMatrix";
        }

        /// <summary>
        /// On(N)
        /// </summary>
        /// <param name="givenNumberArray"></param>
        /// <returns></returns>
        public static string reverseOfIntArray(int[] givenNumberArray) 
        {
            for (int i = 0; i < givenNumberArray.Length / 2; i++) 
            {
                int other = givenNumberArray.Length - i - 1;
                int temp = givenNumberArray[i];
                givenNumberArray[i] = givenNumberArray[other];
                givenNumberArray[other] = temp;
            }
            for (int j = 0; j < givenNumberArray.Length; j++)
            {
                if (j == givenNumberArray.Length - 1)
                {
                    Console.WriteLine(Convert.ToString(givenNumberArray[j]));
                }
                else
                {
                    Console.Write(Convert.ToString(givenNumberArray[j]) + " ");
                }
            }
            return "reverseOfIntArray";
        }



    }
}
