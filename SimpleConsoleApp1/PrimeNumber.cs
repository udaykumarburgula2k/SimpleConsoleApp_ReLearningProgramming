using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class PrimeNumber
    {
        public static bool IsPrimeNumber(int givenNumber) 
        {
            for (int i = 2; i * i <= givenNumber; i++) 
            {
                if(givenNumber % i == 0) 
                {   
                    Console.WriteLine(givenNumber +" is not Prime Number!!");
                    return false;
                }
            }
            Console.WriteLine(givenNumber + " is a Prime Number!!");
            return true;
        }
    }
}
