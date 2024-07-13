using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class CountDigits
    {
        public static int nNumber_CountDigitsInNumber(int givenNumber)
        {
            int res = 0;
            int providedNumber = givenNumber;
            while (providedNumber > 0)
            {
                providedNumber = providedNumber / 10;
                res++;
            }
            return res;
        }
    }
}
