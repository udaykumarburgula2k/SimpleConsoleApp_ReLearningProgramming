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
            /* 
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
            // PrimeNumber.IsPrimeNumber(43);
            // PrimeNumber.IsPrimeNumber(12932);

            Console.WriteLine("Execution Done!!");
        }
    }
}