using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class RecursionPart2
    {
        /// <summary>
        /// RecursivePart2_Program4.png
        /// </summary>
        /// <param name="iteration4"></param>
        public static void RecursiveBasicFunction4(int iteration4)
        {
            if (iteration4 == 1) return; // base case : recursive termination condition calling
            Console.WriteLine("-- #1 Before --" + iteration4.ToString());
            RecursionPart2.RecursiveBasicFunction4(1| + iteration4 / 2);
            Console.WriteLine("-- #2 After --" + iteration4.ToString());
        }

    }
}
