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
            if (givenNumber == 0) return false;
            // IDEA #3
            if (givenNumber == 2 || givenNumber == 3) return true;
            if (givenNumber%2 == 0 || givenNumber % 3 == 0) return false;
            

            // IDEA #1
            // for (int i = 2; i < givenNumber; i++) // TC: O(n-2)

            // optimization: IDEA #1
            /*
             30 : (1,30) (2,15) (3,10)  -- 6*6 = 36 < 30
             65 : (1,65) (5,13) -- 11*11 = 66 < 65
             25 : (1,25) (5,5)  -- 5*5 = 25
              
              
             if(x,y) is a pair
                 x * y = n
            And if x <= y 
                   x*x <=n
                   x <= sqrt(n)

            for (int i = 2; i * i < givenNumber; i++)   O(sqrt(n))

            IDEA #3
            By checking i%2 =0, then not a prime number
            By checking i%3=0, then not a prime number

            n = 121  --> i = 5, 11
            n = 1031 --> i = 5, 11, 17, 23, 29 note: 35*35 = 1225 > 1031. 
             */

            for (int i = 5; i * i < givenNumber; i= i +6)  
            {
                if(givenNumber % i == 0 || givenNumber%(i+2) == 0) 
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
