using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class BitwiseOperator
    {
        public static int nNumber_Bitwise_AND(int givenNumber1, int givenNumber2)
        {
            int x = givenNumber1, y = givenNumber2;
            Console.WriteLine("x & y");
            Console.WriteLine(x & y);
            return x & y;
        }

        public static int nNumber_Bitwise_OR(int givenNumber1, int givenNumber2)
        {
            int x = givenNumber1, y = givenNumber2;
            Console.WriteLine("x | y");
            Console.WriteLine(x | y);
            return x | y;
        }
        public static int nNumber_Bitwise_XOR(int givenNumber1, int givenNumber2)
        {
            int x = givenNumber1, y = givenNumber2;
            Console.WriteLine("x ^ y");
            Console.WriteLine(x ^ y);
            return x ^ y;
        }
    }
}
