using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class BigO_SpaceComplexity
    {
        public static void sumOfNumberUntilZeroWithRecursion(int givenNumber) {
            Console.WriteLine("sumOfNumberUntilZeroWithRecursion");
            Console.WriteLine(sum(givenNumber));
        }

        public static int sum(int n) { 
            if (n <= 0) { return 0; }
            return n + sum(n - 1);
        }

        public static void pairSumSequenceWithoutRecursion(int givenNumber) {
            Console.WriteLine("pairSumSequenceWithoutRecursion");
            Console.WriteLine(pairSumSequence(givenNumber));
        }

        public static int pairSumSequence(int n)
        {
           int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += pairSum(i, i + 1);
            }
            return sum;
        }

        public static int pairSum(int n1, int n2)
        {
            return  n1 + n2;
        }


        public static void dropTheConstants(int givenNumber)
        {
            Console.WriteLine("pairSumSequenceWithoutRecursion");
            Console.WriteLine((doDropTheConstants(givenNumber)==1)? "Min changed!!": "Max changed!!");
        }

        public static void dropTheConstantsFineTune(int givenNumber)
        {
            Console.WriteLine("pairSumSequenceWithoutRecursion");
            Console.WriteLine((doFineTuneDropTheConstants(givenNumber) == 1) ? "Min changed!!" : "Max changed!!");
        }

        public static int doDropTheConstants(int age)
        {
            int min = 21;
            int max = 60;
            int operation = 0;
            for (int i = 0; i < age; i++) {
                if (age < min) { min = age; operation = 1; } // Section#A
                if (age > max) { max = age; operation = 2; } // Section#B
            }
            // Timecomplexity : A*B
            return operation;
        }

        public static int doFineTuneDropTheConstants(int age)
        {
            int min = 21;
            int max = 60;
            int operation = 0;
            for (int i = 0; i < age; i++)
            {
                if (age < min) { min = age; operation = 1; }// Section#A
            }
            for (int i = 0; i < age; i++)
            {
                if (age < min) { min = age; operation = 1; }// Section#B
            }
            // Timecomplexity : A+B
            return operation;
        }



    }
}
