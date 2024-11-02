using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleConsoleApp
{
    internal class PracticeRecursion
    {
        /// <summary>
        /// PracticeRecursionBasicFunction5
        /// </summary>
        /// <param name="iteration4"></param>
        //////////////////
        /// sample output 
        /// Readme: Uncomment each method to learn!!
        ///  3
        ///  2
        ///  1
        ///  1
        ///  2
        ///  3
        ///  Execution Done!!
        ////////////////////////
        public static void PracticeRecursionBasicFunction5(int iteration5)
        {
            if (iteration5 == 0) return;
            Console.WriteLine(iteration5);
            PracticeRecursionBasicFunction5(iteration5 - 1);
            Console.WriteLine(iteration5);
        }


        /// <summary>
        /// PracticeRecursionBasicFunction6
        /// </summary>
        /// <param name="iteration6"></param>
        /// Readme: Uncomment each method to learn!!
        //  1
        //  2
        //  1
        //  3
        //  1
        //  2
        //  1
        //  Execution Done!!
        ///
        public static void PracticeRecursionBasicFunction6(int iteration6)
        {
            if (iteration6 == 0) return;
            
            PracticeRecursionBasicFunction6(iteration6 - 1);
            Console.WriteLine(iteration6);
            PracticeRecursionBasicFunction6(iteration6 - 1);
        }


        /// <summary>
        /// PracticeRecursionBasicFunction7 - calculate log n
        /// </summary>
        /// <param name="iteration7"></param>
        /// <returns></returns>
        /// 
        /// condition iteration7 == 1 terminate recursion - base condition.
        /// usage : PracticeRecursion.PracticeRecursionBasicFunction7(7).ToString())
        /// Sample: 7
        // Readme: Uncomment each method to learn!!
        // iteration7 : 7
        // iteration7 :  3
        // PracticeRecursionBasicFunction7-2
        /// 
        public static int PracticeRecursionBasicFunction7(int iteration7)
        {
            if (iteration7 == 1) 
            { 
                return 0; 
            }
            else
            {
                Console.WriteLine("iteration7");
                Console.WriteLine(iteration7);
                return 1 + PracticeRecursionBasicFunction7(iteration7 / 2);
            }
        }

        /// <summary>
        /// PracticeRecursionBasicFunction8
        /// </summary>
        /// <param name="iteration8"></param>
        /// <returns></returns>
        public static int PracticeRecursionBasicFunction8(int iteration8)
        {
            if (iteration8 == 1)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("iteration8");
                Console.WriteLine(iteration8);
                return 1 + PracticeRecursionBasicFunction8(iteration8 / 3);
            }
        }


        /// <summary>
        /// PracticeRecursionBasicFunction9
        /// </summary>
        /// <param name="iteration9"></param>
        /// <returns></returns>
        public static void PracticeRecursionBasicFunction9(int iteration9)
        {
            if (iteration9 == 0)
            {
                return ;
            }
            else
            {
                Console.WriteLine("iteration9");
                Console.WriteLine(iteration9);
                PracticeRecursionBasicFunction9(iteration9 / 2);
                Console.WriteLine(iteration9 % 2); // count of sop
            }
        }

    }
}
