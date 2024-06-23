using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class Swap2NumberWithThirdNumber
    {
        public static void DoSwap2NumberWithThirdNumber()
        {
            int providedNumber1, providedNumber2, numberVarible3;
            Console.WriteLine("To swap 2 number, Enter any number#1");
            int.TryParse(Console.ReadLine(), out providedNumber1);
            Console.WriteLine("To swap 2 number, Enter any number#2");
            int.TryParse(Console.ReadLine(), out providedNumber2);
            Console.WriteLine("To swap 2 number, provided number1#"+ providedNumber1+ ", provided number2#" + providedNumber2);
            numberVarible3 = providedNumber1;
            providedNumber1 = providedNumber2;
            providedNumber2 = numberVarible3;
            Console.WriteLine("swapped 2 number, provided number1#" + providedNumber1 + ", provided number2#" + providedNumber2);


        }

        public static void DoSwap2NumberWithoutThirdNumber()
        {
            int providedNumber1, providedNumber2;
            Console.WriteLine("To swap 2 number, Enter any number#1");
            int.TryParse(Console.ReadLine(), out providedNumber1);
            Console.WriteLine("To swap 2 number, Enter any number#2");
            int.TryParse(Console.ReadLine(), out providedNumber2);
            Console.WriteLine("To swap 2 number, provided number1#" + providedNumber1 + ", provided number2#" + providedNumber2);
           
            providedNumber1 = providedNumber1 + providedNumber2;
            providedNumber2 = providedNumber1 - providedNumber2 ;
            providedNumber1 = providedNumber1 - providedNumber2;
            Console.WriteLine("swapped 2 number, provided number1#" + providedNumber1 + ", provided number2#" + providedNumber2);
        }
    }
}
