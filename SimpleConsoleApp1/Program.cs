using System;

namespace SimpleConsoleApp
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Readme: Uncomment each method to learn!!");
            // BasicProgrammingConstructs.BasicLanguageConstructs();
            // EvenOrOddNumber.DecideEvenOrOddNumber();

            // Homework : 
            // Calculator +, -, *, %
            // Mathmatical Tables : 7 * 1 = 7 to 7 * 20 = 140

            // SumOfDigitsForGivenNumber.CalculateSumOfDigits();
            // Swap2NumberWithThirdNumber.DoSwap2NumberWithThirdNumber();
            // Swap2NumberWithThirdNumber.DoSwap2NumberWithoutThirdNumber();

            //BigO_SpaceComplexity.sumOfNumberUntilZeroWithRecursion(1000);
            //BigO_SpaceComplexity.pairSumSequenceWithoutRecursion(1000);
            // BigO_SpaceComplexity.dropTheConstants(12); // A*B
            // BigO_SpaceComplexity.dropTheConstants(60);
            //BigO_SpaceComplexity.dropTheConstantsFineTune(12); // A+B
            //BigO_SpaceComplexity.dropTheConstantsFineTune(60);

            // Multipart Algorithms: Add vs Multiply 
            /* For calculating time and space complexity
             * // (A) do this, when all done, do that = Add the runtimes
                for(int a: arrA){
                    print(a);
                }
                for(int b: arrB){
                    print(b);
                }
            * // (B) do this, for each time, do that = multiply the runtimes
                for(int a: arrA){
                    for(int b: arrB){
                        print(a + ","+ b);
                    }
                }
             */

            /*
             Amortized Array 
             ArrayList dynamically resizing array. is implemented with a array.
             when array hits the capacity, the ArrayList class will create a new array with the 
             double the capacity and copy all the elements. 
             time required to insert is amortized/not considered as it does not happen often. 
             */

            // int[] array = { 1, 5, 3};
            // BigO_Iteration.timeComplexitySumProduct(array);
            // BigO_Iteration.timeComplexityPrintPairs(array);
            // BigO_Iteration.timeComplexityPrintUnorderedPairs(array);
            // BigO_Iteration.timeComplexityPrintUnorderedPairs2Array(array);
            // BigO_Iteration.timeComplexityPrintUnorderedPairs2Array1kUnitOfWork(array);

            // int[] array = { 1, 5, 3, 4, 8, 2, 14, 9};
            // BigO_Iteration.reverseOfIntArray(array);
            //PrimeNumber.IsPrimeNumber(43);
            //PrimeNumber.IsPrimeNumber(12932);

            // Sum of n Numbers
            //Console.WriteLine("Sum"+ SumofNItemNumbers.nNumber_SumOfNumbers(10));
            //Console.WriteLine("------###-----");
            //Console.WriteLine("Sum#1-" + SumofNItemNumbers.nNumber_SumOfNumbers_1(10));
            //Console.WriteLine("-----------");
            //Console.WriteLine("Sum#2-" + SumofNItemNumbers.nNumber_SumOfNumbers_2(10));
            //Console.WriteLine("-----------");
            //Console.WriteLine("Sum#3-" + SumofNItemNumbers.nNumber_SumOfNumbers_3(10));

            // CountDigits
            // Console.WriteLine("Count of digits in a given number: 3121012 is " + CountDigits.nNumber_CountDigitsInNumber(3121012));
            //Console.WriteLine("Bitwise operation AND:" + BitwiseOperator.nNumber_Bitwise_AND(3,5));
            //Console.WriteLine("-----------");
            //Console.WriteLine("Bitwise operation OR:" + BitwiseOperator.nNumber_Bitwise_OR(3, 5));
            //Console.WriteLine("-----------");
            //Console.WriteLine("Bitwise operation XOR:" + BitwiseOperator.nNumber_Bitwise_XOR(3, 5));
            //Console.WriteLine("-----------");

            Console.WriteLine("Greatest common divisor");
            Console.WriteLine("Greatest common divisor" + GreatestCommonDivisor.Calculate_GCD(10, 15));
            Console.WriteLine("Greatest common divisor" + GreatestCommonDivisor.Calculate_GCD2(10, 15));
            Console.WriteLine("Greatest common divisor" + GreatestCommonDivisor.Calculate_GCD3(10, 15));
            Console.WriteLine("Execution Done!!");
        }
    }
}