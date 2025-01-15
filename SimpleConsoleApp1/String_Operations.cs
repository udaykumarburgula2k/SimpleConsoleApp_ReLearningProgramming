using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class String_Operations
    {

        /// <summary>
        /// ReverseString 
        /// </summary>
        /// <param name="givenString">Hi My name is Andrei</param>
        /// <returns></returns>
        public static string ReverseString(string givenString = "Hi My name is Andrei")
        {
            string reverseOfString = string.Empty;
            if (givenString == null)
            { 
                return string.Empty;
            }
            char[] splitString = givenString.ToCharArray();

            for (int i = splitString.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(splitString[i]);
                reverseOfString += splitString[i];
            }

            return reverseOfString;
        }


        /// <summary>
        /// Reverse a String in C# without using Built-in method
        /// https://dotnettutorials.net/lesson/how-to-reverse-a-string-in-csharp/
        /// </summary>
        /// <param name="givenString"></param>
        /// <returns></returns>
        public static string ReverseString2(string givenString = "Hi My name is Andrei")
        {
            string reverseOfString = string.Empty;
            int k = 0;
            if (givenString == null)
            {
                return string.Empty;
            }
            
            for (int i = givenString.Length - 1; i >= 0; i--)
            {
                reverseOfString += givenString[i];
            }

            return reverseOfString;
        }


        /// <summary>
        /// Using the for-each loop to reverse a string in C#
        /// https://dotnettutorials.net/lesson/how-to-reverse-a-string-in-csharp/
        /// </summary>
        /// <param name="givenString"></param>
        /// <returns></returns>
        public static string ReverseString3(string givenString = "Hi My name is Andrei")
        {
            string reverseOfString = string.Empty;
            int k = 0;
            if (givenString == null)
            {
                return string.Empty;
            }

            foreach (char c in givenString) 
            {
                reverseOfString = c + reverseOfString;
            }

            return reverseOfString;
        }

        /// <summary>
        /// Reverse a String Using in-built Reverse Method in C#
        /// </summary>
        /// <param name="givenString"></param>
        /// <returns></returns>
        public static string ReverseString4(string givenString = "Hi My name is Andrei")
        {
            string reverseOfString = string.Empty;
            int k = 0;
            if (givenString == null)
            {
                return string.Empty;
            }

            char[] stringArray = givenString.ToCharArray();
            Array.Reverse(stringArray);
            reverseOfString = new string(stringArray);

            return reverseOfString;
        }


        /// <summary>
        /// MergeSortedArrays
        /// </summary>
        /// <param name="givenArray1">new int[] { 0, 3, 4, 31 }</param>
        /// <param name="givenArray2">new int[] { 4, 6, 30 }</param>
        /// <returns></returns>
        public static int[] MergeSortedArrays(int[] array1, int[] array2) 
        {
            int length1 = array1.Length;
            int length2 = array2.Length;
            int[] mergedArray = new int[length1 + length2];

            int i = 0, j = 0, k = 0;

            // Compare elements from both arrays and add the smallest one to mergedArray
            while (i < length1 && j < length2)
            {
                if (array1[i] <= array2[j])
                {
                    mergedArray[k++] = array1[i++];
                }
                else
                {
                    mergedArray[k++] = array2[j++];
                }
            }

            // Add remaining elements from array1, if any
            while (i < length1)
            {
                mergedArray[k++] = array1[i++];
            }

            // Add remaining elements from array2, if any
            while (j < length2)
            {
                mergedArray[k++] = array2[j++];
            }

            return mergedArray;
        }
    }
}
