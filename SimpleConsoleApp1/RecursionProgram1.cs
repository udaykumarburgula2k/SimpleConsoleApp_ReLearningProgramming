using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class RecursionProgram1
    {

        /// <summary>
        /// func1
        /// </summary>
        /// <returns></returns>
        public static void func1()
        {
            Console.WriteLine("func1 execution!!");
        }

        /// <summary>
        /// func2
        /// </summary>
        /// <returns></returns>
        public static void func2()
        {
            Console.WriteLine("Before func1");
            RecursionProgram1.func1();
            Console.WriteLine("After func1");
        }

        public static void fromMain()
        {
            Console.WriteLine("Before func2");
            RecursionProgram1.func2();
            Console.WriteLine("After func2");
        }

        static int iteration1 = 0;
        /// <summary>
        /// generateStackOverflowError
        /// </summary>
        public static void generateStackOverflowError()
        {
            Console.WriteLine("Before generateStackOverflowError"+ iteration1.ToString());
            RecursionProgram1.generateStackOverflowError();
            iteration1 = iteration1 + 1;
            Console.WriteLine("After generateStackOverflowError"+ iteration1.ToString());
        }

        /// <summary>
        /// generateStackOverflowError2
        /// </summary>
        /// <param name="iteration2"></param>
        public static void RecursiveBasicFunction2(int iteration2)
        {
            if (iteration2 <= 0) return; // base case : recursive termination condition calling
            Console.WriteLine("Before generateStackOverflowError" + iteration2.ToString());
            RecursionProgram1.RecursiveBasicFunction2(iteration2 -1);
            Console.WriteLine("After generateStackOverflowError" + iteration2.ToString());
        }

        /// <summary>
        /// generateStackOverflowError3 : RecursiveProgram3.png
        /// </summary>
        /// <param name="iteration2"></param>
        public static void RecursiveBasicFunction3(int iteration2)
        {
            if (iteration2 <= 0) return; // base case : recursive termination condition calling
            Console.WriteLine("- #1 Before--" + iteration2.ToString());
            RecursionProgram1.RecursiveBasicFunction3(iteration2 - 1);
            Console.WriteLine("- #2 After --" + iteration2.ToString());
            Console.WriteLine("-----" + iteration2.ToString() + "-----");
            RecursionProgram1.RecursiveBasicFunction3(iteration2 - 1);
            Console.WriteLine("- #3 After --" + iteration2.ToString());
        }

        /*
         Typical structure of recursive

         fun(..)
        {
            Base cases // meaning recursion termination condition.
            ...
            Make Recursive call (i.e, call with atleast one change in input parameter)
            example: 5->4->3->2->1
        }
            
        Application of Recursion
                Any program programmed with iteration can be done with recursion.
        
        (1) Many techniques are based on Recursion
            (a) Dynamic 
            (b) Backtracking
            (c) Divide and Conquer (Binary search, Quick sort, and Merge Sort)
        (2) Many problem inheritantly recursive
            (a) Tower of the Hanoi
            (b) DFS based traversal (DFS of Graph and Inorder/Preorder/postorder traverse of tree)

        */


    }
}
