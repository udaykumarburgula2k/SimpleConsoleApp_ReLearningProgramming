﻿using System;

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

            // GCD
            //Console.WriteLine("Greatest common divisor");
            //Console.WriteLine("Greatest common divisor" + GreatestCommonDivisor.Calculate_GCD(10, 15));
            //Console.WriteLine("Greatest common divisor" + GreatestCommonDivisor.Calculate_GCD2(10, 15));
            //Console.WriteLine("Greatest common divisor" + GreatestCommonDivisor.Calculate_GCD3(10, 15));

            // Recursion
            // Console.WriteLine("Calling RecursionProgram#1!!");
            // RecursionProgram1.fromMain();
            // RecursionProgram1.generateStackOverflowError();
            // RecursionProgram1.RecursiveBasicFunction2(10);
            // RecursionProgram1.RecursiveBasicFunction3(3);
            //Console.WriteLine("Calling RecursionProgram#1 - Part2!!");
            // RecursionPart2.RecursiveBasicFunction4(16);

            // UsingArrayList.BasicOperationOnArrayList();
            //Console.WriteLine("Search name 'Raju' ");
            //UsingArrayList.BasicSearchOperationOnArrayList("Raju");
            //Console.WriteLine("Search name 'Kumar' ");
            //
            //UsingArrayList.BasicSearchOperationOnArrayList("Kumar");

            //int[] array = { 1, 5, 3, 15, _ };
            //int searchElement1 = 5;
            //int searchElement2 = 99;
            //Console.WriteLine("Found element "+ searchElement1 + " at index:"+ UsingArrayList.BasicSearchOperationOnIntArrayList(array,5, searchElement1));
            //Console.WriteLine("Found element " + searchElement2 + " at index:" + UsingArrayList.BasicSearchOperationOnIntArrayList(array, 5, searchElement2));

            //int[] array = new int[5];
            //array[0] = 1;
            //array[1] = 5;
            //array[2] = 3;
            //array[3] = 15;
            //array[4] = 0;
            //int arrayLength = array.Length;
            //int insertElement = 99, insertPosition = 2;
            //Console.WriteLine("Insert element " + 
            //    UsingArrayList.BasicInsertArrayItemInList(array, arrayLength, insertElement, insertPosition));


            //int[] array = { 1, 5, 3, 15, 2 };
            //int deleteItem = 5;
            //Console.WriteLine("completed operation try deleted element at index#" +
            //    UsingArrayList.deleteGivenItemOperationOnArray(array, deleteItem));

            //int[] array = new int[] { 10, 5, 20, 8 };
            //int searchElement = 20;
            //Console.WriteLine("largest element at index#" +
            //    UsingArrayList.largestElementOfAnArray(array));
            //Console.WriteLine("largest element at index#" +
            //    UsingArrayList.largestElementOfAnArray_better2(array));

            //Console.WriteLine("ReverseOfTheString");
            //Console.WriteLine(UseStringOperations.ReverseOfTheString("Hi My name is Andrei"));

            //Console.WriteLine("CommonLoops-----------");
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine("CommonLoop"+ CommonLoop.executeFunction(3,1));
            //watch.Stop();
            //var elapsedMs1 = watch.ElapsedMilliseconds;
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine("CommonLoop" + CommonLoop.executeFunction(3, 2));
            //watch.Stop();
            //var elapsedMs2 = watch.ElapsedMilliseconds;
            //Console.WriteLine("CommonLoop" + CommonLoop.executeFunction(3, 3));
            //watch.Stop();
            //var elapsedMs3 = watch.ElapsedMilliseconds;
            //Console.WriteLine("elapsedMs1" + elapsedMs1);
            //Console.WriteLine("elapsedMs2" + elapsedMs2);
            //Console.WriteLine("elapsedMs3" + elapsedMs3);

            //Console.WriteLine("CommonLoop" + CommonLoop.executeFunction(10, 4));
            //Console.WriteLine("CommonLoop" + CommonLoop.executeFunction(10, 5));
            //Console.WriteLine("CommonLoop" + CommonLoop.executeFunction(10, 6));

            //Console.WriteLine("CommonLoop-" + CommonLoop.executeFunction(10, 7));
            //Console.WriteLine("CommonLoop-" + CommonLoop.executeFunction(10, 8));
            //Console.WriteLine("CommonLoop-" + CommonLoop.executeFunction(10, 9));

            // PracticeRecursion.PracticeRecursionBasicFunction5(3);
            // PracticeRecursion.PracticeRecursionBasicFunction6(3);

            // Console.WriteLine("PracticeRecursionBasicFunction7-"+  PracticeRecursion.PracticeRecursionBasicFunction7(7).ToString());
            // Console.WriteLine("PracticeRecursionBasicFunction7-" + PracticeRecursion.PracticeRecursionBasicFunction7(8).ToString());
            // Console.WriteLine("PracticeRecursionBasicFunction8-" + PracticeRecursion.PracticeRecursionBasicFunction8(7).ToString());
            // Console.WriteLine("PracticeRecursionBasicFunction8-" + PracticeRecursion.PracticeRecursionBasicFunction8(8).ToString());


            // Implement a method to find all occurrences of a substring within a given string and return their starting indices.
            // string input = "abcabcabc";
            // string substring = "abc";
            // List<int> result = StringSearch.FindSubstringOccurrences(input, substring);
            // Console.WriteLine("Indices: " + string.Join(", ", result));

            // Implement a method to find all occurrences repeated string within a given string and provided the largest repeated string
            // string input = "banana";
            // string result = RepeatedSubstringFinder.FindLargestRepeatedSubstring(input);
            // Console.WriteLine("Largest Repeated Substring: " + result);
            
            Console.Write(Environment.NewLine);

            // Console.WriteLine("Enter string to get ReverseOfTheString");
            // string givenString = Console.ReadLine();
            // givenString = givenString.Length > 0 ? givenString : "Hi My name is Andrei";
            // Console.WriteLine("ReverseOfTheString");
            // Console.WriteLine("ReverseOfTheString-ToCharArray");
            // Console.WriteLine(String_Operations.ReverseString(givenString));
            // Console.WriteLine("ReverseOfTheString-Reverse a String in C# without using Built-in method");
            // Console.WriteLine(String_Operations.ReverseString2(givenString));
            // Console.WriteLine("ReverseOfTheString-Using the for-each loop to reverse a string in C#");
            // Console.WriteLine(String_Operations.ReverseString3(givenString));
            // Console.WriteLine("ReverseOfTheString-Reverse a String Using in-built Reverse Method in C#");
            // Console.WriteLine(String_Operations.ReverseString4(givenString));

            Console.WriteLine("Enter string to get ReverseNumber eg: 14587");
            int number = int.Parse(Console.ReadLine());
            if (int.TryParse(Convert.ToString(number), out int n) == false) 
            { 
                number = 14587; 
            }
            Console.WriteLine("ReverseNumber : Reverse a Number with Examples");
            Console.WriteLine(Number_Operations.ReverseNumber(number));

            // Console.WriteLine("MergeSortedArrays");
            // int[] result = String_Operations.MergeSortedArrays(
            //    new int[] { 0, 3, 4, 31 }, new int[] { 4, 6, 30 });
            // Console.WriteLine(result);


            // Array_Operations
            // https://leetcode.com/problems/two-sum/description/
            // https://leetcode.com/problems/maximum-subarray/description/
            // https://leetcode.com/problems/move-zeroes/description/
            // https://leetcode.com/problems/contains-duplicate/description/
            // https://leetcode.com/problems/rotate-array/description/
            //Console.WriteLine("Array_2Sums");
            //Dictionary<int, int> result = Array_Operations.TwoSum(new int[] { 2, 7, 11, 15 }, 9);



            Console.WriteLine("Execution Done!!");
        }
    }
}